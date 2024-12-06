namespace Axolotl.Util;

public class ResourcePackInfo
    {
        /// <summary>
        ///     The unique identifier for the pack
        /// </summary>
        public string UUID { get; set; }

        /// <summary>
        ///     Version is the version of the pack. The client will cache packs sent by the server as
        ///     long as they carry the same version. Sending a pack with a different version than previously
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        ///     Size is the total size in bytes that the texture pack occupies. This is the size of the compressed
        ///     archive (zip) of the texture pack.
        /// </summary>
        public ulong Size { get; set; }

        /// <summary>
        ///     ContentKey is the key used to decrypt the behaviour pack if it is encrypted. This is generally the case
        ///     for marketplace texture packs.
        /// </summary>
        public string ContentKey { get; set; }

        public string SubPackName { get; set; }

        /// <summary>
        ///     Size is the total size in bytes that the texture pack occupies. This is the size of the compressed archive (zip) of
        ///     the texture pack.
        /// </summary>
        public string ContentIdentity { get; set; }

        /// <summary>
        ///     HasScripts specifies if the texture packs has any scripts in it. A client will only download the behaviour pack if
        ///     it supports scripts, which, up to 1.11, only includes Windows 10.
        /// </summary>
        public bool HasScripts { get; set; }

        public bool isAddon { get; set; }
    }