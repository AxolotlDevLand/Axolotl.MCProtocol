namespace Axolotl.MCProtocol.Packet;

public class SubChunkEntryWithCache : SubChunkEntryCommon
    {
        public long usedBlobHash;

        /// <inheritdoc />
        protected override void OnRead(Packet packet)
            {
                usedBlobHash = packet.ReadLong();
            }

        /// <inheritdoc />
        protected override void OnWrite(Packet packet)
            {
                packet.Write(usedBlobHash);
            }
    }