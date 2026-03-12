using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;   // tambahan

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        // Variabel koneksi
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        // Method koneksi database
        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=IZAYAAA\\IZA;Initial Catalog=DBAkademikADO;Integrated Security=True"
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Event tombol connect
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHitungMK_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}