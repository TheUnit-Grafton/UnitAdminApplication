using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IComputerService
    {
        IEnumerable<ComputerModel> GetAllComputers();

        IEnumerable<ComputerModel> GetCurrentComputers();

        void AddComputer(ComputerModel newComputer);

        ComputerModel UpdateComputer(ComputerModel model);

        ComputerModel GetComputerById(int id);

        void DeleteComputer(ComputerModel model);
    }
}