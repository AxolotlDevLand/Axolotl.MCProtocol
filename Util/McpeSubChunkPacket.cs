namespace Axolotl.MCProtocol.Packet;

//TODO
public partial class McpeSubChunkPacket
    {
        public SubChunkEntryCommon[] entries;

        partial void AfterEncode()
            {
                Write(entries != null ? entries.Length : 0);

                foreach (SubChunkEntryCommon entry in entries) entry.Write(this, cacheEnabled);
            }

        partial void AfterDecode()
            {
                int count = ReadInt();

                entries = new SubChunkEntryCommon[count];

                for (int i = 0; i < entries.Length; i++)
                    {
                        if (cacheEnabled)
                            entries[i] = new SubChunkEntryWithCache();
                        else
                            entries[i] = new SubChunkEntryWithoutCache();

                        entries[i].Read(this, cacheEnabled);
                    }
            }
    }