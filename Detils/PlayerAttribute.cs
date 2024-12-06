#region LICENSE

// The contents of this file are subject to the Common Public Attribution
// License Version 1.0. (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
// https://github.com/NiclasOlofsson/MiNET/blob/master/LICENSE. 
// The License is based on the Mozilla Public License Version 1.1, but Sections 14 
// and 15 have been added to cover use of software over a computer network and 
// provide for limited attribution for the Original Developer. In addition, Exhibit A has 
// been modified to be consistent with Exhibit B.
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for
// the specific language governing rights and limitations under the License.
// 
// The Original Code is MiNET.
// 
// The Original Developer is the Initial Developer.  The Initial Developer of
// the Original Code is Niclas Olofsson.
// 
// All portions of the code written by Niclas Olofsson are Copyright (c) 2014-2018 Niclas Olofsson. 
// All Rights Reserved.

#endregion

namespace Axolotl;

public class PlayerAttribute
    {
        public string Name { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float Value { get; set; }
        public float Default { get; set; }
        public AttributeModifiers Modifiers { get; set; }

        public override string ToString()
            {
                return
                    $"{{Name: {Name}, MinValue: {MinValue}, MaxValue: {MaxValue}, Value: {Value}, Default: {Default}}}";
            }
    }

public class GameRule<T> : GameRule
    {
        public GameRule(GameRulesEnum rule, T value) : this(rule.ToString(), value)
            {
            }

        public GameRule(string name, T value) : base(name)
            {
                Value = value;
            }

        public T Value { get; set; }
    }