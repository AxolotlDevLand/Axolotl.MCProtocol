#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;

public partial class McpeMovePlayer : Packet
    {
        public enum Mode
            {
                Normal = 0,
                Reset = 1,
                Teleport = 2,
                Rotation = 3,
            }
        public enum Teleportcause
            {
                Unknown = 0,
                Projectile = 1,
                ChorusFruit = 2,
                Command = 3,
                Behavior = 4,
                Count = 5,
            }

        public long runtimeEntityId; // = null;
        public float x; // = null;
        public float y; // = null;
        public float z; // = null;
        public float pitch; // = null;
        public float yaw; // = null;
        public float headYaw; // = null;
        public byte mode; // = null;
        public bool onGround; // = null;
        public long otherRuntimeEntityId; // = null;

        public McpeMovePlayer()
            {
                Id = 0x13;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteUnsignedVarLong(runtimeEntityId);
                Write(x);
                Write(y);
                Write(z);
                Write(pitch);
                Write(yaw);
                Write(headYaw);
                Write(mode);
                Write(onGround);
                WriteUnsignedVarLong(otherRuntimeEntityId);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                runtimeEntityId = ReadUnsignedVarLong();
                x = ReadFloat();
                y = ReadFloat();
                z = ReadFloat();
                pitch = ReadFloat();
                yaw = ReadFloat();
                headYaw = ReadFloat();
                mode = ReadByte();
                onGround = ReadBool();
                otherRuntimeEntityId = ReadUnsignedVarLong();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                runtimeEntityId=default(long);
                x=default(float);
                y=default(float);
                z=default(float);
                pitch=default(float);
                yaw=default(float);
                headYaw=default(float);
                mode=default(byte);
                onGround=default(bool);
                otherRuntimeEntityId=default(long);
            }

    }