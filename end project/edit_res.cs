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
    public partial class edit_res : Form
    {
        private string id = string.Empty;
        public edit_res(string selected_id , Resources res)
        {
            this.id = selected_id;
            res2 = res;
            InitializeComponent();
        }
        
        private void load_task()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlConn.Open();
                    string sqlQuery_res_id = "SELECT [resource name ],[resource_standard_rate ]  FROM [dbo].[resource] WHERE [resource_id] =" + "'" + id + "'";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_res_id, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                textBox1.Text = Convert.ToString((string)reader[0]);
                                textBox3.Text = Convert.ToString((decimal)reader[1]);
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
        private void save_edit_project()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE [dbo].[resource] SET [resource name ]=" + "'" + textBox1.Text + "'" + ",[resource_standard_rate ] =" + "'" + textBox3.Text + "'" + " WHERE [resource_id] =" + "'" + id + "'", con);
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
        private void edit_res_Load(object sender, EventArgs e)
        {
            load_task();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            save_edit_project();
            Resources obj = new Resources();
            this.Close();
        }


        //reload the data
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        Resources res2 = new Resources();
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
