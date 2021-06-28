using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUITParking
{
    public partial class form_quanlytt : Form
    {
        public form_quanlytt()
        {
            InitializeComponent();
        }

        private void cmd_quanlynhanvien_Click(object sender, EventArgs e)
        {
            quanlynhanvien f = new quanlynhanvien();
            f.TopLevel = false;
            f.Show();
            pnQuanlytt.Controls.Clear();
            pnQuanlytt.Controls.Add(f);
        }

        private void cmdquanlyxe_Click(object sender, EventArgs e)
        {
            form_quanlyxe f = new form_quanlyxe();
            f.TopLevel = false;
            f.Show();
            pnQuanlytt.Controls.Clear();
            pnQuanlytt.Controls.Add(f);
        }

    }
}
