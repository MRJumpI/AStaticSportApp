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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            loadform(new PageHome());
        }
        public void loadform(object Form)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(new PageHome()); 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new About());

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loadform(new GameRule());

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadform(new HowToPlay());

        }
    }
}
