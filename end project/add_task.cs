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
    public partial class add_task : Form
    {
        public add_task()
        {
            InitializeComponent();
        }
        private void load_drop()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlConn.Open();
                    string sqlQuery_res_id_name = "SELECT [resource_id],[resource name] FROM [dbo].[resource]";
                    string sqlQuery_pro_id_name = "SELECT [Project_id],[Project_Name] FROM [dbo].[Projects]";
                    string sqlQuery_pro_task_name = "SELECT [task_name] FROM [dbo].[TaskInfo]";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_res_id_name, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add((int)reader[0] + ": " + (string)reader[1]);
                            }

                        }
                    }
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_pro_id_name, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox2.Items.Add((int)reader[0] + ": " + (string)reader[1]);
                            }

                        }
                    }
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_pro_task_name, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox3.Items.Add((string)reader[0]);
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Invalidate();

        }

        private void add_task_Load(object sender, EventArgs e)
        {
            load_drop();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string []Project = Convert.ToString(comboBox2.SelectedItem).Split(':');
            string []task_re = Convert.ToString(comboBox1.SelectedItem).Split(':');
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[TaskInfo]([task_name],[predecessor_task],[task_resource],[task_duration ],[Project] ) VALUES('" + textBox1.Text + "', '" + Convert.ToString(comboBox3.SelectedItem) + "', '" + Convert.ToString(task_re[0]) + "','" + textBox3.Text +"','"+ Convert.ToString(Project[0]) + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully.", "click ok to close", MessageBoxButtons.OK);
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();

        }
    }
}
