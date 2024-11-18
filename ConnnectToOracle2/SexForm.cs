using ConnnectToSql2;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConnnectToSql2
{
    public partial class SexForm : Form
    {
        clsSex objSex = new clsSex();
        DataTable sexes;

        public SexForm()
        {
            InitializeComponent();
        }

        // Road sex
        private void LoadSex()
        {
            sexes = objSex.GetSexes();

            dgvSex.DataSource = sexes;
            LabelTotalCount.Text = $"Total records: {sexes.Rows.Count}";
        }

        // Clear form
        private void ClearForm()
        {
            TextBoxId.Clear();
            TextBoxLabel.Clear();
        }

        // Save (Update or create sex)
        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool isInvalidField;

            isInvalidField = string.IsNullOrEmpty(TextBoxLabel.Text);
            if (isInvalidField)
            {
                MessageBox.Show("Please enter label");
                return;
            }

            try
            {
                int sexId;
                bool isUpdated = int.TryParse(TextBoxId.Text, out sexId);

                if (isUpdated)
                {
                    objSex.UpdateSexbyId(
                        sexId,
                        TextBoxLabel.Text
                    );
                }
                else
                {
                    objSex.InsertSex(TextBoxLabel.Text);
                }

                ClearForm();
                LoadSex();

                string message = isUpdated ? "Sex is updated successfully" : "Sex is created successfully";
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while saving: " + ex.Message);
            }
        }

        // Road sex form
        private void SexForm_Load(object sender, EventArgs e)
        {
            LoadSex();
        }

        // Refresh
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadSex();
        }

        // Close
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Delete sex
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int sexId;
            bool isSuccess = int.TryParse(TextBoxId.Text, out sexId);
            if (!isSuccess)
            {
                MessageBox.Show("Please double click sex row first!");
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sur to delete!", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No) return;

            try
            {
                bool isDeleted = objSex.DeleteSexbyId(sexId);
                if (isDeleted)
                {
                    ClearForm();
                    LoadSex();
                    MessageBox.Show("Sex is deleted successfully");
                }
                else
                {
                    MessageBox.Show("No sex found!");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong while deleting");
            }
        }

        // Double click on sex row
        private void dgvSex_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string sexId = dgvSex.Rows[e.RowIndex].Cells[0].Value.ToString();
            DataRow[] sex = sexes.Select($" Sex_Id = {sexId}");

            TextBoxId.Text = sex[0]["Sex_Id"].ToString();
            TextBoxLabel.Text = sex[0]["Label"].ToString();
        }
    }
}
