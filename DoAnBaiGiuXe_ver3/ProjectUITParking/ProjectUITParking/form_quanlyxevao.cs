using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectUITParking
{
    public partial class form_quanlyxevao : Form
    {
        public form_quanlyxevao()
        {
            InitializeComponent();
        }
        private void form_quanlyxeravao_Load(object sender, EventArgs e)
        {
            combox2.Text = "Thời gian vào";
            DBacess db = new DBacess();
            SqlConnection con = db.Getcon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select maxe as [MÃ XE], thoigianvao as [THỜI GIAN VÀO ], loaixe as [LOẠI XE], mathexe as [MÃ SỐ THẺ], mauxe as [MÀU XE] from thongtinxevao", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvxevao.DataSource = dt;
            con.Close();
            da.Dispose();

        }
        public DataTable ShowCSDL(string sql)
        {
            DBacess db = new DBacess();
            SqlConnection con = db.Getcon();
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(sql, con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            con.Close();
            return dt1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (combox2.Text == "Mã xe")
            {
                dgvxevao.DataSource = ShowCSDL("select maxe as [MA XE], thoigianvao as [THOI GIAN VAO], loaixe as [LOAI XE], mathexe as [MA THE XE],mauxe as [Màu xe] from thongtinxevao where maxe like '%" + textBox1.Text.Trim() + "%'");

            }
            if (combox2.Text == "Mã thẻ xe")
            {
                dgvxevao.DataSource = ShowCSDL("select maxe as [MA XE], thoigianvao as [THOI GIAN VAO], loaixe as [LOAI XE], mathexe as [MA THE XE],mauxe as [Màu xe] from thongtinxevao where mathexe like '%" + textBox1.Text.Trim() + "%'");

            }
            if (combox2.Text == "Loại xe")
            {
                dgvxevao.DataSource = ShowCSDL("select maxe as [MA XE], thoigianvao as [THOI GIAN VAO], loaixe as [LOAI XE], mathexe as [MA THE XE],mauxe as [Màu xe] from thongtinxevao where loaixe like '%" + textBox1.Text.Trim() + "%'");

            }
          
            if (combox2.Text == "Thời gian vào")
            {
                dgvxevao.DataSource = ShowCSDL("select maxe as [MA XE], thoigianvao as [THOI GIAN VAO], loaixe as [LOAI XE], mathexe as [MA THE XE],mauxe as [Màu xe] from thongtinxevao where CONVERT(varchar,thoigianvao,103) ='" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            DBacess db = new DBacess();
            SqlConnection con = db.Getcon();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into thongtinxevao(maxe,thoigianvao,mathexe,loaixe,mauxe) values ('" +txtmaxe.Text + "', '" + txtthoigianvao.Text + "', '" + txtmathexe.Text + "', '" + txtloaixe.Text + "', '" + txtmauxe.Text + "')", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter("select maxe as [MÃ XE], thoigianvao as [THỜI GIAN VÀO], mathexe as [MÃ SỐ XE],loaixe as [LOẠI XE], mauxe as [MÀU XE] from thongtinxevao ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
           dgvxevao.DataSource = dt;
           form_quanlyxera frm = new form_quanlyxera();
           SqlCommand cmd1 = new SqlCommand("insert into thongtinxera(maxe,mathexe,loaixe,mauxe) values ('" + txtmaxe.Text + "','" + txtmathexe.Text + "', '" + txtloaixe.Text + "', '" + txtmauxe.Text + "')", con);
           cmd1.ExecuteNonQuery();
           SqlDataAdapter da1 = new SqlDataAdapter("select * from thongtinxera ", con);
           DataTable dt1 = new DataTable();
           dt1.Clear();
           da1.Fill(dt);
           frm.dgvxera.DataSource = dt1;
           form_quanlyxe frm1 = new form_quanlyxe();
           SqlCommand cmd2 = new SqlCommand("insert into thongkequanlyxe(maxe,thoigianvao,mathexe,loaixe,mauxe) values ('" + txtmaxe.Text + "', '" + txtthoigianvao.Text + "', '" + txtmathexe.Text + "', '" + txtloaixe.Text + "', '" + txtmauxe.Text + "')", con);
           cmd2.ExecuteNonQuery();
           SqlDataAdapter da2 = new SqlDataAdapter("select maxe as [MÃ XE] ,thoigianvao as [THỜI GIAN VÀO],mathexe as [MÃ THẺ XE] ,loaixe as [LOẠI XE],mauxe as [MÀU XE] from thongkequanlyxe", con);
           DataTable dt2 = new DataTable();
           dt2.Clear();
           da2.Fill(dt2);
           frm1.dgvquanlixe.DataSource = dt2;
            con.Close();
            da1.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DBacess db = new DBacess();
            SqlConnection con = db.Getcon();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select maxe as [MÃ XE], thoigianvao as [THỜI GIAN VÀO], mathexe as [MÃ SỐ XE],loaixe as [LOẠI XE], mauxe as [MÀU XE] from thongtinxevao ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvxevao.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try{DBacess db = new DBacess();
              SqlConnection con = db.Getcon();
              con.Open();
              SqlCommand cmd3 = new SqlCommand("delete thongtinxevao where maxe = '" + txtmaxe.Text + "'  ", con);
              cmd3.ExecuteNonQuery();
              con.Close();
              con.Open();
              SqlDataAdapter da = new SqlDataAdapter(" select maxe as [MÃ XE], thoigianvao as [THỜI GIAN VÀO], mathexe as [MÃ SỐ XE],loaixe as [LOẠI XE], mauxe as [MÀU XE] from thongtinxevao", con);
              DataTable dt = new DataTable();
              dt.Clear();
              da.Fill(dt);
              dgvxevao.DataSource = dt;
              con.Close();
              da.Dispose();
              MessageBox.Show("Xóa xe thành công", "Quản lý  Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          catch
          {
              MessageBox.Show("Xóa xe thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }
    }
}
 