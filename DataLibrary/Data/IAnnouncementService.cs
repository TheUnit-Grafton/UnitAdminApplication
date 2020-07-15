using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IAnnouncementService
    {
        AnnouncementModel GetAnnouncementById(int id);
        Task<AnnouncementModel> GetAnnouncementByIdAsync(int id);
        List<AnnouncementModel> GetAnnouncements(bool displayNonCurrent = false);
        Task<List<AnnouncementModel>> GetAnnouncementsAsync(bool displayNonCurrent = false);
        void SaveAnnouncement(AnnouncementModel model);
        Task SaveAnnouncementAsync(AnnouncementModel model);
        AnnouncementModel UpdateAnnouncement(AnnouncementModel announcement);
        Task<AnnouncementModel> UpdateAnnouncementAsync(AnnouncementModel announcement);
    }
}