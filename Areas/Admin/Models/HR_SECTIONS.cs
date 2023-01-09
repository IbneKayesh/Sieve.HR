namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_SECTIONS
    {
        public int ID { get; set; }
        public int DEPT_ID { get; set; }
        public string? SECT_NAME { get; set; }
        public string? SECT_ADDR { get; set; }
        public string? HEAD_EMP_ID { get; set; }
        public int MAX_EMP_NO { get; set; }
        public int MAX_SALARY { get; set; }
    }
}
