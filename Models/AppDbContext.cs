using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Webenglishfinal.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }

        public DbSet<Role> roles { get; set; }
        public DbSet<Grade> grades { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<DetailGradeAccount> detailGradeAccounts { get; set; }
        public DbSet<DetailRoleAccount> detailRoleAccounts { get; set; }
        public DbSet<Rank> ranks { get; set; }  
        public DbSet<Test> tests { get; set; }
        public DbSet<TypeofExe> typeofExes { get; set; }
        public DbSet<Exercise> exercise { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet <Recommand> recommands { get; set; }
        public DbSet<Catalouge> catalouges { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Report> reports { get; set; }
        public DbSet<IncorrectSen> incorrectSens { get; set; }

    }
}
