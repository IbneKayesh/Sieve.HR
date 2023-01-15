using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_JOB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Emp ID")]
        [Required(ErrorMessage = "{0} is required")]
        public int EMP_ID { get; set; }

        [Display(Name = "Emp Designation")]
        [Required(ErrorMessage = "{0} is required")]
        public int DESIG_ID { get; set; }

        [Display(Name = "Assign Section")]
        [Required(ErrorMessage = "{0} is required")]
        public int SECTION_ID { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime START_DATE { get; set; }

        [Display(Name = "Confirmation Date")]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime? CONF_DATE { get; set; }

        [Display(Name = "End Date")]
        public DateTime? END_DATE { get; set; }

        [Display(Name = "Gross Salary")]
        [Required(ErrorMessage = "{0} is required")]
        public int GROSS_SALARY { get; set; }

        [Display(Name = "Initiated By")]
        [Required(ErrorMessage = "{0} is required")]
        public int INITIATED_BY { get; set; }
        public DateTime? INITIATED_DATE { get; set; }

        [Display(Name = "Varified By")]
        [Required(ErrorMessage = "{0} is required")]
        public int VERIFIED_BY { get; set; }
        public DateTime? VERIFIED_DATE { get; set; }

        [Display(Name = "Approved By")]
        [Required(ErrorMessage = "{0} is required")]
        public int APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
    }
}
