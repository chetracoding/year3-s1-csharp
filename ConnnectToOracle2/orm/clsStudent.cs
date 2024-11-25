using ConnnectToOracle2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConnnectToSql2
{
    internal class clsStudent
    {
        public List<Student> GetStudents(string keyword = "")
        {
            var students = new List<Student>();
            string sql = "SELECT st.student_id, st.student_code, st.first_name, st.last_name, st.date_of_birth, st.place_of_birth, " +
                "st.phone, se.label sex_label, se.sex_id FROM students st LEFT JOIN sexes se ON se.sex_id = st.fk_sex_id " +
                "WHERE st.student_id LIKE @keyword OR st.student_code LIKE @keyword OR st.first_name LIKE @keyword OR st.last_name LIKE @keyword " +
                "ORDER BY st.student_id DESC";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);
            cmd.Parameters.AddWithValue("keyword", $"%{keyword}%");

            try
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentId = reader.GetInt32(0),
                            StudentCode = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            LastName = reader.GetString(3),
                            DateOfBirth = reader.GetDateTime(4),
                            PlaceOfBirth = reader.GetString(5),
                            PhoneNumber = reader.GetString(6),
                            SexLabel = reader.GetString(7),
                            SexId = reader.GetInt32(8)
                        });
                    }
                }

                return students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while getting students: " + ex.Message);
            }

            return students;
        }

        private bool FindStudentByCode(string code, int id = 0)
        {
            string sql = "SELECT * FROM students WHERE student_code=@code AND student_id!=@id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@code", code);

            try
            {
                using(var reader = cmd.ExecuteReader())
                {
                    bool isExisted = reader.HasRows;
                    return isExisted;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while finding: " + ex.Message);
            }
            return false;
        }

        public void InsertStudent(Student student)
        {
            bool isStudentExisted = FindStudentByCode(student.StudentCode);
            if (isStudentExisted)
            {
                throw new CustomException("Student code is already existed");
            }

            string sql = "INSERT INTO students(student_code, first_name, last_name, fk_sex_id, date_of_birth, place_of_birth, phone) " +
                "VALUES (@code, @fName, @lName, @sexId, @dOfBirth, @pOfBirth, @phone)";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@code", student.StudentCode);
            cmd.Parameters.AddWithValue("@fName", student.FirstName);
            cmd.Parameters.AddWithValue("@lName", student.LastName);
            cmd.Parameters.AddWithValue("@sexId", student.SexId);
            cmd.Parameters.AddWithValue("@dOfBirth", student.DateOfBirth);
            cmd.Parameters.AddWithValue("@pOfBirth", student.PlaceOfBirth);
            cmd.Parameters.AddWithValue("@phone", student.PhoneNumber);

            try
            {
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show("Something went wrong​ while inserting: " + ex.Message);
            }
        }

        public void UpdateStudentById(Student student)
        {
            bool isStudentExisted = FindStudentByCode(student.StudentCode, student.StudentId);
            if (isStudentExisted)
            {
                throw new CustomException("Student code is already existed");
            }

            string sql = "UPDATE students SET student_code=@code, first_name=@fName, last_name=@lName, fk_sex_id=@sexId, " +
                "date_of_birth=@dOfBirth, place_of_birth=@pOfBirth, phone=@phone WHERE student_id=@id";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection.cn);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@id", student.StudentId);
            cmd.Parameters.AddWithValue("@code", student.StudentCode);
            cmd.Parameters.AddWithValue("@fName", student.FirstName);
            cmd.Parameters.AddWithValue("@lName", student.LastName);
            cmd.Parameters.AddWithValue("@sexId", student.SexId);
            cmd.Parameters.AddWithValue("@dOfBirth", student.DateOfBirth);
            cmd.Parameters.AddWithValue("@pOfBirth", student.PlaceOfBirth);
            cmd.Parameters.AddWithValue("@phone", student.PhoneNumber);

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
                MessageBox.Show("Something went wrong​ while updating: " + ex.Message);
            }
            return false;
        }
    }
}
