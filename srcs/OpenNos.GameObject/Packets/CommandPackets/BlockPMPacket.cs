﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core.Serializing;
using OpenNos.Domain;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$BlockPM", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class BlockPmPacket : PacketDefinition
    {
        public static string ReturnHelp()
        {
            return "$BlockPM";
        }
    }
}