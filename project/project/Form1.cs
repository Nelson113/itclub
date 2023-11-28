using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class Form1 : Form
    {
        static OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Database2.accdb ");
        static OleDbCommand cmd = con.CreateCommand();
        static OleDbDataReader reader;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
            

            private void button2_Click(object sender, EventArgs e)
            {
                con.Open();
                cmd.CommandText = "Move to Students (Name , Score) values";
                cmd.Connection = con;
                reader = cmd.ExecuteReader();
                reader.Close();
                con.Close();
            }

            private void btnsave_Click(object sender, EventArgs e)
            {
                
            }

            private void btnback_Click(object sender, EventArgs e)
            {
                

            }

            private void btntally_Click(object sender, EventArgs e)
            {
                
            }

        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database2DataSet.Table1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "insert Students (Name , club , activity) values";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "Add to Students (Name , club , activity) values";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.itlogo;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
