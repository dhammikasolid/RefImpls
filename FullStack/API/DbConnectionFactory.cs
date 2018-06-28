using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace API
{
    public class DbConnectionFactory
    {
        public static DbConnection Connection
        {
            get
            {
                var con = new SqlConnection(ConfigurationManager.ConnectionStrings["FullStack"].ConnectionString);
                con.Open();

                return con;
            }
        }
    }
}