using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Dict
{
    class trforms
    {
        public static void open(Form f)
        {   
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            Form1.instance.Controls.Add(f);
            Form1.instance.Tag = f;
            f.BringToFront();
            f.Show();
            Form1.l1.Text = f.Text;

        }
    }
}
