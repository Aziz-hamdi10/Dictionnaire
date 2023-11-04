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
    public partial class Dictionnaire : Form
    {
        private Button currentButton;

        public Dictionnaire()
        {
            InitializeComponent();
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dictionnaire_Load(object sender, EventArgs e)
        {
            panelfr2    .BackColor = couleurs.couleuractive;
            francais2.ForeColor= couleurs.couleuractive;
            panelang1.BackColor = couleurs.couleuractive;
            Anglais.ForeColor= couleurs.couleuractive;
        }

        private void Anglais_Click(object sender, EventArgs e)
        {
            Anglais.ForeColor = couleurs.couleuractive;
            Francais.ForeColor = Color.Black;
            panelang1.BackColor = couleurs.couleuractive;
            panelfr1.BackColor = Color.White;
          
            if (panelang2.BackColor == couleurs.couleuractive && panelang1.BackColor == couleurs.couleuractive)
            {
                Anglais2.ForeColor = Color.Black;
                panelang2.BackColor = Color.White;
                panelfr2.BackColor = couleurs.couleuractive;
                francais2.ForeColor= couleurs.couleuractive; 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Anglais2_Click(object sender, EventArgs e)
        {
            francais2.ForeColor = Color.Black;
            Anglais2.ForeColor = couleurs.couleuractive;
            panelang2.BackColor = couleurs.couleuractive;
            panelfr2.BackColor = Color.White;
            if (panelang2.BackColor == couleurs.couleuractive && panelang1.BackColor == couleurs.couleuractive)
            {
                Anglais.ForeColor = Color.Black;
                panelang1.BackColor = Color.White;
                panelfr1.BackColor = couleurs.couleuractive;
                Francais.ForeColor= couleurs.couleuractive;
            }


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Francais_Click(object sender, EventArgs e)
        {
            Anglais.ForeColor = Color.Black;
            Francais.ForeColor = couleurs.couleuractive;
            panelfr1.BackColor = couleurs.couleuractive;
            panelang1.BackColor = Color.White;
            if (panelfr2.BackColor == couleurs.couleuractive && panelfr1.BackColor == couleurs.couleuractive)
            {
                francais2.ForeColor = Color.Black;
                panelfr2.BackColor = Color.White;
                panelang2.BackColor = couleurs.couleuractive;
                Anglais2.ForeColor= couleurs.couleuractive;

            }


        }

        private void francais2_Click(object sender, EventArgs e)
        {
            francais2.ForeColor = couleurs.couleuractive;
            Anglais2.ForeColor = Color.Black;
            panelfr2.BackColor = couleurs.couleuractive;
            panelang2.BackColor = Color.White;
                  if (panelfr2.BackColor == couleurs.couleuractive && panelfr1.BackColor == couleurs.couleuractive)
            {
                Francais.ForeColor = Color.Black;
                panelfr1.BackColor = Color.White;
                panelang1.BackColor = couleurs.couleuractive;
                Anglais.ForeColor= couleurs.couleuractive; 


            }


        }

        private void Dictionnaire_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void panelang2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tr1_TextChanged(object sender, EventArgs e)
        {

            tr2.ForeColor = Color.Black;
            tr2.Text = tr1.Text;
        }

        private void tr2_TextChanged(object sender, EventArgs e)
        {
            if (tr2.Text.Length == 0)
            {
                tr2.ForeColor = Color.Gray;
                tr2.Text =" traduction";
            }
        }

        

        private void excahnge_Click(object sender, EventArgs e)
        {
            Color c1 = panelfr1.BackColor;
            Color c2 = panelfr2.BackColor;
            panelfr1.BackColor = panelang1.BackColor;
            panelang1.BackColor = c1;
            panelfr2.BackColor = panelang2.BackColor;
            panelang2.BackColor = c2;
            if(panelang1.BackColor==couleurs.couleuractive)
            {
                Anglais.ForeColor = couleurs.couleuractive;
                Anglais2.ForeColor = Color.Black;
            }
            if (panelang2.BackColor == couleurs.couleuractive)
            {
                Anglais2.ForeColor = couleurs.couleuractive;
               Anglais.ForeColor = Color.Black;
            }
            if (panelfr2.BackColor == couleurs.couleuractive)
            {
                francais2.ForeColor = couleurs.couleuractive;

                Francais.ForeColor = Color.Black;
            }
            if (panelfr1.BackColor == couleurs.couleuractive)
            {
                Francais.ForeColor = couleurs.couleuractive;

                francais2.ForeColor = Color.Black;
            }

        }
    }
}
