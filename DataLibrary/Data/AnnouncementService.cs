using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class AnnouncementService : IAnnouncementService
    {
        private UnitDataDbContext _context;

        public AnnouncementService(UnitDataDbContext context)
        {
            _context = context;
        }

        public void SaveAnnouncement(AnnouncementModel model)
        {
            if (model != null)
            {
                if (model.Id == 0) //Id = 0 then this is a new announcement, otherwise it's existing
                {
                    _context.Announcements.Add(model);
                }
                else
                {
                    _context.Announcements.Attach(model);
                    _context.Entry(model).State = EntityState.Modified;
                }
                 _context.SaveChanges();
            }
        }

        public List<AnnouncementModel> GetAnnouncements(bool displayNonCurrent = false)
        {
            if (displayNonCurrent)
            {
                // If Non-Current box is checked, all records returned
                return _context.Announcements.ToList();
            }
            else
            {
                // Only activities marked as current are returned
                return _context.Announcements.Where(x => x.IsCurrent == true).ToList();
            }
        }

        public AnnouncementModel GetAnnouncementById(int id)
        {
            return _context.Announcements.Find(id);
        }

        public AnnouncementModel UpdateAnnouncement(AnnouncementModel announcement)
        {
            _context.Entry(announcement).State = EntityState.Modified;
            _context.SaveChanges();
            return announcement;
        }
    }
}