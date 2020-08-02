using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLibrary.Data
{
    public class UnitDataDbContext : DbContext
    {
        public DbSet<ActivityModel> Activities { get; set; }

        public DbSet<ComputerModel> Computers { get; set; }
        public DbSet<PartModel> Parts { get; set; }
        public DbSet<AnnouncementModel> Announcements { get; set; }
        public DbSet<MemberModel> Members { get; set; }


        public UnitDataDbContext(DbContextOptions<UnitDataDbContext> options)
            : base(options)
        {
        }
    }
}