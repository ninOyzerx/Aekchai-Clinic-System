using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProject
{
    public partial class Aekchai : Form
    {
        public Aekchai()
        {
            InitializeComponent();
            MessageBox.Show("ยินดีตอนรับ" ,"Welcome");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            SearchEmployee searchEmp = new SearchEmployee();
            searchEmp.Show();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            Create cr = new Create();
            cr.Show();
        }

        private void LoginIntoAccount_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void mainHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
