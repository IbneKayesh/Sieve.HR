using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_SALARY
    {

        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }


        [Display(Name = "Year Month")]
        public int YYYYMM{ get; set; }

        [Display(Name = "Employee")]
        [Required(ErrorMessage = "{0} is required")]
        public int EMP_ID { get; set; }


        [Display(Name = "Salary Type")]
        [Required(ErrorMessage = "{0} is required")]
        public int SALARY_TYPE_ID { get; set; }

        [Display(Name = "Salary Amount")]
        [Required(ErrorMessage = "{0} is required")]
        public int SALARY_AMNT { get; set; } = 1;


        //Foreign Key
        [ForeignKey("EMP_ID")]
        public virtual HR_EMP_DETAIL HR_EMP_DETAIL { get; set; } = null!;

        [ForeignKey("SALARY_TYPE_ID")]
        public virtual HR_SALARY_TYPE HR_SALARY_TYPE { get; set; } = null!;
    }
}
