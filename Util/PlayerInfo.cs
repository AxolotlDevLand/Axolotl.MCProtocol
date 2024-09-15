using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axolotl.MCProtocol;
using Axolotl.Auth;
using Axolotl.Skins;

namespace Axolotl.Util
{
    public class PlayerInfo
	{
		public Skin Skin { get; set; }
		public int ADRole { get; set; }
        public CertificateData CertificateData { get; set; }
        public string Username { get; set; }
        public UUID ClientUuid { get; set; }
        public string ServerAddress { get; set; }
        public long ClientId { get; set; }
        public int CurrentInputMode { get; set; }
        public int DefaultInputMode { get; set; }
        public string DeviceModel { get; set; }
        public string GameVersion { get; set; }
        public int DeviceOS { get; set; }
        public string DeviceId { get; set; }
        public int GuiScale { get; set; }
        public int UIProfile { get; set; }
        public int Edition { get; set; }
        public int ProtocolVersion { get; set; }
        public string LanguageCode { get; set; }
        public string PlatformChatId { get; set; }
        public string ThirdPartyName { get; set; }
        public string TenantId { get; set; }
    }
}
