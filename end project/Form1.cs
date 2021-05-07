using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end_project
{
    public partial class Form1 : Form
    {
        int resource_Count = 0;
        int project_Count = 0;
        int TaskInfo_Count = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void project()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("select *  from Projects", con);
                DataSet st = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(st, "Series1");
                chart.DataSource = st.Tables["Series1"];
                chart.Series["Series1"].XValueMember = "Project_Name";
                chart.Series["Series1"].YValueMembers = "END ,Strat";
                chart.Series["Series1"].LabelBackColor = Color.White;
                chart.Series["Series1"].LabelForeColor = Color.Black;
                while (count == 0)
                {
                    this.chart.Titles.Add("Projects");
                    count++;
                }
                chart.Series["Series1"].IsValueShownAsLabel = true;
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand cmd_resource = new SqlCommand("SELECT resource_id FROM resource", con);
                    SqlDataReader r_resource = cmd_resource.ExecuteReader();
                    while (r_resource.Read())
                    {
                        resource_Count++;
                    }
                    ResourcesNumberLab.Text = resource_Count++.ToString();
                }
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand cmd_Project = new SqlCommand("SELECT Project_id FROM Projects", con);
                    SqlDataReader r_project = cmd_Project.ExecuteReader();
                    while (r_project.Read())
                    {
                        project_Count++;
                    }
                    ProjectNumberLab.Text = project_Count++.ToString();
                }
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand cmd_task = new SqlCommand("SELECT task_id FROM TaskInfo", con);
                    SqlDataReader r_TaskInfo = cmd_task.ExecuteReader();
                    while (r_TaskInfo.Read())
                    {
                        TaskInfo_Count++;
                    }
                    tasksNumberLab.Text = TaskInfo_Count++.ToString();
                }
                chart.Series["Series1"].Points.AddXY(0, 10);
                project();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
           
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            Task obj = new Task();
            obj.Show();
            this.Hide();
        }


        private void ProjectBtn_Click(object sender, EventArgs e)
        {
            Project obj = new Project();
            this.Hide();
            obj.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ResourcesBtn_Click(object sender, EventArgs e)
        {
            Resources obj = new Resources();
            this.Hide();
            obj.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Add_Project obj = new Add_Project();
            obj.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            add_task obj = new add_task();
            obj.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            add_res obj = new add_res();
            obj.ShowDialog();
        }
    }
}
