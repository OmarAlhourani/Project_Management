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
    public partial class Gantt_chart : Form
    {
        string id = string.Empty;
        public Gantt_chart(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Gantt_chart_Load(object sender, EventArgs e)
        {
            
        }
        

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush textBrush = new SolidBrush(Color.Black);
            SolidBrush Brush = new SolidBrush(Color.WhiteSmoke);

            Pen pen = new Pen(textBrush);
            SolidBrush Brush_task = new SolidBrush(Color.Green);

            //draw area 
            g.FillRectangle(Brush, 29, 109, 1152, 533);
            //draw XY
            g.DrawLine(pen , 80 , 120 , 80, 610);
            g.DrawString("Task", this.Font, textBrush, 40, 377);
            //draw XA
            g.DrawLine(pen, 80, 610, 1150, 610);
            g.DrawString("Duration", this.Font, textBrush, 605, 615);

           
          
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True")) //here goes connStrng or the variable of it
                {
                    sqlConn.Open();
                    string sqlQuery_pro_time1 = "select  [task_name], [task_duration ] , [predecessor_task] from [dbo].[TaskInfo] where [Project] =" + id;
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_pro_time1, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                        int x = 80;
                        int y = 0;
                        while (reader.Read())
                            {
                                g.FillRectangle(Brush_task, (x + (int)reader[1]) , 120 + y, (x + (int)reader[1]), 30);
                                y = y + 50;
                                x = x + 80;
                            }

                        }
                    }
                }
            



        }
    }
}
