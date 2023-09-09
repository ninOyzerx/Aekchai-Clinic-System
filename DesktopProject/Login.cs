using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DesktopProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginAccount_Click(object sender, EventArgs e)
        {
            string email = LoginEmail.Text;
            string password = LoginPassword.Text;
            string constr = "Data Source=.;Initial Catalog=system;Integrated Security=True";

            try
            { 
                using(SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"select * from users where email = '{email}' and password = '{password}'",conn);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("password", password);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("เข้าสู่ระบบสำเร็จ", "ยินดีตอนรับกลับ", MessageBoxButtons.OK);
                        this.Close();
                        //UserHomeForm uhf = new UserHomeForm();
                        //uhf.Show();
                    }
                    else
                    {
                        MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }catch(Exception err)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " + err.Message);
            }
        }

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
