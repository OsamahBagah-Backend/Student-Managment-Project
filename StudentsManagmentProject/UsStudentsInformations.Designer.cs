namespace StudentsManagmentProject
{
    partial class UsStudentsInformations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudentsFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbUniversitiesFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbMajorsFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbLevelsFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvShowStudentsInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmStripStudenUserControl = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ShowStudentInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateStudentInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowStudentInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.cmbPeriodes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintTheReport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudentsInfo)).BeginInit();
            this.cmStripStudenUserControl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = " الطلاب";
            // 
            // cmbStudentsFilter
            // 
            this.cmbStudentsFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbStudentsFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cmbStudentsFilter.BorderThickness = 2;
            this.cmbStudentsFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStudentsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentsFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStudentsFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStudentsFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentsFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStudentsFilter.ItemHeight = 40;
            this.cmbStudentsFilter.Items.AddRange(new object[] {
            "الكل",
            "الخريجين",
            "غير الخريجين"});
            this.cmbStudentsFilter.Location = new System.Drawing.Point(1206, 207);
            this.cmbStudentsFilter.Name = "cmbStudentsFilter";
            this.cmbStudentsFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStudentsFilter.Size = new System.Drawing.Size(252, 46);
            this.cmbStudentsFilter.TabIndex = 6;
            this.cmbStudentsFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmbStudentsFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStudentsFilter_SelectedIndexChanged);
            // 
            // cmbUniversitiesFilter
            // 
            this.cmbUniversitiesFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbUniversitiesFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cmbUniversitiesFilter.BorderThickness = 2;
            this.cmbUniversitiesFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUniversitiesFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniversitiesFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUniversitiesFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUniversitiesFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUniversitiesFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUniversitiesFilter.ItemHeight = 40;
            this.cmbUniversitiesFilter.Items.AddRange(new object[] {
            "الكل"});
            this.cmbUniversitiesFilter.Location = new System.Drawing.Point(930, 207);
            this.cmbUniversitiesFilter.Name = "cmbUniversitiesFilter";
            this.cmbUniversitiesFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbUniversitiesFilter.Size = new System.Drawing.Size(248, 46);
            this.cmbUniversitiesFilter.TabIndex = 8;
            this.cmbUniversitiesFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmbUniversitiesFilter.SelectedIndexChanged += new System.EventHandler(this.cmbUniversitiesFilter_SelectedIndexChanged);
            // 
            // cmbMajorsFilter
            // 
            this.cmbMajorsFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbMajorsFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cmbMajorsFilter.BorderThickness = 2;
            this.cmbMajorsFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMajorsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMajorsFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMajorsFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMajorsFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMajorsFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMajorsFilter.ItemHeight = 40;
            this.cmbMajorsFilter.Items.AddRange(new object[] {
            "الكل"});
            this.cmbMajorsFilter.Location = new System.Drawing.Point(628, 207);
            this.cmbMajorsFilter.Name = "cmbMajorsFilter";
            this.cmbMajorsFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMajorsFilter.Size = new System.Drawing.Size(253, 46);
            this.cmbMajorsFilter.TabIndex = 10;
            this.cmbMajorsFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmbMajorsFilter.SelectedIndexChanged += new System.EventHandler(this.cmbMajorsFilter_SelectedIndexChanged);
            // 
            // cmbLevelsFilter
            // 
            this.cmbLevelsFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbLevelsFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cmbLevelsFilter.BorderThickness = 2;
            this.cmbLevelsFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLevelsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevelsFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLevelsFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLevelsFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLevelsFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLevelsFilter.ItemHeight = 40;
            this.cmbLevelsFilter.Items.AddRange(new object[] {
            "الكل"});
            this.cmbLevelsFilter.Location = new System.Drawing.Point(335, 207);
            this.cmbLevelsFilter.Name = "cmbLevelsFilter";
            this.cmbLevelsFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLevelsFilter.Size = new System.Drawing.Size(253, 46);
            this.cmbLevelsFilter.TabIndex = 12;
            this.cmbLevelsFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmbLevelsFilter.SelectedIndexChanged += new System.EventHandler(this.cmbLevelsFilter_SelectedIndexChanged);
            // 
            // dgvShowStudentsInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShowStudentsInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowStudentsInfo.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvShowStudentsInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvShowStudentsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvShowStudentsInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowStudentsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowStudentsInfo.ColumnHeadersHeight = 76;
            this.dgvShowStudentsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowStudentsInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowStudentsInfo.GridColor = System.Drawing.Color.Black;
            this.dgvShowStudentsInfo.Location = new System.Drawing.Point(0, 296);
            this.dgvShowStudentsInfo.MultiSelect = false;
            this.dgvShowStudentsInfo.Name = "dgvShowStudentsInfo";
            this.dgvShowStudentsInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowStudentsInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowStudentsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowStudentsInfo.RowHeadersVisible = false;
            this.dgvShowStudentsInfo.RowHeadersWidth = 62;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShowStudentsInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowStudentsInfo.RowTemplate.ContextMenuStrip = this.cmStripStudenUserControl;
            this.dgvShowStudentsInfo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvShowStudentsInfo.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvShowStudentsInfo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.dgvShowStudentsInfo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShowStudentsInfo.RowTemplate.DividerHeight = 3;
            this.dgvShowStudentsInfo.RowTemplate.Height = 35;
            this.dgvShowStudentsInfo.RowTemplate.ReadOnly = true;
            this.dgvShowStudentsInfo.ShowCellToolTips = false;
            this.dgvShowStudentsInfo.Size = new System.Drawing.Size(1470, 498);
            this.dgvShowStudentsInfo.TabIndex = 13;
            this.dgvShowStudentsInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.dgvShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShowStudentsInfo.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.dgvShowStudentsInfo.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvShowStudentsInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.dgvShowStudentsInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowStudentsInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowStudentsInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShowStudentsInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShowStudentsInfo.ThemeStyle.HeaderStyle.Height = 76;
            this.dgvShowStudentsInfo.ThemeStyle.ReadOnly = false;
            this.dgvShowStudentsInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShowStudentsInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvShowStudentsInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowStudentsInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShowStudentsInfo.ThemeStyle.RowsStyle.Height = 35;
            this.dgvShowStudentsInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvShowStudentsInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmStripStudenUserControl
            // 
            this.cmStripStudenUserControl.BackColor = System.Drawing.Color.White;
            this.cmStripStudenUserControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmStripStudenUserControl.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmStripStudenUserControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowStudentInfoItem,
            this.updateStudentInfoItem,
            this.deleteStudentItem});
            this.cmStripStudenUserControl.Name = "cmStripStudenUserControl";
            this.cmStripStudenUserControl.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmStripStudenUserControl.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cmStripStudenUserControl.RenderStyle.ColorTable = null;
            this.cmStripStudenUserControl.RenderStyle.RoundedEdges = false;
            this.cmStripStudenUserControl.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmStripStudenUserControl.RenderStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.cmStripStudenUserControl.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmStripStudenUserControl.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.cmStripStudenUserControl.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmStripStudenUserControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmStripStudenUserControl.ShowCheckMargin = true;
            this.cmStripStudenUserControl.Size = new System.Drawing.Size(346, 118);
            // 
            // ShowStudentInfoItem
            // 
            this.ShowStudentInfoItem.Name = "ShowStudentInfoItem";
            this.ShowStudentInfoItem.Size = new System.Drawing.Size(345, 38);
            this.ShowStudentInfoItem.Text = "عرض معلومات الطالب ";
            // 
            // updateStudentInfoItem
            // 
            this.updateStudentInfoItem.Name = "updateStudentInfoItem";
            this.updateStudentInfoItem.Size = new System.Drawing.Size(345, 38);
            this.updateStudentInfoItem.Text = "تعديل معلومات الطالب";
            // 
            // deleteStudentItem
            // 
            this.deleteStudentItem.Name = "deleteStudentItem";
            this.deleteStudentItem.Size = new System.Drawing.Size(345, 38);
            this.deleteStudentItem.Text = "حذف الطالب المحدد";
            // 
            // btnUpdateStudentInfo
            // 
            this.btnUpdateStudentInfo.BorderRadius = 20;
            this.btnUpdateStudentInfo.BorderThickness = 1;
            this.btnUpdateStudentInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateStudentInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateStudentInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateStudentInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateStudentInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnUpdateStudentInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudentInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudentInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnUpdateStudentInfo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdateStudentInfo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnUpdateStudentInfo.Location = new System.Drawing.Point(1121, 814);
            this.btnUpdateStudentInfo.Name = "btnUpdateStudentInfo";
            this.btnUpdateStudentInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdateStudentInfo.Size = new System.Drawing.Size(293, 61);
            this.btnUpdateStudentInfo.TabIndex = 14;
            this.btnUpdateStudentInfo.Text = "تعديل معلومات لطالب المحدد";
            this.btnUpdateStudentInfo.TextOffset = new System.Drawing.Point(15, 0);
            this.btnUpdateStudentInfo.Click += new System.EventHandler(this.btnUpdateStudentInfo_Click);
            // 
            // btnShowStudentInfo
            // 
            this.btnShowStudentInfo.BorderRadius = 20;
            this.btnShowStudentInfo.BorderThickness = 1;
            this.btnShowStudentInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowStudentInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowStudentInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowStudentInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowStudentInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnShowStudentInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStudentInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowStudentInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnShowStudentInfo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnShowStudentInfo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnShowStudentInfo.Location = new System.Drawing.Point(742, 814);
            this.btnShowStudentInfo.Name = "btnShowStudentInfo";
            this.btnShowStudentInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnShowStudentInfo.Size = new System.Drawing.Size(293, 61);
            this.btnShowStudentInfo.TabIndex = 15;
            this.btnShowStudentInfo.Text = "عرض معلومات الطالب المحدد";
            this.btnShowStudentInfo.TextOffset = new System.Drawing.Point(15, 0);
            this.btnShowStudentInfo.Click += new System.EventHandler(this.btnShowStudentInfo_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BorderRadius = 20;
            this.btnDeleteStudent.BorderThickness = 1;
            this.btnDeleteStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnDeleteStudent.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnDeleteStudent.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteStudent.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnDeleteStudent.Location = new System.Drawing.Point(378, 814);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteStudent.Size = new System.Drawing.Size(293, 61);
            this.btnDeleteStudent.TabIndex = 16;
            this.btnDeleteStudent.Text = "حذف الطالب المحدد";
            this.btnDeleteStudent.TextOffset = new System.Drawing.Point(20, 0);
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // cmbPeriodes
            // 
            this.cmbPeriodes.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeriodes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cmbPeriodes.BorderThickness = 2;
            this.cmbPeriodes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriodes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriodes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPeriodes.ItemHeight = 40;
            this.cmbPeriodes.Items.AddRange(new object[] {
            "الكل"});
            this.cmbPeriodes.Location = new System.Drawing.Point(27, 207);
            this.cmbPeriodes.Name = "cmbPeriodes";
            this.cmbPeriodes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPeriodes.Size = new System.Drawing.Size(252, 46);
            this.cmbPeriodes.TabIndex = 18;
            this.cmbPeriodes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmbPeriodes.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodes_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(1121, 53);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtSearch.PlaceholderText = "بحث بالإسم";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(340, 64);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel1.Location = new System.Drawing.Point(1206, 154);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(255, 53);
            this.guna2Panel1.TabIndex = 20;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel2.Location = new System.Drawing.Point(930, 154);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(251, 53);
            this.guna2Panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "الجامعات";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel3.Location = new System.Drawing.Point(628, 154);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(256, 53);
            this.guna2Panel3.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "التخصصات";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel4.Location = new System.Drawing.Point(335, 154);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(256, 53);
            this.guna2Panel4.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "المستويات";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.label5);
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel5.Location = new System.Drawing.Point(27, 154);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(255, 53);
            this.guna2Panel5.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "فترة الدراسة";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::StudentsManagmentProject.Properties.Resources.arrow_dotted_rotate_anticlockwise_10x;
            this.btnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRefresh.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(210, 51);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRefresh.Size = new System.Drawing.Size(220, 66);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.TextOffset = new System.Drawing.Point(30, 0);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 20;
            this.btnPrint.BorderThickness = 1;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::StudentsManagmentProject.Properties.Resources.print_10x;
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrint.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPrint.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrint.Location = new System.Drawing.Point(508, 51);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrint.Size = new System.Drawing.Size(220, 66);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.BorderRadius = 20;
            this.btnAddNewStudent.BorderThickness = 1;
            this.btnAddNewStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnAddNewStudent.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddNewStudent.Image = global::StudentsManagmentProject.Properties.Resources.square_plus_10x;
            this.btnAddNewStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddNewStudent.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnAddNewStudent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewStudent.Location = new System.Drawing.Point(787, 51);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddNewStudent.Size = new System.Drawing.Size(293, 66);
            this.btnAddNewStudent.TabIndex = 4;
            this.btnAddNewStudent.Text = "إضافة طالب جديد";
            this.btnAddNewStudent.TextOffset = new System.Drawing.Point(30, 0);
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // btnPrintTheReport
            // 
            this.btnPrintTheReport.BorderRadius = 20;
            this.btnPrintTheReport.BorderThickness = 1;
            this.btnPrintTheReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintTheReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintTheReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintTheReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintTheReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnPrintTheReport.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTheReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintTheReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnPrintTheReport.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrintTheReport.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnPrintTheReport.Image = global::StudentsManagmentProject.Properties.Resources.file_content_10x;
            this.btnPrintTheReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrintTheReport.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPrintTheReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrintTheReport.Location = new System.Drawing.Point(27, 814);
            this.btnPrintTheReport.Name = "btnPrintTheReport";
            this.btnPrintTheReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrintTheReport.Size = new System.Drawing.Size(308, 61);
            this.btnPrintTheReport.TabIndex = 3;
            this.btnPrintTheReport.Text = "طباعة التقرير pdf";
            this.btnPrintTheReport.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // UsStudentsInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbPeriodes);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnShowStudentInfo);
            this.Controls.Add(this.btnUpdateStudentInfo);
            this.Controls.Add(this.dgvShowStudentsInfo);
            this.Controls.Add(this.cmbLevelsFilter);
            this.Controls.Add(this.cmbMajorsFilter);
            this.Controls.Add(this.cmbUniversitiesFilter);
            this.Controls.Add(this.cmbStudentsFilter);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.btnPrintTheReport);
            this.Name = "UsStudentsInformations";
            this.Size = new System.Drawing.Size(1470, 887);
            this.Load += new System.EventHandler(this.UsStudentsInformations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudentsInfo)).EndInit();
            this.cmStripStudenUserControl.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnPrintTheReport;
        private Guna.UI2.WinForms.Guna2Button btnAddNewStudent;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStudentsFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUniversitiesFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMajorsFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLevelsFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShowStudentsInfo;
        private System.Windows.Forms.ToolStripMenuItem ShowStudentInfoItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentInfoItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentItem;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip cmStripStudenUserControl;
        private Guna.UI2.WinForms.Guna2Button btnUpdateStudentInfo;
        private Guna.UI2.WinForms.Guna2Button btnShowStudentInfo;
        private Guna.UI2.WinForms.Guna2Button btnDeleteStudent;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeriodes;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
