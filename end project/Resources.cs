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
    public partial class Resources : Form
    {
        private string[] selected = { };
        private string[] selected_id_delet = { };
        public Resources()
        {
            InitializeComponent();
        }
        
        private void resourceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resourceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.endProjectDataSet);

        }
        private void Resources_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'endProjectDataSet.resource' table. You can move, or remove it, as needed.
            this.resourceTableAdapter.Fill(this.endProjectDataSet.resource);
            BindData obj = new BindData();
            resourceDataGridView.DataSource = obj.BindSource("[dbo].[resource]");

            edit_drop_list obj2 = new edit_drop_list();
            var list = obj2.load_drop2("[resource_id],[resource name ]", "[dbo].[resource]");
            int count = 0;
            while (count < list.Count)
            {
                comboBox2.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox3.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                count++;
            }

        }
        private void DashBordBtn_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }
        private void TasksBtn_Click(object sender, EventArgs e)
        {
            Task obj = new Task();
            this.Hide();
            obj.Show();
        }
        private void ProjectBtn_Click(object sender, EventArgs e)
        {
            Project obj = new Project();
            this.Hide();
            obj.Show();
        }
        private void Resources_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = Convert.ToString(comboBox2.SelectedItem).Split(':');
            edit_res obj = new edit_res(selected[0] , this);
            obj.UpdateEventHandler += F3_UpdateEventHandler1;
            obj.ShowDialog();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            
            edit_drop_list obj2 = new edit_drop_list();
            var list = obj2.load_drop2("[resource_id],[resource name ]", "[dbo].[resource]");
            int count = 0;
            while (count < list.Count)
            {
                comboBox2.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                comboBox3.Items.Add(list[count].IntegerData + ":" + list[count].StringData);
                count++;
            }


        }
        private void F3_UpdateEventHandler1(object sender, edit_res.UpdateEventArgs args)
        {
            BindData obj = new BindData();
            resourceDataGridView.DataSource = obj.BindSource("[dbo].[resource]");
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_id_delet = Convert.ToString(comboBox3.SelectedItem).Split(':');
            delete obj1 = new delete();
            obj1.delete_method("[dbo].[resource]", "[resource_id]", Convert.ToInt32(selected_id_delet[0]));
            Resources obj = new Resources();
            obj.Show();
            this.Hide();
        }
    }
}
