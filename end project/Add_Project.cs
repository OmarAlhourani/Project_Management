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
    public partial class Add_Project : Form
    {
        public Add_Project()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try 
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Projects]([Project_Name], [Strat] , [END]) VALUES('" + textBox1.Text + "', '" + dateEdit1.Text + "', '" + dateEdit2.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully." , "click ok to close" , MessageBoxButtons.OK);
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
