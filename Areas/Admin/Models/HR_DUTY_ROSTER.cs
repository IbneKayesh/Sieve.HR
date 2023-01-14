using System.ComponentModel.DataAnnotations;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_DUTY_ROSTER
    {
        public HR_DUTY_ROSTER()
        {
            HR_EMP_ROSTERS_NAV = new HashSet<HR_EMP_ROSTER>();
            RowVersion = new byte[] { 0, 0, 0, 0, 0, 0, 0, 120 };
        }
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

       
        [Display(Name = "Roster Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? DUTY_ROSTER_NAME { get; set; }

        
        [Display(Name = "In Time")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(5, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 5)]
        [DataType(DataType.Time)]
        public string? IN_TIME { get; set; }


        [Display(Name = "Out Time")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(5, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 5)]
        [DataType(DataType.Time)]
        public string? OUT_TIME { get; set; }


        [Display(Name = "Max OT Hours")]
        [Required(ErrorMessage = "{0} is required")]
        public int MAX_OT_HOUR { get; set; } = 0;


        [Display(Name = "Concurrency Timestamp")]
        [Required(ErrorMessage = "{0} is required")]
        [ConcurrencyCheck]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        //For Navigation
        public virtual ICollection<HR_EMP_ROSTER> HR_EMP_ROSTERS_NAV { get; set; }
    }
}
