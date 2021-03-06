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
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OpenNos.Core;
using OpenNos.Data;
using OpenNos.DAL.EF.Base;
using OpenNos.DAL.EF.DB;
using OpenNos.DAL.EF.Entities;
using OpenNos.DAL.EF.Helpers;
using OpenNos.DAL.Interface;

namespace OpenNos.DAL.EF
{
    public class BCardDAO : MappingBaseDao<BCard, BCardDTO>, IBCardDAO
    {
        #region Methods

        public BCardDTO Insert(ref BCardDTO cardObject)
        {
            try
            {
                using (OpenNosContext context = DataAccessHelper.CreateContext())
                {
                    var entity = _mapper.Map<BCard>(cardObject);
                    context.BCard.Add(entity);
                    context.SaveChanges();
                    return _mapper.Map<BCardDTO>(entity);
                }
            }
            catch (Exception e)
            {
                Logger.Error(e);
                return null;
            }
        }

        public void Insert(List<BCardDTO> cards)
        {
            try
            {
                using (OpenNosContext context = DataAccessHelper.CreateContext())
                {
                    context.Configuration.AutoDetectChangesEnabled = false;
                    foreach (BCardDTO card in cards)
                    {
                        var entity = _mapper.Map<BCard>(card);
                        context.BCard.Add(entity);
                    }

                    context.Configuration.AutoDetectChangesEnabled = true;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Logger.Error(e);
            }
        }

        public IEnumerable<BCardDTO> LoadAll()
        {
            using (OpenNosContext context = DataAccessHelper.CreateContext())
            {
                foreach (BCard card in context.BCard)
                {
                    yield return _mapper.Map<BCardDTO>(card);
                }
            }
        }

        public IEnumerable<BCardDTO> LoadByCardId(short cardId)
        {
            using (OpenNosContext context = DataAccessHelper.CreateContext())
            {
                foreach (BCard card in context.BCard.Where(s => s.CardId == cardId))
                {
                    yield return _mapper.Map<BCardDTO>(card);
                }
            }
        }

        public IEnumerable<BCardDTO> LoadByItemVNum(short Vnum)
        {
            using (OpenNosContext context = DataAccessHelper.CreateContext())
            {
                foreach (BCard card in context.BCard.Where(s => s.ItemVNum == Vnum))
                {
                    yield return _mapper.Map<BCardDTO>(card);
                }
            }
        }

        public IEnumerable<BCardDTO> LoadBySkillVNum(short Vnum)
        {
            using (OpenNosContext context = DataAccessHelper.CreateContext())
            {
                foreach (BCard card in context.BCard.Where(s => s.SkillVNum == Vnum))
                {
                    yield return _mapper.Map<BCardDTO>(card);
                }
            }
        }

        public void Clean()
        {
            using (OpenNosContext context = DataAccessHelper.CreateContext())
            {
                DbSet<BCard> dbSet = context.BCard;
                foreach (BCard entity in dbSet)
                {
                    dbSet.Remove(entity);
                }

                context.SaveChanges();
            }
        }

        public IEnumerable<BCardDTO> LoadByNpcMonsterVNum(short Vnum)
        {
            using (OpenNosContext context = DataAccessHelper.CreateContext())
            {
                foreach (BCard card in context.BCard.Where(s => s.NpcMonsterVNum == Vnum))
                {
                    yield return _mapper.Map<BCardDTO>(card);
                }
            }
        }

        public BCardDTO LoadById(short cardId)
        {
            try
            {
                using (OpenNosContext context = DataAccessHelper.CreateContext())
                {
                    return _mapper.Map<BCardDTO>(context.BCard.FirstOrDefault(s => s.BCardId.Equals(cardId)));
                }
            }
            catch (Exception e)
            {
                Logger.Error(e);
                return null;
            }
        }

        #endregion
    }
}