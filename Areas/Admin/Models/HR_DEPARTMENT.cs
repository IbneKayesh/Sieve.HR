namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_DEPARTMENT
    {
        public int ID { get; set; }
        public int COMP_ID { get; set; }
        public string? DEPT_NAME { get; set; }
        public string? DEPT_ADDR { get; set; }
        public string? HEAD_EMP_ID { get; set; }
        public int MAX_EMP_NO { get; set; }
        public int MAX_SALARY { get; set; }
    }
}
