using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static DataLibrary.Extensions.Enums;

namespace DataLibrary.Models
{
    public class ActivityModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40 , ErrorMessage = "Name must be less than 40 characters.")]
        public string ActivityName { get; set; }

        [Required]
        [MaxLength(500 , ErrorMessage = "Description must be less than 500 characters")]
        public string ActivityDescription { get; set; }

        [Required]
        public ActivityType ActivityType { get; set; } = ActivityType.ComputerGame;

        [Required(ErrorMessage = "You must provide information on how to find this activity.")]
        [MaxLength(150 , ErrorMessage = "Activity Location or address needs to be less than 150 characters")]
        public string ActivityAddress { get; set; }

        [MaxLength(50)]
        public string ActivityPort { get; set; }

        public bool IsCurrent { get; set; } = true;
    }
}