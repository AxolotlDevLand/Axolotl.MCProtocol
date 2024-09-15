using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Axolotl.Actor;
using Axolotl.MCProtocol;
using Axolotl.Auth;
using Axolotl.Util;
using Axolotl.Skins;

namespace Axolotl.Actor
{
    public class Player : Mob
    {
        public Player() { }
        public Player(object server, IPEndPoint endPoint)
        {
            EndPoint = endPoint;
        }
        public IPEndPoint EndPoint { get; private set; }
        public PlayerLocation SpawnPosition { get; set; }
        public bool IsSleeping { get; set; } = false;

        public int MaxViewDistance { get; set; } = 22;
        public int MoveRenderDistance { get; set; } = 1;

        public GameMode GameMode { get; set; }
        public bool UseCreativeInventory { get; set; } = true;
        public bool IsConnected { get; set; }
        public CertificateData CertificateData { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public long ClientId { get; set; }
        public UUID ClientUuid { get; set; }
        public string ServerAddress { get; set; }
        public PlayerInfo PlayerInfo { get; set; }
        public bool IsFalling { get; set; }
        public bool IsFlyingHorizontally { get; set; }
        public float MovementSpeed { get; set; } = 0.1f;
        public Skin Skin { get; set; }
    }
}
