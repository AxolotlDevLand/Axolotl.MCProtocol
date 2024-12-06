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
// All portions of the code written by Niclas Olofsson are Copyright (c) 2014-2020 Niclas Olofsson.
// All Rights Reserved.

#endregion

namespace Axolotl.Util;

using Newtonsoft.Json;

public class BlockPalette : Dictionary<int, BlockStateContainer>
    {
        public static int Version => 17694723;

        public static BlockPalette FromJson(string json)
            {
                BlockPalette pallet = new();

                dynamic result = JsonConvert.DeserializeObject<dynamic>(json);
                foreach (dynamic obj in result)
                    {
                        BlockStateContainer record = new();
                        record.Id = obj.Id;
                        record.Name = obj.Name;
                        record.Data = obj.Data;
                        record.RuntimeId = obj.RuntimeId;

                        foreach (dynamic stateObj in obj.States)
                            switch ((int)stateObj.Type)
                                {
                                    case 1:
                                        {
                                            record.States.Add(new BlockStateByte
                                                {
                                                    Name = stateObj.Name,
                                                    Value = stateObj.Value
                                                });
                                            break;
                                        }
                                    case 3:
                                        {
                                            record.States.Add(new BlockStateInt
                                                {
                                                    Name = stateObj.Name,
                                                    Value = stateObj.Value
                                                });
                                            break;
                                        }
                                    case 8:
                                        {
                                            record.States.Add(new BlockStateString
                                                {
                                                    Name = stateObj.Name,
                                                    Value = stateObj.Value
                                                });
                                            break;
                                        }
                                }

                        dynamic itemInstance = obj.ItemInstance;
                        if (itemInstance != null)
                            record.ItemInstance = new ItemPickInstance
                                {
                                    Id = itemInstance.Id,
                                    Metadata = itemInstance.Metadata,
                                    WantNbt = itemInstance.WantNbt
                                };

                        pallet.Add(record.RuntimeId, record);
                    }


                return pallet;
            }
    }