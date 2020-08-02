using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class ComputerService : IComputerService
    {
        private UnitDataDbContext _context;

        public ComputerService(UnitDataDbContext context)
        {
            _context = context;
        }

        public void AddComputer(ComputerModel newComputer)
        {
            _context.Computers.Add(newComputer);
            _context.SaveChanges();
        }

        public async Task AddComputerAsync(ComputerModel newComputer)
        {
            _context.Computers.Add(newComputer);
            await _context.SaveChangesAsync();
        }

        public void DeleteComputer(ComputerModel model)
        {
            _context.Computers.Remove(model);
            _context.SaveChanges();
        }

        public async Task DeleteComputerAsync(ComputerModel model)
        {
            _context.Computers.Remove(model);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<ComputerModel> GetAllComputers()
        {
            return _context.Computers;
        }

        public async Task<IEnumerable<ComputerModel>> GetAllComputersAsync()
        {
            return await _context.Computers.OrderBy(x => x.AssetTag).ToListAsync();
        }

        public ComputerModel GetComputerById(int id)
        {
            return _context.Computers.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<ComputerModel> GetComputerByIdAsync(int id)
        {
            return await _context.Computers.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public IEnumerable<ComputerModel> GetCurrentComputers()
        {
            IEnumerable<ComputerModel> output = _context.Computers.Where(x => x.IsCurrentAsset == true)
                .OrderBy(a => a.Id);
            return output.ToList();
        }

        public async Task<IEnumerable<ComputerModel>> GetCurrentComputersAsync()
        {
            return await _context.Computers.Where(x => x.IsCurrentAsset == true)
                .OrderBy(a => a.Id).ToListAsync();
        }

        public ComputerModel UpdateComputer(ComputerModel model)
        {
            _context.Computers.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return model;
        }

        public async Task<ComputerModel> UpdateComputerAsync(ComputerModel model)
        {
            _context.Computers.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return model;
        }
    }
}