using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IAnnouncementService
    {
        void SaveAnnouncement(AnnouncementModel model);

        List<AnnouncementModel> GetAnnouncements(bool displayNonCurrent = false);

        AnnouncementModel UpdateAnnouncement(AnnouncementModel announcement);

        AnnouncementModel GetAnnouncementById(int id);
    }
}