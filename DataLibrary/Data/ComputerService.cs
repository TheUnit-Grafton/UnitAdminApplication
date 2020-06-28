using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

        public void DeleteComputer(ComputerModel model)
        {
            _context.Computers.Remove(model);
            _context.SaveChanges();
        }

        public IEnumerable<ComputerModel> GetAllComputers()
        {
            return _context.Computers;
        }

        public ComputerModel GetComputerById(int id)
        {
            return _context.Computers.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<ComputerModel> GetCurrentComputers()
        {
            IEnumerable<ComputerModel> output = _context.Computers.Where(x => x.IsCurrentAsset == true)
                .OrderBy(a => a.Id);
            return output.ToList();
        }

        public ComputerModel UpdateComputer(ComputerModel model)
        {
            _context.Computers.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return model;
        }
    }
}