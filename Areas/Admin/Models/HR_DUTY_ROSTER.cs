﻿using Sieve.HR.Models;
using System.ComponentModel.DataAnnotations;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_DUTY_ROSTER
    {
        public HR_DUTY_ROSTER()
        {
            HR_EMP_ROSTERS = new HashSet<HR_EMP_ROSTER>();
        }
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

       
        [Display(Name = "Duty Roster Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? DUTY_ROSTER_NAME { get; set; }

        
        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(5, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 5)]
        public string? START_TIME { get; set; }


        [Display(Name = "End Time")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(5, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 5)]
        public string? END_TIME { get; set; }


        public virtual ICollection<HR_EMP_ROSTER> HR_EMP_ROSTERS { get; set; }
    }
}
