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
    public partial class edit_task : Form
    {
        private string id = string.Empty;
        
        public edit_task(string selected_id , Task task)
        {
            this.id = selected_id;
            obj = task;
            InitializeComponent();
        }

        //load form info
        private void load_task()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlConn.Open();
                    string sqlQuery_res_id = "SELECT [task_name],[predecessor_task],[task_resource],[task_duration ],[Project]  FROM [dbo].[TaskInfo] WHERE [task_id] =" + "'"+ id + "'";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_res_id, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                textBox1.Text = Convert.ToString((string)reader[0]);
                                comboBox3.Text = Convert.ToString((string)reader[1]);
                                comboBox1.Text = Convert.ToString((int)reader[2]);
                                textBox3.Text = Convert.ToString((int)reader[3]);
                                comboBox2.Text = Convert.ToString((int)reader[4]);
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
        //load the combo info in the form
        private void load_drop2()
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

        //save the edit in dataBase
        //col raiseUpdate to reload the grideviwe 
        private void save_edit_task()
        {
            string[] Project = Convert.ToString(comboBox2.SelectedItem).Split(':');
            if (Project[0] == "")
            {
                Project = Convert.ToString(comboBox2.Text).Split(':');
            }
            string[] task_re = Convert.ToString(comboBox1.SelectedItem).Split(':');
            if (task_re[0] == "")
            {
                task_re = Convert.ToString(comboBox1.Text).Split(':');
            }
            string[] pro_task = Convert.ToString(comboBox3.SelectedItem).Split(':');
            if (pro_task[0] == "")
            {
                pro_task = Convert.ToString(comboBox3.Text).Split(':');
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE [dbo].[TaskInfo] SET [task_name]=" + "'" + Convert.ToString(textBox1.Text) + "'" + ",[predecessor_task] =" + "'" + Convert.ToString(pro_task[0])  + "'" + ",[task_resource]=" + Convert.ToString(task_re[0]) + " ,[task_duration ] =" + Convert.ToString(textBox3.Text) + ",[Project] =" + Convert.ToString(Project[0]) + " WHERE [task_id] =" + Convert.ToString(id) , con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully.", "click ok to close", MessageBoxButtons.OK);
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            raiseUpdate();
        }

        //col load_task and load_drop2
        private void edit_task_Load(object sender, EventArgs e)
        {
            load_task();
            load_drop2();
        }

        //col save_edit_task
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            save_edit_task();
            this.Close();
        }

        //*****************************************************************************************************************************************//
        //reload the data
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        Task obj = new Task();
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }

    }
}
