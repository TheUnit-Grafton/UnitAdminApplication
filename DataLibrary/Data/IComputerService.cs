using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IComputerService
    {
        void AddComputer(ComputerModel newComputer);
        Task AddComputerAsync(ComputerModel newComputer);
        void DeleteComputer(ComputerModel model);
        Task DeleteComputerAsync(ComputerModel model);
        IEnumerable<ComputerModel> GetAllComputers();
        Task<IEnumerable<ComputerModel>> GetAllComputersAsync();
        ComputerModel GetComputerById(int id);
        Task<ComputerModel> GetComputerByIdAsync(int id);
        IEnumerable<ComputerModel> GetCurrentComputers();
        Task<IEnumerable<ComputerModel>> GetCurrentComputersAsync();
        ComputerModel UpdateComputer(ComputerModel model);
        Task<ComputerModel> UpdateComputerAsync(ComputerModel model);
    }
}