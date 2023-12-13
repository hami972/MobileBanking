using Mobile_Banking.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Banking
{
    
    public partial class SignInUp : Form
    {
        public SignInUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelSign.Controls.Clear();
            signin signin = new signin();
            signin.Dock = DockStyle.Fill;
            panelSign.Controls.Add(signin);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            panelSign.Controls.Clear();
            signup signup = new signup();
            signup.Dock = DockStyle.Fill;
            panelSign.Controls.Add(signup);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSign.Controls.Clear();
            forgetpassword forgetpassword = new forgetpassword();
            forgetpassword.Dock = DockStyle.Fill;
            panelSign.Controls.Add(forgetpassword);
        }
    }
}
