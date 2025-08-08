using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C#(.net)\\C-sharp_Projects\\WindowsFormsApp\\Registration_Form.mdf;Integrated Security=True");
            con.Open();
            string query = "";
            SqlCommand cmd=new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Register");

            con.Close();
        }
    }
}
