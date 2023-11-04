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
    public partial class formadmin : Form
    {
        private Rectangle titreorig;
        private Rectangle pictureBox1orig;
        private Rectangle pictureBox2orig;

        private Rectangle pictureBox4orig;
        private Rectangle usernameorig;
        private Rectangle textbox1orig;
        private Rectangle paneluserorig;
        private Rectangle panelpassorig;
        private Rectangle loginorig;
        private Rectangle exitorig;
        private Size formsize;







        public formadmin()
        {
            InitializeComponent();
           
        }

    private void load()
        {
            foreach(Control btns in this.Controls)
            { if (btns.GetType() == typeof(Button)) {
                    Button btn = (Button)btns;
                        btn.BackColor = couleurs.couleuractive;
                    btn.ForeColor = Color.White;
                        }

            }
            titre.ForeColor = couleurs.couleuractive;
            paneluser.BackColor=couleurs.couleuractive;
            panelpass.BackColor = couleurs.couleuractive;

            exit.ForeColor = couleurs.couleuractive;
        }

        private void formadmin_Load(object sender, EventArgs e)
        {
            load();
            formsize = this.Size;
            titreorig = new Rectangle(titre.Location.X, titre.Location.Y, titre.Width, titre.Height);
            loginorig = new Rectangle(login.Location.X, login.Location.Y, login.Width, login.Height);
            panelpassorig = new Rectangle(panelpass.Location.X, panelpass.Location.Y, panelpass.Width, panelpass.Height);
            exitorig = new Rectangle(exit.Location.X, exit.Location.Y, exit.Width, exit.Height);
            paneluserorig = new Rectangle(paneluser.Location.X, paneluser.Location.Y, paneluser.Width, paneluser.Height);
            pictureBox1orig = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
            pictureBox2orig = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Width, pictureBox2.Height);
            pictureBox4orig = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Width, pictureBox4.Height);

            usernameorig = new Rectangle(username.Location.X, username.Location.Y, username.Width, username.Height);
            textbox1orig = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            
            



        }
        private void resizeChildrenControls()
        {
            resizeControl(titreorig, titre);
            resizeControl(loginorig, login);
            resizeControl(panelpassorig, panelpass);
            resizeControl(exitorig, exit);
            resizeControl(paneluserorig, paneluser);
            resizeControl(pictureBox1orig, pictureBox1);
            resizeControl(pictureBox2orig, pictureBox2);
            resizeControl(pictureBox4orig, pictureBox4);
            resizeControl(usernameorig, username);
            resizeControl(textbox1orig, textBox1);





        }
        private void resizeControl(Rectangle orig, Control contol)
        {
            float xRation = (float)(this.Width) / (float)(formsize.Width);
            float yRation = (float)(this.Height) / (float)(formsize.Height);
            int newX = (int)(orig.X * xRation);
            int newY = (int)(orig.Y * yRation);
            int newwidth = (int)(orig.Width * xRation);
            int newheight = (int)(orig.Height * yRation);
            contol.Location = new Point(newX, newY);
            contol.Size = new Size(newwidth, newheight);





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        { Form f = new Adminmenu();
         
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            Form1.instance.Controls.Add(f);
            Form1.instance.Tag = f;
            f.BringToFront();
            f.Show();
            Form1.l1.Text = "NAARESH :=)";


        }

        private void formadmin_SizeChanged(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
    }
}
