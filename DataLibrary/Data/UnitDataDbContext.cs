using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class UnitDataDbContext : DbContext
    {
        public DbSet<ActivityModel> Activities { get; set; }

        public DbSet<ComputerModel> Computers { get; set; }
        public DbSet<PartModel> Parts { get; set; }
        public DbSet<AnnouncementModel> Announcements { get; set; }

        public UnitDataDbContext(DbContextOptions<UnitDataDbContext> options)
            : base(options)
        {
        }
    }
}