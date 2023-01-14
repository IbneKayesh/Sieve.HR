using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Services.Section;

namespace Sieve.HR.Services.Designation
{
    public class DesignationRep : GenericRepository<HR_DESIGNATIONS>, IDesignationRep
    {
        public DesignationRep(HRDbContext context) : base(context) { }
    }
}
