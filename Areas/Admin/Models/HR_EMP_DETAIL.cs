using System.ComponentModel.DataAnnotations;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_DETAIL : HR_COMMON
    {
        public HR_EMP_DETAIL()
        {
            HR_EMP_ROSTER_SUPERVISOR = new HashSet<HR_EMP_ROSTER>();
            HR_EMP_ROSTER_HEAD = new HashSet<HR_EMP_ROSTER>();
        }

        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Employee No")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 1)]
        public string EMP_NO { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? FULL_NAME { get; set; }

        [Display(Name = "Contact")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(30, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? CONTACT_NO { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        [DataType(DataType.EmailAddress)]
        public string? EMAIL_ID { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(15, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? GENDER_ID { get; set; }

        [Display(Name = "Nationality")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? NATIONALITY { get; set; }

        [Display(Name = "Birthdate")]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime BIRTH_DATE { get; set; }

        [Display(Name = "Marital Status")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(10, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? MARITAIL_STATUS { get; set; }

        [Display(Name = "Spouse Name")]
        [StringLength(100, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? SPOUSE_NAME { get; set; }

        [Display(Name = "National ID")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? NATIONAL_ID { get; set; }

        [Display(Name = "Passport Number")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? PASSPORT_ID { get; set; }

        [Display(Name = "Father Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? FATHER_NAME { get; set; }

        [Display(Name = "Mother Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? MOTHER_NAME { get; set; }

        [Display(Name = "Parent Contact")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(30, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? PARENTS_CONACT { get; set; }

        [Display(Name = "Present Address")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(200, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? PRESENT_ADDRESS { get; set; }

        [Display(Name = "Parmanent Address")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(200, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? PARMANENT_ADDRESS { get; set; }


        public virtual HR_EMP_ROSTER? HR_EMP_ROSTER_EMP { get; set; }
        public virtual ICollection<HR_EMP_ROSTER> HR_EMP_ROSTER_SUPERVISOR { get; set; }
        public virtual ICollection<HR_EMP_ROSTER> HR_EMP_ROSTER_HEAD { get; set; }
    }
}
