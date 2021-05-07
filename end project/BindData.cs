using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace end_project
{
    class BindData
    {
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public DataTable BindSource(string table)
        {
            string sqlCon = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlSelect = @"SELECT * FROM " + table;
            using (SqlConnection conn = new SqlConnection(sqlCon))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        ds.Clear();
                        adapter.Fill(ds);

                        dt = ds.Tables[0];
                        conn.Close();
                    }
                }
            }
            return dt;
        }
    }
}
