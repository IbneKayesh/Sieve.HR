using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_SALARY_TYPE
    {
        public HR_SALARY_TYPE()
        {
            HR_EMP_SALARY_NAV = new HashSet<HR_EMP_SALARY>();
            RowVersion = new byte[] { 0, 0, 0, 0, 0, 0, 0, 120 };
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Salary Type")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? TYPE_NAME { get; set; }

        [Display(Name = "Type Effect")]
        [Required(ErrorMessage = "{0} is required")]
        public int TYPE_EFFECT { get; set; } = 0;


        [Display(Name = "Concurrency Timestamp")]
        [Required(ErrorMessage = "{0} is required")]
        [ConcurrencyCheck]
        [Timestamp]
        public byte[] RowVersion { get; set; }


        //For Navigation
        public virtual ICollection<HR_EMP_SALARY> HR_EMP_SALARY_NAV { get; set; }
    }
}
