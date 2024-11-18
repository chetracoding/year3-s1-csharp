namespace ConnnectToSql2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCreate = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelTotalCount = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.datePickerOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxPBirth = new System.Windows.Forms.TextBox();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SexBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCreate.Location = new System.Drawing.Point(15, 136);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(187, 41);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Save";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(15, 356);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(1062, 342);
            this.dgvStudent.TabIndex = 1;
            this.dgvStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LabelTotalCount
            // 
            this.LabelTotalCount.AutoSize = true;
            this.LabelTotalCount.Location = new System.Drawing.Point(11, 700);
            this.LabelTotalCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTotalCount.Name = "LabelTotalCount";
            this.LabelTotalCount.Size = new System.Drawing.Size(130, 24);
            this.LabelTotalCount.TabIndex = 4;
            this.LabelTotalCount.Text = "Total records: ";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnDelete.Location = new System.Drawing.Point(15, 202);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(187, 41);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TextBoxSearch);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TextBoxId);
            this.groupBox1.Controls.Add(this.datePickerOfBirth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TextBoxPBirth);
            this.groupBox1.Controls.Add(this.ComboBoxGender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TextBoxLName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxFName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxCode);
            this.groupBox1.Controls.Add(this.LabelTotalCount);
            this.groupBox1.Controls.Add(this.dgvStudent);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 730);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student mangement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Student ID";
            // 
            // TextBoxId
            // 
            this.TextBoxId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxId.Enabled = false;
            this.TextBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxId.Location = new System.Drawing.Point(563, 245);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.ReadOnly = true;
            this.TextBoxId.Size = new System.Drawing.Size(514, 32);
            this.TextBoxId.TabIndex = 29;
            // 
            // datePickerOfBirth
            // 
            this.datePickerOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerOfBirth.Location = new System.Drawing.Point(567, 113);
            this.datePickerOfBirth.Name = "datePickerOfBirth";
            this.datePickerOfBirth.Size = new System.Drawing.Size(510, 28);
            this.datePickerOfBirth.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Place of birth";
            // 
            // TextBoxPBirth
            // 
            this.TextBoxPBirth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxPBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPBirth.Location = new System.Drawing.Point(567, 180);
            this.TextBoxPBirth.Name = "TextBoxPBirth";
            this.TextBoxPBirth.Size = new System.Drawing.Size(510, 32);
            this.TextBoxPBirth.TabIndex = 26;
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.Location = new System.Drawing.Point(567, 49);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(510, 30);
            this.ComboBoxGender.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Phone number";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhone.Location = new System.Drawing.Point(15, 245);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(514, 32);
            this.TextBoxPhone.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Last name";
            // 
            // TextBoxLName
            // 
            this.TextBoxLName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLName.Location = new System.Drawing.Point(15, 180);
            this.TextBoxLName.Name = "TextBoxLName";
            this.TextBoxLName.Size = new System.Drawing.Size(514, 32);
            this.TextBoxLName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "First name";
            // 
            // TextBoxFName
            // 
            this.TextBoxFName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFName.Location = new System.Drawing.Point(15, 113);
            this.TextBoxFName.Name = "TextBoxFName";
            this.TextBoxFName.Size = new System.Drawing.Size(514, 32);
            this.TextBoxFName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Student Code";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCode.Location = new System.Drawing.Point(15, 49);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(514, 32);
            this.TextBoxCode.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SexBtn);
            this.groupBox2.Controls.Add(this.CloseBtn);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.BtnCreate);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(1129, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 732);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // SexBtn
            // 
            this.SexBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SexBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SexBtn.Location = new System.Drawing.Point(17, 335);
            this.SexBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SexBtn.Name = "SexBtn";
            this.SexBtn.Size = new System.Drawing.Size(187, 41);
            this.SexBtn.TabIndex = 8;
            this.SexBtn.Text = "Sex";
            this.SexBtn.UseVisualStyleBackColor = false;
            this.SexBtn.Click += new System.EventHandler(this.SexBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.DarkRed;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBtn.Location = new System.Drawing.Point(15, 395);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(187, 41);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(17, 267);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(15, 317);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(514, 32);
            this.TextBoxSearch.TabIndex = 31;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Search for students...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 754);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelTotalCount;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxPBirth;
        private System.Windows.Forms.DateTimePicker datePickerOfBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Button SexBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxSearch;
    }
}

