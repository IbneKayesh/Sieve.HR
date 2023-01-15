using Microsoft.AspNetCore.Mvc.Rendering;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Services.DutyRoster
{
    public class DutyRosterRep : GenericRepository<HR_DUTY_ROSTER>, IDutyRosterRep
    {
        public DutyRosterRep(HRDbContext context) : base(context) { }

        public IEnumerable<SelectListItem> SelectListDutyRoster()
        {
            return context.HR_DUTY_ROSTER.ToList().Select(s => new SelectListItem() { Text = s.DUTY_ROSTER_NAME, Value = s.ID.ToString() });
        }
    }
}
