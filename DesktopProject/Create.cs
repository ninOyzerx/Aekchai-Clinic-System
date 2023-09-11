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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DesktopProject
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void mainHeading_Click(object sender, EventArgs e)
        {

        }

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateEmpAccount_Click(object sender, EventArgs e)
        {
            string fname = firstnameBox.Text;
            string lname = lastnameBox.Text;
            string phone_no = phone_noBox.Text;
            string email = regEmail.Text;
            string password = regPassword.Text;
            string usertype = "Member";

            string constr = "Data Source=.;Initial Catalog=system;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();

                    SqlCommand checkEmailCmd = new SqlCommand($"SELECT COUNT(*) FROM users WHERE email = '{email}'", conn);
                    int emailCount = (int)checkEmailCmd.ExecuteScalar();
                    
                    if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(phone_no) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ข้อผิดพลาด");
                    }
                    else if (emailCount > 0)
                    {
                        MessageBox.Show("Email นี้ได้ถูกใช้เรียบร้อยแล้ว", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand($"insert into users(fname, lname, phone_no, email, password, usertype)values('{fname}','{lname}','{phone_no}','{email}','{password}','{usertype}')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("บัญชีได้ถูกสร้างเสร็จเรียบร้อยแล้ว...");
                        this.Close();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + err.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void regEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
