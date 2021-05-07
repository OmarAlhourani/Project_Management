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
    public partial class Project : Form
    {
        private decimal pro_COST = 0;
        private string[] selected = { };
        private string[] selected_id_delet = { };
        string[] selected_id_cost = { };
        string[] selected_id_time = { };
        string[] selected_id_gantt = { };
        public Project()
        {
            InitializeComponent();
        }

        private void fined_cost()
        {
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")) //here goes connStrng or the variable of it
            {
                selected_id_cost = Convert.ToString(comboBox1.SelectedItem).Split(':');
                sqlConn.Open();
                string sqlQuery_pro_COST = "select  TaskInfo. [task_duration ], resource.[resource_standard_rate ] from [dbo].[TaskInfo] INNER JOIN [dbo].[resource] ON TaskInfo.task_resource = resource.resource_id where [Project]= " + "'" + selected_id_cost[0] + "'";
                using (SqlCommand cmd = new SqlCommand(sqlQuery_pro_COST, sqlConn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pro_COST = pro_COST + ((int)reader[0] * (decimal)reader[1]);
                        }

                    }
                }
            }
        }
        private void Project_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'endProjectDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.endProjectDataSet.Projects);
            BindData obj = new BindData();
            projectsDataGridView.DataSource = obj.BindSource("[dbo].[Projects]");
            //load combobox
            edit_drop_list obj2 = new edit_drop_list();
            var list = obj2.load_drop2("[Project_id],[Project_Name]", "[dbo].[Projects]");
            int count = 0;
            while (count < list.Count)
            {
                comboBox1.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox2.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox3.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox4.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox5.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                count++;
            }

        }
        private void projectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.endProjectDataSet);
            Invalidate();
        }
        //col cost
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fined_cost();
            if (pro_COST == 0)
            {
                labelControl2.Text = "No tasks assigned for this project yet";
                pro_COST = 0;
            }
            else
            {
                labelControl2.Text = pro_COST + " JD";
                pro_COST = 0;
            }

        }
        private void TasksBtn_Click(object sender, EventArgs e)
        {
            Task obj = new Task();
            obj.Show();
            this.Hide();
        }
        private void DashBordBtn_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
        private void Project_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ResourcesBtn_Click(object sender, EventArgs e)
        {
            Resources obj = new Resources();
            this.Hide();
            obj.Show();
        }
        //col the other form
        //send obj from this form
        //send the id 
        //clear the combo
        //reload the combo
        //add the delegate of F3_UpdateEventHandler1 to the internal list that the UpdateEventHandler keeps track of
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = Convert.ToString(comboBox2.SelectedItem).Split(':');
            edit_project obj = new edit_project(selected[0], this);
            obj.UpdateEventHandler += F3_UpdateEventHandler1;
            obj.ShowDialog();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();

            edit_drop_list obj2 = new edit_drop_list();
            var list = obj2.load_drop2("[Project_id],[Project_Name]", "[dbo].[Projects]");
            int count = 0;
            while (count < list.Count)
            {
                comboBox1.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox2.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox3.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox4.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox5.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                count++;
            }
        }
        //col class BindData to reload the dataSource in it 
        private void F3_UpdateEventHandler1(object sender, edit_project.UpdateEventArgs args)
        {
            BindData obj = new BindData();
            projectsDataGridView.DataSource = obj.BindSource("[dbo].[Projects]");
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_id_delet = Convert.ToString(comboBox3.SelectedItem).Split(':');
            delete obj1 = new delete();
            obj1.delete_method("[dbo].[Projects]", "[Project_id]", Convert.ToInt32(selected_id_delet[0]));
            Project obj = new Project();
            obj.Show();
            this.Hide();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_id_time = Convert.ToString(comboBox4.SelectedItem).Split(':');
            project_time obj = new project_time();
            var list = obj.fined_time(selected_id_time[0]);
            int count = 0;
            int max = 0;
            while (count < list.Count)
            {
                if (list[count].E_F > max)
                {
                    max = list[count].E_F;
                }
                count++;
            }
            if (max == 0)
            {
                labelControl6.Text = "No tasks assigned for this project yet";
            }
            else
            {
                labelControl6.Text = Convert.ToString(max) + " Hours";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_id_gantt = Convert.ToString(comboBox5.SelectedItem).Split(':');
            Gantt_chart obj = new Gantt_chart(selected_id_gantt[0]);
            obj.ShowDialog();
        }
















        //private void select_avg()
        //{
            
        //    using (SqlConnection Connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV11;Initial Catalog=test222;Integrated Security=True;Connect Timeout=30;ApplicationIntent=ReadWrite;")) 
        //    {
        //        float avg = 0;
        //        int count = 0;
        //        Connection.Open();
        //        string select_avg = "select Age from [dbo].[Employee]";
        //        using (SqlCommand cmd = new SqlCommand(select_avg, Connection))
        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    avg = avg + ((int)reader[0]);
        //                    count++;
        //                }
        //                avg = avg / count;

        //            }
        //        }
        //        Connection.Close();
        //    }
        //}






















    }
}
