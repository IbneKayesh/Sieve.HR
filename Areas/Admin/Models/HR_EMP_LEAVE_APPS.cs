using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_LEAVE_APPS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Emp ID")]
        public int EMP_ID { get; set; }

        [Display(Name = "From Date")]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime FROM_DATE { get; set; }

        [Display(Name = "To Date")]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime TO_DATE { get; set; }

        [Display(Name = "Total days")]
        public int TOTAL_DAYS { get; set; }

        [Display(Name = "Leave Type")]
        public int LEAVE_TYPE_ID { get; set; }

        [Display(Name = "Leave Details")]
        [Required(ErrorMessage = "{0} is required")]
        public string? LEAVE_DETAIL { get; set; }

        [Display(Name = "Verify By")]
        public int VERIFY_BY { get; set; }

        [Display(Name = "Approved By")]
        public int APPROVED_BY { get; set; }
    }
}
