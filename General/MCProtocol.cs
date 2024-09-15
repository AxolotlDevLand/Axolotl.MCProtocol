
//
// WARNING: T4 GENERATED CODE - DO NOT EDIT
// 

using System;
using System.Net;
using System.Numerics;
using System.Threading;
using Axolotl.Items;
using Axolotl.Util;
using Axolotl.Nbts;
using Axolotl.Metadata;
using Axolotl.Skins;
using little = Axolotl.Util.Int24;// friendly name
using LongString = System.String;

namespace Axolotl.MCProtocol.Packet
{
	public class McpeProtocolInfo
	{
		public const int ProtocolVersion = 582;
		public const string GameVersion = "1.19.80";
	}
	public enum AdventureFlags
	{
		Mayfly = 0x40,
		Noclip = 0x80,
		Worldbuilder = 0x100,
		Flying = 0x200,
		Muted = 0x400,
	}
	public enum CommandPermission
	{
		Normal = 0,
		Operator = 1,
		Host = 2,
		Automation = 3,
		Admin = 4,
	}
	public enum PermissionLevel
	{
		Visitor = 0,
		Member = 1,
		Operator = 2,
		Custom = 3,
	}
	public enum ActionPermissions
	{
		BuildAndMine = 0x1,
		DoorsAndSwitches = 0x2,
		OpenContainers = 0x4,
		AttackPlayers = 0x8,
		AttackMobs = 0x10,
		Operator = 0x20,
		Teleport = 0x80,
		Default = (BuildAndMine | DoorsAndSwitches | OpenContainers | AttackPlayers | AttackMobs ),
		All = (BuildAndMine | DoorsAndSwitches | OpenContainers | AttackPlayers | AttackMobs | Operator | Teleport),
	}

	public partial class ConnectedPing : Packet
	{

		public long sendpingtime; // = null;

		public ConnectedPing()
		{
			Id = 0x00;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(sendpingtime);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			sendpingtime = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			sendpingtime=default(long);
		}

	}

	public partial class UnconnectedPing : Packet
	{

		public long pingId; // = null;
		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public long guid; // = null;

		public UnconnectedPing()
		{
			Id = 0x01;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(pingId);
			Write(offlineMessageDataId);
			Write(guid);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			pingId = ReadLong();
			ReadBytes(offlineMessageDataId.Length);
			guid = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			pingId=default(long);
			guid=default(long);
		}

	}

	public partial class ConnectedPong : Packet
	{

		public long sendpingtime; // = null;
		public long sendpongtime; // = null;

		public ConnectedPong()
		{
			Id = 0x03;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(sendpingtime);
			Write(sendpongtime);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			sendpingtime = ReadLong();
			sendpongtime = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			sendpingtime=default(long);
			sendpongtime=default(long);
		}

	}

	public partial class DetectLostConnections : Packet
	{


