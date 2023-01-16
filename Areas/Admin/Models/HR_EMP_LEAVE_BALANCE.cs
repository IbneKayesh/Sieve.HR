using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_LEAVE_BALANCE : HR_COMMON
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Emp ID")]
        [Required(ErrorMessage = "{0} is required")]
        public int EMP_ID { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "{0} is required")]
        public int YEAR_ID { get; set; }

        [Display(Name = "Leaves Quantity")]
        [Required(ErrorMessage = "{0} is required")]
        public int LEAVE_QTY { get; set; }
    }
}
