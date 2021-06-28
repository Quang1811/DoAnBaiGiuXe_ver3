using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectUITParking
{
    public partial class indsxevao : Form
    {
        xevao rp = new xevao();
        public indsxevao()
        {
            InitializeComponent();
        }
        private void indsxevao_Load(object sender, EventArgs e)
        {

            DBacess kn = new DBacess();
            SqlConnection con = kn.Getcon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select maxe , thoigianvao , loaixe , mathexe , mauxe  from thongtinxevao", con);
            DataTable dt = new DataTable();
            dt.Clear();     
            da.Fill(dt);
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
