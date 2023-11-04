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
    public partial class adduser : Form
    {
        private Rectangle logoutorig;
        private Rectangle label4orig;
        private Rectangle roundpic3orig;
        private Rectangle panelaccountorig;
        private Rectangle roundpic2orig;
        private Rectangle roundpic1orig;
        private Rectangle label1orig;
        private Rectangle label2orig;
        private Rectangle label3orig;
        private Rectangle label5orig;
        private Rectangle label6orig;
        private Rectangle button1orig;
        private Rectangle button2orig;
        private Rectangle textBox1orig;
        private Rectangle textBox2orig;
        private Rectangle textBox6orig;
        private Rectangle textBox5orig;

        private Rectangle textBox3orig;


        private Size formsize;

        public adduser()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void adduser_Load(object sender, EventArgs e)
        {
            formsize = this.Size;
            textBox1orig = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            label1orig = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            textBox2orig = new Rectangle(textBox2.Location.X, textBox2.Location.Y, textBox2.Width, textBox2.Height);
            textBox3orig = new Rectangle(textBox3.Location.X, textBox3.Location.Y, textBox3.Width, textBox3.Height);
            textBox6orig = new Rectangle(textBox6.Location.X, textBox6.Location.Y, textBox6.Width, textBox6.Height);
            textBox5orig = new Rectangle(textBox5.Location.X, textBox5.Location.Y, textBox5.Width, textBox5.Height);
            label3orig = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            label2orig = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            label4orig = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            label5orig = new Rectangle(label5.Location.X, label5.Location.Y, label5.Width, label5.Height);
            label6orig = new Rectangle(label6.Location.X, label6.Location.Y, label6.Width, label6.Height);
            logoutorig = new Rectangle(logout.Location.X, logout.Location.Y, logout.Width, logout.Height);

            roundpic1orig = new Rectangle(roundpic1.Location.X, roundpic1.Location.Y, roundpic1.Width, roundpic1.Height);
            roundpic3orig = new Rectangle(roundpic3.Location.X, roundpic3.Location.Y, roundpic3.Width, roundpic3.Height);
            roundpic2orig = new Rectangle(roundpic4.Location.X, roundpic4.Location.Y, roundpic4.Width, roundpic4.Height);
            panelaccountorig = new Rectangle(panelAccount.Location.X, panelAccount.Location.Y, panelAccount.Width, panelAccount.Height);
            button1orig = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);

            button2orig = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);


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
        private void resizeChildrenControls()
        {
            resizeControl(textBox1orig, textBox1);
            resizeControl(textBox2orig, textBox2);
            resizeControl(textBox3orig, textBox3);
            resizeControl(textBox6orig, textBox6);
            resizeControl(textBox5orig, textBox5);
            resizeControl(label1orig, label1);
            resizeControl(label2orig, label2);
            resizeControl(label3orig, label3);
            resizeControl(label4orig, label4);
            resizeControl(label5orig, label5);
            resizeControl(label6orig, label6);
            resizeControl(logoutorig, logout);
            resizeControl(roundpic1orig, roundpic1);
            resizeControl(roundpic3orig, roundpic3);
            resizeControl(roundpic2orig, roundpic4  );










        }

        private void logout_Click(object sender, EventArgs e)
        {
            trforms.open(new Adminmenu());

        }
     
      

        private void adduser_SizeChanged(object sender, EventArgs e)
        {
            resizeChildrenControls();

        }

        private void roundpic4_Click(object sender, EventArgs e)
        {

        }

        private void roundpic1_Click(object sender, EventArgs e)
        {
                                                   
        }
    }
}
