using System.Data.SqlClient;

namespace ConnnectToSql2
{
    internal class sqlConnection
    {
        public static SqlConnection cn = new SqlConnection("User ID=sa; Password=root; Data Source=localhost; Initial Catalog=student_management_db");
    }
}
