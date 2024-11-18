using System.Data.SqlClient;

namespace ConnnectToSql2
{
    internal class sqlConnection
    {
        private static string conString = "User ID=your_username; Password=your_password; Data Source=localhost; Initial Catalog=your_database_name";
        public static SqlConnection cn = new SqlConnection(conString);
    }
}
