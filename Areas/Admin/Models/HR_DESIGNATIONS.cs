using System.ComponentModel.DataAnnotations;


namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_DESIGNATIONS
    {
        public HR_DESIGNATIONS()
        {
            HR_EMP_JOB_NAV = new HashSet<HR_EMP_JOB>();
            RowVersion = new byte[] { 0, 0, 0, 0, 0, 0, 0, 120 };
        }
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }


        [Display(Name = "Short Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(8, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 1)]
        public string? SHORT_FORM { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? FULL_FORM { get; set; }


        [Display(Name = "Top Level Designation")]
        [Required(ErrorMessage = "{0} is required")]
        public int PARENT_ID { get; set; } = 0;


        [Display(Name = "Minimum Salary")]
        [Required(ErrorMessage = "{0} is required")]
        [Range(minimum:1000,maximum:int.MaxValue)]
        public int MIN_SALARY { get; set; } = 1000;


        [Display(Name = "Maximum Salary")]
        [Required(ErrorMessage = "{0} is required")]
        [Range(minimum: 1000, maximum: int.MaxValue)]
        public int MAX_SALARY { get; set; } = 9999999;


        [Display(Name = "Concurrency Timestamp")]
        [Required(ErrorMessage = "{0} is required")]
        [ConcurrencyCheck]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        //For Navigation
        public virtual ICollection<HR_EMP_JOB> HR_EMP_JOB_NAV { get; set; }
    }
}
