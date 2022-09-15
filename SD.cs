
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AthleteManagement_WebForm.Models
{
    public class SD
    {
        public static string _conString = ConfigurationManager.ConnectionStrings["AthleteString"].ConnectionString;
        public static SqlConnection _con;
        public static SqlCommand _cmd;
        public static StringBuilder _html;
        public static SqlDataReader _dr;
        public static SqlDataAdapter _adapter;
        public static DataTable _dt;
        public enum MessageType { Success, Error, Info, Warning };

        public const string Athlete = "Athlete";
        public const string Coach = "Coach";
        public const string SportsFederation = "SportsFederation";
        public const string HealthProfession = "HealthProfession";

        public const string emailHost = "10.142.204.51";

        public const string redirectURL = "https://gpgathletes-test.gauteng.gov.za/";
    }
}
