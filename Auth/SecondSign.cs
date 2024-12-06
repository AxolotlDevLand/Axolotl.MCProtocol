namespace Axolotl.Auth;

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