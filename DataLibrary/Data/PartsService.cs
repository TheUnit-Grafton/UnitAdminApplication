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
            _db.Parts.Add(part);
            _db.SaveChanges();
        }

        public async Task<PartModel> UpdatePart(PartModel part)
        {
            _db.Parts.Attach(part);
            _db.Entry(part).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return part;
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