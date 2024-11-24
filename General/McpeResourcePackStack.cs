#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeResourcePackStack : Packet
    {
        public ResourcePackIdVersions behaviorpackidversions; // = null;
        public Experiments experiments; // = null;
        public bool experimentsPreviouslyToggled; // = null;
        public string gameVersion; // = null;

        public bool mustAccept; // = null;
        public ResourcePackIdVersions resourcepackidversions; // = null;

        public McpeResourcePackStack()
            {
                Id = 0x07;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(mustAccept);
                Write(behaviorpackidversions);
                Write(resourcepackidversions);
                Write(gameVersion);
                Write(experiments);
                Write(experimentsPreviouslyToggled);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                mustAccept = ReadBool();
                behaviorpackidversions = ReadResourcePackIdVersions();
                resourcepackidversions = ReadResourcePackIdVersions();
                gameVersion = ReadString();
                experiments = ReadExperiments();
                experimentsPreviouslyToggled = ReadBool();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                mustAccept = default;
                behaviorpackidversions = default;
                resourcepackidversions = default;
                gameVersion = default;
                experiments = default;
                experimentsPreviouslyToggled = default;
            }
    }