using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_HOLIDAY_CALENDER
    {
        [Key, Column(Order = 0)]
        [Display(Name = "Year")]
        public int YEAR_ID { get; set; }

        [Key, Column(Order = 1)]
        [Display(Name = "Month")]
        public int MONTH_ID { get; set; }

        [Key, Column(Order = 2)]
        [Display(Name = "Day")]
        public int DAY_ID { get; set; }

        [Display(Name = "Holiday Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? HOLIDAY_NAME { get; set; }
    }
}
