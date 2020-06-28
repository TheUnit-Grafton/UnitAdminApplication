using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IActivityService
    {
        void AddActivity(ActivityModel newActivity);

        List<ActivityModel> GetActivities(bool displayNonCurrent = false);

        ActivityModel UpdateActivity(ActivityModel model);

        ActivityModel GetActivity(int id);

        void DeleteActivity(ActivityModel model);
    }
}