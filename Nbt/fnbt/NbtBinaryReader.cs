namespace fNbt;

using System.Diagnostics;
using System.Text;
using JetBrains.Annotations;

/// <summary>
///     BinaryReader wrapper that takes care of reading primitives from an NBT stream,
///     while taking care of endianness, string encoding, and skipping.
/// </summary>
public sealed class NbtBinaryReader : BinaryReader
    {
        private const int SeekBufferSize = 8 * 1024;
        private readonly byte[] buffer = new byte[sizeof(double)];
        private readonly byte[] stringConversionBuffer = new byte[64];
        private readonly bool swapNeeded;

        private byte[] seekBuffer;

        public NbtBinaryReader([NotNull] Stream input, bool bigEndian)
            : base(input)
            {
                swapNeeded = BitConverter.IsLittleEndian == bigEndian;
            }

        public bool UseVarInt { get; set; }


        [CanBeNull] public TagSelector Selector { get; set; }


        public NbtTagType ReadTagType()
            {
                int type = ReadByte();
                if (type < 0)
                    throw new EndOfStreamException();
                if (type > (int)NbtTagType.LongArray)
                    throw new NbtFormatException("NBT tag type out of range: " + type);
                return (NbtTagType)type;
            }


        public override short ReadInt16()
            {
                if (swapNeeded)
                    return Swap(base.ReadInt16());
                return base.ReadInt16();
            }


        public override int ReadInt32()
            {
                if (UseVarInt) return ReadVarInt();

                if (swapNeeded)
                    return Swap(base.ReadInt32());
                return base.ReadInt32();
            }

        public int ReadVarInt()
            {
                return VarInt.ReadSInt32(BaseStream);
            }


        public override long ReadInt64()
            {
                if (UseVarInt) return ReadVarLong();

                if (swapNeeded)
                    return Swap(base.ReadInt64());
                return base.ReadInt64();
            }

        public long ReadVarLong()
            {
                return VarInt.ReadSInt64(BaseStream);
            }

        public override float ReadSingle()
            {
                if (swapNeeded)
                    {
                        FillBuffer(sizeof(float));
                        Array.Reverse(buffer, 0, sizeof(float));
                        return BitConverter.ToSingle(buffer, 0);
                    }

                return base.ReadSingle();
            }


        public override double ReadDouble()
            {
                if (swapNeeded)
                    {
                        FillBuffer(sizeof(double));
                        Array.Reverse(buffer);
                        return BitConverter.ToDouble(buffer, 0);
                    }

                return base.ReadDouble();
            }

        public int ReadLenght()
            {
                return (int)VarInt.ReadUInt32(BaseStream);
            }

        public override string ReadString()
            {
                int length;
                if (UseVarInt)
                    length = ReadLenght();
                else
                    length = ReadInt16();
                if (length < 0) throw new NbtFormatException("Negative string length given!");
                if (length < stringConversionBuffer.Length)
                    {
                        int stringBytesRead = 0;
                        while (stringBytesRead < length)
                            {
                                int bytesReadThisTime =
                                    BaseStream.Read(stringConversionBuffer, stringBytesRead, length);
                                if (bytesReadThisTime == 0) throw new EndOfStreamException();
                                stringBytesRead += bytesReadThisTime;
                            }

                        return Encoding.UTF8.GetString(stringConversionBuffer, 0, length);
                    }

                byte[] stringData = ReadBytes(length);
                if (stringData.Length < length) throw new EndOfStreamException();
                return Encoding.UTF8.GetString(stringData);
            }


        public void Skip(int bytesToSkip)
            {
                if (bytesToSkip < 0) throw new ArgumentOutOfRangeException("bytesToSkip");

                if (BaseStream.CanSeek)
                    {
                        BaseStream.Position += bytesToSkip;
                    }
                else if (bytesToSkip != 0)
                    {
                        if (seekBuffer == null) seekBuffer = new byte[SeekBufferSize];
                        int bytesSkipped = 0;
                        while (bytesSkipped < bytesToSkip)
                            {
                                int bytesToRead = Math.Min(SeekBufferSize, bytesToSkip - bytesSkipped);
                                int bytesReadThisTime = BaseStream.Read(seekBuffer, 0, bytesToRead);
                                if (bytesReadThisTime == 0) throw new EndOfStreamException();
                                bytesSkipped += bytesReadThisTime;
                            }
                    }
            }


        private new void FillBuffer(int numBytes)
            {
                int offset = 0;
                do
                    {
                        int num = BaseStream.Read(buffer, offset, numBytes - offset);
                        if (num == 0) throw new EndOfStreamException();
                        offset += num;
                    } while (offset < numBytes);
            }


        public void SkipString()
            {
                short length;
                if (UseVarInt)
                    length = ReadByte();
                else
                    length = ReadInt16();
                if (length < 0) throw new NbtFormatException("Negative string length given!");
                Skip(length);
            }


        [DebuggerStepThrough]
        private static short Swap(short v)
            {
                unchecked
                    {
                        return (short)(((v >> 8) & 0x00FF) |
                                       ((v << 8) & 0xFF00));
                    }
            }


        [DebuggerStepThrough]
        private static int Swap(int v)
            {
                unchecked
                    {
                        uint v2 = (uint)v;
                        return (int)(((v2 >> 24) & 0x000000FF) |
                                     ((v2 >> 8) & 0x0000FF00) |
                                     ((v2 << 8) & 0x00FF0000) |
                                     ((v2 << 24) & 0xFF000000));
                    }
            }


        [DebuggerStepThrough]
        private static long Swap(long v)
            {
                unchecked
                    {
                        return ((Swap((int)v) & uint.MaxValue) << 32) |
                               (Swap((int)(v >> 32)) & uint.MaxValue);
                    }
            }
    }