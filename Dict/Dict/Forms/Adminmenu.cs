using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dict.Forms
{
    public partial class Adminmenu : Form
    {
        public Adminmenu()
        {
            InitializeComponent();
        }
   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Adminmenu_Load(object sender, EventArgs e)
        {
            welcome.ForeColor = couleurs.couleuractive;
            logout.ForeColor= couleurs.couleuractive;
            logpanel.BackColor= couleurs.couleuractive; 
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            trforms.open(new adduser());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trforms.open(new addword());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trforms.open(new modifword());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trforms.open(new deleteword());
        }

        private void logout_Click(object sender, EventArgs e)
        {
            trforms.open(new formadmin());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void roundpic1_Click(object sender, EventArgs e)
        {

        }
    }
}
