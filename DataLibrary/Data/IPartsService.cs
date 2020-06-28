using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IPartsService
    {
        void SavePart(PartModel part);

        Task<PartModel> UpdatePart(PartModel part);

        PartModel GetPartById(int id);

        IEnumerable<PartModel> GetPartsInStock();

        void DeletePart(PartModel model);
    }
}