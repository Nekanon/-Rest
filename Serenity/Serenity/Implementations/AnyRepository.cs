using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serenity.DbContexts;
using Serenity.Interfaces;
using Serenity.Models;
using Microsoft.EntityFrameworkCore;

namespace Serenity.Implementations
{
    public class AnyRepository : IAnyRepository
    {
        private readonly AnyDbContext _db;

        public AnyRepository(AnyDbContext anyDbContext)
        {
            _db = anyDbContext;
        }

        public Any Create(Any any)
        {
            _db.Anies.Add(any);
            _db.SaveChanges();
            return any;
        }

        public Any Delete(Guid guid)
        {
            Any any = _db.Anies.Find(guid);
            _db.Anies.Remove(any);
            return any;
        }

        public Any Get(Guid guid)
        {
            return _db.Anies.Find(guid);
        }

        public List<Any> GetAll()
        {
            return _db.Anies.ToList();
        }

        public Any Update(Guid guid, Any any)
        {
            Any found_any = _db.Anies.Find(guid);
            if(found_any!= null)
                _db.Update(any);
            _db.SaveChanges();
            return any;
        }
    }
}
