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

        public void AddActivity(ActivityModel newActivity)
        {
            _context.Activities.Add(newActivity);
            _context.SaveChanges();
        }

        public ActivityModel UpdateActivity(ActivityModel model)
        {
            _context.Activities.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return model;
        }

        public ActivityModel GetActivity(int id)
        {
            return _context.Activities.Where(x => x.Id == id).FirstOrDefault();
        }

        public void DeleteActivity(ActivityModel model)
        {
            _context.Activities.Remove(model);
            _context.SaveChanges();
        }
    }
}