#pragma warning disable
namespace Axolotl.MCProtocol.Packet;

using System.Net;
using System.Numerics;
using Items;
using Metadata;
using Nbts;
using Skins;
using Util;


public partial class McpePlayStatus : Packet
    {
        public enum PlayStatus
            {
                LoginSuccess = 0,
                LoginFailedClient = 1,
                LoginFailedServer = 2,
                PlayerSpawn = 3,
                LoginFailedInvalidTenant = 4,
                LoginFailedVanillaEdu = 5,
                LoginFailedEduVanilla = 6,
                LoginFailedServerFull = 7
            }

        public int status; // = null;

        public McpePlayStatus()
            {
                Id = 0x02;
                IsMcpe = true;
            }

        protected override void EncodePacket()
            {
                base.EncodePacket();

                BeforeEncode();

                WriteBe(status);

                AfterEncode();
            }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
            {
                base.DecodePacket();

                BeforeDecode();

                status = ReadIntBe();

                AfterDecode();
            }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
            {
                base.ResetPacket();

                status = default;
            }
    }