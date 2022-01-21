using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using A3_HT3610.Models;

namespace A3_HT3610.Data
{
    public class AuditContext : DbContext
    {
        public AuditContext(DbContextOptions<AuditContext> options)
            : base(options)
        {
        }

        public DbSet<A3_HT3610.Models.Audit> Audit { get; set; }
        public DbSet<A3_HT3610.Models.AuditType> AuditType { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditType>().HasData(
               new AuditType() { AuditTypeId = 1, Name = "Cash In" },
               new AuditType() { AuditTypeId = 2, Name = "Cash Out" },
               new AuditType() { AuditTypeId = 3, Name = "Win" },
               new AuditType() { AuditTypeId = 4, Name = "Lose" });

            modelBuilder.Entity<Audit>().HasData(
                new Audit() { AuditId = 1, PlayerName = "Bart", CreatedDate = Convert.ToDateTime(DateTime.Now.AddDays(-2).ToShortDateString()), Amount = 5000.00, AuditTypeId = 1 },
                new Audit() { AuditId = 2, PlayerName = "Bart", CreatedDate = Convert.ToDateTime(DateTime.Now.AddDays(-2).ToShortDateString()), Amount = 2000.00, AuditTypeId = 2 },
                new Audit() { AuditId = 3, PlayerName = "Bart", CreatedDate = Convert.ToDateTime(DateTime.Now.AddDays(-2).ToShortDateString()), Amount = 2000.00, AuditTypeId = 3 },
                new Audit() { AuditId = 4, PlayerName = "Brian", CreatedDate = Convert.ToDateTime(DateTime.Now.AddDays(-1).ToShortDateString()), Amount = 1000.00, AuditTypeId = 1 },
                new Audit() { AuditId = 5, PlayerName = "Brian", CreatedDate = Convert.ToDateTime(DateTime.Now.AddDays(-1).ToShortDateString()), Amount = 0.00, AuditTypeId = 4 });
        }
    }
}
