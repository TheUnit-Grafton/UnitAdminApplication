using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class PartsService : IPartsService
    {
        private UnitDataDbContext _db;

        public PartsService(UnitDataDbContext db)
        {
            this._db = db;
        }

        public void SavePart(PartModel part)
        {
            if (part != null)
            {
                if (part.Id == 0) //Id = 0 then this is a new part, otherwise it's existing
                {
                    _db.Parts.Add(part);
                }
                else
                {
                    _db.Parts.Attach(part);
                    _db.Entry(part).State = EntityState.Modified;
                }
                _db.SaveChanges();
            }
        }

        public IEnumerable<PartModel> GetPartsInStock()
        {
            return _db.Parts;
        }

        public PartModel GetPartById(int id)
        {
            var output = _db.Parts.Where(p => p.Id == id).FirstOrDefault();
            return output;
        }

        public void DeletePart(PartModel model)
        {
            _db.Parts.Remove(model);
            _db.SaveChanges();
        }
    }
}