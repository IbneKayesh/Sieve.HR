using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_PAYSLIP_DETAIL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Pay Slip ID")]
        public int PAYSLIP_ID { get; set; }

        [Display(Name = "Salary Type ID")]
        public int SALARY_TYPE_ID { get; set; }

        [Display(Name = "Pay Slip Amount")]
        public int PAYSLIP_AMT { get; set; }
    }
}
