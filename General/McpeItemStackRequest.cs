#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeItemStackRequest : Packet
    {
        public enum ActionType
            {
                Take = 0,
                Place = 1,
                Swap = 2,
                Drop = 3,
                Destroy = 4,
                Consume = 5,
                Create = 6,
                PlaceIntoBundle = 7,
                TakeFromBundle = 8,
                LabTableCombine = 9,
                BeaconPayment = 10,
                MineBlock = 11,
                CraftRecipe = 12,
                CraftRecipeAuto = 13,
                CraftCreative = 14,
                CraftRecipeOptional = 15,
                CraftGrindstone = 16,
                CraftLoom = 17,
                CraftNotImplementedDeprecated = 18,
                CraftResultsDeprecated = 19
            }

        public ItemStackRequests requests; // = null;

        public McpeItemStackRequest()
            {
                Id = 0x93;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(requests);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                requests = ReadItemStackRequests();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                requests = default;
            }
    }