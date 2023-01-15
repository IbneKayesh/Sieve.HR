using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_COMMON
    {
        public HR_COMMON()
        {
            RowVersion = new byte[] { 0, 0, 0, 0, 0, 0, 0, 120 };
        }

        [Display(Name = "Concurrency Timestamp")]
        [Required(ErrorMessage = "{0} is required")]
        [ConcurrencyCheck]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
