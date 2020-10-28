using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class NewDoctor : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public NewDoctor()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\SanaZia\Downloads\hms\hospital management system\patients.accdb;
            Persist Security Info=False;";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into doctors_info (Doctor_name,timings,speciality,days,username,[password],fees) values ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+ textBox2.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            connection.Close();
            MessageBox.Show("New Record Added.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            adminView adminView = new adminView();
            adminView.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NewDoctor_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(900, 500);
        }
    }
}
