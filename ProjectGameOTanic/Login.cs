using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGameOTanic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MainScreen form = new MainScreen();
            form.Show();
            this.Close();
        }
    }
}
