namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_JOB
    {
        public int ID { get; set; }
        public int EMP_ID { get; set; }
        public int DESIG_ID { get; set; }
        public int SECTION_ID { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime? CONF_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public int GROSS_SALARY { get; set; }
        public int INITIATED_BY { get; set; }
        public int VERIFIED_BY { get; set; }
        public int APPROVED_BY { get; set; }
    }
}
