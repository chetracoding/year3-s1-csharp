using ConnnectToOracle2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ConnnectToSql2
{
    public partial class MainForm : Form
    {
        clsStudent objStudent = new clsStudent();
        clsSex objSex = new clsSex();
        List<Student> students;
        DataTable sexes;

        public MainForm()
        {
            InitializeComponent();
        }

        // Road student
        private void LoadStudent()
        {
            students = objStudent.GetStudents();

            dgvStudent.DataSource = students;
            LabelTotalCount.Text = $"Total records: {dgvStudent.RowCount}";
        }

        // Road sex
        private void LoadSex()
        {
            sexes = objSex.GetSexes();
            ComboBoxGender.Items.Clear();
            for (int i = 0; i < sexes.Rows.Count; i++)
            {
                ComboBoxGender.Items.Add(sexes.Rows[i]["Label"].ToString());
            }
        }

        // Clear form
        private void ClearForm()
        {
            TextBoxId.Clear();
            TextBoxCode.Clear();
            TextBoxFName.Clear();
            TextBoxLName.Clear();
            TextBoxPBirth.Clear();
            TextBoxPhone.Clear();
            ComboBoxGender.SelectedIndex = -1;
        }

        // Load main form
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.cn.Open();
                LoadStudent();
                LoadSex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection fail: " + ex.Message);
            }
        }

        // Save (Update or create student)
        private void button1_Click(object sender, EventArgs e)
        {
            bool isInvalidField;
            int sexId;

            isInvalidField = string.IsNullOrEmpty(TextBoxCode.Text);
            if (isInvalidField)
            {
                MessageBox.Show("Please enter student code");
                return;
            }
            isInvalidField = string.IsNullOrEmpty(TextBoxFName.Text);
            if (isInvalidField)
            {
                MessageBox.Show("Please enter first name");
                return;
            }
            isInvalidField = string.IsNullOrEmpty(TextBoxLName.Text);
            if (isInvalidField)
            {
                MessageBox.Show("Please enter last name");
                return;
            }
            isInvalidField = string.IsNullOrEmpty(TextBoxPhone.Text);
            if (isInvalidField)
            {
                MessageBox.Show("Please enter phone number");
                return;
            }

            if (string.IsNullOrEmpty(ComboBoxGender.Text) || ComboBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select sex");
                return;
            } else
            {
                isInvalidField = int.TryParse(sexes.Rows[ComboBoxGender.SelectedIndex]["Sex_Id"].ToString(), out sexId);
                if (!isInvalidField)
                {
                    MessageBox.Show("Please select sex");
                    return;
                }
            }

            isInvalidField = string.IsNullOrEmpty(datePickerOfBirth.Text);
            if (isInvalidField)
            {
                MessageBox.Show("Please enter date of birth");
                return;
            }
            isInvalidField = string.IsNullOrEmpty(TextBoxPBirth.Text);
            if (isInvalidField)
            {
                MessageBox.Show("Please enter place of birth");
                return;
            }

            try
            {
                int studentId;
                bool isUpdated = int.TryParse(TextBoxId.Text, out studentId);

                if (isUpdated)
                {
                    objStudent.UpdateStudentById(
                        studentId,
                        TextBoxCode.Text,
                        TextBoxFName.Text,
                        TextBoxLName.Text,
                        sexId,
                        datePickerOfBirth.Text,
                        TextBoxPBirth.Text,
                        TextBoxPhone.Text
                    );
                } else
                {
                    objStudent.InsertStudent(
                        TextBoxCode.Text,
                        TextBoxFName.Text,
                        TextBoxLName.Text,
                        sexId,
                        datePickerOfBirth.Text,
                        TextBoxPBirth.Text,
                        TextBoxPhone.Text
                    );
                }

                ClearForm();
                LoadStudent();

                string message = isUpdated ? "Student is updated successfully" : "Student is created successfully";
                MessageBox.Show(message);
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Something went wrong while saving: " + ex.Message);
            }
        }

        // Delete student
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int studentId;
            bool isSuccess = int.TryParse(TextBoxId.Text, out studentId);
            if (!isSuccess)
            {
                MessageBox.Show("Please double click student row first!");
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sur to delete!", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No) return;

            try
            {
                bool isDeleted = objStudent.DeleteStudentById(studentId);
                if (isDeleted)
                {
                    ClearForm();
                    LoadStudent();
                    MessageBox.Show("Student is deleted successfully");
                } else
                {
                    MessageBox.Show("No student found!");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong while deleting");
            }
        }

        // Double click on student row
        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            
            int studentId = int.Parse(dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataRow[] student = students.Find(s => s.Field<int>("StudentId") == studentId);

            int fkSexId;
            bool isNoEmptySex = int.TryParse(student[0]["Fk_Sex_Id"].ToString(), out fkSexId);
            if (isNoEmptySex)
            {
                DataRow[] sex = sexes.Select($" Sex_Id = {fkSexId}");
                if (sex.Length > 0)
                {
                    ComboBoxGender.SelectedIndex = sexes.Rows.IndexOf(sex[0]);
                } else
                {
                    ComboBoxGender.SelectedIndex = -1;
                }
            } else
            {
                ComboBoxGender.SelectedIndex = -1;
            }

            TextBoxId.Text = student[0]["Student_Id"].ToString();
            TextBoxCode.Text = student[0]["Student_Code"].ToString();
            TextBoxFName.Text = student[0]["First_Name"].ToString();
            TextBoxLName.Text = student[0]["Last_Name"].ToString();
            TextBoxPhone.Text = student[0]["Phone"].ToString();
            TextBoxPBirth.Text = student[0]["Place_Of_Birth"].ToString();
            datePickerOfBirth.Text = student[0]["Date_Of_Birth"].ToString();
        }

        // Clear
        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Close
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Search student
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

        // Open sex form
        private void SexBtn_Click(object sender, EventArgs e)
        {
            Form sexForm = new SexForm();
            sexForm.ShowDialog();
        }

        // Refresh
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadStudent();
            LoadSex();
        }
    }
}
