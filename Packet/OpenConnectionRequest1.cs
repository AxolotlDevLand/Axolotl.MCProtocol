namespace Axolotl.MCProtocol.Packet;

public partial class OpenConnectionRequest1
    {
        public short mtuSize;

        partial void AfterEncode()
            {
                Write(new byte[mtuSize - 46]);
            }

        partial void AfterDecode()
            {
                mtuSize = (short)(_reader.Length + 28);
                ReadBytes((int)(_reader.Length - _reader.Position));
            }
    }