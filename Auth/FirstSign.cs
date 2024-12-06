namespace Axolotl.Auth;

public class FirstSign
    {
        public long Exp { get; set; }
        public bool CertificateAuthority { get; set; }
        public string IdentityPublicKey { get; set; }
        public long Nbf { get; set; }
    }