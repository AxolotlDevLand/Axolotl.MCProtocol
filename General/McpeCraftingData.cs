#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeCraftingData : Packet
    {
        public bool isClean; // = null;
        public MaterialReducerRecipe[] materialReducerRecipes; // = null;
        public PotionContainerChangeRecipe[] potionContainerRecipes; // = null;
        public PotionTypeRecipe[] potionTypeRecipes; // = null;

        public Recipes recipes; // = null;

        public McpeCraftingData()
            {
                Id = 0x34;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(recipes);
                Write(potionTypeRecipes);
                Write(potionContainerRecipes);
                Write(materialReducerRecipes);
                Write(isClean);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                recipes = ReadRecipes();
                potionTypeRecipes = ReadPotionTypeRecipes();
                potionContainerRecipes = ReadPotionContainerChangeRecipes();
                materialReducerRecipes = ReadMaterialReducerRecipes();
                isClean = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                recipes = default;
                potionTypeRecipes = default;
                potionContainerRecipes = default;
                materialReducerRecipes = default;
                isClean = default;
            }
    }