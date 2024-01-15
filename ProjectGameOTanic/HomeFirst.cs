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
    public partial class AboutGame : Form
    {
        public int turn = 0;
        public AboutGame()
        {
            InitializeComponent();

            //Intial just to show first image
            img1.Visible = true;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
        }

        private void slidertransition_Tick(object sender, EventArgs e)
        {
            if(turn == 0) {
                slideShowTransition.HideSync(img1);
                slideShowTransition.ShowSync(img2);
                img1.Visible=false;
                img2.Visible=true;
                turn++;
                    
            }else if(turn == 1) {
                slideShowTransition.HideSync(img2);
                slideShowTransition.ShowSync(img3);
                img2.Visible = false;
                img3.Visible = true;

                turn++;
            } else if(turn == 2) {
                slideShowTransition.HideSync(img3);
                slideShowTransition.ShowSync(img4);
                img3.Visible = false;
                img4.Visible = true;

                turn++;
            }  else {
                slideShowTransition.HideSync(img2);
                slideShowTransition.ShowSync(img1);
                img2.Visible = false;
                img1.Visible = true;

                turn = 0; }   
        }
    }
}
