namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_LEAVE_APPS
    {
        public int EMP_ID { get; set; }
        public DateTime FROM_DATE { get; set; }
        public DateTime TO_DATE { get; set; }
        public int TOTAL_DAYS { get; set; }
        public int LEAVE_TYPE_ID { get; set; }
        public string? LEAVE_DETAIL { get; set; }
        public int VERIFY_BY { get; set; }
        public int APPROVED_BY { get; set; }
    }
}
