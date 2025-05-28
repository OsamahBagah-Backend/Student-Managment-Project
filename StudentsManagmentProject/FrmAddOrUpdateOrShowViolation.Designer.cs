namespace StudentsManagmentProject
{
    partial class FrmAddOrUpdateOrShowViolation
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimeViolation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbViolationFKind = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescriptionViolation = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCansel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lbTitle.Location = new System.Drawing.Point(472, 40);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(168, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "إضافة مخالفة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(901, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = ":إسم الطالب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(875, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = ":تاريخ المخالفة";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtStudentName.BorderRadius = 20;
            this.txtStudentName.BorderThickness = 2;
            this.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentName.DefaultText = "";
            this.txtStudentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtStudentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentName.Location = new System.Drawing.Point(521, 165);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PlaceholderText = "";
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.Size = new System.Drawing.Size(370, 64);
            this.txtStudentName.TabIndex = 3;
            this.txtStudentName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // dateTimeViolation
            // 
            this.dateTimeViolation.BorderRadius = 15;
            this.dateTimeViolation.Checked = true;
            this.dateTimeViolation.CustomFormat = "dd/mm/yyyy";
            this.dateTimeViolation.FillColor = System.Drawing.Color.LightGray;
            this.dateTimeViolation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeViolation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.dateTimeViolation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeViolation.Location = new System.Drawing.Point(521, 258);
            this.dateTimeViolation.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimeViolation.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeViolation.Name = "dateTimeViolation";
            this.dateTimeViolation.Size = new System.Drawing.Size(348, 56);
            this.dateTimeViolation.TabIndex = 4;
            this.dateTimeViolation.Value = new System.DateTime(2025, 3, 13, 0, 0, 0, 0);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel1.Location = new System.Drawing.Point(25, 171);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(333, 60);
            this.guna2Panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "نوع المخالفة";
            // 
            // cmbViolationFKind
            // 
            this.cmbViolationFKind.BackColor = System.Drawing.Color.Transparent;
            this.cmbViolationFKind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cmbViolationFKind.BorderThickness = 2;
            this.cmbViolationFKind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbViolationFKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViolationFKind.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbViolationFKind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbViolationFKind.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViolationFKind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbViolationFKind.ItemHeight = 40;
            this.cmbViolationFKind.Items.AddRange(new object[] {
            "مخالفات الصلاة",
            "مخالفات حلقات الفجر",
            "مخالفات الأنشطة",
            "مخالفات السلوك",
            "مخالفات النظافة",
            "مخالفات حلقات الأسبوع"});
            this.cmbViolationFKind.Location = new System.Drawing.Point(25, 231);
            this.cmbViolationFKind.Name = "cmbViolationFKind";
            this.cmbViolationFKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbViolationFKind.Size = new System.Drawing.Size(330, 46);
            this.cmbViolationFKind.TabIndex = 23;
            this.cmbViolationFKind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(875, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 39);
            this.label4.TabIndex = 25;
            this.label4.Text = "وصف المخالفة";
            // 
            // txtDescriptionViolation
            // 
            this.txtDescriptionViolation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtDescriptionViolation.BorderRadius = 20;
            this.txtDescriptionViolation.BorderThickness = 2;
            this.txtDescriptionViolation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescriptionViolation.DefaultText = "";
            this.txtDescriptionViolation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescriptionViolation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescriptionViolation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescriptionViolation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescriptionViolation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescriptionViolation.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionViolation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescriptionViolation.Location = new System.Drawing.Point(13, 424);
            this.txtDescriptionViolation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescriptionViolation.Name = "txtDescriptionViolation";
            this.txtDescriptionViolation.PlaceholderText = "";
            this.txtDescriptionViolation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescriptionViolation.SelectedText = "";
            this.txtDescriptionViolation.Size = new System.Drawing.Size(1089, 180);
            this.txtDescriptionViolation.TabIndex = 26;
            this.txtDescriptionViolation.TextOffset = new System.Drawing.Point(10, -42);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderThickness = 2;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(657, 634);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 57);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnCansel.BorderRadius = 15;
            this.btnCansel.BorderThickness = 2;
            this.btnCansel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCansel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCansel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCansel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCansel.FillColor = System.Drawing.Color.White;
            this.btnCansel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCansel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnCansel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnCansel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCansel.Location = new System.Drawing.Point(267, 634);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(180, 57);
            this.btnCansel.TabIndex = 28;
            this.btnCansel.Text = "إلغاء";
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // FrmAddOrUpdateOrShowViolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1115, 712);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescriptionViolation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.cmbViolationFKind);
            this.Controls.Add(this.dateTimeViolation);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmAddOrUpdateOrShowViolation";
            this.Text = "FrmAddOrUpdateOrShowViolation";
            this.Load += new System.EventHandler(this.FrmAddOrUpdateOrShowViolation_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimeViolation;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbViolationFKind;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtDescriptionViolation;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCansel;
    }
}