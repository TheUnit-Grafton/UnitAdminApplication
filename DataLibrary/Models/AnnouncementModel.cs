using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class AnnouncementModel
    {
        public AnnouncementModel(string message , string linkAddress = "")
        {
            Message = message;
            LinkAddress = linkAddress;
        }

        public AnnouncementModel()
        {
            Message = "";
            LinkAddress = "";
        }

        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        public string LinkAddress { get; set; }
        public bool IsCurrent { get; set; }
    }
}