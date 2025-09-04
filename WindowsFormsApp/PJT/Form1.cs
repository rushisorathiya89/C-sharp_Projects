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

namespace WindowsFormsApp.PJT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {



        }

        private void Insert_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C#(.net)\\C-sharp_Projects\\WindowsFormsApp\\DbStud.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            // Check if EnrollNo already exists
            string checkQuery = "SELECT COUNT(*) FROM Student WHERE EnrollNo = @EnrollNo";
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
            {
                checkCmd.Parameters.AddWithValue("@EnrollNo", Enroll.Text);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("EnrollNo already exists. Please use a unique EnrollNo.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            string query = "INSERT INTO Student(EnrollNo, Age, Name, City)  VALUES (@EnrollNo, @Age, @Name, @City)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EnrollNo",Enroll.Text);
            cmd.Parameters.AddWithValue("@Age",Sage.Text);
            cmd.Parameters.AddWithValue("@Name",Sname.Text);
            cmd.Parameters.AddWithValue("@City",Scity.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted successfully.");
            Enroll.Text = "";
            Sage.Text = "";
            Sname.Text = "";
            Scity.Text = "";

        }

        private void Update_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C#(.net)\\C-sharp_Projects\\WindowsFormsApp\\DbStud.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string query = "UPDATE Student SET Age=@Age, Name=@Name, City=@City WHERE EnrollNo=@EnrollNo";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EnrollNo", Enroll.Text);
            cmd.Parameters.AddWithValue("@Age", Sage.Text);
            cmd.Parameters.AddWithValue("@Name", Sname.Text);
            cmd.Parameters.AddWithValue("@City", Scity.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated successfully.");
            Enroll.Text = "";
            Sage.Text = "";
            Sname.Text = "";
            Scity.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C#(.net)\\C-sharp_Projects\\WindowsFormsApp\\DbStud.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string query = "DELETE FROM Student WHERE EnrollNo=@EnrollNo";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EnrollNo", Enroll.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted successfully.");
            Enroll.Text = "";
            Sage.Text = "";
            Sname.Text = "";
            Scity.Text = "";
        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void Enroll_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Scity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
