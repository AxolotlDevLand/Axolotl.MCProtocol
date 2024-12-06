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

using fNbt;
using Items;

public static class EnchantingExtensions
    {
        public static List<Enchanting> GetEnchantings(this Item tool)
            {
                List<Enchanting> enchantings = new();

                if (tool == null) return enchantings;
                if (tool.ExtraData == null) return enchantings;

                if (!tool.ExtraData.TryGet("ench", out NbtList enchantingsNbt)) return enchantings;

                foreach (NbtTag enchantingNbt in enchantingsNbt)
                    {
                        short level = enchantingNbt["lvl"].ShortValue;

                        if (level == 0) continue;

                        Enchanting enchanting = new();
                        enchanting.Level = level;

                        short id = enchantingNbt["id"].ShortValue;
                        enchanting.Id = (EnchantingType)id;
                        enchantings.Add(enchanting);
                    }

                return enchantings;
            }

        public static short GetEnchantingLevel(this Item tool, EnchantingType enchantingId)
            {
                if (tool == null) return 0;
                if (tool.ExtraData == null) return 0;

                NbtList enchantingsNbt;
                if (!tool.ExtraData.TryGet("ench", out enchantingsNbt)) return 0;

                foreach (NbtCompound enchantingNbt in enchantingsNbt)
                    {
                        short level = enchantingNbt["lvl"].ShortValue;

                        if (level == 0) continue;

                        short id = enchantingNbt["id"].ShortValue;

                        if (id == (int)enchantingId) return level;
                    }

                return 0;
            }

        public static void SetEnchantings(this Item tool, List<Enchanting> enchantings)
            {
                if (tool == null) return;
                if (tool.ExtraData == null)
                    if (tool.ExtraData == null)
                        tool.ExtraData = new NbtCompound("tag");

                tool.ExtraData.Remove("ench");

                NbtList nbtList = new("ench");

                foreach (Enchanting enchanting in enchantings)
                    nbtList.Add(new NbtCompound
                        {
                            new NbtShort("id", (short)enchanting.Id),
                            new NbtShort("lvl", enchanting.Level)
                        });

                tool.ExtraData.Add(nbtList);
            }
    }