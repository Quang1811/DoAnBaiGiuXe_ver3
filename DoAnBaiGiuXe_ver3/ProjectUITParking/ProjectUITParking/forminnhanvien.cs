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
    public partial class forminnhanvien : Form
    {
        innhanvien rp = new innhanvien();
        public forminnhanvien()
        {
            InitializeComponent();
        }

        private void forminnhanvien_Load(object sender, EventArgs e)
        {
            DBacess kn = new DBacess();
            SqlConnection con = kn.Getcon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien , TenNhanVien ,  GioiTinh , NgaySinh , DiaChi , DienThoai , Email, BangCap, CMND, NgayVaoLam  from ttnhanvien", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
