using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end_project
{
    class delete
    {
        public void delete_method(string table , string id , int selected_id)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlConn.Open();
                    string sqlQuery_res_id = "DELETE FROM " +table +" WHERE "+ id +"="+ selected_id;
                    SqlCommand cmd = new SqlCommand(sqlQuery_res_id, sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
