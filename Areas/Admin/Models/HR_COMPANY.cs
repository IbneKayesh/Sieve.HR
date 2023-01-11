using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_COMPANY
    {
        public HR_COMPANY()
        {
            HR_DEPARTMENT_NAV = new HashSet<HR_DEPARTMENT>();
        }

        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100,ErrorMessage ="{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? COMP_NAME { get; set; }

        [Display(Name = "Company Address")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(250, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? COMP_ADDR { get; set; }

        [Display(Name = "Maximum Employees")]
        [Required(ErrorMessage = "{0} is required")]
        public int MAX_EMP_NO { get; set; } = 10;

        [Display(Name = "Total Salary")]
        [Required(ErrorMessage = "{0} is required")]
        public int MAX_SALARY { get; set; } = 1000000;

        //For Navigation
        public virtual ICollection<HR_DEPARTMENT> HR_DEPARTMENT_NAV { get; set; }
    }
}
