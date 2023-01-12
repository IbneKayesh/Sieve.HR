namespace Sieve.HR.Utilities
{
    public class SweetMessages
    {
        public const string SaveSuccessOKtxt = "Saved successful";
        public const string ContactWithProvidertxt = "Please contact with Provider";
        public const string LoginErrortxt = "User Id/Password is invalid";
        public static string SaveSuccessOK(string _msg)
        {
            return "Swal.fire('success','" + _msg + "','success')";
        }
        public static string SaveSuccessOK()
        {
            return "Swal.fire('success','Saved successful','success')";
        }

        public static string NoResultFound()
        {
            return "Swal.fire('Search','No result found','info')";
        }
        public static string ShowInfo(string infoTxt)
        {
            return $"Swal.fire('Information','{infoTxt}','info')";
        }
        public static string ShowError(string errorTxt)
        {
            return $"Swal.fire('error','{errorTxt.Replace("'", "").Replace("\r\n","")}','error')";
        }
        public static string DeleteSuccessOK()
        {
            return "Swal.fire('success','Delete successful','success')";
        }
        public static string AlreadyAdded()
        {
            return $"Swal.fire('Information','Already added, try another','info')";
        }
    }
}
