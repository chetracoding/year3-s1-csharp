using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConnnectToSql2
{
    public partial class MainForm : Form
    {
        clsStudent objStudent = new clsStudent();
        clsSex objSex = new clsSex();

        List<Student> students;
        List<Sex> sexes;

        public MainForm()
        {
            InitializeComponent();
        }

        // Road students
        private void LoadStudent(string keyword = "")
        {
            students = objStudent.GetStudents(keyword);
            dgvStudent.DataSource = students;

            LabelTotalCount.Text = $"Total records: {dgvStudent.RowCount}";
        }

        // Road sexes
        private void LoadSex()
        {
            sexes = objSex.GetSexes();
            ComboBoxGender.Items.Clear();

            foreach (var sex in sexes)
            {
                ComboBoxGender.Items.Add(sex.Label);
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
            TextBoxSearch.Clear();
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
                MessageBox.Show("SQL connection fail: " + ex.Message);
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
            if (string.IsNullOrEmpty(ComboBoxGender.Text) || ComboBoxGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select sex");
                return;
            } else
            {
                sexId = sexes[ComboBoxGender.SelectedIndex].SexId;
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
                Student student = new Student
                    {
                        StudentId = studentId,
                        StudentCode = TextBoxCode.Text,
                        FirstName = TextBoxFName.Text,
                        LastName = TextBoxLName.Text,
                        SexId = sexId,
                        DateOfBirth = datePickerOfBirth.Value,
                        PlaceOfBirth = TextBoxPBirth.Text,
                        PhoneNumber = TextBoxPhone.Text
                    };

                if (isUpdated)
                {
                    objStudent.UpdateStudentById(student);
                } else
                {
                    objStudent.InsertStudent(student);
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
            bool isRowSelected = int.TryParse(TextBoxId.Text, out studentId);
            if (!isRowSelected)
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
            Student student = students.Find(s => s.StudentId == studentId);

            int sexIndex = sexes.FindIndex(s => s.SexId == student.SexId);
            if (sexIndex < 0)
            {
                ComboBoxGender.SelectedIndex = -1;
            } else
            {
                ComboBoxGender.SelectedIndex = sexIndex;
            }

            TextBoxId.Text = student.StudentId.ToString();
            TextBoxCode.Text = student.StudentCode;
            TextBoxFName.Text = student.FirstName;
            TextBoxLName.Text = student.LastName;
            TextBoxPhone.Text = student.PhoneNumber;
            TextBoxPBirth.Text = student.PlaceOfBirth;
            datePickerOfBirth.Text = student.DateOfBirth.ToString();
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

        // Open sex form
        private void SexBtn_Click(object sender, EventArgs e)
        {
            Form sexForm = new SexForm();
            sexForm.ShowDialog();
        }

        // Refresh
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadStudent(TextBoxSearch.Text);
            LoadSex();
        }

        // Search for students
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudent(TextBoxSearch.Text);
        }
    }
}
