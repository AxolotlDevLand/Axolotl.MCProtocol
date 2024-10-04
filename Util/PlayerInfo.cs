namespace Axolotl.Util;

using Auth;
using MCProtocol;
using Skins;

public class PlayerInfo
    {
        public string Xuid { get; set; }
        public dynamic SkinJson { get; set; }
        public Skin Skin { get; set; }
        public int ADRole { get; set; }
        public CertificateData CertificateData { get; set; }
        public string Username { get; set; }
        public UUID ClientUuid { get; set; }
        public ExtraData ExtraData { get; set; }
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