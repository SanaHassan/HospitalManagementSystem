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
    public partial class doctorSchedule : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public doctorSchedule()
        {
            InitializeComponent();
        }

        private void doctorSchedule_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(900, 500);
            dataGridView1.DataSource = GetDoctorsList();
        }
            private DataTable GetDoctorsList()
            {
                DataTable dtdoc = new DataTable();
            
                String connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                using (OleDbConnection con = new OleDbConnection(connString))
                {
                    using (OleDbCommand cmd = new OleDbCommand("SELECT Doctor_name,timings,speciality FROM doctors_info", con))
                    {
                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        dtdoc.Load(reader);
                    }
                }
                    return dtdoc;
        
            }
        public string cnic;
        public void set(string c)
        {
            cnic = c;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientDetails details = new patientDetails();
            details.set(cnic);
            details.Show();
            this.Hide();
        }
    }
}
