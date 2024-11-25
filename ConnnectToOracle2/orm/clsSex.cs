using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ConnnectToSql2
{
    internal class clsSex
    {
        public List<Sex> GetSexes(string keyword = "")
        {
            var sexes = new List<Sex>();
            string sql = "SELECT sex_id, label, disabled FROM sexes WHERE disabled=0 AND (sex_id LIKE @keyword OR label LIKE @keyword)";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);
            cmd.Parameters.AddWithValue("keyword", $"%{keyword}%");

            try
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sexes.Add(new Sex
                        {
                            SexId = reader.GetInt32(0),
                            Label = reader.GetString(1),
                            Disabled = reader.GetBoolean(2)
                        });
                    }
                }

                return sexes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while getting sexes: " + ex.Message);
            }

            return sexes;
        }

        public void InsertSex(Sex sex)
        {
            string sql = "INSERT INTO sexes(label) VALUES (@label)";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@label", sex.Label);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while inserting: " + ex.Message);
            }
        }

        public void UpdateSexById(Sex sex)
        {
            string sql = "UPDATE sexes SET label=@label WHERE sex_id=@id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@id", sex.SexId);
            cmd.Parameters.AddWithValue("@label", sex.Label);

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
