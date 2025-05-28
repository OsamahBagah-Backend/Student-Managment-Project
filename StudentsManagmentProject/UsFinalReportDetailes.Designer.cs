namespace StudentsManagmentProject
{
    partial class UsFinalReportDetailes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ViolationCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ViolationDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvViolations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbViolationFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViolationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolations)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lbTitle.Location = new System.Drawing.Point(588, 38);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(281, 44);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "تفاصيل التقرير النهائي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(1281, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = ":إسم الطالب";
            // 
            // lbStudentName
            // 
            this.lbStudentName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lbStudentName.Location = new System.Drawing.Point(898, 166);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbStudentName.Size = new System.Drawing.Size(377, 44);
            this.lbStudentName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(129, 155);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(234, 35);
            this.label3.TabIndex = 32;
            this.label3.Text = "إبحث بعدد المخالفات:";
            // 
            // ViolationCount
            // 
            this.ViolationCount.BackColor = System.Drawing.Color.Transparent;
            this.ViolationCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ViolationCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViolationCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ViolationCount.Location = new System.Drawing.Point(28, 190);
            this.ViolationCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViolationCount.Name = "ViolationCount";
            this.ViolationCount.Size = new System.Drawing.Size(323, 60);
            this.ViolationCount.TabIndex = 31;
            this.ViolationCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ViolationCount.UpDownButtonForeColor = System.Drawing.Color.White;
            this.ViolationCount.ValueChanged += new System.EventHandler(this.ViolationCount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(110, 281);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(232, 35);
            this.label4.TabIndex = 30;
            this.label4.Text = "إبحث بتاريخ المخالفة:";
            // 
            // ViolationDateTime
            // 
            this.ViolationDateTime.BorderColor = System.Drawing.Color.Transparent;
            this.ViolationDateTime.BorderRadius = 20;
            this.ViolationDateTime.Checked = true;
            this.ViolationDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ViolationDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViolationDateTime.ForeColor = System.Drawing.Color.White;
            this.ViolationDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ViolationDateTime.Location = new System.Drawing.Point(21, 317);
            this.ViolationDateTime.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.ViolationDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ViolationDateTime.Name = "ViolationDateTime";
            this.ViolationDateTime.Size = new System.Drawing.Size(330, 68);
            this.ViolationDateTime.TabIndex = 29;
            this.ViolationDateTime.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.ViolationDateTime.ValueChanged += new System.EventHandler(this.ViolationDateTime_ValueChanged);
            // 
            // dgvViolations
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvViolations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvViolations.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvViolations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvViolations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvViolations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViolations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvViolations.ColumnHeadersHeight = 76;
            this.dgvViolations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViolations.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvViolations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvViolations.GridColor = System.Drawing.Color.Black;
            this.dgvViolations.Location = new System.Drawing.Point(0, 435);
            this.dgvViolations.MultiSelect = false;
            this.dgvViolations.Name = "dgvViolations";
            this.dgvViolations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvViolations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViolations.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvViolations.RowHeadersVisible = false;
            this.dgvViolations.RowHeadersWidth = 62;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvViolations.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvViolations.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvViolations.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvViolations.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.dgvViolations.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvViolations.RowTemplate.DividerHeight = 3;
            this.dgvViolations.RowTemplate.Height = 50;
            this.dgvViolations.RowTemplate.ReadOnly = true;
            this.dgvViolations.ShowCellToolTips = false;
            this.dgvViolations.Size = new System.Drawing.Size(1470, 452);
            this.dgvViolations.TabIndex = 33;
            this.dgvViolations.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvViolations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvViolations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvViolations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvViolations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.dgvViolations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvViolations.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.dgvViolations.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvViolations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.dgvViolations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvViolations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvViolations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvViolations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvViolations.ThemeStyle.HeaderStyle.Height = 76;
            this.dgvViolations.ThemeStyle.ReadOnly = false;
            this.dgvViolations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvViolations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvViolations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvViolations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvViolations.ThemeStyle.RowsStyle.Height = 50;
            this.dgvViolations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvViolations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnBack
            // 
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnBack.BorderRadius = 15;
            this.btnBack.BorderThickness = 2;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnBack.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnBack.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(21, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 64);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "العودة";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel1.Location = new System.Drawing.Point(1127, 279);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(333, 60);
            this.guna2Panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "إبحث بنوع المخالفة";
            // 
            // cmbViolationFilter
            // 
            this.cmbViolationFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbViolationFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cmbViolationFilter.BorderThickness = 2;
            this.cmbViolationFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbViolationFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViolationFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbViolationFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbViolationFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViolationFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbViolationFilter.ItemHeight = 40;
            this.cmbViolationFilter.Items.AddRange(new object[] {
            "الكل",
            "مخالفات الصلاة",
            "مخالفات حلقات الفجر",
            "مخالفات الأنشطة",
            "مخالفات السلوك",
            "مخالفات النظافة",
            "مخالفات حلقات الأسبوع"});
            this.cmbViolationFilter.Location = new System.Drawing.Point(1126, 339);
            this.cmbViolationFilter.Name = "cmbViolationFilter";
            this.cmbViolationFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbViolationFilter.Size = new System.Drawing.Size(330, 46);
            this.cmbViolationFilter.TabIndex = 35;
            this.cmbViolationFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmbViolationFilter.SelectedIndexChanged += new System.EventHandler(this.cmbViolationFilter_SelectedIndexChanged);
            // 
            // UsFinalReportDetailes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.cmbViolationFilter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvViolations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ViolationCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ViolationDateTime);
            this.Controls.Add(this.lbStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.Name = "UsFinalReportDetailes";
            this.Size = new System.Drawing.Size(1470, 887);
            this.Load += new System.EventHandler(this.UsFinalReportDetailes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViolationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViolations)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown ViolationCount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker ViolationDateTime;
        private Guna.UI2.WinForms.Guna2DataGridView dgvViolations;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbViolationFilter;
    }
}
