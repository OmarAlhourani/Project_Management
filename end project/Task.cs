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
    public partial class Task : Form
    {
        private int res_id = 1;
        private int task_time = 1;
        private decimal res_rate = 1;
        private string [] selected = { };
        string[] selected_id_delet = { };
        string[] selected_id_cost = { };
        public Task()
        {
            InitializeComponent();
        }

       
        private void fined_cost()
        {
            selected_id_cost = Convert.ToString(comboBox1.SelectedItem).Split(':');
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EndProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")) 
                {
                    sqlConn.Open();
                    string sqlQuery_res_id = "SELECT [task_resource],[task_duration]  FROM [dbo].[TaskInfo] WHERE  [task_id]= " + "'" + Convert.ToString(selected_id_cost[0]) + "'";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_res_id, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                res_id = (int)reader[0];
                                task_time = (int)reader[1];
                            }

                        }
                    }
                    string sqlQuery_res_rate = "SELECT [resource_standard_rate ] FROM [dbo].[resource] WHERE [resource_id]= " + "'" + Convert.ToString(res_id) + "'";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery_res_rate, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                res_rate = (decimal)reader[0];
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
        //load the comboboxes and the DataSource in the GridView
        private void Task_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'endProjectDataSet.TaskInfo' table. You can move, or remove it, as needed.
            this.taskInfoTableAdapter.Fill(this.endProjectDataSet.TaskInfo);
            BindData obj = new BindData();
            taskInfoDataGridView.DataSource = obj.BindSource("[dbo].[TaskInfo]");

            edit_drop_list obj2 = new edit_drop_list();
            var list = obj2.load_drop2("[task_id],[task_name]", "[dbo].[TaskInfo]");
            int count = 0;
            while (count < list.Count)
            {
                comboBox1.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox2.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox3.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                count++;
            }

        }
        //col fined_cost() when we need to find cost 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fined_cost();
            labelControl2.Text = task_time * res_rate + "JD";
            task_time = 1;
            res_rate = 1;
        }
        private void DashBordBtn_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
        private void ProjectBtn_Click(object sender, EventArgs e)
        {
            Project obj = new Project();
            this.Hide();
            obj.Show();
        }
        private void ResourcesBtn_Click(object sender, EventArgs e)
        {
            Resources obj = new Resources();
            this.Hide();
            obj.Show();
        }
        //close all app when closing this form
        private void Task_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            //**********************************************************************************************************************//
            edit_task obj = new edit_task(selected[0] ,this);
            obj.UpdateEventHandler += F3_UpdateEventHandler1;
            //**********************************************************************************************************************//
            obj.ShowDialog();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            edit_drop_list obj2 = new edit_drop_list();
            var list = obj2.load_drop2("[task_id],[task_name]", "[dbo].[TaskInfo]");
            int count = 0;
            while (count < list.Count)
            {
                comboBox1.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox2.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox3.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                count++;
            }
        }
        //**********************************************************************************************************************//
        //col class BindData to reload the dataSource in it 
        private void F3_UpdateEventHandler1(object sender, edit_task.UpdateEventArgs args)
        {
            BindData obj = new BindData();
            taskInfoDataGridView.DataSource = obj.BindSource("[dbo].[TaskInfo]");
        }
        //**********************************************************************************************************************//
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_id_delet = Convert.ToString(comboBox3.SelectedItem).Split(':');
            delete obj1 = new delete();
            obj1.delete_method("[dbo].[TaskInfo]", "[task_id]", Convert.ToInt32(selected_id_delet[0]));
            Task obj = new Task();
            obj.Show();
            this.Hide();

        }
    }
}
