﻿using System;
using System.Numerics;
using Axolotl.MCProtocol.Packet;
using Axolotl.MCProtocol;
using Axolotl.Nbts;
using Axolotl.Util;
using Axolotl;
using fNbt;

namespace Axolotl.MCProtocol.Packet
{
    public partial class McpeStartGame : Packet
	{
		
		public long entityIdSelf; // = null;
		public long runtimeEntityId; // = null;
		public int playerGamemode; // = null;
		public Vector3 spawn; // = null;
		public Vector2 rotation; // = null;
		public string serverId; // = null;
		public string worldId; // = null;
		public string scenarioId; // = null;
		public string levelId; // = null;
		public string worldName; // = null;
		public string premiumWorldTemplateId; // = null;
		public bool isTrial; // = null;
		public int movementType; // = null;
		public int movementRewindHistorySize; // = null;
		public bool enableNewBlockBreakSystem; // = null;
		public long currentTick; // = null;
		public int enchantmentSeed; // = null;
		public BlockPalette blockPalette; // = null;
		public ulong blockPaletteChecksum;
		public Itemstates itemstates; // = null;
		public string multiplayerCorrelationId; // = null;
		public bool enableNewInventorySystem; // = null;
		public string serverVersion; // = null;
		public Nbt propertyData;
		public UUID worldTemplateId;
		public bool clientSideGenerationEnabled;
		public bool blockNetworkIdsAreHashes = false;

		public LevelSettings levelSettings = new LevelSettings();
		
		partial void AfterEncode()
		{
			WriteSignedVarLong(entityIdSelf);
			WriteUnsignedVarLong(runtimeEntityId);
			WriteSignedVarInt(playerGamemode);
			Write(spawn);
			Write(rotation);
			
			LevelSettings s = levelSettings ?? new LevelSettings();
			s.Write(this);
			Write(serverId);
			Write(worldId);
			Write(scenarioId);
			Write(levelId);
			Write(worldName);
			Write(premiumWorldTemplateId);
			Write(isTrial);
			
			//Player movement settings
			WriteSignedVarInt(movementType);
			WriteSignedVarInt(movementRewindHistorySize);
			Write(enableNewBlockBreakSystem);
			
			Write(currentTick);
			WriteSignedVarInt(enchantmentSeed);
			
			Write(blockPalette);

			Write(itemstates);
			
			Write(multiplayerCorrelationId);
			Write(enableNewInventorySystem);
			Write(serverVersion);
			Write(propertyData);
			Write(blockPaletteChecksum);
			Write(worldTemplateId);
			Write(clientSideGenerationEnabled);
			Write(blockNetworkIdsAreHashes);
			Write(false);
		}
		
		partial void AfterDecode()
		{
			entityIdSelf = ReadSignedVarLong();
			runtimeEntityId = ReadUnsignedVarLong();
			playerGamemode = ReadSignedVarInt();
			spawn = ReadVector3();
			rotation = ReadVector2();

			levelSettings = new LevelSettings();
			levelSettings.Read(this);

			serverId = ReadString();
			worldId = ReadString();
			scenarioId = ReadString();

			levelId = ReadString();
			worldName = ReadString();
			premiumWorldTemplateId = ReadString();
			isTrial = ReadBool();
			
			//Player movement settings
			movementType = ReadSignedVarInt();
			movementRewindHistorySize = ReadSignedVarInt();
			enableNewBlockBreakSystem = ReadBool();
			
			currentTick = ReadLong();
			enchantmentSeed = ReadSignedVarInt();

			try
			{
				blockPalette = ReadBlockPalette();
			}
			catch (Exception ex)
			{
				
				return;
			}
			
			itemstates = ReadItemstates();
			
			multiplayerCorrelationId = ReadString();
			enableNewInventorySystem = ReadBool();
			serverVersion = ReadString();
			propertyData = ReadNbt();
			blockPaletteChecksum = ReadUlong();
			worldTemplateId = ReadUUID();
			clientSideGenerationEnabled = ReadBool();
			blockNetworkIdsAreHashes = ReadBool();
			ReadBool();
		}

		/// <inheritdoc />
		public override void Reset()
		{
			entityIdSelf=default(long);
			runtimeEntityId=default(long);
			playerGamemode=default(int);
			spawn=default(Vector3);
			rotation=default(Vector2);
			levelSettings = default;
			serverId=default(string);
			worldId=default(string);
			scenarioId=default(string);
			levelId=default(string);
			worldName=default(string);
			premiumWorldTemplateId=default(string);
			isTrial=default(bool);
			movementType=default(int);
			movementRewindHistorySize=default(int);
			enableNewBlockBreakSystem=default(bool);
			currentTick=default(long);
			enchantmentSeed=default(int);
			blockPalette=default(BlockPalette);
			itemstates=default(Itemstates);
			multiplayerCorrelationId=default(string);
			enableNewInventorySystem=default(bool);
			serverVersion=default(string);
			propertyData = default;
			worldTemplateId = default;
			clientSideGenerationEnabled = default(bool);
			blockNetworkIdsAreHashes =default(bool);
			base.Reset();
		}
	}
}