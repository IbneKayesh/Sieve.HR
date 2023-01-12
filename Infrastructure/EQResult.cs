namespace Sieve.HR.Infrastructure
{
    //Author: Md. Ibne Kayesh
    //Framework: ASP.NET MVC
    //Date: 15-Nov-2022
    //Version: 0.0.1
    //Last Update: 15-Nov-2022
    //Licence: Free to use only
    public class EQResult
    {
        public bool SUCCESS { get; set; }
        public string MESSAGES { get; set; }
        public int ROWS { get; set; }
        public EQResult()
        {
            SUCCESS = true;
            MESSAGES = "SUCCEEDED";
            ROWS = 0;
        }
    }
}
