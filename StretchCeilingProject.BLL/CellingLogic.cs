﻿using StretchCeilingProject.DAL;
using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StretchCeilingProject.BLL
{
    public class CellingLogic : ICellingLogic
    {
        public CellingLogic(ICeilingDao cellingDao)
        {
            this.CellingDao = cellingDao;
        }

        private ICeilingDao CellingDao { get; }

        public void Add(Celling item)
        {
            if (this.IsValidImage(item))
            {
                this.CellingDao.Add(item);
            }
            else
            {
                throw new InvalidOperationException($"Can't add item with id {item.Id}: logic layer validation failed");
            }
        }

        private bool IsValidImage(Celling item)
        {
            if (item.Id == default(Guid) ||
                item.ImageId == default(Guid) ||
                string.IsNullOrWhiteSpace(item.Cost) ||
                string.IsNullOrWhiteSpace(item.Description))
            {
                return false;
            }

            return true;
        }

        public Celling Get(Guid id)
        {
            return this.CellingDao.Get(id);
        }

        public void Remove(Guid id)
        {
            this.CellingDao.Remove(id);
        }

        public void Update(Celling item)
        {
            this.CellingDao.Update(item);
        }

        public IEnumerable<Celling> GetByFilter(CellingFilter filter)
        {
            return this.CellingDao.GetByFilter(filter).ToList();
        }

        public IEnumerable<IGrouping<CellingCategory, Celling>> GetGroupedByCategory()
        {
            return this.CellingDao.GetGroupedByCategory();
        }
    }
}