using Sieve.HR.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_ROSTER
    {
        [Key]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EMP_ID { get; set; }     


        [Display(Name = "Duty Roster")]
        [Required(ErrorMessage = "{0} is required")]
        public int ROSTER_ID { get; set; }


        [Display(Name = "Weekend Day Number")]
        [Required(ErrorMessage = "{0} is required")]
        public int WEEKEND_DAYNO { get; set; }


        [Display(Name = "Supervisor Name")]
        [Required(ErrorMessage = "{0} is required")]
        public int SUPERVISOR_ID { get; set; }


        [Display(Name = "Head Name")]
        [Required(ErrorMessage = "{0} is required")]
        public int HEAD_ID { get; set; }


        //Foreign Key
        [ForeignKey("EMP_ID")]
        public virtual HR_EMP_DETAIL EMP { get; set; } = null!;

        //Foreign Key
        [ForeignKey("ROSTER_ID")]
        public virtual HR_DUTY_ROSTER? ROSTER { get; set; }

        //Foreign Key
        [ForeignKey("SUPERVISOR_ID")]
        public virtual HR_EMP_DETAIL? SUPERVISOR { get; set; }

        //Foreign Key
        [ForeignKey("HEAD_ID")]
        public virtual HR_EMP_DETAIL? HEAD { get; set; }


    }
}
