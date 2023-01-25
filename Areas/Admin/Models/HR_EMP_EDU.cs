using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_EDU : HR_COMMON
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Emp ID")]
        [Required(ErrorMessage = "{0} is required")]
        public int EMP_ID { get; set; }

        [Display(Name = "Institution/Training Type")]
        [Required(ErrorMessage = "{0} is required")]
        public int EDU_TYPE_ID { get; set; }

        [Display(Name = "Institution/Training Title")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? EDU_TITLE { get; set; }

        [Display(Name = "Passing Year")]
        [Required(ErrorMessage = "{0} is required")]
        public int EDU_YEAR { get; set; }

        [Display(Name = "Passing Grade")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 2)]
        public string? EDU_GRADE { get; set; }

        [Display(Name = "Institute Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? INSTITUE_NAME { get; set; }


        //Foreign Key
        [ForeignKey("EMP_ID")]
        public virtual HR_EMP_DETAIL? HR_EMP_DETAIL { get; set; }
    }
}
