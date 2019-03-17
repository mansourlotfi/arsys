using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Drawing.Imaging;
namespace arsyserp
{
    public partial class Frmlogin : Telerik.WinControls.UI.RadForm
    {
        public Frmlogin()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            Frmmain f = new Frmmain();
            f.Show();
            this.Hide();
        }
    }
}
