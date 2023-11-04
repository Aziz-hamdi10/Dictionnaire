using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Dict
{
                    

    public partial class Form1 : Form
    {
        private Rectangle label1orig;
        private Rectangle btnloginorig;
        private Rectangle paneltitreorig;
        private Rectangle panelMenuorig;
        private Rectangle panellogoorig;
        private Rectangle paneldeskorig;
        private Rectangle btnAdminorig;
        private Rectangle btnDictionnaireorig;
        private Rectangle btnsettingorig;
        private Rectangle btnHistoriqueorig;
        private Size formsize;
        private Rectangle Labeltitreorig;
        private Button currentButton;
        private Random random;
        public static Label l1;
        public static Panel instance;
            private int index;
        private Form formactive;
        public Form1()
        {
            InitializeComponent();
            instance = this.paneldesk;
            random = new Random();
            l1 = this.Labeltitre;
            
        }
        private Color Selectcolor()
        {
            int index1 =random.Next(couleurs.lcouleurs.Count);
            while (index == index1)
            {
                index1 = random.Next(couleurs.lcouleurs.Count);

            }
            index = index1;
            string color = couleurs.lcouleurs[index];
            return ColorTranslator.FromHtml(color);
        }
        private void active(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    diac();
                    Color color = Selectcolor();
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    paneltitre.BackColor = color;
                    panellogo.BackColor = color;
                    couleurs.couleuractive = color;
                }
            }

        }
        private void diac()
            {
                foreach(Control previousBtn in panelMenu.Controls)
                {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                        previousBtn.BackColor = Color.FromArgb(51, 51, 76) ;
                        previousBtn.ForeColor = Color.Gainsboro;
                        

                    }
                }
            }
        private void open(Form f ,object sender)
        {
            if (null!= formactive)
            {
                formactive.Close();

            }
            active(sender);
            formactive = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.paneldesk.Controls.Add(f);
            this.paneldesk.Tag = f;
            f.BringToFront();
            f.Show();
            Labeltitre.Text = f.Text;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            open(new Forms.formadmin(), sender);
        }

        private void btnDictionnaire_Click(object sender, EventArgs e)
        {
            open(new Forms.Dictionnaire(), sender);


        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            open(new Forms.Setting(), sender);

        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            open(new Forms.History(), sender);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panellogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formsize = this.Size;
            btnAdminorig= new Rectangle(btnAdmin.Location.X, btnAdmin.Location.Y, btnAdmin.Width, btnAdmin.Height);
            label1orig = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            paneltitreorig = new Rectangle(paneltitre.Location.X,paneltitre.Location.Y,paneltitre.Width,paneltitre.Height);
         panelMenuorig=new Rectangle(panelMenu.Location.X, panelMenu.Location.Y, panelMenu.Width, panelMenu.Height);
            panellogoorig = new Rectangle(panellogo.Location.X, panellogo.Location.Y, panellogo.Width, panellogo.Height);
            paneldeskorig = new Rectangle(paneldesk.Location.X, paneldesk.Location.Y, paneldesk.Width, paneldesk.Height);
        btnDictionnaireorig= new Rectangle(btnDictionnaire.Location.X, btnDictionnaire.Location.Y, btnDictionnaire.Width, btnDictionnaire.Height);
        btnsettingorig= new Rectangle(btnsetting.Location.X, btnsetting.Location.Y, btnsetting.Width, btnsetting.Height);
    btnHistoriqueorig= new Rectangle(btnHistorique.Location.X, btnHistorique.Location.Y, btnHistorique.Width, btnHistorique.Height); 
      Labeltitreorig= new Rectangle(Labeltitre.Location.X, Labeltitre.Location.Y, Labeltitre.Width, Labeltitre.Height);
        }
        private void resizeChildrenControls()
        {
            resizeControl(paneltitreorig,paneltitre);
            resizeControl(panelMenuorig, panelMenu);
            resizeControl(panellogoorig, panellogo);
            resizeControl(paneldeskorig, paneldesk);
            resizeControl(btnDictionnaireorig, btnDictionnaire);
            resizeControl(btnsettingorig, btnsetting);
            resizeControl(btnHistoriqueorig, btnHistorique);
            resizeControl(Labeltitreorig, Labeltitre);
            resizeControl(label1orig, label1);
            resizeControl(btnAdminorig, btnAdmin);





        }
        private void resizeControl(Rectangle orig , Control contol)
        {
            float xRation = (float)(this.Width) / (float)(formsize.Width);
            float yRation = (float)(this.Height) / (float)(formsize.Height);
            int newX =(int)(orig.X* xRation);
                int newY= (int)(orig.Y * yRation);
            int newwidth = (int)(orig.Width * xRation);
            int newheight = (int)(orig.Height * yRation);
            contol.Location = new Point(newX, newY);
            contol.Size = new Size(newwidth, newheight);





        }
        private void Form1_Resize(object sender, EventArgs e)
        {
           
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
           
            resizeChildrenControls();
        }
    }
}
