namespace Axolotl.MCProtocol.Packet;

using Util;

public class LevelSettings
    {
        public long seed; // = null;
        public SpawnSettings spawnSettings;

        public int generator; // = null;
        public int gamemode; // = null;
        public bool hardcoreEnabled; // = null;
        public int difficulty; // = null;
        public int x; // = null;
        public int y; // = null;
        public int z; // = null;
        public bool hasAchievementsDisabled; // = null;
        public bool editorWorld;
        public bool createdInEditorMode; // = null;
        public bool exportedFromEditorMode; // = null;
        public int time; // = null;
        public int eduOffer; // = null;
        public bool hasEduFeaturesEnabled; // = null;
        public string eduProductUuid; // = null;
        public float rainLevel; // = null;
        public float lightningLevel; // = null;
        public bool hasConfirmedPlatformLockedContent; // = null;
        public bool isMultiplayer; // = null;
        public bool broadcastToLan; // = null;
        public int xboxLiveBroadcastMode; // = null;
        public int platformBroadcastMode; // = null;
        public bool enableCommands; // = null;
        public bool isTexturepacksRequired; // = null;
        public GameRules gamerules; // = null;
        public Experiments experiments;
        public bool bonusChest; // = null;
        public bool mapEnabled; // = null;
        public byte permissionLevel; // = null;
        public int serverChunkTickRange; // = null;
        public bool hasLockedBehaviorPack; // = null;
        public bool hasLockedResourcePack; // = null;
        public bool isFromLockedWorldTemplate; // = null;
        public bool useMsaGamertagsOnly; // = null;
        public bool isFromWorldTemplate; // = null;
        public bool isWorldTemplateOptionLocked; // = null;
        public bool onlySpawnV1Villagers; // = null;
        public bool isDisablingPersonas; // = null;
        public bool isDisablingCustomSkins; // = null;
        public bool emoteChatMuted;  // = null;
        public string gameVersion; // = null;
        public int limitedWorldWidth; // = null;
        public int limitedWorldLength; // = null;
        public bool isNewNether; // = null;
        public EducationUriResource eduSharedUriResource = null;
        public bool experimentalGameplayOverride; // = null;
        public byte chatRestrictionLevel; // = null;
        public bool isDisablePlayerInteractions; // = null;


        public void Write(Packet packet)
            {
                packet.Write(seed);

                var s = spawnSettings ?? new SpawnSettings();
                s.Write(packet);

                packet.WriteSignedVarInt(generator);
                packet.WriteSignedVarInt(gamemode);
                packet.Write(false); //hardcore
                packet.WriteSignedVarInt(difficulty);

                packet.WriteSignedVarInt(x);
                packet.WriteVarInt(y);
                packet.WriteSignedVarInt(z);

                packet.Write(hasAchievementsDisabled);
                packet.Write(editorWorld);
                packet.Write(createdInEditorMode);
                packet.Write(exportedFromEditorMode);
                packet.WriteSignedVarInt(time);
                packet.WriteSignedVarInt(eduOffer);
                packet.Write(hasEduFeaturesEnabled);
                packet.Write(eduProductUuid);
                packet.Write(rainLevel);
                packet.Write(lightningLevel);
                packet.Write(hasConfirmedPlatformLockedContent);
                packet.Write(isMultiplayer);
                packet.Write(broadcastToLan);
                packet.WriteVarInt(xboxLiveBroadcastMode);
                packet.WriteVarInt(platformBroadcastMode);
                packet.Write(enableCommands);
                packet.Write(isTexturepacksRequired);
                packet.Write(gamerules);
                packet.Write(experiments);
                packet.Write(false); //ExperimentsPreviouslyToggled
                packet.Write(bonusChest);
                packet.Write(mapEnabled);
                packet.Write(permissionLevel);
                packet.Write(serverChunkTickRange);
                packet.Write(hasLockedBehaviorPack);
                packet.Write(hasLockedResourcePack);
                packet.Write(isFromLockedWorldTemplate);
                packet.Write(useMsaGamertagsOnly);
                packet.Write(isFromWorldTemplate);
                packet.Write(isWorldTemplateOptionLocked);
                packet.Write(onlySpawnV1Villagers);
                packet.Write(isDisablingPersonas);
                packet.Write(isDisablingCustomSkins);
                packet.Write(emoteChatMuted);
                packet.Write(gameVersion);
                packet.Write(limitedWorldWidth);
                packet.Write(limitedWorldLength);
                packet.Write(isNewNether);
                packet.Write(eduSharedUriResource ?? new EducationUriResource("", ""));
                packet.Write(false);
                packet.Write(chatRestrictionLevel);
                packet.Write(isDisablePlayerInteractions);
            }

        public void Read(Packet packet)
            {
                seed = packet.ReadLong();

                spawnSettings = new SpawnSettings();
                spawnSettings.Read(packet);

                generator = packet.ReadSignedVarInt();
                gamemode = packet.ReadSignedVarInt();
                hardcoreEnabled = packet.ReadBool();
                difficulty = packet.ReadSignedVarInt();

                x = packet.ReadSignedVarInt();
                y = packet.ReadVarInt();
                z = packet.ReadSignedVarInt();

                hasAchievementsDisabled = packet.ReadBool();
                editorWorld = packet.ReadBool();
                createdInEditorMode = packet.ReadBool();
                exportedFromEditorMode= packet.ReadBool();
                time = packet.ReadSignedVarInt();
                eduOffer = packet.ReadSignedVarInt();
                hasEduFeaturesEnabled = packet.ReadBool();
                eduProductUuid = packet.ReadString();
                rainLevel = packet.ReadFloat();
                lightningLevel = packet.ReadFloat();
                hasConfirmedPlatformLockedContent = packet.ReadBool();
                isMultiplayer = packet.ReadBool();
                broadcastToLan = packet.ReadBool();
                xboxLiveBroadcastMode = packet.ReadVarInt();
                platformBroadcastMode = packet.ReadVarInt();
                enableCommands = packet.ReadBool();
                isTexturepacksRequired = packet.ReadBool();
                gamerules = packet.ReadGameRules();
                experiments = packet.ReadExperiments();
                packet.ReadBool();
                bonusChest = packet.ReadBool();
                mapEnabled = packet.ReadBool();
                permissionLevel = packet.ReadByte();
                serverChunkTickRange = packet.ReadInt();
                hasLockedBehaviorPack = packet.ReadBool();
                hasLockedResourcePack = packet.ReadBool();
                isFromLockedWorldTemplate = packet.ReadBool();
                useMsaGamertagsOnly = packet.ReadBool();
                isFromWorldTemplate = packet.ReadBool();
                isWorldTemplateOptionLocked = packet.ReadBool();
                onlySpawnV1Villagers = packet.ReadBool();
                isDisablingPersonas = packet.ReadBool();
                isDisablingCustomSkins = packet.ReadBool();
                emoteChatMuted = packet.ReadBool();
                gameVersion = packet.ReadString();

                limitedWorldWidth = packet.ReadInt();
                limitedWorldLength = packet.ReadInt();
                isNewNether = packet.ReadBool();
                eduSharedUriResource = packet.ReadEducationUriResource();

                if (packet.ReadBool())
                    {
                        experimentalGameplayOverride = packet.ReadBool();
                    }
                else
                    {
                        experimentalGameplayOverride = false;
                    }
                chatRestrictionLevel = packet.ReadByte();
                isDisablePlayerInteractions = packet.ReadBool();
            }
    }