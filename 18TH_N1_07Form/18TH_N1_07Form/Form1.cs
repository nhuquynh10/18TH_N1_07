using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18TH_N1_07Form
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String pass = txtPass.Text;
            if(username == "admin" && pass == "admin")
            {
                MessageBox.Show("Dang nhap thanh cong!!");

            }


            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
