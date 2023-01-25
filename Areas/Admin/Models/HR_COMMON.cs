using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_COMMON 
    {
        public HR_COMMON()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            CreateUser = 1;
            UpdateUser = 1;
            IsActive = 1;
            RowVersion = new byte[] { 0, 0, 0, 0, 0, 0, 0, 120 };
        }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CreateUser { get; set; }
        public int UpdateUser { get; set; }
        public int IsActive { get; set; }

        [Display(Name = "Concurrency Timestamp")]
        [Required(ErrorMessage = "{0} is required")]
        [ConcurrencyCheck]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
