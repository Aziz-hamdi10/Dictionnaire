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
    public partial class deleteword : Form
    {
        public deleteword()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            trforms.open(new Adminmenu());

        }
    }
}
