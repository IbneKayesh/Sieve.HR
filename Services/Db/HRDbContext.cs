using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;

namespace Sieve.HR.Services.Db
{
    public class HRDbContext : DbContext
    {
        public HRDbContext(DbContextOptions<HRDbContext> options) : base(options)
        {

        }

        public DbSet<HR_COMPANY> HR_COMPANY { get; set; }
        public DbSet<HR_DEPARTMENT> HR_DEPARTMENT { get; set; }
    }
}
