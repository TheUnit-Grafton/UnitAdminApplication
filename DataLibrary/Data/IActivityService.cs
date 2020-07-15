using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IActivityService
    {
        void AddActivity(ActivityModel newActivity);
        Task AddActivityAsync(ActivityModel newActivity);
        void DeleteActivity(ActivityModel model);
        Task DeleteActivityAsync(ActivityModel model);
        List<ActivityModel> GetActivities(bool displayNonCurrent = false);
        Task<List<ActivityModel>> GetActivitiesAsync(bool displayNonCurrent = false);
        ActivityModel GetActivity(int id);
        Task<ActivityModel> GetActivityAsync(int id);
        ActivityModel UpdateActivity(ActivityModel model);
        Task<ActivityModel> UpdateActivityAsync(ActivityModel model);
    }
}