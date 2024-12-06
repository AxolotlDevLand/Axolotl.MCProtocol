namespace Axolotl.Auth;

public class HandshakeData
    {
        public string salt { get; set; }

        public string signedToken { get; set; }
    }