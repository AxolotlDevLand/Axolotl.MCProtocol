#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeCraftingEvent : Packet
    {
        public enum RecipeTypes
            {
                Shapeless = 0,
                Shaped = 1,
                Furnace = 2,
                FurnaceData = 3,
                Multi = 4,
                ShulkerBox = 5,
                ChemistryShapeless = 6,
                ChemistryShaped = 7,
                SmithingTransform = 8,
                SmithingTrim = 9
            }

        public ItemStacks input; // = null;
        public UUID recipeId; // = null;
        public int recipeType; // = null;
        public ItemStacks result; // = null;

        public byte windowId; // = null;

        public McpeCraftingEvent()
            {
                Id = 0x35;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(windowId);
                WriteSignedVarInt(recipeType);
                Write(recipeId);
                Write(input);
                Write(result);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                windowId = ReadByte();
                recipeType = ReadSignedVarInt();
                recipeId = ReadUUID();
                input = ReadItemStacks();
                result = ReadItemStacks();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                windowId = default;
                recipeType = default;
                recipeId = default;
                input = default;
                result = default;
            }
    }