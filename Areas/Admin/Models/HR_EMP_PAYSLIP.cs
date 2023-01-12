using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_PAYSLIP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Employee ID")]
        [Required(ErrorMessage = "{0} is required")]
        public int EMP_ID { get; set; }

        [Display(Name = "Section")]
        [Required(ErrorMessage = "{0} is required")]
        public int SECTION_ID { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "{0} is required")]
        public int YEAR_ID { get; set; }

        [Display(Name = "Month")]
        [Required(ErrorMessage = "{0} is required")]
        public int MONTH_ID { get; set; }

        [Display(Name = "Net Pay")]
        [Required(ErrorMessage = "{0} is required")]
        public int NET_PAY { get; set; }
    }
}
