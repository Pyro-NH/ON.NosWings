﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core.Serializing;
using OpenNos.Domain;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$Character", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class CharacterPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public string Property { get; set; }

        [PacketIndex(1)]
        public string Value { get; set; }

        [PacketIndex(2)]
        public string Name { get; set; }

        #endregion
    }
}
