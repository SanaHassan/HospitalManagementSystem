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
using System.Configuration;

namespace HospitalManagementSystem
{
    public partial class doctroDetails : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public doctroDetails()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SanaZia\Downloads\hms\hospital management system\patients.accdb;
            Persist Security Info=False;";
        }

        private void adminAppointment_Load(object sender, EventArgs e)
        {

            this.Size = new System.Drawing.Size(900, 500);
            //dataGridView1.DataSource = GetDoctorsList();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            adminView av = new adminView();
            this.Hide();
            av.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /* try
              {
                  doctors_infoTableAdapter.Update(patientsDataSet1.doctors_info);
              }
              catch (Exception a)
              {
                  MessageBox.Show("Error: " + a);
              }*/
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE doctors_info SET Doctor_name='"+ textBox1.Text + "',timings='" + textBox2.Text + "',speciality='" + textBox3.Text + "',days='" + textBox4.Text + "' WHERE doctorID=" + textBox5.Text ;
            cmd.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            connection.Close();
            MessageBox.Show("Record Updated.");
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void view_btn_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT doctorID,Doctor_name,timings,speciality,days FROM doctors_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            connection.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from doctors_info where doctorID=" + textBox5.Text;
            cmd.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            connection.Close();
            MessageBox.Show("Record Deleted.");
        }
    }
}
