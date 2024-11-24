#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpeSpawnParticleEffect : Packet
    {
        public byte dimensionId; // = null;
        public long entityId; // = null;
        public string molangVariablesJson; // = null;
        public string particleName; // = null;
        public Vector3 position; // = null;

        public McpeSpawnParticleEffect()
            {
                Id = 0x76;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                Write(dimensionId);
                WriteSignedVarLong(entityId);
                Write(position);
                Write(particleName);
                Write(molangVariablesJson);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                dimensionId = ReadByte();
                entityId = ReadSignedVarLong();
                position = ReadVector3();
                particleName = ReadString();
                molangVariablesJson = ReadString();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                dimensionId = default;
                entityId = default;
                position = default;
                particleName = default;
                molangVariablesJson = default;
            }
    }