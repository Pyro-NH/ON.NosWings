﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.ClientPackets
{
    [PacketHeader("ptctl")]
    public class PtCtlPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public short MapType { get; set; }

        [PacketIndex(1)]
        public byte Amount { get; set; }

        [PacketIndex(2, SerializeToEnd = true)]
        public string PacketEnd { get; set; }

        /*
         
        [PacketIndex(2, RemoveSeparator = true)]
        public List<PtCtlSubPacket> Users { get; set; }

        [PacketIndex(3)]
        public byte Option { get; set; }

         */
        #endregion
    }
}