		public DetectLostConnections()
		{
			Id = 0x04;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class UnconnectedPong : Packet
	{

		public long pingId; // = null;
		public long serverId; // = null;
		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public string serverName; // = null;

		public UnconnectedPong()
		{
			Id = 0x1c;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(pingId);
			Write(serverId);
			Write(offlineMessageDataId);
			WriteFixedString(serverName);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			pingId = ReadLong();
			serverId = ReadLong();
			ReadBytes(offlineMessageDataId.Length);
			serverName = ReadFixedString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			pingId=default(long);
			serverId=default(long);
			serverName=default(string);
		}

	}

	public partial class OpenConnectionRequest1 : Packet
	{

		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public byte raknetProtocolVersion; // = null;

		public OpenConnectionRequest1()
		{
			Id = 0x05;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(raknetProtocolVersion);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			raknetProtocolVersion = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			raknetProtocolVersion=default(byte);
		}

	}

	public partial class OpenConnectionReply1 : Packet
	{

		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public long serverGuid; // = null;
		public byte serverHasSecurity; // = null;
		public short mtuSize; // = null;

		public OpenConnectionReply1()
		{
			Id = 0x06;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(serverGuid);
			Write(serverHasSecurity);
			WriteBe(mtuSize);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			serverGuid = ReadLong();
			serverHasSecurity = ReadByte();
			mtuSize = ReadShortBe();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			serverGuid=default(long);
			serverHasSecurity=default(byte);
			mtuSize=default(short);
		}

	}

	public partial class OpenConnectionRequest2 : Packet
	{

		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public IPEndPoint remoteBindingAddress; // = null;
		public short mtuSize; // = null;
		public long clientGuid; // = null;

		public OpenConnectionRequest2()
		{
			Id = 0x07;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(remoteBindingAddress);
			WriteBe(mtuSize);
			Write(clientGuid);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			remoteBindingAddress = ReadIPEndPoint();
			mtuSize = ReadShortBe();
			clientGuid = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			remoteBindingAddress=default(IPEndPoint);
			mtuSize=default(short);
			clientGuid=default(long);
		}

	}

	public partial class OpenConnectionReply2 : Packet
	{

		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public long serverGuid; // = null;
		public IPEndPoint clientEndpoint; // = null;
		public short mtuSize; // = null;
		public byte[] doSecurityAndHandshake; // = null;

		public OpenConnectionReply2()
		{
			Id = 0x08;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(serverGuid);
			Write(clientEndpoint);
			WriteBe(mtuSize);
			Write(doSecurityAndHandshake);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			serverGuid = ReadLong();
			clientEndpoint = ReadIPEndPoint();
			mtuSize = ReadShortBe();
			doSecurityAndHandshake = ReadBytes(0, true);

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			serverGuid=default(long);
			clientEndpoint=default(IPEndPoint);
			mtuSize=default(short);
			doSecurityAndHandshake=default(byte[]);
		}

	}

	public partial class ConnectionRequest : Packet
	{

		public long clientGuid; // = null;
		public long timestamp; // = null;
		public byte doSecurity; // = null;

		public ConnectionRequest()
		{
			Id = 0x09;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(clientGuid);
			Write(timestamp);
			Write(doSecurity);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			clientGuid = ReadLong();
			timestamp = ReadLong();
			doSecurity = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			clientGuid=default(long);
			timestamp=default(long);
			doSecurity=default(byte);
		}

	}

	public partial class ConnectionRequestAccepted : Packet
	{

		public IPEndPoint systemAddress; // = null;
		public short systemIndex; // = null;
		public IPEndPoint[] systemAddresses; // = null;
		public long incomingTimestamp; // = null;
		public long serverTimestamp; // = null;

		public ConnectionRequestAccepted()
		{
			Id = 0x10;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(systemAddress);
			WriteBe(systemIndex);
			Write(systemAddresses);
			Write(incomingTimestamp);
			Write(serverTimestamp);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			systemAddress = ReadIPEndPoint();
			systemIndex = ReadShortBe();
			systemAddresses = ReadIPEndPoints(20);
			incomingTimestamp = ReadLong();
			serverTimestamp = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			systemAddress=default(IPEndPoint);
			systemIndex=default(short);
			systemAddresses=default(IPEndPoint[]);
			incomingTimestamp=default(long);
			serverTimestamp=default(long);
		}

	}

	public partial class NewIncomingConnection : Packet
	{

		public IPEndPoint clientendpoint; // = null;
		public IPEndPoint[] systemAddresses; // = null;
		public long incomingTimestamp; // = null;
		public long serverTimestamp; // = null;

		public NewIncomingConnection()
		{
			Id = 0x13;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(clientendpoint);
			Write(systemAddresses);
			Write(incomingTimestamp);
			Write(serverTimestamp);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			clientendpoint = ReadIPEndPoint();
			systemAddresses = ReadIPEndPoints(20);
			incomingTimestamp = ReadLong();
			serverTimestamp = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			clientendpoint=default(IPEndPoint);
			systemAddresses=default(IPEndPoint[]);
			incomingTimestamp=default(long);
			serverTimestamp=default(long);
		}

	}

	public partial class NoFreeIncomingConnections : Packet
	{

		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public long serverGuid; // = null;

		public NoFreeIncomingConnections()
		{
			Id = 0x14;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(serverGuid);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			serverGuid = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			serverGuid=default(long);
		}

	}

	public partial class DisconnectionNotification : Packet
	{


		public DisconnectionNotification()
		{
			Id = 0x15;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class ConnectionBanned : Packet
	{

		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };
		public long serverGuid; // = null;

		public ConnectionBanned()
		{
			Id = 0x17;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(offlineMessageDataId);
			Write(serverGuid);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);
			serverGuid = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			serverGuid=default(long);
		}

	}

	public partial class IpRecentlyConnected : Packet
	{

		public readonly byte[] offlineMessageDataId = new byte[]{ 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 }; // = { 0x00, 0xff, 0xff, 0x00, 0xfe, 0xfe, 0xfe, 0xfe, 0xfd, 0xfd, 0xfd, 0xfd, 0x12, 0x34, 0x56, 0x78 };

		public IpRecentlyConnected()
		{
			Id = 0x1a;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(offlineMessageDataId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			ReadBytes(offlineMessageDataId.Length);

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeLogin : Packet
	{

		public int protocolVersion; // = null;
		public byte[] payload; // = null;

		public McpeLogin()
		{
			Id = 0x01;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteBe(protocolVersion);
			WriteByteArray(payload);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			protocolVersion = ReadIntBe();
			payload = ReadByteArray();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			protocolVersion=default(int);
			payload=default(byte[]);
		}

	}

	public partial class McpePlayStatus : Packet
	{
		public enum PlayStatus
		{
			LoginSuccess = 0,
			LoginFailedClient = 1,
			LoginFailedServer = 2,
			PlayerSpawn = 3,
			LoginFailedInvalidTenant = 4,
			LoginFailedVanillaEdu = 5,
			LoginFailedEduVanilla = 6,
			LoginFailedServerFull = 7,
		}

		public int status; // = null;

		public McpePlayStatus()
		{
			Id = 0x02;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteBe(status);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			status = ReadIntBe();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			status=default(int);
		}

	}

	public partial class McpeServerToClientHandshake : Packet
	{

		public string token; // = null;

		public McpeServerToClientHandshake()
		{
			Id = 0x03;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(token);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			token = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			token=default(string);
		}

	}

	public partial class McpeClientToServerHandshake : Packet
	{


		public McpeClientToServerHandshake()
		{
			Id = 0x04;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeDisconnect : Packet
	{


        public bool hideDisconnectReason; // = null;
        public string message; // = null;
        public uint failReason; // = null;
        public string filteredMessage; // = null

        public McpeDisconnect()
        {
            Id = 0x05;
            IsMcpe = true;
        }

        protected override void EncodePacket()
        {
            base.EncodePacket();

            BeforeEncode();

            WriteUnsignedVarInt(0); //todo
            Write(hideDisconnectReason);
            Write(message);
            
            AfterEncode();
        }

        partial void BeforeEncode();
        partial void AfterEncode();

        protected override void DecodePacket()
        {
            base.DecodePacket();

            BeforeDecode();

            failReason = ReadUnsignedVarInt();
            hideDisconnectReason = ReadBool();
            message = ReadString();
            filteredMessage = ReadString();

            AfterDecode();
        }

        partial void BeforeDecode();
        partial void AfterDecode();

        protected override void ResetPacket()
        {
            base.ResetPacket();

            hideDisconnectReason = default(bool);
            message = default(string);
            failReason = default(int);
        }

    }

	public partial class McpeResourcePacksInfo : Packet
	{

		public bool mustAccept; // = null;
		public bool hasScripts; // = null;
		public bool forceServerPacks; // = null;
		public ResourcePackInfos behahaviorpackinfos; // = null;
		public TexturePackInfos texturepacks; // = null;

		public McpeResourcePacksInfo()
		{
			Id = 0x06;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(mustAccept);
			Write(hasScripts);
			Write(forceServerPacks);
			Write(behahaviorpackinfos);
			Write(texturepacks);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			mustAccept = ReadBool();
			hasScripts = ReadBool();
			forceServerPacks = ReadBool();
			behahaviorpackinfos = ReadResourcePackInfos();
			texturepacks = ReadTexturePackInfos();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			mustAccept=default(bool);
			hasScripts=default(bool);
			forceServerPacks=default(bool);
			behahaviorpackinfos=default(ResourcePackInfos);
			texturepacks=default(TexturePackInfos);
		}

	}

	public partial class McpeResourcePackStack : Packet
	{

		public bool mustAccept; // = null;
		public ResourcePackIdVersions behaviorpackidversions; // = null;
		public ResourcePackIdVersions resourcepackidversions; // = null;
		public string gameVersion; // = null;
		public Experiments experiments; // = null;
		public bool experimentsPreviouslyToggled; // = null;

		public McpeResourcePackStack()
		{
			Id = 0x07;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(mustAccept);
			Write(behaviorpackidversions);
			Write(resourcepackidversions);
			Write(gameVersion);
			Write(experiments);
			Write(experimentsPreviouslyToggled);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			mustAccept = ReadBool();
			behaviorpackidversions = ReadResourcePackIdVersions();
			resourcepackidversions = ReadResourcePackIdVersions();
			gameVersion = ReadString();
			experiments = ReadExperiments();
			experimentsPreviouslyToggled = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			mustAccept=default(bool);
			behaviorpackidversions=default(ResourcePackIdVersions);
			resourcepackidversions=default(ResourcePackIdVersions);
			gameVersion=default(string);
			experiments=default(Experiments);
			experimentsPreviouslyToggled=default(bool);
		}

	}

	public partial class McpeResourcePackClientResponse : Packet
	{
		public enum ResponseStatus
		{
			Refused = 1,
			SendPacks = 2,
			HaveAllPacks = 3,
			Completed = 4,
		}

		public byte responseStatus; // = null;
		public ResourcePackIds resourcepackids; // = null;

		public McpeResourcePackClientResponse()
		{
			Id = 0x08;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(responseStatus);
			Write(resourcepackids);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			responseStatus = ReadByte();
			resourcepackids = ReadResourcePackIds();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			responseStatus=default(byte);
			resourcepackids=default(ResourcePackIds);
		}

	}

	public partial class McpeText : Packet
	{
		public enum ChatTypes
		{
			Raw = 0,
			Chat = 1,
			Translation = 2,
			Popup = 3,
			Jukeboxpopup = 4,
			Tip = 5,
			System = 6,
			Whisper = 7,
			Announcement = 8,
			Json = 9,
			Jsonwhisper = 10,
			Jsonannouncement = 11,
		}

		public byte type; // = null;

		public McpeText()
		{
			Id = 0x09;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(type);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			type = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			type=default(byte);
		}

	}

	public partial class McpeSetTime : Packet
	{

		public int time; // = null;

		public McpeSetTime()
		{
			Id = 0x0a;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(time);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			time = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			time=default(int);
		}

	}

	public partial class McpeStartGame : Packet
	{


		public McpeStartGame()
		{
			Id = 0x0b;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeAddPlayer : Packet
	{

		public UUID uuid; // = null;
		public string username; // = null;
		public long runtimeEntityId; // = null;
		public string platformChatId; // = null;
		public float x; // = null;
		public float y; // = null;
		public float z; // = null;
		public float speedX; // = null;
		public float speedY; // = null;
		public float speedZ; // = null;
		public float pitch; // = null;
		public float yaw; // = null;
		public float headYaw; // = null;
		public Item item; // = null;
		public uint gameType; // = null;
		public MetadataDictionary metadata; // = null;
		public PropertySyncData syncdata; // = null;
		public long entityIdSelf; // = null;
		public byte playerPermissions; // = null;
		public byte commandPermissions; // = null;
		public AbilityLayers layers; // = null;
		public EntityLinks links; // = null;
		public string deviceId; // = null;
		public int deviceOs; // = null;

		public McpeAddPlayer()
		{
			Id = 0x0c;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(uuid);
			Write(username);
			WriteUnsignedVarLong(runtimeEntityId);
			Write(platformChatId);
			Write(x);
			Write(y);
			Write(z);
			Write(speedX);
			Write(speedY);
			Write(speedZ);
			Write(pitch);
			Write(yaw);
			Write(headYaw);
			Write(item);
			WriteUnsignedVarInt(gameType);
			Write(metadata);
			Write(syncdata);
			WriteSignedVarLong(entityIdSelf);
			Write(playerPermissions);
			Write(commandPermissions);
			Write(layers);
			Write(links);
			Write(deviceId);
			Write(deviceOs);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			uuid = ReadUUID();
			username = ReadString();
			runtimeEntityId = ReadUnsignedVarLong();
			platformChatId = ReadString();
			x = ReadFloat();
			y = ReadFloat();
			z = ReadFloat();
			speedX = ReadFloat();
			speedY = ReadFloat();
			speedZ = ReadFloat();
			pitch = ReadFloat();
			yaw = ReadFloat();
			headYaw = ReadFloat();
			item = ReadItem();
			gameType = ReadUnsignedVarInt();
			metadata = ReadMetadataDictionary();
			syncdata = ReadPropertySyncData();
			entityIdSelf = ReadSignedVarLong();
			playerPermissions = ReadByte();
			commandPermissions = ReadByte();
			layers = ReadAbilityLayers();
			links = ReadEntityLinks();
			deviceId = ReadString();
			deviceOs = ReadInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			uuid=default(UUID);
			username=default(string);
			runtimeEntityId=default(long);
			platformChatId=default(string);
			x=default(float);
			y=default(float);
			z=default(float);
			speedX=default(float);
			speedY=default(float);
			speedZ=default(float);
			pitch=default(float);
			yaw=default(float);
			headYaw=default(float);
			item=default(Item);
			gameType=default(uint);
			metadata=default(MetadataDictionary);
			syncdata=default(PropertySyncData);
			entityIdSelf=default(long);
			playerPermissions=default(byte);
			commandPermissions=default(byte);
			layers=default(AbilityLayers);
			links=default(EntityLinks);
			deviceId=default(string);
			deviceOs=default(int);
		}

	}

	public partial class McpeAddEntity : Packet
	{

		public long entityIdSelf; // = null;
		public long runtimeEntityId; // = null;
		public string entityType; // = null;
		public float x; // = null;
		public float y; // = null;
		public float z; // = null;
		public float speedX; // = null;
		public float speedY; // = null;
		public float speedZ; // = null;
		public float pitch; // = null;
		public float yaw; // = null;
		public float headYaw; // = null;
		public float bodyYaw; // = null;
		public EntityAttributes attributes; // = null;
		public MetadataDictionary metadata; // = null;
		public PropertySyncData syncdata; // = null;
		public EntityLinks links; // = null;

		public McpeAddEntity()
		{
			Id = 0x0d;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarLong(entityIdSelf);
			WriteUnsignedVarLong(runtimeEntityId);
			Write(entityType);
			Write(x);
			Write(y);
			Write(z);
			Write(speedX);
			Write(speedY);
			Write(speedZ);
			Write(pitch);
			Write(yaw);
			Write(headYaw);
			Write(bodyYaw);
			Write(attributes);
			Write(metadata);
			Write(syncdata);
			Write(links);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			entityIdSelf = ReadSignedVarLong();
			runtimeEntityId = ReadUnsignedVarLong();
			entityType = ReadString();
			x = ReadFloat();
			y = ReadFloat();
			z = ReadFloat();
			speedX = ReadFloat();
			speedY = ReadFloat();
			speedZ = ReadFloat();
			pitch = ReadFloat();
			yaw = ReadFloat();
			headYaw = ReadFloat();
			bodyYaw = ReadFloat();
			attributes = ReadEntityAttributes();
			metadata = ReadMetadataDictionary();
			syncdata = ReadPropertySyncData();
			links = ReadEntityLinks();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			entityIdSelf=default(long);
			runtimeEntityId=default(long);
			entityType=default(string);
			x=default(float);
			y=default(float);
			z=default(float);
			speedX=default(float);
			speedY=default(float);
			speedZ=default(float);
			pitch=default(float);
			yaw=default(float);
			headYaw=default(float);
			bodyYaw=default(float);
			attributes=default(EntityAttributes);
			metadata=default(MetadataDictionary);
			syncdata=default(PropertySyncData);
			links=default(EntityLinks);
		}

	}

	public partial class McpeRemoveEntity : Packet
	{

		public long entityIdSelf; // = null;

		public McpeRemoveEntity()
		{
			Id = 0x0e;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarLong(entityIdSelf);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			entityIdSelf = ReadSignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			entityIdSelf=default(long);
		}

	}

	public partial class McpeAddItemEntity : Packet
	{

		public long entityIdSelf; // = null;
		public long runtimeEntityId; // = null;
		public Item item; // = null;
		public float x; // = null;
		public float y; // = null;
		public float z; // = null;
		public float speedX; // = null;
		public float speedY; // = null;
		public float speedZ; // = null;
		public MetadataDictionary metadata; // = null;
		public bool isFromFishing; // = null;

		public McpeAddItemEntity()
		{
			Id = 0x0f;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarLong(entityIdSelf);
			WriteUnsignedVarLong(runtimeEntityId);
			Write(item);
			Write(x);
			Write(y);
			Write(z);
			Write(speedX);
			Write(speedY);
			Write(speedZ);
			Write(metadata);
			Write(isFromFishing);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			entityIdSelf = ReadSignedVarLong();
			runtimeEntityId = ReadUnsignedVarLong();
			item = ReadItem();
			x = ReadFloat();
			y = ReadFloat();
			z = ReadFloat();
			speedX = ReadFloat();
			speedY = ReadFloat();
			speedZ = ReadFloat();
			metadata = ReadMetadataDictionary();
			isFromFishing = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			entityIdSelf=default(long);
			runtimeEntityId=default(long);
			item=default(Item);
			x=default(float);
			y=default(float);
			z=default(float);
			speedX=default(float);
			speedY=default(float);
			speedZ=default(float);
			metadata=default(MetadataDictionary);
			isFromFishing=default(bool);
		}

	}

	public partial class McpeTakeItemEntity : Packet
	{

		public long runtimeEntityId; // = null;
		public long target; // = null;

		public McpeTakeItemEntity()
		{
			Id = 0x11;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			WriteUnsignedVarLong(target);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			target = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			target=default(long);
		}

	}

	public partial class McpeMoveEntity : Packet
	{

		public long runtimeEntityId; // = null;
		public byte flags; // = null;
		public PlayerLocation position; // = null;

		public McpeMoveEntity()
		{
			Id = 0x12;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(flags);
			Write(position);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			flags = ReadByte();
			position = ReadPlayerLocation();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			flags=default(byte);
			position=default(PlayerLocation);
		}

	}

	public partial class McpeMovePlayer : Packet
	{
		public enum Mode
		{
			Normal = 0,
			Reset = 1,
			Teleport = 2,
			Rotation = 3,
		}
		public enum Teleportcause
		{
			Unknown = 0,
			Projectile = 1,
			ChorusFruit = 2,
			Command = 3,
			Behavior = 4,
			Count = 5,
		}

		public long runtimeEntityId; // = null;
		public float x; // = null;
		public float y; // = null;
		public float z; // = null;
		public float pitch; // = null;
		public float yaw; // = null;
		public float headYaw; // = null;
		public byte mode; // = null;
		public bool onGround; // = null;
		public long otherRuntimeEntityId; // = null;

		public McpeMovePlayer()
		{
			Id = 0x13;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(x);
			Write(y);
			Write(z);
			Write(pitch);
			Write(yaw);
			Write(headYaw);
			Write(mode);
			Write(onGround);
			WriteUnsignedVarLong(otherRuntimeEntityId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			x = ReadFloat();
			y = ReadFloat();
			z = ReadFloat();
			pitch = ReadFloat();
			yaw = ReadFloat();
			headYaw = ReadFloat();
			mode = ReadByte();
			onGround = ReadBool();
			otherRuntimeEntityId = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			x=default(float);
			y=default(float);
			z=default(float);
			pitch=default(float);
			yaw=default(float);
			headYaw=default(float);
			mode=default(byte);
			onGround=default(bool);
			otherRuntimeEntityId=default(long);
		}

	}

	public partial class McpeRiderJump : Packet
	{

		public int unknown; // = null;

		public McpeRiderJump()
		{
			Id = 0x14;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(unknown);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			unknown = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			unknown=default(int);
		}

	}

	public partial class McpeUpdateBlock : Packet
	{
		public enum Flags
		{
			None = 0,
			Neighbors = 1,
			Network = 2,
			Nographic = 4,
			Priority = 8,
			All = (Neighbors | Network),
			AllPriority = (All | Priority),
		}

		public BlockCoordinates coordinates; // = null;
		public uint blockRuntimeId; // = null;
		public uint blockPriority; // = null;
		public uint storage; // = null;

		public McpeUpdateBlock()
		{
			Id = 0x15;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(coordinates);
			WriteUnsignedVarInt(blockRuntimeId);
			WriteUnsignedVarInt(blockPriority);
			WriteUnsignedVarInt(storage);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			coordinates = ReadBlockCoordinates();
			blockRuntimeId = ReadUnsignedVarInt();
			blockPriority = ReadUnsignedVarInt();
			storage = ReadUnsignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			coordinates=default(BlockCoordinates);
			blockRuntimeId=default(uint);
			blockPriority=default(uint);
			storage=default(uint);
		}

	}

	public partial class McpeAddPainting : Packet
	{

		public long entityIdSelf; // = null;
		public long runtimeEntityId; // = null;
		public BlockCoordinates coordinates; // = null;
		public int direction; // = null;
		public string title; // = null;

		public McpeAddPainting()
		{
			Id = 0x16;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarLong(entityIdSelf);
			WriteUnsignedVarLong(runtimeEntityId);
			Write(coordinates);
			WriteSignedVarInt(direction);
			Write(title);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			entityIdSelf = ReadSignedVarLong();
			runtimeEntityId = ReadUnsignedVarLong();
			coordinates = ReadBlockCoordinates();
			direction = ReadSignedVarInt();
			title = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			entityIdSelf=default(long);
			runtimeEntityId=default(long);
			coordinates=default(BlockCoordinates);
			direction=default(int);
			title=default(string);
		}

	}

	public partial class McpeTickSync : Packet
	{

		public long requestTime; // = null;
		public long responseTime; // = null;

		public McpeTickSync()
		{
			Id = 0x17;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(requestTime);
			Write(responseTime);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			requestTime = ReadLong();
			responseTime = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			requestTime=default(long);
			responseTime=default(long);
		}

	}

	public partial class McpeLevelSoundEventOld : Packet
	{

		public byte soundId; // = null;
		public Vector3 position; // = null;
		public int blockId; // = null;
		public int entityType; // = null;
		public bool isBabyMob; // = null;
		public bool isGlobal; // = null;

		public McpeLevelSoundEventOld()
		{
			Id = 0x18;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(soundId);
			Write(position);
			WriteSignedVarInt(blockId);
			WriteSignedVarInt(entityType);
			Write(isBabyMob);
			Write(isGlobal);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			soundId = ReadByte();
			position = ReadVector3();
			blockId = ReadSignedVarInt();
			entityType = ReadSignedVarInt();
			isBabyMob = ReadBool();
			isGlobal = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			soundId=default(byte);
			position=default(Vector3);
			blockId=default(int);
			entityType=default(int);
			isBabyMob=default(bool);
			isGlobal=default(bool);
		}

	}

	public partial class McpeLevelEvent : Packet
	{

		public int eventId; // = null;
		public Vector3 position; // = null;
		public int data; // = null;

		public McpeLevelEvent()
		{
			Id = 0x19;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(eventId);
			Write(position);
			WriteSignedVarInt(data);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			eventId = ReadSignedVarInt();
			position = ReadVector3();
			data = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			eventId=default(int);
			position=default(Vector3);
			data=default(int);
		}

	}

	public partial class McpeBlockEvent : Packet
	{

		public BlockCoordinates coordinates; // = null;
		public int case1; // = null;
		public int case2; // = null;

		public McpeBlockEvent()
		{
			Id = 0x1a;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(coordinates);
			WriteSignedVarInt(case1);
			WriteSignedVarInt(case2);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			coordinates = ReadBlockCoordinates();
			case1 = ReadSignedVarInt();
			case2 = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			coordinates=default(BlockCoordinates);
			case1=default(int);
			case2=default(int);
		}

	}

	public partial class McpeEntityEvent : Packet
	{

		public long runtimeEntityId; // = null;
		public byte eventId; // = null;
		public int data; // = null;

		public McpeEntityEvent()
		{
			Id = 0x1b;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(eventId);
			WriteSignedVarInt(data);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			eventId = ReadByte();
			data = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			eventId=default(byte);
			data=default(int);
		}

	}

	public partial class McpeMobEffect : Packet
	{

		public long runtimeEntityId; // = null;
		public byte eventId; // = null;
		public int effectId; // = null;
		public int amplifier; // = null;
		public bool particles; // = null;
		public int duration; // = null;

		public McpeMobEffect()
		{
			Id = 0x1c;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(eventId);
			WriteSignedVarInt(effectId);
			WriteSignedVarInt(amplifier);
			Write(particles);
			WriteSignedVarInt(duration);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			eventId = ReadByte();
			effectId = ReadSignedVarInt();
			amplifier = ReadSignedVarInt();
			particles = ReadBool();
			duration = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			eventId=default(byte);
			effectId=default(int);
			amplifier=default(int);
			particles=default(bool);
			duration=default(int);
		}

	}

	public partial class McpeUpdateAttributes : Packet
	{

		public long runtimeEntityId; // = null;
		public PlayerAttributes attributes; // = null;
		public long tick; // = null;

		public McpeUpdateAttributes()
		{
			Id = 0x1d;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(attributes);
			WriteUnsignedVarLong(tick);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			attributes = ReadPlayerAttributes();
			tick = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			attributes=default(PlayerAttributes);
			tick=default(long);
		}

	}

	public partial class McpeInventoryTransaction : Packet
	{
		public enum TransactionType
		{
			Normal = 0,
			InventoryMismatch = 1,
			ItemUse = 2,
			ItemUseOnEntity = 3,
			ItemRelease = 4,
		}
		public enum InventorySourceType
		{
			Container = 0,
			Global = 1,
			WorldInteraction = 2,
			Creative = 3,
			Crafting = 100,
			Unspecified = 99999,
		}
		public enum CraftingAction
		{
			CraftAddIngredient = -2,
			CraftRemoveIngredient = -3,
			CraftResult = -4,
			CraftUseIngredient = -5,
			AnvilInput = -10,
			AnvilMaterial = -11,
			AnvilResult = -12,
			AnvilOutput = -13,
			EnchantItem = -15,
			EnchantLapis = -16,
			EnchantResult = -17,
			Drop = -100,
		}
		public enum ItemReleaseAction
		{
			Release = 0,
			Use = 1,
		}
		public enum ItemUseAction
		{
			Place,Clickblock = 0,
			Use,Clickair = 1,
			Destroy = 2,
		}
		public enum ItemUseOnEntityAction
		{
			Interact = 0,
			Attack = 1,
			ItemInteract = 2,
		}

		public Transaction transaction; // = null;

		public McpeInventoryTransaction()
		{
			Id = 0x1e;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(transaction);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			transaction = ReadTransaction();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			transaction=default(Transaction);
		}

	}

	public partial class McpeMobEquipment : Packet
	{

		public long runtimeEntityId; // = null;
		public Item item; // = null;
		public byte slot; // = null;
		public byte selectedSlot; // = null;
		public byte windowsId; // = null;

		public McpeMobEquipment()
		{
			Id = 0x1f;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(item);
			Write(slot);
			Write(selectedSlot);
			Write(windowsId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			item = ReadItem();
			slot = ReadByte();
			selectedSlot = ReadByte();
			windowsId = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			item=default(Item);
			slot=default(byte);
			selectedSlot=default(byte);
			windowsId=default(byte);
		}

	}

	public partial class McpeMobArmorEquipment : Packet
	{

		public long runtimeEntityId; // = null;
		public Item helmet; // = null;
		public Item chestplate; // = null;
		public Item leggings; // = null;
		public Item boots; // = null;

		public McpeMobArmorEquipment()
		{
			Id = 0x20;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(helmet);
			Write(chestplate);
			Write(leggings);
			Write(boots);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			helmet = ReadItem();
			chestplate = ReadItem();
			leggings = ReadItem();
			boots = ReadItem();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			helmet=default(Item);
			chestplate=default(Item);
			leggings=default(Item);
			boots=default(Item);
		}

	}

	public partial class McpeInteract : Packet
	{
		public enum Actions
		{
			RightClick = 1,
			LeftClick = 2,
			LeaveVehicle = 3,
			MouseOver = 4,
			OpenNpc = 5,
			OpenInventory = 6,
		}

		public byte actionId; // = null;
		public long targetRuntimeEntityId; // = null;

		public McpeInteract()
		{
			Id = 0x21;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(actionId);
			WriteUnsignedVarLong(targetRuntimeEntityId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			actionId = ReadByte();
			targetRuntimeEntityId = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			actionId=default(byte);
			targetRuntimeEntityId=default(long);
		}

	}

	public partial class McpeBlockPickRequest : Packet
	{

		public int x; // = null;
		public int y; // = null;
		public int z; // = null;
		public bool addUserData; // = null;
		public byte selectedSlot; // = null;

		public McpeBlockPickRequest()
		{
			Id = 0x22;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(x);
			WriteSignedVarInt(y);
			WriteSignedVarInt(z);
			Write(addUserData);
			Write(selectedSlot);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			x = ReadSignedVarInt();
			y = ReadSignedVarInt();
			z = ReadSignedVarInt();
			addUserData = ReadBool();
			selectedSlot = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			x=default(int);
			y=default(int);
			z=default(int);
			addUserData=default(bool);
			selectedSlot=default(byte);
		}

	}

	public partial class McpeEntityPickRequest : Packet
	{

		public ulong runtimeEntityId; // = null;
		public byte selectedSlot; // = null;
		public bool addUserData; // = null;

		public McpeEntityPickRequest()
		{
			Id = 0x23;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(runtimeEntityId);
			Write(selectedSlot);
			Write(addUserData);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUlong();
			selectedSlot = ReadByte();
			addUserData = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(ulong);
			selectedSlot=default(byte);
			addUserData=default(bool);
		}

	}

	public partial class McpePlayerAction : Packet
	{

		public long runtimeEntityId; // = null;
		public int actionId; // = null;
		public BlockCoordinates coordinates; // = null;
		public BlockCoordinates resultCoordinates; // = null;
		public int face; // = null;

		public McpePlayerAction()
		{
			Id = 0x24;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			WriteSignedVarInt(actionId);
			Write(coordinates);
			Write(resultCoordinates);
			WriteSignedVarInt(face);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			actionId = ReadSignedVarInt();
			coordinates = ReadBlockCoordinates();
			resultCoordinates = ReadBlockCoordinates();
			face = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			actionId=default(int);
			coordinates=default(BlockCoordinates);
			resultCoordinates=default(BlockCoordinates);
			face=default(int);
		}

	}

	public partial class McpeHurtArmor : Packet
	{

		public int cause; // = null;
		public int health; // = null;
		public long armorSlotFlags; // = null;

		public McpeHurtArmor()
		{
			Id = 0x26;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteVarInt(cause);
			WriteSignedVarInt(health);
			WriteUnsignedVarLong(armorSlotFlags);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			cause = ReadVarInt();
			health = ReadSignedVarInt();
			armorSlotFlags = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			cause=default(int);
			health=default(int);
			armorSlotFlags=default(long);
		}

	}

	public partial class McpeSetEntityData : Packet
	{

		public long runtimeEntityId; // = null;
		public MetadataDictionary metadata; // = null;
		public PropertySyncData syncdata; // = null;
		public long tick; // = null;

		public McpeSetEntityData()
		{
			Id = 0x27;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(metadata);
			Write(syncdata);
			WriteUnsignedVarLong(tick);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			metadata = ReadMetadataDictionary();
			syncdata = ReadPropertySyncData();
			tick = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			metadata=default(MetadataDictionary);
			syncdata=default(PropertySyncData);
			tick=default(long);
		}

	}

	public partial class McpeSetEntityMotion : Packet
	{

		public long runtimeEntityId; // = null;
		public Vector3 velocity; // = null;

		public McpeSetEntityMotion()
		{
			Id = 0x28;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(velocity);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			velocity = ReadVector3();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			velocity=default(Vector3);
		}

	}

	public partial class McpeSetEntityLink : Packet
	{
		public enum LinkActions
		{
			Remove = 0,
			Ride = 1,
			Passenger = 2,
		}

		public long riddenId; // = null;
		public long riderId; // = null;
		public byte linkType; // = null;
		public byte unknown; // = null;

		public McpeSetEntityLink()
		{
			Id = 0x29;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarLong(riddenId);
			WriteSignedVarLong(riderId);
			Write(linkType);
			Write(unknown);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			riddenId = ReadSignedVarLong();
			riderId = ReadSignedVarLong();
			linkType = ReadByte();
			unknown = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			riddenId=default(long);
			riderId=default(long);
			linkType=default(byte);
			unknown=default(byte);
		}

	}

	public partial class McpeSetHealth : Packet
	{

		public int health; // = null;

		public McpeSetHealth()
		{
			Id = 0x2a;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(health);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			health = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			health=default(int);
		}

	}

	public partial class McpeSetSpawnPosition : Packet
	{

		public int spawnType; // = null;
		public BlockCoordinates coordinates; // = null;
		public int dimension; // = null;
		public BlockCoordinates unknownCoordinates; // = null;

		public McpeSetSpawnPosition()
		{
			Id = 0x2b;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(spawnType);
			Write(coordinates);
			WriteSignedVarInt(dimension);
			Write(unknownCoordinates);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			spawnType = ReadSignedVarInt();
			coordinates = ReadBlockCoordinates();
			dimension = ReadSignedVarInt();
			unknownCoordinates = ReadBlockCoordinates();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			spawnType=default(int);
			coordinates=default(BlockCoordinates);
			dimension=default(int);
			unknownCoordinates=default(BlockCoordinates);
		}

	}

	public partial class McpeAnimate : Packet
	{

		public int actionId; // = null;
		public long runtimeEntityId; // = null;

		public McpeAnimate()
		{
			Id = 0x2c;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(actionId);
			WriteUnsignedVarLong(runtimeEntityId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			actionId = ReadSignedVarInt();
			runtimeEntityId = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			actionId=default(int);
			runtimeEntityId=default(long);
		}

	}

	public partial class McpeRespawn : Packet
	{
		public enum RespawnState
		{
			Search = 0,
			Ready = 1,
			ClientReady = 2,
		}

		public float x; // = null;
		public float y; // = null;
		public float z; // = null;
		public byte state; // = null;
		public long runtimeEntityId; // = null;

		public McpeRespawn()
		{
			Id = 0x2d;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(x);
			Write(y);
			Write(z);
			Write(state);
			WriteUnsignedVarLong(runtimeEntityId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			x = ReadFloat();
			y = ReadFloat();
			z = ReadFloat();
			state = ReadByte();
			runtimeEntityId = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			x=default(float);
			y=default(float);
			z=default(float);
			state=default(byte);
			runtimeEntityId=default(long);
		}

	}

	public partial class McpeContainerOpen : Packet
	{

		public byte windowId; // = null;
		public byte type; // = null;
		public BlockCoordinates coordinates; // = null;
		public long runtimeEntityId; // = null;

		public McpeContainerOpen()
		{
			Id = 0x2e;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(windowId);
			Write(type);
			Write(coordinates);
			WriteSignedVarLong(runtimeEntityId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			windowId = ReadByte();
			type = ReadByte();
			coordinates = ReadBlockCoordinates();
			runtimeEntityId = ReadSignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			windowId=default(byte);
			type=default(byte);
			coordinates=default(BlockCoordinates);
			runtimeEntityId=default(long);
		}

	}

	public partial class McpeContainerClose : Packet
	{

		public byte windowId; // = null;
		public bool server; // = null;

		public McpeContainerClose()
		{
			Id = 0x2f;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(windowId);
			Write(server);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			windowId = ReadByte();
			server = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			windowId=default(byte);
			server=default(bool);
		}

	}

	public partial class McpePlayerHotbar : Packet
	{

		public uint selectedSlot; // = null;
		public byte windowId; // = null;
		public bool selectSlot; // = null;

		public McpePlayerHotbar()
		{
			Id = 0x30;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarInt(selectedSlot);
			Write(windowId);
			Write(selectSlot);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			selectedSlot = ReadUnsignedVarInt();
			windowId = ReadByte();
			selectSlot = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			selectedSlot=default(uint);
			windowId=default(byte);
			selectSlot=default(bool);
		}

	}

	public partial class McpeInventoryContent : Packet
	{

		public uint inventoryId; // = null;
		public ItemStacks input; // = null;

		public McpeInventoryContent()
		{
			Id = 0x31;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarInt(inventoryId);
			Write(input);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			inventoryId = ReadUnsignedVarInt();
			input = ReadItemStacks();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			inventoryId=default(uint);
			input=default(ItemStacks);
		}

	}

	public partial class McpeInventorySlot : Packet
	{

		public uint inventoryId; // = null;
		public uint slot; // = null;
		public Item item; // = null;

		public McpeInventorySlot()
		{
			Id = 0x32;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarInt(inventoryId);
			WriteUnsignedVarInt(slot);
			Write(item);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			inventoryId = ReadUnsignedVarInt();
			slot = ReadUnsignedVarInt();
			item = ReadItem();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			inventoryId=default(uint);
			slot=default(uint);
			item=default(Item);
		}

	}

	public partial class McpeContainerSetData : Packet
	{

		public byte windowId; // = null;
		public int property; // = null;
		public int value; // = null;

		public McpeContainerSetData()
		{
			Id = 0x33;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(windowId);
			WriteSignedVarInt(property);
			WriteSignedVarInt(value);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			windowId = ReadByte();
			property = ReadSignedVarInt();
			value = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			windowId=default(byte);
			property=default(int);
			value=default(int);
		}

	}

	public partial class McpeCraftingData : Packet
	{

		public Recipes recipes; // = null;
		public PotionTypeRecipe[] potionTypeRecipes; // = null;
		public PotionContainerChangeRecipe[] potionContainerRecipes; // = null;
		public MaterialReducerRecipe[] materialReducerRecipes; // = null;
		public bool isClean; // = null;

		public McpeCraftingData()
		{
			Id = 0x34;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(recipes);
			Write(potionTypeRecipes);
			Write(potionContainerRecipes);
			Write(materialReducerRecipes);
			Write(isClean);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			recipes = ReadRecipes();
			potionTypeRecipes = ReadPotionTypeRecipes();
			potionContainerRecipes = ReadPotionContainerChangeRecipes();
			materialReducerRecipes = ReadMaterialReducerRecipes();
			isClean = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			recipes=default(Recipes);
			potionTypeRecipes=default(PotionTypeRecipe[]);
			potionContainerRecipes=default(PotionContainerChangeRecipe[]);
			materialReducerRecipes=default(MaterialReducerRecipe[]);
			isClean=default(bool);
		}

	}

	public partial class McpeCraftingEvent : Packet
	{
		public enum RecipeTypes
		{
			Shapeless = 0,
			Shaped = 1,
			Furnace = 2,
			FurnaceData = 3,
			Multi = 4,
			ShulkerBox = 5,
			ChemistryShapeless = 6,
			ChemistryShaped = 7,
			SmithingTransform = 8,
			SmithingTrim = 9,
		}

		public byte windowId; // = null;
		public int recipeType; // = null;
		public UUID recipeId; // = null;
		public ItemStacks input; // = null;
		public ItemStacks result; // = null;

		public McpeCraftingEvent()
		{
			Id = 0x35;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(windowId);
			WriteSignedVarInt(recipeType);
			Write(recipeId);
			Write(input);
			Write(result);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			windowId = ReadByte();
			recipeType = ReadSignedVarInt();
			recipeId = ReadUUID();
			input = ReadItemStacks();
			result = ReadItemStacks();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			windowId=default(byte);
			recipeType=default(int);
			recipeId=default(UUID);
			input=default(ItemStacks);
			result=default(ItemStacks);
		}

	}

	public partial class McpeGuiDataPickItem : Packet
	{


		public McpeGuiDataPickItem()
		{
			Id = 0x36;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeAdventureSettings : Packet
	{

		public uint flags; // = null;
		public uint commandPermission; // = null;
		public uint actionPermissions; // = null;
		public uint permissionLevel; // = null;
		public uint customStoredPermissions; // = null;
		public long entityUniqueId; // = null;

		public McpeAdventureSettings()
		{
			Id = 0x37;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarInt(flags);
			WriteUnsignedVarInt(commandPermission);
			WriteUnsignedVarInt(actionPermissions);
			WriteUnsignedVarInt(permissionLevel);
			WriteUnsignedVarInt(customStoredPermissions);
			Write(entityUniqueId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			flags = ReadUnsignedVarInt();
			commandPermission = ReadUnsignedVarInt();
			actionPermissions = ReadUnsignedVarInt();
			permissionLevel = ReadUnsignedVarInt();
			customStoredPermissions = ReadUnsignedVarInt();
			entityUniqueId = ReadLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			flags=default(uint);
			commandPermission=default(uint);
			actionPermissions=default(uint);
			permissionLevel=default(uint);
			customStoredPermissions=default(uint);
			entityUniqueId=default(long);
		}

	}

	public partial class McpeBlockEntityData : Packet
	{

		public BlockCoordinates coordinates; // = null;
		public Nbt namedtag; // = null;

		public McpeBlockEntityData()
		{
			Id = 0x38;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(coordinates);
			Write(namedtag);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			coordinates = ReadBlockCoordinates();
			namedtag = ReadNbt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			coordinates=default(BlockCoordinates);
			namedtag=default(Nbt);
		}

	}

	public partial class McpePlayerInput : Packet
	{

		public float motionX; // = null;
		public float motionZ; // = null;
		public bool jumping; // = null;
		public bool sneaking; // = null;

		public McpePlayerInput()
		{
			Id = 0x39;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(motionX);
			Write(motionZ);
			Write(jumping);
			Write(sneaking);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			motionX = ReadFloat();
			motionZ = ReadFloat();
			jumping = ReadBool();
			sneaking = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			motionX=default(float);
			motionZ=default(float);
			jumping=default(bool);
			sneaking=default(bool);
		}

	}

	public partial class McpeLevelChunk : Packet
	{

		public int chunkX; // = null;
		public int chunkZ; // = null;

		public McpeLevelChunk()
		{
			Id = 0x3a;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(chunkX);
			WriteSignedVarInt(chunkZ);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			chunkX = ReadSignedVarInt();
			chunkZ = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			chunkX=default(int);
			chunkZ=default(int);
		}

	}

	public partial class McpeSetCommandsEnabled : Packet
	{

		public bool enabled; // = null;

		public McpeSetCommandsEnabled()
		{
			Id = 0x3b;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(enabled);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			enabled = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			enabled=default(bool);
		}

	}

	public partial class McpeSetDifficulty : Packet
	{

		public uint difficulty; // = null;

		public McpeSetDifficulty()
		{
			Id = 0x3c;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarInt(difficulty);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			difficulty = ReadUnsignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			difficulty=default(uint);
		}

	}

	public partial class McpeChangeDimension : Packet
	{

		public int dimension; // = null;
		public Vector3 position; // = null;
		public bool respawn; // = null;

		public McpeChangeDimension()
		{
			Id = 0x3d;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(dimension);
			Write(position);
			Write(respawn);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			dimension = ReadSignedVarInt();
			position = ReadVector3();
			respawn = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			dimension=default(int);
			position=default(Vector3);
			respawn=default(bool);
		}

	}

	public partial class McpeSetPlayerGameType : Packet
	{

		public int gamemode; // = null;

		public McpeSetPlayerGameType()
		{
			Id = 0x3e;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(gamemode);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			gamemode = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			gamemode=default(int);
		}

	}

	public partial class McpePlayerList : Packet
	{

		public PlayerRecords records; // = null;

		public McpePlayerList()
		{
			Id = 0x3f;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(records);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			records = ReadPlayerRecords();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			records=default(PlayerRecords);
		}

	}

	public partial class McpeSimpleEvent : Packet
	{

		public ushort eventType; // = null;

		public McpeSimpleEvent()
		{
			Id = 0x40;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(eventType);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			eventType = ReadUshort();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			eventType=default(ushort);
		}

	}

	public partial class McpeTelemetryEvent : Packet
	{

		public long runtimeEntityId; // = null;
		public int eventData; // = null;
		public byte eventType; // = null;
		public byte[] auxData; // = null;

		public McpeTelemetryEvent()
		{
			Id = 0x41;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			WriteSignedVarInt(eventData);
			Write(eventType);
			Write(auxData);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			eventData = ReadSignedVarInt();
			eventType = ReadByte();
			auxData = ReadBytes(0, true);

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			eventData=default(int);
			eventType=default(byte);
			auxData=default(byte[]);
		}

	}

	public partial class McpeSpawnExperienceOrb : Packet
	{

		public Vector3 position; // = null;
		public int count; // = null;

		public McpeSpawnExperienceOrb()
		{
			Id = 0x42;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(position);
			WriteSignedVarInt(count);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			position = ReadVector3();
			count = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			position=default(Vector3);
			count=default(int);
		}

	}

	public partial class McpeClientboundMapItemData : Packet
	{

		public MapInfo mapinfo; // = null;

		public McpeClientboundMapItemData()
		{
			Id = 0x43;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(mapinfo);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			mapinfo = ReadMapInfo();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			mapinfo=default(MapInfo);
		}

	}

	public partial class McpeMapInfoRequest : Packet
	{

		public long mapId; // = null;

		public McpeMapInfoRequest()
		{
			Id = 0x44;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarLong(mapId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			mapId = ReadSignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			mapId=default(long);
		}

	}

	public partial class McpeRequestChunkRadius : Packet
	{

		public int chunkRadius; // = null;
		public byte maxRadius; // = null;

		public McpeRequestChunkRadius()
		{
			Id = 0x45;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(chunkRadius);
			Write(maxRadius);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			chunkRadius = ReadSignedVarInt();
			maxRadius = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			chunkRadius=default(int);
			maxRadius=default(byte);
		}

	}

	public partial class McpeChunkRadiusUpdate : Packet
	{

		public int chunkRadius; // = null;

		public McpeChunkRadiusUpdate()
		{
			Id = 0x46;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(chunkRadius);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			chunkRadius = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			chunkRadius=default(int);
		}

	}

	public partial class McpeItemFrameDropItem : Packet
	{

		public BlockCoordinates coordinates; // = null;

		public McpeItemFrameDropItem()
		{
			Id = 0x47;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(coordinates);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			coordinates = ReadBlockCoordinates();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			coordinates=default(BlockCoordinates);
		}

	}

	public partial class McpeGameRulesChanged : Packet
	{

		public GameRules rules; // = null;

		public McpeGameRulesChanged()
		{
			Id = 0x48;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(rules);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			rules = ReadGameRules();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			rules=default(GameRules);
		}

	}

	public partial class McpeCamera : Packet
	{

		public long unknown1; // = null;
		public long unknown2; // = null;

		public McpeCamera()
		{
			Id = 0x49;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarLong(unknown1);
			WriteSignedVarLong(unknown2);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			unknown1 = ReadSignedVarLong();
			unknown2 = ReadSignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			unknown1=default(long);
			unknown2=default(long);
		}

	}

	public partial class McpeBossEvent : Packet
	{
		public enum Type
		{
			AddBoss = 0,
			AddPlayer = 1,
			RemoveBoss = 2,
			RemovePlayer = 3,
			UpdateProgress = 4,
			UpdateName = 5,
			UpdateOptions = 6,
			UpdateStyle = 7,
			Query = 8,
		}

		public long bossEntityId; // = null;
		public uint eventType; // = null;

		public McpeBossEvent()
		{
			Id = 0x4a;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarLong(bossEntityId);
			WriteUnsignedVarInt(eventType);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			bossEntityId = ReadSignedVarLong();
			eventType = ReadUnsignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			bossEntityId=default(long);
			eventType=default(uint);
		}

	}

	public partial class McpeShowCredits : Packet
	{

		public long runtimeEntityId; // = null;
		public int status; // = null;

		public McpeShowCredits()
		{
			Id = 0x4b;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			WriteSignedVarInt(status);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			status = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			status=default(int);
		}

	}

	public partial class McpeAvailableCommands : Packet
	{


		public McpeAvailableCommands()
		{
			Id = 0x4c;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeCommandRequest : Packet
	{

		public string command; // = null;
		public uint commandType; // = null;
		public UUID unknownUuid; // = null;
		public string requestId; // = null;
		public bool isinternal; // = null;
		public int version; // = null;

		public McpeCommandRequest()
		{
			Id = 0x4d;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(command);
			WriteUnsignedVarInt(commandType);
			Write(unknownUuid);
			Write(requestId);
			Write(isinternal);
			WriteSignedVarInt(version);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			command = ReadString();
			commandType = ReadUnsignedVarInt();
			unknownUuid = ReadUUID();
			requestId = ReadString();
			isinternal = ReadBool();
			version = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			command=default(string);
			commandType=default(uint);
			unknownUuid=default(UUID);
			requestId=default(string);
			isinternal=default(bool);
			version=default(int);
		}

	}

	public partial class McpeCommandBlockUpdate : Packet
	{

		public bool isBlock; // = null;

		public McpeCommandBlockUpdate()
		{
			Id = 0x4e;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(isBlock);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			isBlock = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			isBlock=default(bool);
		}

	}

	public partial class McpeCommandOutput : Packet
	{


		public McpeCommandOutput()
		{
			Id = 0x4f;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeUpdateTrade : Packet
	{

		public byte windowId; // = null;
		public byte windowType; // = null;
		public int unknown0; // = null;
		public int unknown1; // = null;
		public int unknown2; // = null;
		public bool isWilling; // = null;
		public long traderEntityId; // = null;
		public long playerEntityId; // = null;
		public string displayName; // = null;
		public Nbt namedtag; // = null;

		public McpeUpdateTrade()
		{
			Id = 0x50;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(windowId);
			Write(windowType);
			WriteVarInt(unknown0);
			WriteVarInt(unknown1);
			WriteVarInt(unknown2);
			Write(isWilling);
			WriteSignedVarLong(traderEntityId);
			WriteSignedVarLong(playerEntityId);
			Write(displayName);
			Write(namedtag);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			windowId = ReadByte();
			windowType = ReadByte();
			unknown0 = ReadVarInt();
			unknown1 = ReadVarInt();
			unknown2 = ReadVarInt();
			isWilling = ReadBool();
			traderEntityId = ReadSignedVarLong();
			playerEntityId = ReadSignedVarLong();
			displayName = ReadString();
			namedtag = ReadNbt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			windowId=default(byte);
			windowType=default(byte);
			unknown0=default(int);
			unknown1=default(int);
			unknown2=default(int);
			isWilling=default(bool);
			traderEntityId=default(long);
			playerEntityId=default(long);
			displayName=default(string);
			namedtag=default(Nbt);
		}

	}

	public partial class McpeUpdateEquipment : Packet
	{

		public byte windowId; // = null;
		public byte windowType; // = null;
		public byte unknown; // = null;
		public long entityId; // = null;
		public Nbt namedtag; // = null;

		public McpeUpdateEquipment()
		{
			Id = 0x51;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(windowId);
			Write(windowType);
			Write(unknown);
			WriteSignedVarLong(entityId);
			Write(namedtag);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			windowId = ReadByte();
			windowType = ReadByte();
			unknown = ReadByte();
			entityId = ReadSignedVarLong();
			namedtag = ReadNbt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			windowId=default(byte);
			windowType=default(byte);
			unknown=default(byte);
			entityId=default(long);
			namedtag=default(Nbt);
		}

	}

	public partial class McpeResourcePackDataInfo : Packet
	{

		public string packageId; // = null;
		public uint maxChunkSize; // = null;
		public uint chunkCount; // = null;
		public ulong compressedPackageSize; // = null;
		public byte[] hash; // = null;
		public bool isPremium; // = null;
		public byte packType; // = null;

		public McpeResourcePackDataInfo()
		{
			Id = 0x52;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(packageId);
			Write(maxChunkSize);
			Write(chunkCount);
			Write(compressedPackageSize);
			WriteByteArray(hash);
			Write(isPremium);
			Write(packType);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			packageId = ReadString();
			maxChunkSize = ReadUint();
			chunkCount = ReadUint();
			compressedPackageSize = ReadUlong();
			hash = ReadByteArray();
			isPremium = ReadBool();
			packType = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			packageId=default(string);
			maxChunkSize=default(uint);
			chunkCount=default(uint);
			compressedPackageSize=default(ulong);
			hash=default(byte[]);
			isPremium=default(bool);
			packType=default(byte);
		}

	}

	public partial class McpeResourcePackChunkData : Packet
	{

		public string packageId; // = null;
		public uint chunkIndex; // = null;
		public ulong progress; // = null;
		public byte[] payload; // = null;

		public McpeResourcePackChunkData()
		{
			Id = 0x53;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(packageId);
			Write(chunkIndex);
			Write(progress);
			WriteByteArray(payload);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			packageId = ReadString();
			chunkIndex = ReadUint();
			progress = ReadUlong();
			payload = ReadByteArray();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			packageId=default(string);
			chunkIndex=default(uint);
			progress=default(ulong);
			payload=default(byte[]);
		}

	}

	public partial class McpeResourcePackChunkRequest : Packet
	{

		public string packageId; // = null;
		public uint chunkIndex; // = null;

		public McpeResourcePackChunkRequest()
		{
			Id = 0x54;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(packageId);
			Write(chunkIndex);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			packageId = ReadString();
			chunkIndex = ReadUint();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			packageId=default(string);
			chunkIndex=default(uint);
		}

	}

	public partial class McpeTransfer : Packet
	{

		public string serverAddress; // = null;
		public ushort port; // = null;

		public McpeTransfer()
		{
			Id = 0x55;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(serverAddress);
			Write(port);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			serverAddress = ReadString();
			port = ReadUshort();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			serverAddress=default(string);
			port=default(ushort);
		}

	}

	public partial class McpePlaySound : Packet
	{

		public string name; // = null;
		public BlockCoordinates coordinates; // = null;
		public float volume; // = null;
		public float pitch; // = null;

		public McpePlaySound()
		{
			Id = 0x56;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(name);
			Write(coordinates);
			Write(volume);
			Write(pitch);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			name = ReadString();
			coordinates = ReadBlockCoordinates();
			volume = ReadFloat();
			pitch = ReadFloat();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			name=default(string);
			coordinates=default(BlockCoordinates);
			volume=default(float);
			pitch=default(float);
		}

	}

	public partial class McpeStopSound : Packet
	{

		public string name; // = null;
		public bool stopAll; // = null;

		public McpeStopSound()
		{
			Id = 0x57;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(name);
			Write(stopAll);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			name = ReadString();
			stopAll = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			name=default(string);
			stopAll=default(bool);
		}

	}

	public partial class McpeSetTitle : Packet
	{

		public int type; // = null;
		public string text; // = null;
		public int fadeInTime; // = null;
		public int stayTime; // = null;
		public int fadeOutTime; // = null;
		public string xuid; // = null;
		public string platformOnlineId; // = null;

		public McpeSetTitle()
		{
			Id = 0x58;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(type);
			Write(text);
			WriteSignedVarInt(fadeInTime);
			WriteSignedVarInt(stayTime);
			WriteSignedVarInt(fadeOutTime);
			Write(xuid);
			Write(platformOnlineId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			type = ReadSignedVarInt();
			text = ReadString();
			fadeInTime = ReadSignedVarInt();
			stayTime = ReadSignedVarInt();
			fadeOutTime = ReadSignedVarInt();
			xuid = ReadString();
			platformOnlineId = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			type=default(int);
			text=default(string);
			fadeInTime=default(int);
			stayTime=default(int);
			fadeOutTime=default(int);
			xuid=default(string);
			platformOnlineId=default(string);
		}

	}

	public partial class McpeAddBehaviorTree : Packet
	{

		public string behaviortree; // = null;

		public McpeAddBehaviorTree()
		{
			Id = 0x59;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(behaviortree);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			behaviortree = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			behaviortree=default(string);
		}

	}

	public partial class McpeStructureBlockUpdate : Packet
	{


		public McpeStructureBlockUpdate()
		{
			Id = 0x5a;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeShowStoreOffer : Packet
	{

		public string unknown0; // = null;
		public bool unknown1; // = null;

		public McpeShowStoreOffer()
		{
			Id = 0x5b;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(unknown0);
			Write(unknown1);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			unknown0 = ReadString();
			unknown1 = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			unknown0=default(string);
			unknown1=default(bool);
		}

	}

	public partial class McpePurchaseReceipt : Packet
	{


		public McpePurchaseReceipt()
		{
			Id = 0x5c;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpePlayerSkin : Packet
	{

		public UUID uuid; // = null;
		public Skin skin; // = null;
		public string skinName; // = null;
		public string oldSkinName; // = null;
		public bool isVerified; // = null;

		public McpePlayerSkin()
		{
			Id = 0x5d;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(uuid);
			Write(skin);
			Write(skinName);
			Write(oldSkinName);
			Write(isVerified);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			uuid = ReadUUID();
			skin = ReadSkin();
			skinName = ReadString();
			oldSkinName = ReadString();
			isVerified = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			uuid=default(UUID);
			skin=default(Skin);
			skinName=default(string);
			oldSkinName=default(string);
			isVerified=default(bool);
		}

	}

	public partial class McpeSubClientLogin : Packet
	{


		public McpeSubClientLogin()
		{
			Id = 0x5e;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeInitiateWebSocketConnection : Packet
	{

		public string server; // = null;

		public McpeInitiateWebSocketConnection()
		{
			Id = 0x5f;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(server);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			server = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			server=default(string);
		}

	}

	public partial class McpeSetLastHurtBy : Packet
	{

		public int unknown; // = null;

		public McpeSetLastHurtBy()
		{
			Id = 0x60;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteVarInt(unknown);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			unknown = ReadVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			unknown=default(int);
		}

	}

	public partial class McpeBookEdit : Packet
	{


		public McpeBookEdit()
		{
			Id = 0x61;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeNpcRequest : Packet
	{

		public long runtimeEntityId; // = null;
		public byte unknown0; // = null;
		public string unknown1; // = null;
		public byte unknown2; // = null;

		public McpeNpcRequest()
		{
			Id = 0x62;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(unknown0);
			Write(unknown1);
			Write(unknown2);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			unknown0 = ReadByte();
			unknown1 = ReadString();
			unknown2 = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			unknown0=default(byte);
			unknown1=default(string);
			unknown2=default(byte);
		}

	}

	public partial class McpePhotoTransfer : Packet
	{

		public string fileName; // = null;
		public string imageData; // = null;
		public string unknown2; // = null;

		public McpePhotoTransfer()
		{
			Id = 0x63;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(fileName);
			Write(imageData);
			Write(unknown2);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			fileName = ReadString();
			imageData = ReadString();
			unknown2 = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			fileName=default(string);
			imageData=default(string);
			unknown2=default(string);
		}

	}

	public partial class McpeModalFormRequest : Packet
	{

		public uint formId; // = null;
		public string data; // = null;

		public McpeModalFormRequest()
		{
			Id = 0x64;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarInt(formId);
			Write(data);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			formId = ReadUnsignedVarInt();
			data = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			formId=default(uint);
			data=default(string);
		}

	}

	public partial class McpeModalFormResponse : Packet
	{

		public uint formId; // = null;
		public string data; // = null;

		public McpeModalFormResponse()
		{
			Id = 0x65;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarInt(formId);
			Write(data);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			formId = ReadUnsignedVarInt();
			data = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			formId=default(uint);
			data=default(string);
		}

	}

	public partial class McpeServerSettingsRequest : Packet
	{


		public McpeServerSettingsRequest()
		{
			Id = 0x66;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeServerSettingsResponse : Packet
	{

		public long formId; // = null;
		public string data; // = null;

		public McpeServerSettingsResponse()
		{
			Id = 0x67;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(formId);
			Write(data);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			formId = ReadUnsignedVarLong();
			data = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			formId=default(long);
			data=default(string);
		}

	}

	public partial class McpeShowProfile : Packet
	{

		public string xuid; // = null;

		public McpeShowProfile()
		{
			Id = 0x68;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(xuid);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			xuid = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			xuid=default(string);
		}

	}

	public partial class McpeSetDefaultGameType : Packet
	{

		public int gamemode; // = null;

		public McpeSetDefaultGameType()
		{
			Id = 0x69;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteVarInt(gamemode);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			gamemode = ReadVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			gamemode=default(int);
		}

	}

	public partial class McpeRemoveObjective : Packet
	{

		public string objectiveName; // = null;

		public McpeRemoveObjective()
		{
			Id = 0x6a;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(objectiveName);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			objectiveName = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			objectiveName=default(string);
		}

	}

	public partial class McpeSetDisplayObjective : Packet
	{

		public string displaySlot; // = null;
		public string objectiveName; // = null;
		public string displayName; // = null;
		public string criteriaName; // = null;
		public int sortOrder; // = null;

		public McpeSetDisplayObjective()
		{
			Id = 0x6b;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(displaySlot);
			Write(objectiveName);
			Write(displayName);
			Write(criteriaName);
			WriteSignedVarInt(sortOrder);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			displaySlot = ReadString();
			objectiveName = ReadString();
			displayName = ReadString();
			criteriaName = ReadString();
			sortOrder = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			displaySlot=default(string);
			objectiveName=default(string);
			displayName=default(string);
			criteriaName=default(string);
			sortOrder=default(int);
		}

	}

	public partial class McpeSetScore : Packet
	{
		public enum Types
		{
			Change = 0,
			Remove = 1,
		}
		public enum ChangeTypes
		{
			Player = 1,
			Entity = 2,
			FakePlayer = 3,
		}

		public ScoreEntries entries; // = null;

		public McpeSetScore()
		{
			Id = 0x6c;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(entries);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			entries = ReadScoreEntries();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			entries=default(ScoreEntries);
		}

	}

	public partial class McpeLabTable : Packet
	{

		public byte uselessByte; // = null;
		public int labTableX; // = null;
		public int labTableY; // = null;
		public int labTableZ; // = null;
		public byte reactionType; // = null;

		public McpeLabTable()
		{
			Id = 0x6d;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(uselessByte);
			WriteVarInt(labTableX);
			WriteVarInt(labTableY);
			WriteVarInt(labTableZ);
			Write(reactionType);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			uselessByte = ReadByte();
			labTableX = ReadVarInt();
			labTableY = ReadVarInt();
			labTableZ = ReadVarInt();
			reactionType = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			uselessByte=default(byte);
			labTableX=default(int);
			labTableY=default(int);
			labTableZ=default(int);
			reactionType=default(byte);
		}

	}

	public partial class McpeUpdateBlockSynced : Packet
	{

		public BlockCoordinates coordinates; // = null;
		public uint blockRuntimeId; // = null;
		public uint blockPriority; // = null;
		public uint dataLayerId; // = null;
		public long unknown0; // = null;
		public long unknown1; // = null;

		public McpeUpdateBlockSynced()
		{
			Id = 0x6e;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(coordinates);
			WriteUnsignedVarInt(blockRuntimeId);
			WriteUnsignedVarInt(blockPriority);
			WriteUnsignedVarInt(dataLayerId);
			WriteUnsignedVarLong(unknown0);
			WriteUnsignedVarLong(unknown1);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			coordinates = ReadBlockCoordinates();
			blockRuntimeId = ReadUnsignedVarInt();
			blockPriority = ReadUnsignedVarInt();
			dataLayerId = ReadUnsignedVarInt();
			unknown0 = ReadUnsignedVarLong();
			unknown1 = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			coordinates=default(BlockCoordinates);
			blockRuntimeId=default(uint);
			blockPriority=default(uint);
			dataLayerId=default(uint);
			unknown0=default(long);
			unknown1=default(long);
		}

	}

	public partial class McpeMoveEntityDelta : Packet
	{

		public long runtimeEntityId; // = null;
		public ushort flags; // = null;

		public McpeMoveEntityDelta()
		{
			Id = 0x6f;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(flags);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			flags = ReadUshort();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			flags=default(ushort);
		}

	}

	public partial class McpeSetScoreboardIdentity : Packet
	{
		public enum Operations
		{
			RegisterIdentity = 0,
			ClearIdentity = 1,
		}

		public ScoreboardIdentityEntries entries; // = null;

		public McpeSetScoreboardIdentity()
		{
			Id = 0x70;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(entries);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			entries = ReadScoreboardIdentityEntries();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			entries=default(ScoreboardIdentityEntries);
		}

	}

	public partial class McpeSetLocalPlayerAsInitialized : Packet
	{

		public long runtimeEntityId; // = null;

		public McpeSetLocalPlayerAsInitialized()
		{
			Id = 0x71;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
		}

	}

	public partial class McpeUpdateSoftEnum : Packet
	{


		public McpeUpdateSoftEnum()
		{
			Id = 0x72;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeNetworkStackLatency : Packet
	{

		public ulong timestamp; // = null;
		public byte unknownFlag; // = null;

		public McpeNetworkStackLatency()
		{
			Id = 0x73;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(timestamp);
			Write(unknownFlag);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			timestamp = ReadUlong();
			unknownFlag = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			timestamp=default(ulong);
			unknownFlag=default(byte);
		}

	}

	public partial class McpeScriptCustomEvent : Packet
	{

		public string eventName; // = null;
		public string eventData; // = null;

		public McpeScriptCustomEvent()
		{
			Id = 0x75;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(eventName);
			Write(eventData);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			eventName = ReadString();
			eventData = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			eventName=default(string);
			eventData=default(string);
		}

	}

	public partial class McpeSpawnParticleEffect : Packet
	{

		public byte dimensionId; // = null;
		public long entityId; // = null;
		public Vector3 position; // = null;
		public string particleName; // = null;
		public string molangVariablesJson; // = null;

		public McpeSpawnParticleEffect()
		{
			Id = 0x76;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(dimensionId);
			WriteSignedVarLong(entityId);
			Write(position);
			Write(particleName);
			Write(molangVariablesJson);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			dimensionId = ReadByte();
			entityId = ReadSignedVarLong();
			position = ReadVector3();
			particleName = ReadString();
			molangVariablesJson = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			dimensionId=default(byte);
			entityId=default(long);
			position=default(Vector3);
			particleName=default(string);
			molangVariablesJson=default(string);
		}

	}

	public partial class McpeAvailableEntityIdentifiers : Packet
	{

		public Nbt namedtag; // = null;

		public McpeAvailableEntityIdentifiers()
		{
			Id = 0x77;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(namedtag);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			namedtag = ReadNbt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			namedtag=default(Nbt);
		}

	}

	public partial class McpeLevelSoundEventV2 : Packet
	{

		public byte soundId; // = null;
		public Vector3 position; // = null;
		public int blockId; // = null;
		public string entityType; // = null;
		public bool isBabyMob; // = null;
		public bool isGlobal; // = null;

		public McpeLevelSoundEventV2()
		{
			Id = 0x78;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(soundId);
			Write(position);
			WriteSignedVarInt(blockId);
			Write(entityType);
			Write(isBabyMob);
			Write(isGlobal);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			soundId = ReadByte();
			position = ReadVector3();
			blockId = ReadSignedVarInt();
			entityType = ReadString();
			isBabyMob = ReadBool();
			isGlobal = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			soundId=default(byte);
			position=default(Vector3);
			blockId=default(int);
			entityType=default(string);
			isBabyMob=default(bool);
			isGlobal=default(bool);
		}

	}

	public partial class McpeNetworkChunkPublisherUpdate : Packet
	{

		public BlockCoordinates coordinates; // = null;
		public uint radius; // = null;
		public int savedChunks; // = null;

		public McpeNetworkChunkPublisherUpdate()
		{
			Id = 0x79;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(coordinates);
			WriteUnsignedVarInt(radius);
			Write(savedChunks);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			coordinates = ReadBlockCoordinates();
			radius = ReadUnsignedVarInt();
			savedChunks = ReadInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			coordinates=default(BlockCoordinates);
			radius=default(uint);
			savedChunks=default(int);
		}

	}

	public partial class McpeBiomeDefinitionList : Packet
	{

		public Nbt namedtag; // = null;

		public McpeBiomeDefinitionList()
		{
			Id = 0x7a;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(namedtag);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			namedtag = ReadNbt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			namedtag=default(Nbt);
		}

	}

	public partial class McpeLevelSoundEvent : Packet
	{

		public uint soundId; // = null;
		public Vector3 position; // = null;
		public int blockId; // = null;
		public string entityType; // = null;
		public bool isBabyMob; // = null;
		public bool isGlobal; // = null;

		public McpeLevelSoundEvent()
		{
			Id = 0x7b;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarInt(soundId);
			Write(position);
			WriteSignedVarInt(blockId);
			Write(entityType);
			Write(isBabyMob);
			Write(isGlobal);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			soundId = ReadUnsignedVarInt();
			position = ReadVector3();
			blockId = ReadSignedVarInt();
			entityType = ReadString();
			isBabyMob = ReadBool();
			isGlobal = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			soundId=default(uint);
			position=default(Vector3);
			blockId=default(int);
			entityType=default(string);
			isBabyMob=default(bool);
			isGlobal=default(bool);
		}

	}

	public partial class McpeLevelEventGeneric : Packet
	{


		public McpeLevelEventGeneric()
		{
			Id = 0x7c;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeLecternUpdate : Packet
	{


		public McpeLecternUpdate()
		{
			Id = 0x7d;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeVideoStreamConnect : Packet
	{

		public string serverUri; // = null;
		public float frameSendFrequency; // = null;
		public byte action; // = null;
		public int resolutionX; // = null;
		public int resolutionY; // = null;

		public McpeVideoStreamConnect()
		{
			Id = 0x7e;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(serverUri);
			Write(frameSendFrequency);
			Write(action);
			Write(resolutionX);
			Write(resolutionY);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			serverUri = ReadString();
			frameSendFrequency = ReadFloat();
			action = ReadByte();
			resolutionX = ReadInt();
			resolutionY = ReadInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			serverUri=default(string);
			frameSendFrequency=default(float);
			action=default(byte);
			resolutionX=default(int);
			resolutionY=default(int);
		}

	}

	public partial class McpeClientCacheStatus : Packet
	{

		public bool enabled; // = null;

		public McpeClientCacheStatus()
		{
			Id = 0x81;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(enabled);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			enabled = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			enabled=default(bool);
		}

	}

	public partial class McpeOnScreenTextureAnimation : Packet
	{


		public McpeOnScreenTextureAnimation()
		{
			Id = 0x82;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeMapCreateLockedCopy : Packet
	{


		public McpeMapCreateLockedCopy()
		{
			Id = 0x83;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeStructureTemplateDataExportRequest : Packet
	{


		public McpeStructureTemplateDataExportRequest()
		{
			Id = 0x84;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeStructureTemplateDataExportResponse : Packet
	{


		public McpeStructureTemplateDataExportResponse()
		{
			Id = 0x85;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeUpdateBlockProperties : Packet
	{

		public Nbt namedtag; // = null;

		public McpeUpdateBlockProperties()
		{
			Id = 0x86;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(namedtag);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			namedtag = ReadNbt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			namedtag=default(Nbt);
		}

	}

	public partial class McpeClientCacheBlobStatus : Packet
	{


		public McpeClientCacheBlobStatus()
		{
			Id = 0x87;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeClientCacheMissResponse : Packet
	{


		public McpeClientCacheMissResponse()
		{
			Id = 0x88;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeNetworkSettings : Packet
	{
		public enum Compression
		{
			Nothing = 0,
			Everything = 1,
		}

		public short compressionThreshold; // = null;
		public short compressionAlgorithm; // = null;
		public bool clientThrottleEnabled; // = null;
		public byte clientThrottleThreshold; // = null;
		public float clientThrottleScalar; // = null;

		public McpeNetworkSettings()
		{
			Id = 0x8f;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(compressionThreshold);
			Write(compressionAlgorithm);
			Write(clientThrottleEnabled);
			Write(clientThrottleThreshold);
			Write(clientThrottleScalar);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			compressionThreshold = ReadShort();
			compressionAlgorithm = ReadShort();
			clientThrottleEnabled = ReadBool();
			clientThrottleThreshold = ReadByte();
			clientThrottleScalar = ReadFloat();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			compressionThreshold=default(short);
			compressionAlgorithm=default(short);
			clientThrottleEnabled=default(bool);
			clientThrottleThreshold=default(byte);
			clientThrottleScalar=default(float);
		}

	}

	public partial class McpePlayerAuthInput : Packet
	{


		public McpePlayerAuthInput()
		{
			Id = 0x90;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeCreativeContent : Packet
	{

		public CreativeItemStacks input; // = null;

		public McpeCreativeContent()
		{
			Id = 0x91;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(input);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			input = ReadCreativeItemStacks();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			input=default(CreativeItemStacks);
		}

	}

	public partial class McpePlayerEnchantOptions : Packet
	{

		public EnchantOptions enchantOptions; // = null;

		public McpePlayerEnchantOptions()
		{
			Id = 0x92;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(enchantOptions);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			enchantOptions = ReadEnchantOptions();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			enchantOptions=default(EnchantOptions);
		}

	}

	public partial class McpeItemStackRequest : Packet
	{
		public enum ActionType
		{
			Take = 0,
			Place = 1,
			Swap = 2,
			Drop = 3,
			Destroy = 4,
			Consume = 5,
			Create = 6,
			PlaceIntoBundle = 7,
			TakeFromBundle = 8,
			LabTableCombine = 9,
			BeaconPayment = 10,
			MineBlock = 11,
			CraftRecipe = 12,
			CraftRecipeAuto = 13,
			CraftCreative = 14,
			CraftRecipeOptional = 15,
			CraftGrindstone = 16,
			CraftLoom = 17,
			CraftNotImplementedDeprecated = 18,
			CraftResultsDeprecated = 19,
		}

		public ItemStackRequests requests; // = null;

		public McpeItemStackRequest()
		{
			Id = 0x93;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(requests);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			requests = ReadItemStackRequests();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			requests=default(ItemStackRequests);
		}

	}

	public partial class McpeItemStackResponse : Packet
	{

		public ItemStackResponses responses; // = null;

		public McpeItemStackResponse()
		{
			Id = 0x94;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(responses);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			responses = ReadItemStackResponses();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			responses=default(ItemStackResponses);
		}

	}

	public partial class McpeUpdatePlayerGameType : Packet
	{


		public McpeUpdatePlayerGameType()
		{
			Id = 0x97;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpePacketViolationWarning : Packet
	{

		public int violationType; // = null;
		public int severity; // = null;
		public int packetId; // = null;
		public string reason; // = null;

		public McpePacketViolationWarning()
		{
			Id = 0x9c;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(violationType);
			WriteSignedVarInt(severity);
			WriteSignedVarInt(packetId);
			Write(reason);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			violationType = ReadSignedVarInt();
			severity = ReadSignedVarInt();
			packetId = ReadSignedVarInt();
			reason = ReadString();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			violationType=default(int);
			severity=default(int);
			packetId=default(int);
			reason=default(string);
		}

	}

	public partial class McpeItemComponent : Packet
	{

		public ItemComponentList entries; // = null;

		public McpeItemComponent()
		{
			Id = 0xa2;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(entries);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			entries = ReadItemComponentList();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			entries=default(ItemComponentList);
		}

	}

	public partial class McpeFilterTextPacket : Packet
	{

		public string text; // = null;
		public bool fromServer; // = null;

		public McpeFilterTextPacket()
		{
			Id = 0xa3;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(text);
			Write(fromServer);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			text = ReadString();
			fromServer = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			text=default(string);
			fromServer=default(bool);
		}

	}

	public partial class McpeEmotePacket : Packet
	{

		public long runtimeentityid; // = null;
		public string xuid; // = null;
		public string platformid; // = null;
		public string emoteid; // = null;
		public byte flags; // = null;

		public McpeEmotePacket()
		{
			Id = 0x8a;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeentityid);
			Write(xuid);
			Write(platformid);
			Write(emoteid);
			Write(flags);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeentityid = ReadUnsignedVarLong();
			xuid = ReadString();
			platformid = ReadString();
			emoteid = ReadString();
			flags = ReadByte();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeentityid=default(long);
			xuid=default(string);
			platformid=default(string);
			emoteid=default(string);
			flags=default(byte);
		}

	}

	public partial class McpeEmoteList : Packet
	{

		public long runtimeentityid; // = null;
		public EmoteIds emoteids; // = null;

		public McpeEmoteList()
		{
			Id = 0x98;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeentityid);
			Write(emoteids);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeentityid = ReadUnsignedVarLong();
			emoteids = ReadEmoteId();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeentityid=default(long);
			emoteids=default(EmoteIds);
		}

	}

	public partial class McpePermissionRequest : Packet
	{

		public long runtimeentityid; // = null;
		public uint permission; // = null;
		public short flagss; // = null;

		public McpePermissionRequest()
		{
			Id = 0xb9;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(runtimeentityid);
			WriteUnsignedVarInt(permission);
			Write(flagss);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeentityid = ReadLong();
			permission = ReadUnsignedVarInt();
			flagss = ReadShort();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeentityid=default(long);
			permission=default(uint);
			flagss=default(short);
		}

	}

	public partial class McpeSetInventoryOptions : Packet
	{

		public int lefttab; // = null;
		public int righttab; // = null;
		public bool filtering; // = null;
		public int inventorylayout; // = null;
		public int craftinglayout; // = null;

		public McpeSetInventoryOptions()
		{
			Id = 0x133;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteSignedVarInt(lefttab);
			WriteSignedVarInt(righttab);
			Write(filtering);
			WriteSignedVarInt(inventorylayout);
			WriteSignedVarInt(craftinglayout);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			lefttab = ReadSignedVarInt();
			righttab = ReadSignedVarInt();
			filtering = ReadBool();
			inventorylayout = ReadSignedVarInt();
			craftinglayout = ReadSignedVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			lefttab=default(int);
			righttab=default(int);
			filtering=default(bool);
			inventorylayout=default(int);
			craftinglayout=default(int);
		}

	}

	public partial class McpePlayerFog : Packet
	{

		public fogStack fogstack; // = null;

		public McpePlayerFog()
		{
			Id = 0xa0;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(fogstack);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			fogstack = Read();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			fogstack=default(fogStack);
		}

	}

	public partial class McpeAnvilDamage : Packet
	{

		public byte damageamount; // = null;
		public BlockCoordinates coordinates; // = null;

		public McpeAnvilDamage()
		{
			Id = 0x8d;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(damageamount);
			Write(coordinates);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			damageamount = ReadByte();
			coordinates = ReadBlockCoordinates();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			damageamount=default(byte);
			coordinates=default(BlockCoordinates);
		}

	}

	public partial class McpeUpdateSubChunkBlocksPacket : Packet
	{

		public BlockCoordinates subchunkCoordinates; // = null;
		public UpdateSubChunkBlocksPacketEntry[] layerZeroUpdates; // = null;
		public UpdateSubChunkBlocksPacketEntry[] layerOneUpdates; // = null;

		public McpeUpdateSubChunkBlocksPacket()
		{
			Id = 0xac;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(subchunkCoordinates);
			Write(layerZeroUpdates);
			Write(layerOneUpdates);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			subchunkCoordinates = ReadBlockCoordinates();
			layerZeroUpdates = ReadUpdateSubChunkBlocksPacketEntrys();
			layerOneUpdates = ReadUpdateSubChunkBlocksPacketEntrys();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			subchunkCoordinates=default(BlockCoordinates);
			layerZeroUpdates=default(UpdateSubChunkBlocksPacketEntry[]);
			layerOneUpdates=default(UpdateSubChunkBlocksPacketEntry[]);
		}

	}

	public partial class McpeSubChunkPacket : Packet
	{

		public bool cacheEnabled; // = null;
		public int dimension; // = null;
		public BlockCoordinates subchunkCoordinates; // = null;

		public McpeSubChunkPacket()
		{
			Id = 0xae;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(cacheEnabled);
			WriteVarInt(dimension);
			Write(subchunkCoordinates);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			cacheEnabled = ReadBool();
			dimension = ReadVarInt();
			subchunkCoordinates = ReadBlockCoordinates();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			cacheEnabled=default(bool);
			dimension=default(int);
			subchunkCoordinates=default(BlockCoordinates);
		}

	}

	public partial class McpeSubChunkRequestPacket : Packet
	{

		public int dimension; // = null;
		public BlockCoordinates basePosition; // = null;
		public SubChunkPositionOffset[] offsets; // = null;

		public McpeSubChunkRequestPacket()
		{
			Id = 0xaf;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteVarInt(dimension);
			Write(basePosition);
			Write(offsets);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			dimension = ReadVarInt();
			basePosition = ReadBlockCoordinates();
			offsets = ReadSubChunkPositionOffsets();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			dimension=default(int);
			basePosition=default(BlockCoordinates);
			offsets=default(SubChunkPositionOffset[]);
		}

	}

	public partial class McpeDimensionData : Packet
	{

		public DimensionDefinitions definitions; // = null;

		public McpeDimensionData()
		{
			Id = 0xb4;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(definitions);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			definitions = ReadDimensionDefinitions();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			definitions=default(DimensionDefinitions);
		}

	}

	public partial class McpeUpdateAbilities : Packet
	{

		public long entityUniqueId; // = null;
		public byte playerPermissions; // = null;
		public byte commandPermissions; // = null;
		public AbilityLayers layers; // = null;

		public McpeUpdateAbilities()
		{
			Id = 0xbb;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(entityUniqueId);
			Write(playerPermissions);
			Write(commandPermissions);
			Write(layers);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			entityUniqueId = ReadLong();
			playerPermissions = ReadByte();
			commandPermissions = ReadByte();
			layers = ReadAbilityLayers();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			entityUniqueId=default(long);
			playerPermissions=default(byte);
			commandPermissions=default(byte);
			layers=default(AbilityLayers);
		}

	}

	public partial class McpeUpdateAdventureSettings : Packet
	{

		public bool noPvm; // = null;
		public bool noMvp; // = null;
		public bool immutableWorld; // = null;
		public bool showNametags; // = null;
		public bool autoJump; // = null;

		public McpeUpdateAdventureSettings()
		{
			Id = 0xbc;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(noPvm);
			Write(noMvp);
			Write(immutableWorld);
			Write(showNametags);
			Write(autoJump);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			noPvm = ReadBool();
			noMvp = ReadBool();
			immutableWorld = ReadBool();
			showNametags = ReadBool();
			autoJump = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			noPvm=default(bool);
			noMvp=default(bool);
			immutableWorld=default(bool);
			showNametags=default(bool);
			autoJump=default(bool);
		}

	}

	public partial class McpeRequestAbility : Packet
	{

		public int ability; // = null;

		public McpeRequestAbility()
		{
			Id = 0xb8;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteVarInt(ability);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			ability = ReadVarInt();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			ability=default(int);
		}

	}

	public partial class McpeRequestNetworkSettings : Packet
	{

		public int protocolVersion; // = null;

		public McpeRequestNetworkSettings()
		{
			Id = 0xc1;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteBe(protocolVersion);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			protocolVersion = ReadIntBe();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			protocolVersion=default(int);
		}

	}

	public partial class McpeTrimData : Packet
	{


		public McpeTrimData()
		{
			Id = 0x12e;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class McpeOpenSign : Packet
	{

		public BlockCoordinates coordinates; // = null;
		public bool front; // = null;

		public McpeOpenSign()
		{
			Id = 0x12f;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(coordinates);
			Write(front);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			coordinates = ReadBlockCoordinates();
			front = ReadBool();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			coordinates=default(BlockCoordinates);
			front=default(bool);
		}

	}

	public partial class McpeAlexEntityAnimation : Packet
	{

		public long runtimeEntityId; // = null;
		public string boneId; // = null;
		public AnimationKey[] keys; // = null;

		public McpeAlexEntityAnimation()
		{
			Id = 0xe0;
			IsMcpe = true;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			WriteUnsignedVarLong(runtimeEntityId);
			Write(boneId);
			Write(keys);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			runtimeEntityId = ReadUnsignedVarLong();
			boneId = ReadString();
			keys = ReadAnimationKeys();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			runtimeEntityId=default(long);
			boneId=default(string);
			keys=default(AnimationKey[]);
		}

	}

	public partial class McpeWrapper : Packet
	{
		

		public McpeWrapper()
		{
			Id = 0xfe;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();


			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();


			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

		}

	}

	public partial class FtlCreatePlayer : Packet
	{

		public string username; // = null;
		public UUID clientuuid; // = null;
		public string serverAddress; // = null;
		public long clientId; // = null;
		public Skin skin; // = null;

		public FtlCreatePlayer()
		{
			Id = 0x01;
			IsMcpe = false;
		}

		protected override void EncodePacket()
		{
			base.EncodePacket();

			BeforeEncode();

			Write(username);
			Write(clientuuid);
			Write(serverAddress);
			Write(clientId);
			Write(skin);

			AfterEncode();
		}

		partial void BeforeEncode();
		partial void AfterEncode();

		protected override void DecodePacket()
		{
			base.DecodePacket();

			BeforeDecode();

			username = ReadString();
			clientuuid = ReadUUID();
			serverAddress = ReadString();
			clientId = ReadLong();
			skin = ReadSkin();

			AfterDecode();
		}

		partial void BeforeDecode();
		partial void AfterDecode();

		protected override void ResetPacket()
		{
			base.ResetPacket();

			username=default(string);
			clientuuid=default(UUID);
			serverAddress=default(string);
			clientId=default(long);
			skin=default(Skin);
		}

	}

}

