namespace Axolotl.Util;

public enum SubChunkRequestResult : byte
    {
        Success = 1,
        NoSuchChunk = 2,
        WrongDimension = 3,
        NullPlayer = 4,
        YIndexOutOfBounds = 5,
        SuccessAllAir = 6
    }