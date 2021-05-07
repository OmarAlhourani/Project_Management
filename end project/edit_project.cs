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
    public partial class edit_project : Form
    {
        private string id = string.Empty;
        private DateTime start;
        private string short_start;
        private DateTime end;
        private string short_end;

        
        public edit_project(string selected_id , Project pro)
        {
            this.id = selected_id;
            pro2 = pro;
            InitializeComponent();
        }
        private void load_project()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlConn.Open();
                    string sqlQuery_res_id = "SELECT [Project_Name],[Strat],[END] FROM [dbo].[Projects] WHERE [Project_id] =" + "'" + id + "'";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_res_id, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                start = (DateTime)reader[1];
                                short_start = start.ToShortDateString();
                                short_start = String.Format("{0:MM/dd/yyyy}", short_start);
                                end = (DateTime)reader[1];
                                short_end = start.ToShortDateString();
                                short_end = String.Format("{0:MM/dd/yyyy}", short_end);
                                textBox1.Text = Convert.ToString((string)reader[0]);
                                dateEdit1.Text = Convert.ToString(start);
                                dateEdit2.Text = Convert.ToString(end);

                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void save_edit_project()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Projects] SET [Project_Name]=" + "'" + textBox1.Text + "'" + ",[Strat] =" + "'" + dateEdit1.Text + "'" + ",[END]=" + "'" + dateEdit2.Text + "'"+ " WHERE [Project_id] =" + "'" + id + "'", con);
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

        private void edit_project_Load(object sender, EventArgs e)
        {
            load_project();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            save_edit_project();
        }


        //reload the data
        Project pro2 = new Project();
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
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
