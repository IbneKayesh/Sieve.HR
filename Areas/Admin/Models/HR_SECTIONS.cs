using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_SECTIONS: HR_COMMON
    {
        public HR_SECTIONS()
        {
        }

        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Department Id")]
        [Required(ErrorMessage = "{0} is required")]
        public int DEPT_ID { get; set; }

        [Display(Name = "Section Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? SECT_NAME { get; set; }

        [Display(Name = "Section Address")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(250, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? SECT_ADDR { get; set; }

        [Display(Name = "Section Head")]
        [Required(ErrorMessage = "{0} is required")]
        public int HEAD_EMP_ID { get; set; }

        [Display(Name = "Max No of Emp")]
        [Required(ErrorMessage = "{0} is required")]
        public int MAX_EMP_NO { get; set; } = 5;

        [Display(Name = "Max Total Salary")]
        [Required(ErrorMessage = "{0} is required")]
        public int MAX_SALARY { get; set; } = 100000;

        //Foreign Key

        [ForeignKey("DEPT_ID")]
        public virtual HR_DEPARTMENT? HR_DEPARTMENT { get; set; }
    }
}
