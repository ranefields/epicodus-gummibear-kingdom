﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Data
{
    public class EFReviewRepo : IDbRepo<Review>
    {
        private GummiBearKingdomContext db;
        public IQueryable<Review> Data => throw new NotImplementedException();

        public EFReviewRepo()
        {
            db = new GummiBearKingdomContext();
        }

        public EFReviewRepo(GummiBearKingdomContext db)
        {
            this.db = db;
        }

        public Review Save(Review obj)
        {
            throw new NotImplementedException();
        }

        public Review Update(Review obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Review obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }
    }
}