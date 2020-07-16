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

        public async Task SavePartAsync(PartModel part)
        {
            _db.Parts.Add(part);
            await _db.SaveChangesAsync();
        }

        public PartModel UpdatePart(PartModel part)
        {
            _db.Parts.Attach(part);
            _db.Entry(part).State = EntityState.Modified;
            _db.SaveChanges();
            return part;
        }

        public async Task<PartModel> UpdatePartAsync(PartModel part)
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

        public async Task<IEnumerable<PartModel>> GetPartsInStockAsync()
        {
            return await _db.Parts.ToListAsync();
        }

        public PartModel GetPartById(int id)
        {
            var output = _db.Parts.Where(p => p.Id == id).FirstOrDefault();
            return output;
        }

        public async Task<PartModel> GetPartByIdAsync(int id)
        {
            return await _db.Parts.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public void DeletePart(PartModel model)
        {
            _db.Parts.Remove(model);
            _db.SaveChanges();
        }

        public async Task DeletePartAsync(PartModel model)
        {
            _db.Parts.Remove(model);
            await _db.SaveChangesAsync();
        }
    }
}