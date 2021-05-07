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
    public partial class add_res : Form
    {
        public add_res()
        {
            InitializeComponent();
        }
        

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            decimal x = Convert.ToDecimal(textBox3.Text);
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[resource]([resource name ],[resource_standard_rate ]) VALUES('" + textBox1.Text + "', '" + Convert.ToString(x) + "')", con);
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
