namespace Axolotl.MCProtocol.Packet;

public enum PacketID
    {
        ConnectedPing = 0x00,
        UnconnectedPing1 = 0x01,
        UnconnectedPing2 = 0x02,
        ConnectedPong = 0x03,
        UnconnectedPong = 0x1c,
        OpenConnectionRequest1 = 0x05,
        OpenConnectionReply1 = 0x06,
        OpenConnectionRequest2 = 0x07,
        OpenConnectionReply2 = 0x08,
        ConnectionRequest = 0x09,
        ConnectionRequestAccepted = 0x10,
        AlreadyConnected = 0x12,
        NewIncomingConnection = 0x13,
        Disconnect = 0x15,
        IncompatibleProtocolVersion = 0x19,
        FrameSetPacketBegin = 0x80,
        FrameSetPacketEnd = 0x8d,
        Nack = 0xa0,
        Ack = 0xc0,
        Game = 0xfe
    }