using DataLibrary.Models;
using System.Collections.Generic;

namespace DataLibrary.Data
{
    public interface IPartsService
    {
        void SavePart(PartModel part);

        PartModel GetPartById(int id);

        IEnumerable<PartModel> GetPartsInStock();

        void DeletePart(PartModel model);
    }
}