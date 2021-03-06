﻿/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */

using System;
using System.Linq;
using NosSharp.Enums;
using OpenNos.Data;
using OpenNos.DAL;
using OpenNos.GameObject.Networking;
using OpenNos.Master.Library.Client;

namespace OpenNos.GameObject.Event.MINILANDREFRESH
{
    public class MinilandRefresh
    {
        #region Methods

        public static void GenerateMinilandEvent()
        {
            ServerManager.Instance.SaveAll();
            foreach (CharacterDTO chara in DaoFactory.CharacterDao.LoadAll())
            {
                GeneralLogDTO gen = DaoFactory.GeneralLogDao.LoadByAccount(null).LastOrDefault(s =>
                    s.LogData == "MinilandRefresh" && s.LogType == "World" && s.Timestamp.Day == DateTime.Now.Day);
                int count = DaoFactory.GeneralLogDao.LoadByAccount(chara.AccountId).Count(s =>
                    s.LogData == "MINILAND" && s.Timestamp > DateTime.Now.AddDays(-1) &&
                    s.CharacterId == chara.CharacterId);

                ClientSession session = ServerManager.Instance.GetSessionByCharacterId(chara.CharacterId);
                if (session != null)
                {
                    session.Character.GetReput(2 * count, true);
                    session.Character.MinilandPoint = 2000;
                }
                else if (CommunicationServiceClient.Instance.IsCharacterConnected(ServerManager.Instance.ServerGroup,
                    chara.CharacterId))
                {
                    if (gen == null)
                    {
                        chara.Reput += 2 * count;
                    }

                    chara.MinilandPoint = 2000;
                    CharacterDTO chara2 = chara;
                    DaoFactory.CharacterDao.InsertOrUpdate(ref chara2);
                }
            }

            DaoFactory.GeneralLogDao.Insert(new GeneralLogDTO
            {
                LogData = "MinilandRefresh",
                LogType = "World",
                Timestamp = DateTime.Now
            });
            ServerManager.Instance.StartedEvents.Remove(EventType.MINILANDREFRESHEVENT);
        }

        #endregion
    }
}