﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.ServerPackets
{
    [PacketHeader("vb")]
    public class VbPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public byte VbType { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; }

        [PacketIndex(2)]
        public long VbBuffTime { get; set; }

        #endregion
    }
}
