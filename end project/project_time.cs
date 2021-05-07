using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace end_project
{
    class project_time
    {
        public struct Data
        {
            public Data(int task_time1, int E_S1, int E_F1, string id)
            {
                task_time = task_time1;
                E_S = E_S1;
                E_F = E_F1;
                Name = id;
            }

            public int task_time { get; private set; }
            public int E_S { get; private set; }
            public int E_F { get; private set; }
            public string Name { get; private set; }
        }
        public int es = 0;
        public int ef = 0;
        public List<Data> fined_time(string id)
        {
            var list = new List<Data>();
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True")) //here goes connStrng or the variable of it
            {
                sqlConn.Open();
                string sqlQuery_pro_time1 = "select  [task_name], [task_duration ] , [predecessor_task] from [dbo].[TaskInfo] where [Project] =" + id;
                using (SqlCommand cmd = new SqlCommand(sqlQuery_pro_time1, sqlConn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if ((string)reader[2] == "")
                            {
                                es = 0;
                                ef = es + (int)reader[1];
                                list.Add(new Data((int)reader[1], es, ef, (string)reader[0]));
                            }
                            else
                            {
                                Data enstens = list.Find(x => x.Name == (string)reader[2]);
                                var es = enstens.E_F;
                                list.Add(new Data((int)reader[1], es, (es + (int)reader[1]), (string)reader[0]));
                            }
                        }

                    }
                }
            }
            return (list);
        }
    }
}
