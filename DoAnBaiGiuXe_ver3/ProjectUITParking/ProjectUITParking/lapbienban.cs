using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectUITParking
{
    public partial class lapbienban : Form
    {
        bienbansuco rp = new bienbansuco();
        public lapbienban()
        {
            InitializeComponent();
        }

        private void lapbienban_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
