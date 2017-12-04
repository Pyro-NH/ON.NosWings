﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core.Serializing;
using OpenNos.Domain;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$FLvl", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class ChangeFairyLevelPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public short FairyLevel { get; set; }

        public static string ReturnHelp()
        {
            return "$FLvl FAIRYLEVEL";
        }

        #endregion
    }
}