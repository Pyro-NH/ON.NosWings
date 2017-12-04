﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core.Serializing;
using OpenNos.Domain;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$Unmute", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class UnmutePacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public string CharacterName { get; set; }

        public static string ReturnHelp()
        {
            return "$Unmute CHARACTERNAME";
        }

        #endregion
    }
}