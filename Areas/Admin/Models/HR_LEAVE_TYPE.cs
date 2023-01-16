using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_LEAVE_TYPE : HR_COMMON
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Leave Type")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? TYPE_NAME { get; set; }

        [Display(Name = "Type Qty")]
        [Required(ErrorMessage = "{0} is required")]
        public int TYPE_QTY { get; set; } = 0;
    }
}
