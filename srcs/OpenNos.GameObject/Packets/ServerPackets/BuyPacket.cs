﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using NosSharp.Enums;
using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.ServerPackets
{
    [PacketHeader("buy")]
    public class BuyPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public BuyShopType Type { get; set; }

        [PacketIndex(1)]
        public long OwnerId { get; set; }

        [PacketIndex(2)]
        public short Slot { get; set; }

        [PacketIndex(3)]
        public byte Amount { get; set; }

        public override string ToString()
        {
            return $"BuyShop {Type} {OwnerId} {Slot} {Amount}";
        }

        #endregion
    }
}
