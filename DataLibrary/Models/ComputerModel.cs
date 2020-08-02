using System.ComponentModel.DataAnnotations;
using static DataLibrary.Extensions.Enums;

namespace DataLibrary.Models
{
    public class ComputerModel
    {
        public int Id { get; set; }

        [MaxLength(20 , ErrorMessage = "Asset Tag must be less than 25 characters")]
        public string AssetTag { get; set; }

        [MaxLength(50 , ErrorMessage = "Must be less than 50 characters")]
        public string Brand { get; set; }

        [Required]
        [MaxLength(50 , ErrorMessage = "Must be less than 50 characters")]
        public string CPU { get; set; }

        public string Speed { get; set; }

        [Required]
        [MaxLength(50 , ErrorMessage = "Must be less than 50 characters")]
        public string MemorySizeInGb { get; set; }

        [MaxLength(50 , ErrorMessage = "Must be less than 50 characters")]
        public string MemoryType { get; set; }

        [Required]
        [MaxLength(50 , ErrorMessage = "Must be less than 50 characters")]
        public string HardDriveSizeInGb { get; set; }

        [MaxLength(50 , ErrorMessage = "Must be less than 50 characters")]
        public string HardDriveBrand { get; set; }

        [Required]
        public DriveType DriveType { get; set; } = DriveType.Mechanical;

        [MaxLength(50 , ErrorMessage = "Must be less than 50 characters")]
        public string SerialNumber { get; set; }

        [Required]
        [MaxLength(50 , ErrorMessage = "Must be less than 50 characters")]
        public string ObtainedFrom { get; set; }

        [Required]
        [MaxLength(50 , ErrorMessage = "Must be less than 50 characters")]
        public string OperatingSystem { get; set; }

        public bool IsCurrentAsset { get; set; } = true;

        public FormFactor FormFactor { get; set; }

        public string Comments { get; set; }
    }
}