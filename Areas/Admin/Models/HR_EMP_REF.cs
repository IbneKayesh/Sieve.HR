using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_REF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Employee ID")]
        [Required(ErrorMessage = "{0} is required")]
        public int EMP_ID { get; set; }


        [Display(Name = "Employee Name")]
        [NotMapped]
        public string? FULL_NAME { get; set; }


        [Display(Name = "Reference Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? REF_NAME { get; set; }

        [Display(Name = "Reference's Designation")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? DESIGNATION { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(30, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 10)]
        public string? REF_CONTACT { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 0)]
        [DataType(DataType.EmailAddress)]
        public string? REF_EMAIL { get; set; }

        [Display(Name = "Contact Address")]
        [DataType(DataType.MultilineText)]
        [StringLength(150, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 0)]
        public string? REF_ADDR { get; set; }

        //Foreign Key
        [ForeignKey("EMP_ID")]
        public virtual HR_EMP_DETAIL EMP { get; set; } = null!;
    }
}
