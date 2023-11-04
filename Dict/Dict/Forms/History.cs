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
    public partial class History : Form
    {
        String details = "{0, -30}{1, -25}{2, -26}{3, -25}{4, -20}{5, -25}";
        public History()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void History_Load(object sender, EventArgs e)
        {
            l.Items.Add(String.Format(details,"Langue iniale", "Mot", "Type", "Langue second", "traduction","Exemple")) ;
        }

        private void l_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
