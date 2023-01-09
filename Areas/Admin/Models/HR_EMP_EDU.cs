namespace Sieve.HR.Areas.Admin.Models
{
    public class HR_EMP_EDU
    {
        public int ID { get; set; }
        public int EMP_ID { get; set; }
        public int EDU_TYPE { get; set; }
        public string? EDU_TITLE { get; set; }
        public int EDU_YEAR { get; set; }
        public string? EDU_GRADE { get; set; }
        public string? INSTITUE_NAME { get; set; }
    }
}
