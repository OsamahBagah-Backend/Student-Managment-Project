namespace StudentsManagmentProject
{
    partial class FrmMainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainInterface));
            this.pnlMainCountainer = new Guna.UI2.WinForms.Guna2Panel();
            this.InformationMenue = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContainAllUserControls = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmStripStudenUserControl = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ShowStudentInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExite = new Guna.UI2.WinForms.Guna2Button();
            this.btnAboutProgrammers = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsersManagment = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployeeManagment = new Guna.UI2.WinForms.Guna2Button();
            this.btnBledgeManagment = new Guna.UI2.WinForms.Guna2Button();
            this.btnExpenses = new Guna.UI2.WinForms.Guna2Button();
            this.btnActivitesManagment = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentInformation = new Guna.UI2.WinForms.Guna2Button();
            this.btnHomeBage = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlMainCountainer.SuspendLayout();
            this.InformationMenue.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.cmStripStudenUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainCountainer
            // 
            this.pnlMainCountainer.Controls.Add(this.InformationMenue);
            this.pnlMainCountainer.Controls.Add(this.guna2Panel1);
            this.pnlMainCountainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainCountainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainCountainer.Name = "pnlMainCountainer";
            this.pnlMainCountainer.Size = new System.Drawing.Size(1924, 1033);
            this.pnlMainCountainer.TabIndex = 1;
            // 
            // InformationMenue
            // 
            this.InformationMenue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InformationMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.InformationMenue.BorderColor = System.Drawing.Color.White;
            this.InformationMenue.BorderRadius = 30;
            this.InformationMenue.BorderThickness = 1;
            this.InformationMenue.Controls.Add(this.pnContainAllUserControls);
            this.InformationMenue.FillColor = System.Drawing.Color.White;
            this.InformationMenue.Location = new System.Drawing.Point(21, 23);
            this.InformationMenue.Name = "InformationMenue";
            this.InformationMenue.Size = new System.Drawing.Size(1512, 930);
            this.InformationMenue.TabIndex = 3;
            // 
            // pnContainAllUserControls
            // 
            this.pnContainAllUserControls.BackColor = System.Drawing.Color.White;
            this.pnContainAllUserControls.Location = new System.Drawing.Point(18, 28);
            this.pnContainAllUserControls.Name = "pnContainAllUserControls";
            this.pnContainAllUserControls.Size = new System.Drawing.Size(1470, 887);
            this.pnContainAllUserControls.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.ContextMenuStrip = this.cmStripStudenUserControl;
            this.guna2Panel1.Controls.Add(this.btnExite);
            this.guna2Panel1.Controls.Add(this.btnAboutProgrammers);
            this.guna2Panel1.Controls.Add(this.btnUsersManagment);
            this.guna2Panel1.Controls.Add(this.btnEmployeeManagment);
            this.guna2Panel1.Controls.Add(this.btnBledgeManagment);
            this.guna2Panel1.Controls.Add(this.btnExpenses);
            this.guna2Panel1.Controls.Add(this.btnActivitesManagment);
            this.guna2Panel1.Controls.Add(this.btnStudentInformation);
            this.guna2Panel1.Controls.Add(this.btnHomeBage);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(1569, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(355, 1033);
            this.guna2Panel1.TabIndex = 2;
            // 
            // cmStripStudenUserControl
            // 
            this.cmStripStudenUserControl.BackColor = System.Drawing.Color.DarkGray;
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
            this.cmStripStudenUserControl.RenderStyle.RoundedEdges = true;
            this.cmStripStudenUserControl.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmStripStudenUserControl.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.cmStripStudenUserControl.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmStripStudenUserControl.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.cmStripStudenUserControl.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
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
            // btnExite
            // 
            this.btnExite.Animated = true;
            this.btnExite.BorderColor = System.Drawing.Color.Transparent;
            this.btnExite.BorderRadius = 20;
            this.btnExite.BorderThickness = 1;
            this.btnExite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExite.FillColor = System.Drawing.Color.Transparent;
            this.btnExite.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExite.ForeColor = System.Drawing.Color.White;
            this.btnExite.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnExite.HoverState.FillColor = System.Drawing.Color.White;
            this.btnExite.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnExite.HoverState.Image = global::StudentsManagmentProject.Properties.Resources.z1;
            this.btnExite.Image = global::StudentsManagmentProject.Properties.Resources.arrow_door_out_3_4x;
            this.btnExite.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExite.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExite.Location = new System.Drawing.Point(21, 942);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(331, 65);
            this.btnExite.TabIndex = 19;
            this.btnExite.Text = "تسجيل الخروج";
            this.btnExite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExite.TextOffset = new System.Drawing.Point(-8, 0);
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // btnAboutProgrammers
            // 
            this.btnAboutProgrammers.Animated = true;
            this.btnAboutProgrammers.BorderColor = System.Drawing.Color.Transparent;
            this.btnAboutProgrammers.BorderRadius = 20;
            this.btnAboutProgrammers.BorderThickness = 1;
            this.btnAboutProgrammers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAboutProgrammers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAboutProgrammers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAboutProgrammers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAboutProgrammers.FillColor = System.Drawing.Color.Transparent;
            this.btnAboutProgrammers.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutProgrammers.ForeColor = System.Drawing.Color.White;
            this.btnAboutProgrammers.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAboutProgrammers.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAboutProgrammers.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnAboutProgrammers.HoverState.Image = global::StudentsManagmentProject.Properties.Resources._٢٠٢٤١١١٢_١٠٠٣١٣;
            this.btnAboutProgrammers.Image = global::StudentsManagmentProject.Properties.Resources._٢٠٢٤١١١٢_١٠٠٣٠٣;
            this.btnAboutProgrammers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAboutProgrammers.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnAboutProgrammers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAboutProgrammers.Location = new System.Drawing.Point(8, 806);
            this.btnAboutProgrammers.Name = "btnAboutProgrammers";
            this.btnAboutProgrammers.Size = new System.Drawing.Size(344, 65);
            this.btnAboutProgrammers.TabIndex = 18;
            this.btnAboutProgrammers.Text = "عن المبرمج";
            this.btnAboutProgrammers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAboutProgrammers.TextOffset = new System.Drawing.Point(-8, 0);
            this.btnAboutProgrammers.Click += new System.EventHandler(this.btnAboutProgrammers_Click_1);
            // 
            // btnUsersManagment
            // 
            this.btnUsersManagment.Animated = true;
            this.btnUsersManagment.BorderColor = System.Drawing.Color.Transparent;
            this.btnUsersManagment.BorderRadius = 20;
            this.btnUsersManagment.BorderThickness = 1;
            this.btnUsersManagment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnUsersManagment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsersManagment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnUsersManagment.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnUsersManagment.FillColor = System.Drawing.Color.Transparent;
            this.btnUsersManagment.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersManagment.ForeColor = System.Drawing.Color.White;
            this.btnUsersManagment.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUsersManagment.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUsersManagment.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnUsersManagment.HoverState.Image = global::StudentsManagmentProject.Properties.Resources.user_laptop_4x;
            this.btnUsersManagment.Image = global::StudentsManagmentProject.Properties.Resources.e1;
            this.btnUsersManagment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUsersManagment.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnUsersManagment.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsersManagment.Location = new System.Drawing.Point(5, 719);
            this.btnUsersManagment.Name = "btnUsersManagment";
            this.btnUsersManagment.Size = new System.Drawing.Size(347, 65);
            this.btnUsersManagment.TabIndex = 17;
            this.btnUsersManagment.Text = "إدارة الحسابات";
            this.btnUsersManagment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsersManagment.TextOffset = new System.Drawing.Point(-8, 0);
            this.btnUsersManagment.Click += new System.EventHandler(this.btnUsersManagment_Click);
            // 
            // btnEmployeeManagment
            // 
            this.btnEmployeeManagment.Animated = true;
            this.btnEmployeeManagment.BorderColor = System.Drawing.Color.Transparent;
            this.btnEmployeeManagment.BorderRadius = 20;
            this.btnEmployeeManagment.BorderThickness = 1;
            this.btnEmployeeManagment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnEmployeeManagment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeManagment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnEmployeeManagment.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnEmployeeManagment.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployeeManagment.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagment.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeManagment.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnEmployeeManagment.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEmployeeManagment.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnEmployeeManagment.HoverState.Image = global::StudentsManagmentProject.Properties.Resources._٢٠٢٤١١١٢_١٠٠٦٢٣;
            this.btnEmployeeManagment.Image = global::StudentsManagmentProject.Properties.Resources._٢٠٢٤١١١٢_١٠٠٦٠٨;
            this.btnEmployeeManagment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEmployeeManagment.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnEmployeeManagment.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployeeManagment.Location = new System.Drawing.Point(5, 627);
            this.btnEmployeeManagment.Name = "btnEmployeeManagment";
            this.btnEmployeeManagment.Size = new System.Drawing.Size(347, 65);
            this.btnEmployeeManagment.TabIndex = 16;
            this.btnEmployeeManagment.Text = "إدارة الموظفين";
            this.btnEmployeeManagment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployeeManagment.TextOffset = new System.Drawing.Point(-8, 0);
            // 
            // btnBledgeManagment
            // 
            this.btnBledgeManagment.Animated = true;
            this.btnBledgeManagment.BorderColor = System.Drawing.Color.Transparent;
            this.btnBledgeManagment.BorderRadius = 20;
            this.btnBledgeManagment.BorderThickness = 1;
            this.btnBledgeManagment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnBledgeManagment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBledgeManagment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnBledgeManagment.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnBledgeManagment.FillColor = System.Drawing.Color.Transparent;
            this.btnBledgeManagment.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBledgeManagment.ForeColor = System.Drawing.Color.White;
            this.btnBledgeManagment.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnBledgeManagment.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBledgeManagment.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnBledgeManagment.HoverState.Image = global::StudentsManagmentProject.Properties.Resources._٢٠٢٤١١١٢_٠٩٥٩٣٠;
            this.btnBledgeManagment.Image = global::StudentsManagmentProject.Properties.Resources._٢٠٢٤١١١٢_٠٩٥٩٠٩;
            this.btnBledgeManagment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBledgeManagment.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnBledgeManagment.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBledgeManagment.Location = new System.Drawing.Point(2, 538);
            this.btnBledgeManagment.Name = "btnBledgeManagment";
            this.btnBledgeManagment.Size = new System.Drawing.Size(341, 65);
            this.btnBledgeManagment.TabIndex = 15;
            this.btnBledgeManagment.Text = "المخالفات";
            this.btnBledgeManagment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBledgeManagment.Click += new System.EventHandler(this.btnBledgeManagment_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Animated = true;
            this.btnExpenses.BorderColor = System.Drawing.Color.Transparent;
            this.btnExpenses.BorderRadius = 20;
            this.btnExpenses.BorderThickness = 1;
            this.btnExpenses.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnExpenses.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnExpenses.FillColor = System.Drawing.Color.Transparent;
            this.btnExpenses.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnExpenses.HoverState.FillColor = System.Drawing.Color.White;
            this.btnExpenses.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnExpenses.HoverState.Image = global::StudentsManagmentProject.Properties.Resources.wsq1;
            this.btnExpenses.Image = global::StudentsManagmentProject.Properties.Resources.food_svgrepo_com;
            this.btnExpenses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExpenses.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnExpenses.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExpenses.Location = new System.Drawing.Point(2, 454);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(347, 65);
            this.btnExpenses.TabIndex = 14;
            this.btnExpenses.Text = " المصروفات";
            this.btnExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExpenses.TextOffset = new System.Drawing.Point(-8, 0);
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click_1);
            // 
            // btnActivitesManagment
            // 
            this.btnActivitesManagment.Animated = true;
            this.btnActivitesManagment.BorderColor = System.Drawing.Color.Transparent;
            this.btnActivitesManagment.BorderRadius = 20;
            this.btnActivitesManagment.BorderThickness = 1;
            this.btnActivitesManagment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnActivitesManagment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActivitesManagment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnActivitesManagment.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnActivitesManagment.FillColor = System.Drawing.Color.Transparent;
            this.btnActivitesManagment.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivitesManagment.ForeColor = System.Drawing.Color.White;
            this.btnActivitesManagment.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnActivitesManagment.HoverState.FillColor = System.Drawing.Color.White;
            this.btnActivitesManagment.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnActivitesManagment.HoverState.Image = global::StudentsManagmentProject.Properties.Resources._٢٠٢٤١١٢٣_١٤٠٥٥٨;
            this.btnActivitesManagment.Image = global::StudentsManagmentProject.Properties.Resources._٢٠٢٤١١٢٣_١٤٠٤٣٨;
            this.btnActivitesManagment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnActivitesManagment.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnActivitesManagment.ImageSize = new System.Drawing.Size(40, 40);
            this.btnActivitesManagment.Location = new System.Drawing.Point(8, 374);
            this.btnActivitesManagment.Name = "btnActivitesManagment";
            this.btnActivitesManagment.Size = new System.Drawing.Size(341, 65);
            this.btnActivitesManagment.TabIndex = 13;
            this.btnActivitesManagment.Text = "إدارة الأنشطة";
            this.btnActivitesManagment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnStudentInformation
            // 
            this.btnStudentInformation.Animated = true;
            this.btnStudentInformation.BorderColor = System.Drawing.Color.Transparent;
            this.btnStudentInformation.BorderRadius = 20;
            this.btnStudentInformation.BorderThickness = 1;
            this.btnStudentInformation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnStudentInformation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnStudentInformation.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnStudentInformation.FillColor = System.Drawing.Color.Transparent;
            this.btnStudentInformation.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInformation.ForeColor = System.Drawing.Color.White;
            this.btnStudentInformation.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnStudentInformation.HoverState.FillColor = System.Drawing.Color.White;
            this.btnStudentInformation.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnStudentInformation.HoverState.Image = global::StudentsManagmentProject.Properties.Resources.users_4x;
            this.btnStudentInformation.Image = global::StudentsManagmentProject.Properties.Resources.ue1;
            this.btnStudentInformation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnStudentInformation.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnStudentInformation.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStudentInformation.Location = new System.Drawing.Point(8, 288);
            this.btnStudentInformation.Name = "btnStudentInformation";
            this.btnStudentInformation.Size = new System.Drawing.Size(341, 65);
            this.btnStudentInformation.TabIndex = 12;
            this.btnStudentInformation.Text = "إدارة الطلاب";
            this.btnStudentInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentInformation.Click += new System.EventHandler(this.btnStudentInformation_Click_1);
            // 
            // btnHomeBage
            // 
            this.btnHomeBage.Animated = true;
            this.btnHomeBage.BorderColor = System.Drawing.Color.Transparent;
            this.btnHomeBage.BorderRadius = 20;
            this.btnHomeBage.BorderThickness = 1;
            this.btnHomeBage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnHomeBage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHomeBage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnHomeBage.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnHomeBage.FillColor = System.Drawing.Color.Transparent;
            this.btnHomeBage.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeBage.ForeColor = System.Drawing.Color.White;
            this.btnHomeBage.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnHomeBage.HoverState.FillColor = System.Drawing.Color.White;
            this.btnHomeBage.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnHomeBage.HoverState.Image = global::StudentsManagmentProject.Properties.Resources.hom1;
            this.btnHomeBage.Image = global::StudentsManagmentProject.Properties.Resources.house_2_4x;
            this.btnHomeBage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHomeBage.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHomeBage.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHomeBage.Location = new System.Drawing.Point(8, 206);
            this.btnHomeBage.Name = "btnHomeBage";
            this.btnHomeBage.Size = new System.Drawing.Size(341, 65);
            this.btnHomeBage.TabIndex = 11;
            this.btnHomeBage.Text = "الرئيسية";
            this.btnHomeBage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHomeBage.Click += new System.EventHandler(this.btnHomeBage_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::StudentsManagmentProject.Properties.Resources._1730282098928;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(24, -33);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(316, 244);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FrmMainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.pnlMainCountainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMainInterface";
            this.Text = "الواجهه الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMainCountainer.ResumeLayout(false);
            this.InformationMenue.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.cmStripStudenUserControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMainCountainer;
        private Guna.UI2.WinForms.Guna2Panel InformationMenue;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnContainAllUserControls;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip cmStripStudenUserControl;
        private System.Windows.Forms.ToolStripMenuItem ShowStudentInfoItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentInfoItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentItem;
        private Guna.UI2.WinForms.Guna2Button btnHomeBage;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnStudentInformation;
        private Guna.UI2.WinForms.Guna2Button btnBledgeManagment;
        private Guna.UI2.WinForms.Guna2Button btnExpenses;
        private Guna.UI2.WinForms.Guna2Button btnActivitesManagment;
        private Guna.UI2.WinForms.Guna2Button btnUsersManagment;
        private Guna.UI2.WinForms.Guna2Button btnEmployeeManagment;
        private Guna.UI2.WinForms.Guna2Button btnAboutProgrammers;
        private Guna.UI2.WinForms.Guna2Button btnExite;
    }
}

