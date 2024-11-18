namespace ConnnectToSql2
{
    partial class SexForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxLabel = new System.Windows.Forms.TextBox();
            this.LabelTotalCount = new System.Windows.Forms.Label();
            this.dgvSex = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSex)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Sex ID";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.DarkRed;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClose.Location = new System.Drawing.Point(17, 332);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(187, 41);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Location = new System.Drawing.Point(17, 267);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(187, 41);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClose);
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.BtnRefresh);
            this.groupBox2.Location = new System.Drawing.Point(1116, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 532);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
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
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSave.Location = new System.Drawing.Point(15, 136);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(187, 41);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(15, 66);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(187, 41);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TextBoxId
            // 
            this.TextBoxId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxId.Enabled = false;
            this.TextBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxId.Location = new System.Drawing.Point(563, 49);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.ReadOnly = true;
            this.TextBoxId.Size = new System.Drawing.Size(514, 32);
            this.TextBoxId.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Label";
            // 
            // TextBoxLabel
            // 
            this.TextBoxLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLabel.Location = new System.Drawing.Point(15, 49);
            this.TextBoxLabel.Name = "TextBoxLabel";
            this.TextBoxLabel.Size = new System.Drawing.Size(514, 32);
            this.TextBoxLabel.TabIndex = 22;
            // 
            // LabelTotalCount
            // 
            this.LabelTotalCount.AutoSize = true;
            this.LabelTotalCount.Location = new System.Drawing.Point(11, 511);
            this.LabelTotalCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTotalCount.Name = "LabelTotalCount";
            this.LabelTotalCount.Size = new System.Drawing.Size(93, 16);
            this.LabelTotalCount.TabIndex = 4;
            this.LabelTotalCount.Text = "Total records: ";
            // 
            // dgvSex
            // 
            this.dgvSex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSex.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSex.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvSex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSex.Location = new System.Drawing.Point(15, 117);
            this.dgvSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSex.Name = "dgvSex";
            this.dgvSex.RowHeadersWidth = 51;
            this.dgvSex.RowTemplate.Height = 24;
            this.dgvSex.Size = new System.Drawing.Size(1062, 390);
            this.dgvSex.TabIndex = 1;
            this.dgvSex.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSex_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSex);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TextBoxId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxLabel);
            this.groupBox1.Controls.Add(this.LabelTotalCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 532);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex mangement";
            // 
            // SexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SexForm";
            this.Text = "SexForm";
            this.Load += new System.EventHandler(this.SexForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSex)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxLabel;
        private System.Windows.Forms.Label LabelTotalCount;
        private System.Windows.Forms.DataGridView dgvSex;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}