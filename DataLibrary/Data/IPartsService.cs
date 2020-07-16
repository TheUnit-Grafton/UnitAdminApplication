using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IPartsService
    {
        void DeletePart(PartModel model);
        Task DeletePartAsync(PartModel model);
        PartModel GetPartById(int id);
        Task<PartModel> GetPartByIdAsync(int id);
        IEnumerable<PartModel> GetPartsInStock();
        Task<IEnumerable<PartModel>> GetPartsInStockAsync();
        void SavePart(PartModel part);
        Task SavePartAsync(PartModel part);
        PartModel UpdatePart(PartModel part);
        Task<PartModel> UpdatePartAsync(PartModel part);
    }
}