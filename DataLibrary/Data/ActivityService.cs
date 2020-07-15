using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class ActivityService : IActivityService

    {
        private readonly UnitDataDbContext _context;

        public ActivityService(UnitDataDbContext context)
        {
            _context = context;
        }

        public List<ActivityModel> GetActivities(bool displayNonCurrent = false)
        {
            List<ActivityModel> output = new List<ActivityModel>();

            if (displayNonCurrent)
            {
                // If Non-Current box is checked, all records are returned
                output = _context.Activities.OrderBy(x => x.ActivityType).ToList();
            }
            else
            {
                // Otherwise ony current records are checked
                output = _context.Activities.Where(x => x.IsCurrent == true)
                 .OrderBy(a => a.ActivityType).ToList();
            }

            return output;
        }

        public async Task<List<ActivityModel>> GetActivitiesAsync(bool displayNonCurrent = false)
        {
            List<ActivityModel> output = new List<ActivityModel>();

            if (displayNonCurrent)
            {
                // If Non-Current box is checked, all records are returned
                output = await _context.Activities.OrderBy(x => x.ActivityType).ToListAsync();
            }
            else
            {
                // Otherwise ony current records are checked
                output = await _context.Activities.Where(x => x.IsCurrent == true)
                 .OrderBy(a => a.ActivityType).ToListAsync();
            }

            return output;
        }

        public void AddActivity(ActivityModel newActivity)
        {
            _context.Activities.Add(newActivity);
            _context.SaveChanges();
        }
        public async Task AddActivityAsync(ActivityModel newActivity)
        {
            await _context.Activities.AddAsync(newActivity);
            await _context.SaveChangesAsync();
        }

        public ActivityModel UpdateActivity(ActivityModel model)
        {
            _context.Activities.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return model;
        }

        public async Task<ActivityModel> UpdateActivityAsync(ActivityModel model)
        {
            _context.Activities.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return model;
        }


        public ActivityModel GetActivity(int id)
        {
            return _context.Activities.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<ActivityModel> GetActivityAsync(int id)
        {
            return await _context.Activities.Where(x => x.Id == id).FirstOrDefaultAsync();
        }


        public void DeleteActivity(ActivityModel model)
        {
            _context.Activities.Remove(model);
            _context.SaveChanges();
        }

        public async Task DeleteActivityAsync(ActivityModel model)
        {
            _context.Activities.Remove(model);
            await _context.SaveChangesAsync();
        }

    }
}