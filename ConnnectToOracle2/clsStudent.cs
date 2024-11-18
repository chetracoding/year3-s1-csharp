using ConnnectToOracle2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConnnectToSql2
{
    internal class clsStudent
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            string sql = "SELECT st.student_id, st.student_code, st.first_name, st.last_name, st.date_of_birth, st.place_of_birth" +
                ", st.phone, se.label sex_label, se.sex_id FROM students st LEFT JOIN sexes se ON se.sex_id = st.fk_sex_id ORDER BY st.student_id DESC";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);
            var reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        StudentId = reader.GetInt32(0),
                        StudentCode = reader.GetString(1),
                        FirstName = reader.GetString(2),
                        LastName = reader.GetString(3),
                        DateOfBirth = reader.GetString(4),
                        PlaceOfBirth = reader.GetString(5),
                        PhoneNumber = reader.GetString(6),
                        SexLabel = reader.GetString(7),
                        SexId = reader.GetInt32(8)
                    });
                }
                return students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while getting: " + ex.Message);
            }

            return students;
        }

        private bool FindStudentByCode(string code, int id = 0)
        {
            string sql = "SELECT * FROM students WHERE student_code=@code AND student_id!=@id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@code", code);
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                bool isExisted = reader.HasRows;
                reader.Close();

                return isExisted;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while getting: " + ex.Message);
            }
            return false;
        }

        public void InsertStudent(string code, string fName, string lName, int sexId, string dOfBirth, string pOfBirth, string phone)
        {
            bool isStudentExisted = FindStudentByCode(code);
            if (isStudentExisted)
            {
                throw new CustomException("Student code is already existed");
            }

            string sql = "INSERT INTO students(student_code, first_name, last_name, fk_sex_id, date_of_birth, place_of_birth, phone) " +
                "VALUES (@code, @fName, @lName, @sexId, @dOfBirth, @pOfBirth, @phone)";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@sexId", sexId);
            cmd.Parameters.AddWithValue("@dOfBirth", dOfBirth);
            cmd.Parameters.AddWithValue("@pOfBirth", pOfBirth);
            cmd.Parameters.AddWithValue("@phone", phone);

            try
            {
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while inserting: " + ex.Message);
            }
        }

        public void UpdateStudentById(int id, string code, string fName, string lName, int sexId, string dOfBirth, string pOfBirth, string phone)
        {
            bool isStudentExisted = FindStudentByCode(code, id);
            if (isStudentExisted)
            {
                throw new CustomException("Student code is already existed");
            }

            string sql = "UPDATE students SET student_code=@code, first_name=@fName, last_name=@lName, fk_sex_id=@sexId, " +
                "date_of_birth=@dOfBirth, place_of_birth=@pOfBirth, phone=@phone WHERE student_id=@id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@sexId", sexId);
            cmd.Parameters.AddWithValue("@dOfBirth", dOfBirth);
            cmd.Parameters.AddWithValue("@pOfBirth", pOfBirth);
            cmd.Parameters.AddWithValue("@phone", phone);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while updating: " + ex.Message);
            }
        }

        public bool DeleteStudentById(int id)
        {
            string sql = "DELETE FROM students WHERE student_id = @id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while inserting: " + ex.Message);
            }
            return false;
        }
    }
}
