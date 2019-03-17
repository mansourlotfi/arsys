using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arsyserp
{
    public partial class presentcoprint : Form
    {
        public presentcoprint()
        {
            InitializeComponent();
        }

        private void presentcoprint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'arsyserpDataSet.Table_presentedco' table. You can move, or remove it, as needed.
            this.Table_presentedcoTableAdapter.Fill(this.arsyserpDataSet.Table_presentedco);

            this.reportViewer1.RefreshReport();
        }
    }
}
