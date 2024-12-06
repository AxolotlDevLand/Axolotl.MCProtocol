namespace Axolotl.Auth;

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