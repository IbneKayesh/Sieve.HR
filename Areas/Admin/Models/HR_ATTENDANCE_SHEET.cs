using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sieve.HR.Areas.Admin.Models 
{
    public class HR_ATTENDANCE_SHEET : HR_COMMON
    {
        [Display(Name = "Employee Id")]
        public int EMP_ID { get; set; }

        [Display(Name = "Year")]
        public int YEAR_ID { get; set; }

        [Display(Name = "Month")]
        public int MONTH_ID { get; set; }

        [Display(Name = "Day")]
        public int DAY_ID { get; set; }

        [Display(Name = "In Time")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(5, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 5)]
        public string? IN_TIME { get; set; }


        [Display(Name = "Out Time")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(5, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 5)]
        public string? OUT_TIME { get; set; }

        [Display(Name = "Overtime  Hours")]
        [Required(ErrorMessage = "{0} is required")]
        public int OT_HOURS { get; set; }

        [Display(Name = "Attendance Status")]
        [Required(ErrorMessage = "{0} is required")]
        public int ATTEND_STATUS { get; set; } = 0;


        [Display(Name = "Duty Roster")]
        [Required(ErrorMessage = "{0} is required")]
        public int ROSTER_ID { get; set; }
    }
}
