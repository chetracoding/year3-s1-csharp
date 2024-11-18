using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ConnnectToSql2
{
    internal class clsSex
    {
        public int SexId { get; set; }
        public string Label { get; set; }
        public bool Disabled { get; set; }

        public DataTable GetSexes()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT sex_id, label FROM sexes WHERE disabled=0";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while getting: " + ex.Message);
            }

            return dt;
        }

        public void InsertSex(string label)
        {
            string sql = "INSERT INTO sexes(label) VALUES (@label)";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@label", label);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while inserting: " + ex.Message);
            }
        }

        public void UpdateSexbyId(int id, string label)
        {
            string sql = "UPDATE sexes SET label=@label WHERE sex_id=@id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@label", label);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while updating: " + ex.Message);
            }
        }

        public bool DeleteSexbyId(int id)
        {
            string sql = "UPDATE sexes SET disabled=1 WHERE sex_id=@id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while deleting: " + ex.Message);
            }
            return false;
        }
    }
}
