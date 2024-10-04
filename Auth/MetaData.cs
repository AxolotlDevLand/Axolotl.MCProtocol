namespace Axolotl.Auth;

using System.Text.Json.Serialization;

public class HandshakeData
    {
        public string salt { get; set; }

        public string signedToken { get; set; }
    }

public class CertificateData
    {
        public const string MojangRootKey =
            "MHYwEAYHKoZIzj0CAQYFK4EEACIDYgAECRXueJeTDqNRRgJi/vlRufByu/2G0i2Ebt6YMar5QX/R0DIIyrJMcUpruK4QveTfJSTp3Shlq4Gk34cD/4GUWwkv0DVuzeuB+tXija7HBxii03NHDbPAD0AKnLr2wdAp";

        public long Nbf { get; set; }

        public ExtraData ExtraData { get; set; }

        public long RandomNonce { get; set; }

        public string Iss { get; set; }

        public long Exp { get; set; }

        public long Iat { get; set; }


        public string IdentityPublicKey { get; set; }
    }

public class FirstSign
    {
        public long Exp { get; set; }
        public bool CertificateAuthority { get; set; }
        public string IdentityPublicKey { get; set; }
        public long Nbf { get; set; }
    }

public class SecondSign
    {
        public string Iss { get; set; }
        public bool CertificateAuthority { get; set; }
        public long Exp { get; set; }
        public long RandomNonce { get; set; }
        public string IdentityPublicKey { get; set; }
        public long Nbf { get; set; }
        public long Iat { get; set; }
    }

public class ExtraData
    {
        public string Identity { get; set; }

        public string DisplayName { get; set; }

        [JsonPropertyName("XUID")] public string XUID { get; set; }

        public string TitleId { get; set; }
        public string sandboxId { get; set; }
    }