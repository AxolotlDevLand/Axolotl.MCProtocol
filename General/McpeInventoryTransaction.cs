#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeInventoryTransaction : Packet
    {
        public enum CraftingAction
            {
                CraftAddIngredient = -2,
                CraftRemoveIngredient = -3,
                CraftResult = -4,
                CraftUseIngredient = -5,
                AnvilInput = -10,
                AnvilMaterial = -11,
                AnvilResult = -12,
                AnvilOutput = -13,
                EnchantItem = -15,
                EnchantLapis = -16,
                EnchantResult = -17,
                Drop = -100
            }

        public enum InventorySourceType
            {
                Container = 0,
                Global = 1,
                WorldInteraction = 2,
                Creative = 3,
                Crafting = 100,
                Unspecified = 99999
            }

        public enum ItemReleaseAction
            {
                Release = 0,
                Use = 1
            }

        public enum ItemUseAction
            {
                Place,
                Clickblock = 0,
                Use,
                Clickair = 1,
                Destroy = 2
            }

        public enum ItemUseOnEntityAction
            {
                Interact = 0,
                Attack = 1,
                ItemInteract = 2
            }

        public enum TransactionType
            {
                Normal = 0,
                InventoryMismatch = 1,
                ItemUse = 2,
                ItemUseOnEntity = 3,
                ItemRelease = 4
            }

        public Transaction transaction; // = null;

        public McpeInventoryTransaction()
            {
                Id = 0x1e;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(transaction);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                transaction = ReadTransaction();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                transaction = default;
            }
    }