using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_DESIGNATIONS
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }


        [Display(Name = "Short Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(10, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 1)]
        public string? SHORT_FORM { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? FULL_FORM { get; set; }


        [Display(Name = "Top Level Designation")]
        [Required(ErrorMessage = "{0} is required")]
        public int PARENT_ID { get; set; } = 0;


        [Display(Name = "Minimum Salary")]
        [Required(ErrorMessage = "{0} is required")]
        public int MIN_SALARY { get; set; } = 1000;


        [Display(Name = "Maximum Salary")]
        [Required(ErrorMessage = "{0} is required")]
        public int MAX_SALARY { get; set; } = 9999999;
    }
}
