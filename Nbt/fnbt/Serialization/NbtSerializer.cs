namespace fNbt.Serialization;

using System.Collections;
using System.Reflection;

/// <summary>
///     Basic NBT Serializer implementation provided by https://github.com/DarkLexFirst
/// </summary>
public static class NbtSerializer
    {
        private const BindingFlags MemberBindingFlags =
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

        public static NbtCompound SerializeObject(object value)
            {
                return (NbtCompound)SerializeChild(null, value);
            }

        public static T DeserializeObject<T>(NbtTag tag)
            {
                return (T)DeserializeChild(typeof(T), tag);
            }

        public static void FillObject<T>(T value, NbtTag tag) where T : class
            {
                FillObject(value, value.GetType(), tag);
            }

        private static NbtTag SerializeChild(string name, object value)
            {
                if (value is NbtTag normalValue)
                    {
                        normalValue = (NbtTag)normalValue.Clone();
                        normalValue.Name = name;
                        return normalValue;
                    }

                NbtTag? tag = CreateBaseTag(name, value);
                if (tag != null) return tag;

                if (value is IList list)
                    return GetNbtList(name, list);
                if (value is IDictionary dictionary) return GetNbtCompound(name, dictionary);

                Type type = value.GetType();

                PropertyInfo[] properties = type.GetProperties(MemberBindingFlags);
                FieldInfo[] fields = type.GetFields(MemberBindingFlags);

                if (properties.Length == 0 && fields.Length == 0) return null;

                NbtCompound nbt = new();
                if (name != null) nbt.Name = name;

                foreach (PropertyInfo property in properties)
                    {
                        NbtTag? child = SerializeMember(property, property.GetValue(value));
                        if (child != null) nbt.Add(child);
                    }

                foreach (FieldInfo filed in fields)
                    {
                        NbtTag? child = SerializeMember(filed, filed.GetValue(value));
                        if (child != null) nbt.Add(child);
                    }

                if (nbt.Count == 0) return null;

                return nbt;
            }

        private static NbtTag SerializeMember(MemberInfo memberInfo, object value)
            {
                NbtPropertyAttribute? attribute = GetAttribute(memberInfo);
                if (attribute == null) return null;

                if (attribute.HideDefault && value.Equals(GetDefaultValue(value))) return null;

                string childName = attribute.Name ?? memberInfo.Name;
                return SerializeChild(childName, value);
            }

        public static object GetDefaultValue(object value)
            {
                Type type = value.GetType();

                if (type == typeof(byte) || type == typeof(sbyte) ||
                    type == typeof(short) || type == typeof(ushort) ||
                    type == typeof(int) || type == typeof(uint) ||
                    type == typeof(long) || type == typeof(ulong) ||
                    type == typeof(double) || type == typeof(float))
                    return 0;
                if (type == typeof(bool))
                    return false;

                return null;
            }

        private static object DeserializeChild(Type type, NbtTag tag)
            {
                if (typeof(NbtTag).IsAssignableFrom(type))
                    {
                        tag = (NbtTag)tag.Clone();
                        tag.Name = null;
                        return tag;
                    }

                object? value = GetValueFromTag(tag, type);
                if (value != null) return value;

                if (typeof(IList).IsAssignableFrom(type))
                    return GetList(type, (NbtList)tag);
                if (typeof(IDictionary).IsAssignableFrom(type)) return GetDictionary(type, (NbtCompound)tag);

                value = Activator.CreateInstance(type);

                DeserializeBase(value, type, tag);

                return value;
            }

        private static void DeserializeBase(object value, Type type, NbtTag tag)
            {
                NbtCompound compound = (NbtCompound)tag;

                PropertyInfo[] properties = type.GetProperties();
                FieldInfo[] fields = type.GetFields();

                if (compound.Count == 0) return;

                foreach (PropertyInfo property in properties)
                    {
                        if (!TryGetMemberTag(property, compound, out NbtTag child)) continue;

                        if (property.SetMethod == null)
                            {
                                FillObject(property.GetValue(value), property.PropertyType, child);
                                continue;
                            }

                        property.SetValue(value, DeserializeChild(property.PropertyType, child));
                    }

                foreach (FieldInfo filed in fields)
                    {
                        if (!TryGetMemberTag(filed, compound, out NbtTag child)) continue;
                        filed.SetValue(value, DeserializeChild(filed.FieldType, child));
                    }
            }

        private static bool TryGetMemberTag(MemberInfo memberInfo, NbtCompound compound, out NbtTag tag)
            {
                tag = null;

                NbtPropertyAttribute? attribute = GetAttribute(memberInfo);
                if (attribute == null) return false;

                string childName = attribute.Name ?? memberInfo.Name;
                return compound.TryGet(childName, out tag);
            }

        private static void FillObject(object value, Type type, NbtTag tag)
            {
                object? baseTypeValue = GetValueFromTag(tag, type);
                if (baseTypeValue != null) return;

                if (value is IList list)
                    {
                        list.Clear();
                        FillList(list, list.GetType(), (NbtList)tag);
                        return;
                    }

                if (value is IDictionary dictionary)
                    {
                        dictionary.Clear();
                        FillDictionary(dictionary, dictionary.GetType(), (NbtCompound)tag);
                        return;
                    }

                DeserializeBase(value, type, tag);
            }

        private static NbtPropertyAttribute GetAttribute(MemberInfo memberInfo)
            {
                return memberInfo.GetCustomAttribute<NbtPropertyAttribute>();
            }

        private static NbtTag CreateBaseTag(string name, object value)
            {
                Type type = value.GetType();

                if (type == typeof(byte) || type == typeof(sbyte) || type == typeof(bool))
                    return new NbtByte(name, Convert.ToByte(value));
                if (type == typeof(short) || type == typeof(ushort))
                    return new NbtShort(name, Convert.ToInt16(value));
                if (type == typeof(int) || type == typeof(uint))
                    return new NbtInt(name, Convert.ToInt32(value));
                if (type == typeof(long) || type == typeof(ulong))
                    return new NbtLong(name, Convert.ToInt64(value));
                if (type == typeof(double))
                    return new NbtDouble(name, (double)value);
                if (type == typeof(float))
                    return new NbtFloat(name, (float)value);
                if (type == typeof(string))
                    return new NbtString(name, (string)value);
                if (type == typeof(byte[]))
                    return new NbtByteArray(name, (byte[])value);
                if (type == typeof(int[]))
                    return new NbtIntArray(name, (int[])value);

                return null;
            }

        private static object GetValueFromTag(NbtTag tag, Type type)
            {
                switch (tag)
                    {
                        case NbtByte _value:
                            if (type == typeof(bool))
                                return Convert.ToBoolean(_value.Value);
                            if (type == typeof(sbyte))
                                return (sbyte)_value.Value;
                            return _value.Value;
                        case NbtShort _value:
                            if (type == typeof(ushort))
                                return (ushort)_value.Value;
                            return _value.Value;
                        case NbtInt _value:
                            if (type == typeof(uint))
                                return (uint)_value.Value;
                            return _value.Value;
                        case NbtLong _value:
                            if (type == typeof(ulong))
                                return (ulong)_value.Value;
                            return _value.Value;
                        case NbtDouble _value: return _value.Value;
                        case NbtFloat _value: return _value.Value;
                        case NbtString _value: return _value.Value;
                        case NbtByteArray _value: return _value.Value;
                        case NbtIntArray _value: return _value.Value;
                        default: return null;
                    }

                ;
            }

        private static NbtList GetNbtList(string name, IList list)
            {
                if (list.Count == 0) return null;

                NbtList nbt = new();
                if (name != null) nbt.Name = name;

                foreach (object? value in list) nbt.Add(SerializeChild(null, value));

                return nbt;
            }

        private static IList GetList(Type type, NbtList tag)
            {
                IList? list = (IList)Activator.CreateInstance(type);

                FillList(list, type, tag);
                return list;
            }

        private static void FillList(IList list, Type type, NbtList tag)
            {
                if (tag.Count == 0) return;

                Type listType = type.GetGenericArguments().First();

                foreach (NbtTag child in tag) list.Add(DeserializeChild(listType, child));
            }

        private static NbtCompound GetNbtCompound(string name, IDictionary dictionary)
            {
                if (dictionary.Count == 0) return null;
                if (dictionary.GetType().GetGenericArguments().First() != typeof(string)) return null;

                IEnumerator keys = dictionary.Keys.GetEnumerator();
                IEnumerator values = dictionary.Values.GetEnumerator();

                NbtCompound nbt = new();
                if (name != null) nbt.Name = name;

                while (keys.MoveNext() && values.MoveNext())
                    {
                        string childName = (string)keys.Current;
                        nbt.Add(SerializeChild(childName, values.Current));
                    }

                return nbt;
            }

        private static IDictionary GetDictionary(Type type, NbtCompound tag)
            {
                IDictionary? dictionary = (IDictionary)Activator.CreateInstance(type);

                FillDictionary(dictionary, type, tag);
                return dictionary;
            }

        private static void FillDictionary(IDictionary dictionary, Type type, NbtCompound tag)
            {
                Type dictionaryType = type.GetGenericArguments().Last();

                foreach (NbtTag child in tag) dictionary.Add(child.Name, DeserializeChild(dictionaryType, child));
            }
    }