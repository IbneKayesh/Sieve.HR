using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.Section
{
    public class SectionRep : GenericRepository<HR_SECTIONS>, ISectionRep
    {
        public SectionRep(HRDbContext context) : base(context) { }
    }
}
