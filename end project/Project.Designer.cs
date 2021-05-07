
namespace end_project
{
    partial class Project
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
            this.components = new System.ComponentModel.Container();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProPic = new System.Windows.Forms.PictureBox();
            this.UserNameLb = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.accountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProjectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ResourcesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TasksBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DashBordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.endProjectDataSet = new end_project.EndProjectDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new end_project.EndProjectDataSetTableAdapters.ProjectsTableAdapter();
            this.tableAdapterManager = new end_project.EndProjectDataSetTableAdapters.TableAdapterManager();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProPic)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(140)))), ((int)(((byte)(203)))));
            this.guna2GradientPanel1.Controls.Add(this.guna2Panel2);
            this.guna2GradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.BorderRadius = 50;
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 667);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.guna2Panel2.Controls.Add(this.ProPic);
            this.guna2Panel2.Controls.Add(this.UserNameLb);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(200, 161);
            this.guna2Panel2.TabIndex = 3;
            // 
            // ProPic
            // 
            this.ProPic.Image = global::end_project.Properties.Resources.Group1;
            this.ProPic.Location = new System.Drawing.Point(56, 12);
            this.ProPic.Name = "ProPic";
            this.ProPic.Size = new System.Drawing.Size(87, 87);
            this.ProPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProPic.TabIndex = 0;
            this.ProPic.TabStop = false;
            // 
            // UserNameLb
            // 
            this.UserNameLb.AutoSize = true;
            this.UserNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLb.ForeColor = System.Drawing.Color.White;
            this.UserNameLb.Location = new System.Drawing.Point(52, 112);
            this.UserNameLb.Name = "UserNameLb";
            this.UserNameLb.Size = new System.Drawing.Size(89, 20);
            this.UserNameLb.TabIndex = 1;
            this.UserNameLb.Text = "User Name";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.guna2Panel1.Controls.Add(this.accountBtn);
            this.guna2Panel1.Controls.Add(this.ProjectBtn);
            this.guna2Panel1.Controls.Add(this.ResourcesBtn);
            this.guna2Panel1.Controls.Add(this.TasksBtn);
            this.guna2Panel1.Controls.Add(this.DashBordBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 157);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(200, 510);
            this.guna2Panel1.TabIndex = 2;
            // 
            // accountBtn
            // 
            this.accountBtn.Animated = true;
            this.accountBtn.BackColor = System.Drawing.Color.Transparent;
            this.accountBtn.CheckedState.Parent = this.accountBtn;
            this.accountBtn.CustomImages.Parent = this.accountBtn;
            this.accountBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accountBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.accountBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.accountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.accountBtn.HoverState.Parent = this.accountBtn;
            this.accountBtn.Image = global::end_project.Properties.Resources.Vector;
            this.accountBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.accountBtn.ImageOffset = new System.Drawing.Point(30, 0);
            this.accountBtn.Location = new System.Drawing.Point(0, 468);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.ShadowDecoration.Parent = this.accountBtn;
            this.accountBtn.Size = new System.Drawing.Size(200, 42);
            this.accountBtn.TabIndex = 4;
            this.accountBtn.Text = "account";
            this.accountBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.accountBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.accountBtn.UseTransparentBackground = true;
            // 
            // ProjectBtn
            // 
            this.ProjectBtn.Animated = true;
            this.ProjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProjectBtn.CheckedState.Parent = this.ProjectBtn;
            this.ProjectBtn.CustomImages.Parent = this.ProjectBtn;
            this.ProjectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.ProjectBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ProjectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.ProjectBtn.HoverState.Parent = this.ProjectBtn;
            this.ProjectBtn.Image = global::end_project.Properties.Resources.Vector2222;
            this.ProjectBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ProjectBtn.ImageOffset = new System.Drawing.Point(30, 0);
            this.ProjectBtn.Location = new System.Drawing.Point(0, 126);
            this.ProjectBtn.Name = "ProjectBtn";
            this.ProjectBtn.ShadowDecoration.Parent = this.ProjectBtn;
            this.ProjectBtn.Size = new System.Drawing.Size(200, 42);
            this.ProjectBtn.TabIndex = 4;
            this.ProjectBtn.Text = "Project";
            this.ProjectBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProjectBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.ProjectBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.ProjectBtn.UseTransparentBackground = true;
            // 
            // ResourcesBtn
            // 
            this.ResourcesBtn.Animated = true;
            this.ResourcesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResourcesBtn.CheckedState.Parent = this.ResourcesBtn;
            this.ResourcesBtn.CustomImages.Parent = this.ResourcesBtn;
            this.ResourcesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResourcesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.ResourcesBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ResourcesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.ResourcesBtn.HoverState.Parent = this.ResourcesBtn;
            this.ResourcesBtn.Image = global::end_project.Properties.Resources.grommet_icons_resources1;
            this.ResourcesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ResourcesBtn.ImageOffset = new System.Drawing.Point(30, 0);
            this.ResourcesBtn.Location = new System.Drawing.Point(0, 84);
            this.ResourcesBtn.Name = "ResourcesBtn";
            this.ResourcesBtn.ShadowDecoration.Parent = this.ResourcesBtn;
            this.ResourcesBtn.Size = new System.Drawing.Size(200, 42);
            this.ResourcesBtn.TabIndex = 4;
            this.ResourcesBtn.Text = "Resources";
            this.ResourcesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ResourcesBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.ResourcesBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.ResourcesBtn.UseTransparentBackground = true;
            this.ResourcesBtn.Click += new System.EventHandler(this.ResourcesBtn_Click);
            // 
            // TasksBtn
            // 
            this.TasksBtn.Animated = true;
            this.TasksBtn.BackColor = System.Drawing.Color.Transparent;
            this.TasksBtn.CheckedState.Parent = this.TasksBtn;
            this.TasksBtn.CustomImages.Parent = this.TasksBtn;
            this.TasksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TasksBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.TasksBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TasksBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.TasksBtn.HoverState.Parent = this.TasksBtn;
            this.TasksBtn.Image = global::end_project.Properties.Resources.carbon_document_tasks2;
            this.TasksBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TasksBtn.ImageOffset = new System.Drawing.Point(27, 0);
            this.TasksBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.TasksBtn.Location = new System.Drawing.Point(0, 42);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.ShadowDecoration.Parent = this.TasksBtn;
            this.TasksBtn.Size = new System.Drawing.Size(200, 42);
            this.TasksBtn.TabIndex = 4;
            this.TasksBtn.Text = "Tasks";
            this.TasksBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TasksBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.TasksBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.TasksBtn.UseTransparentBackground = true;
            this.TasksBtn.Click += new System.EventHandler(this.TasksBtn_Click);
            // 
            // DashBordBtn
            // 
            this.DashBordBtn.Animated = true;
            this.DashBordBtn.BackColor = System.Drawing.Color.Transparent;
            this.DashBordBtn.CheckedState.Parent = this.DashBordBtn;
            this.DashBordBtn.CustomImages.Parent = this.DashBordBtn;
            this.DashBordBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.DashBordBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DashBordBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.DashBordBtn.HoverState.Parent = this.DashBordBtn;
            this.DashBordBtn.Image = global::end_project.Properties.Resources.dashicons_admin_home1;
            this.DashBordBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DashBordBtn.ImageOffset = new System.Drawing.Point(25, 0);
            this.DashBordBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.DashBordBtn.Location = new System.Drawing.Point(0, 0);
            this.DashBordBtn.Name = "DashBordBtn";
            this.DashBordBtn.ShadowDecoration.Parent = this.DashBordBtn;
            this.DashBordBtn.Size = new System.Drawing.Size(200, 42);
            this.DashBordBtn.TabIndex = 4;
            this.DashBordBtn.Text = "DashBoard";
            this.DashBordBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashBordBtn.TextOffset = new System.Drawing.Point(30, 3);
            this.DashBordBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.DashBordBtn.UseTransparentBackground = true;
            this.DashBordBtn.Click += new System.EventHandler(this.DashBordBtn_Click);
            // 
            // endProjectDataSet
            // 
            this.endProjectDataSet.DataSetName = "EndProjectDataSet";
            this.endProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.endProjectDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProjectsTableAdapter = this.projectsTableAdapter;
            this.tableAdapterManager.resourceTableAdapter = null;
            this.tableAdapterManager.TaskInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = end_project.EndProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.AutoGenerateColumns = false;
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.projectsDataGridView.DataSource = this.projectsBindingSource;
            this.projectsDataGridView.Location = new System.Drawing.Point(200, 0);
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.Size = new System.Drawing.Size(443, 667);
            this.projectsDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Project_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Project_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Project_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Project_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Strat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Strat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "END";
            this.dataGridViewTextBoxColumn4.HeaderText = "END";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(842, 233);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 25);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(664, 227);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(171, 39);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Total cost =";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(664, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 28);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "Projects Name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(664, 149);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(241, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Choose The Project To Know The Total Cost For It";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(664, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(235, 13);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Choose The Task you want to edit its information";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(664, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 28);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.Text = "choose Project";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(952, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(188, 13);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Choose The Project you want to delete";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(952, 48);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(153, 28);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.Text = "choose Project";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(853, 429);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(11, 25);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "0";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(664, 421);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(184, 39);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "Total Time =";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(664, 370);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(153, 28);
            this.comboBox4.TabIndex = 28;
            this.comboBox4.Text = "Projects Name";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(664, 343);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(239, 13);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Choose The Project To Know The Total time For It";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(664, 530);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(206, 13);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "Choose The Project to show its gantt chart";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(664, 549);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(153, 28);
            this.comboBox5.TabIndex = 31;
            this.comboBox5.Text = "choose Project";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1205, 667);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.projectsDataGridView);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Project_FormClosing);
            this.Load += new System.EventHandler(this.Project_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProPic)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.endProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.PictureBox ProPic;
        private System.Windows.Forms.Label UserNameLb;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button accountBtn;
        private Guna.UI2.WinForms.Guna2Button ProjectBtn;
        private Guna.UI2.WinForms.Guna2Button ResourcesBtn;
        private Guna.UI2.WinForms.Guna2Button TasksBtn;
        private Guna.UI2.WinForms.Guna2Button DashBordBtn;
        private EndProjectDataSet endProjectDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private EndProjectDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private EndProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projectsDataGridView;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox comboBox3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox comboBox4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}