using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_SALARY_TYPE
    {
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
    }
}
