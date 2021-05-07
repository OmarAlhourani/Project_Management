using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end_project
{
    class edit_drop_list
    {
        public struct Data
        {
            public Data(int intValue, string strValue)
            {
                IntegerData = intValue;
                StringData = strValue;
            }

            public int IntegerData { get; private set; }
            public string StringData { get; private set; }
        }
        public List<Data> load_drop2(string atr , string table)
        {
            var list = new List<Data>();
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    sqlConn.Open();
                    string sqlQuery_res_id = "SELECT "+ atr + "  FROM "+ table;
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_res_id, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new Data((int)reader[0] , (string)reader[1]));

                            }

                        }
                    }
                }
                return (list);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return (null);
        }


    }
}
