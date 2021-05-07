
namespace end_project
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResourcesNumberLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.tasksNumberLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.ProjectNumberLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.accountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProjectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ResourcesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TasksBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DashBordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserNameLb = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProPic = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProPic)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.guna2Panel6.Controls.Add(this.labelControl1);
            this.guna2Panel6.Controls.Add(this.chart);
            this.guna2Panel6.Location = new System.Drawing.Point(284, 198);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(897, 443);
            this.guna2Panel6.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Display", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 47);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Projects";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(38, 76);
            this.chart.Name = "chart";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomRight;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.CustomProperties = "BarLabelStyle=Outside, DrawingStyle=LightToDark";
            series1.Label = "#VALX";
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelBorderWidth = 0;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(826, 334);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // ResourcesNumberLab
            // 
            this.ResourcesNumberLab.AutoSize = true;
            this.ResourcesNumberLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResourcesNumberLab.ForeColor = System.Drawing.Color.White;
            this.ResourcesNumberLab.Location = new System.Drawing.Point(26, 72);
            this.ResourcesNumberLab.Name = "ResourcesNumberLab";
            this.ResourcesNumberLab.Size = new System.Drawing.Size(64, 46);
            this.ResourcesNumberLab.TabIndex = 5;
            this.ResourcesNumberLab.Text = "00";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resources";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.guna2Panel5.Controls.Add(this.ResourcesNumberLab);
            this.guna2Panel5.Controls.Add(this.guna2Button3);
            this.guna2Panel5.Controls.Add(this.label3);
            this.guna2Panel5.Location = new System.Drawing.Point(902, 25);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(280, 146);
            this.guna2Panel5.TabIndex = 10;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::end_project.Properties.Resources.add;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.Location = new System.Drawing.Point(130, 45);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(129, 45);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Add Resources";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // tasksNumberLab
            // 
            this.tasksNumberLab.AutoSize = true;
            this.tasksNumberLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksNumberLab.ForeColor = System.Drawing.Color.White;
            this.tasksNumberLab.Location = new System.Drawing.Point(26, 72);
            this.tasksNumberLab.Name = "tasksNumberLab";
            this.tasksNumberLab.Size = new System.Drawing.Size(64, 46);
            this.tasksNumberLab.TabIndex = 2;
            this.tasksNumberLab.Text = "00";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tsaks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.guna2Panel4.Controls.Add(this.guna2Button2);
            this.guna2Panel4.Controls.Add(this.tasksNumberLab);
            this.guna2Panel4.Controls.Add(this.label2);
            this.guna2Panel4.Location = new System.Drawing.Point(592, 24);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(280, 146);
            this.guna2Panel4.TabIndex = 11;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::end_project.Properties.Resources.add;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Location = new System.Drawing.Point(130, 45);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(129, 45);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Add Tasks";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // ProjectNumberLab
            // 
            this.ProjectNumberLab.AutoSize = true;
            this.ProjectNumberLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNumberLab.ForeColor = System.Drawing.Color.White;
            this.ProjectNumberLab.Location = new System.Drawing.Point(30, 74);
            this.ProjectNumberLab.Name = "ProjectNumberLab";
            this.ProjectNumberLab.Size = new System.Drawing.Size(64, 46);
            this.ProjectNumberLab.TabIndex = 1;
            this.ProjectNumberLab.Text = "00";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Controls.Add(this.ProjectNumberLab);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Location = new System.Drawing.Point(284, 22);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 5;
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(280, 146);
            this.guna2Panel3.TabIndex = 12;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::end_project.Properties.Resources.add;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(130, 45);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(129, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Add Project";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.ProjectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.ProjectBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ProjectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.ProjectBtn.HoverState.Parent = this.ProjectBtn;
            this.ProjectBtn.Image = global::end_project.Properties.Resources.Vector22;
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
            this.ProjectBtn.Click += new System.EventHandler(this.ProjectBtn_Click);
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
            this.TasksBtn.ImageOffset = new System.Drawing.Point(28, 0);
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
            this.DashBordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.DashBordBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DashBordBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(211)))));
            this.DashBordBtn.HoverState.Parent = this.DashBordBtn;
            this.DashBordBtn.Image = global::end_project.Properties.Resources.home_Hover;
            this.DashBordBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DashBordBtn.ImageOffset = new System.Drawing.Point(30, 0);
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
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataMember = "resource";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1205, 667);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProPic)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private System.Windows.Forms.Label ResourcesNumberLab;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label tasksNumberLab;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label ProjectNumberLab;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button accountBtn;
        private Guna.UI2.WinForms.Guna2Button ProjectBtn;
        private Guna.UI2.WinForms.Guna2Button ResourcesBtn;
        private Guna.UI2.WinForms.Guna2Button TasksBtn;
        private Guna.UI2.WinForms.Guna2Button DashBordBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox ProPic;
        private System.Windows.Forms.Label UserNameLb;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

