namespace Sieve.HR.Utilities
{
    public class JSON_CONFIRM_MESSAGES
    {
        public JSON_CONFIRM_MESSAGES(bool result, string id)
        {
            success = result;
            messages = result ? string.Format("Record ID <{0}> is deleted successfully", id) : "Record ID <{0}> delete failed, try again!";
        }
        public JSON_CONFIRM_MESSAGES(bool result, string successTxt, string failedTxt)
        {
            success = result;
            messages = result ? successTxt : failedTxt;
        }
        public JSON_CONFIRM_MESSAGES(bool result, string trn, string successTxt, string failedTxt)
        {
            success = result;
            trnno = trn;
            messages = result ? successTxt : failedTxt;
        }
        public JSON_CONFIRM_MESSAGES(string failedTxt)
        {
            success = false;
            messages = failedTxt;
        }
        public bool success { get; set; } = true;
        public string trnno { get; set; } = "id-001";
        public string messages { get; set; } = "sieve ?";
    }
}
