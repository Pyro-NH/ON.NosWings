﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using NosSharp.Enums;
using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$Upgrade", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class UpgradeCommandPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public UpgradeMode Mode { get; set; }

        [PacketIndex(2)]
        public UpgradeProtection Protection { get; set; }

        public static string ReturnHelp()
        {
            return "$Upgrade SLOT MODE PROTECTION";
        }

        #endregion
    }
}
