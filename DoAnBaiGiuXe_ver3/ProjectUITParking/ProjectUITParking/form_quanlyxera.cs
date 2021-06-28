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
    public partial class form_quanlyxera : Form
    {
     

        public form_quanlyxera()
        {
            InitializeComponent();
        }
        //public void load_data_xera()
        //{
        //    DBacess db = new DBacess();
        //    SqlConnection con = db.Getcon();
        //    con.Open();
        //    ds = new DataSet();
        //    string query = "select * from thongtinxera";
        //    SqlDataAdapter da = new SqlDataAdapter(query, con);
            
        //    da.SelectCommand.CommandText = "INSERT thongtinxera (maxe,mathexe,loaixe,mauxe) select maxe,mathexe,loaixe,mauxe from thongtinxevao";
        //    da.Fill(ds, "thongtinxera");
        //    dgvxera.DataSource = ds.Tables["thongtinxera"];
        //    con.Close();
        //    da.Dispose();

        //}
         private void form_quanlyxera_Load_1(object sender, EventArgs e)
        {
            combox2.Text = "Thời gian ra";
            DBacess db = new DBacess();
            SqlConnection con = db.Getcon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select maxe as [MÃ XE], thoigianra as [THỜI GIAN RA], loaixe as [LOẠI XE], mathexe as [MÃ THẺ XE], trangthai as [TRẠNG THÁI],giatien as [GIÁ TIỀN],mienphi as [MIỄN PHÍ],mauxe as [MÀU XE] from thongtinxera", con);
            DataTable ds = new DataTable();
            ds.Clear();
            da.Fill(ds);
            dgvxera.DataSource = ds;     
            con.Close();
            da.Dispose();
             //DBacess db = new DBacess();
             //SqlConnection con = db.Getcon();
             //con.Open();
             //////SqlCommand cmd = new SqlCommand("INSERT thongtinxera (maxe,mathexe,loaixe,mauxe) SELECT  maxe,mathexe,loaixe,mauxe FROM thongtinxevao", con);
             //////cmd.ExecuteNonQuery();
             ////SqlDataAdapter da = new SqlDataAdapter("INSERT thongtinxera (maxe,mathexe,loaixe,mauxe) select maxe,mathexe,loaixe,mauxe from thongtinxevao", con);
             ////DataTable dt = new DataTable();
             ////dt.Clear();
             ////da.Fill(dt);
             ////dgvxera.DataSource = dt;
             //con.Close();
             //da.Dispose();
         }
       private void loaddl()
         {
             DBacess db = new DBacess();
             SqlConnection con = db.Getcon();
             con.Open();
             SqlDataAdapter da = new SqlDataAdapter("select maxe as [MÃ XE], thoigianra as [THỜI GIAN RA], loaixe as [LOẠI XE], mathexe as [MÃ SỐ THẺ], trangthai as [TRẠNG THÁI],giatien as [GIÁ TIỀN],mienphi as [MIỄN PHÍ],mauxe as [MÀU XE] from thongtinxera", con);
             DataTable dt = new DataTable();
             dt.Clear();
             da.Fill(dt);
           
             dgvxera.DataSource = dt;
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
             if(combox2.Text == "Mã xe")
             {
                 dgvxera.DataSource = ShowCSDL("select maxe as [MA XE], thoigianra as [THOI GIAN RA], loaixe as [LOAI XE], mathexe as [MA THE XE], trangthai as [Trạng thái],giatien as [Giá tiền],mienphi as [Miễn phí],mauxe as [Màu xe] from thongtinxera where maxe like '%" + textBox1.Text.Trim() + "%'");

             }
             if (combox2.Text == "Mã thẻ xe")
             {
                 dgvxera.DataSource = ShowCSDL("select maxe as [MA XE], thoigianra as [THOI GIAN RA], loaixe as [LOAI XE], mathexe as [MA THE XE], trangthai as [Trạng thái],giatien as [Giá tiền],mienphi as [Miễn phí],mauxe as [Màu xe] from thongtinxera where mathexe like '%" + textBox1.Text.Trim() + "%'");

             }
             if (combox2.Text == "Loại xe")
             {
                 dgvxera.DataSource = ShowCSDL("select maxe as [MA XE], thoigianra as [THOI GIAN RA], loaixe as [LOAI XE], mathexe as [MA THE XE], trangthai as [Trạng thái],giatien as [Giá tiền],mienphi as [Miễn phí],mauxe as [Màu xe] from thongtinxera where loaixe like '%" + textBox1.Text.Trim() + "%'");

             }
             if (combox2.Text == "Hãng xe")
             {
                 dgvxera.DataSource = ShowCSDL("select maxe as [MA XE], thoigianra as [THOI GIAN RA], loaixe as [LOAI XE], mathexe as [MA THE XE], trangthai as [Trạng thái],giatien as [Giá tiền],mienphi as [Miễn phí],,mauxe as [Màu xe] from thongtinxera where hangxe like '%" + textBox1.Text.Trim() + "%'");

             }
             if (combox2.Text == "Trạng thái")
             {
                 dgvxera.DataSource = ShowCSDL("select maxe as [MA XE], thoigianra as [THOI GIAN RA], loaixe as [LOAI XE], mathexe as [MA THE XE], trangthai as [Trạng thái],giatien as [Giá tiền],mienphi as [Miễn phí],mauxe as [Màu xe] from thongtinxera where trangthai like '%" + textBox1.Text.Trim() + "%'");

             }
             if (combox2.Text == "Miễn phí")
             {
                 dgvxera.DataSource = ShowCSDL("select maxe as [MA XE], thoigianra as [THOI GIAN RA], loaixe as [LOAI XE], mathexe as [MA THE XE], trangthai as [Trạng thái],giatien as [Giá tiền],mienphi as [Miễn phí],mauxe as [Màu xe] from thongtinxera where mienphi like '%" + textBox1.Text.Trim() + "%'");

             }
                    if (combox2.Text == "Thời gian ra")
            {
                dgvxera.DataSource = ShowCSDL("select maxe as [MA XE], thoigianra as [THOI GIAN RA], loaixe as [LOAI XE], mathexe as [MA THE XE], trangthai as [Trạng thái],giatien as [Giá tiền],mienphi as [Miễn phí],mauxe as [Màu xe] from thongtinxera where CONVERT(varchar,thoigianra,103) ='" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'");
         }
         }
   

        private void button2_Click(object sender, EventArgs e)
        {
            DBacess db = new DBacess();
            SqlConnection con = db.Getcon();
            con.Open();
            int currentindex = dgvxera.CurrentCell.RowIndex;
            string maxe = Convert.ToString(dgvxera.Rows[currentindex].Cells[0].Value.ToString());
            string trangthai = Convert.ToString(dgvxera.Rows[currentindex].Cells[4].Value.ToString());
           decimal giatien = Convert.ToDecimal(dgvxera.Rows[currentindex].Cells[5].Value.ToString());
            string mienphi =Convert.ToString(dgvxera.Rows[currentindex].Cells[6].Value.ToString());
          DateTime thoigianra = DateTime.Parse(dgvxera.Rows[currentindex].Cells[1].Value.ToString());
          string loaixe = Convert.ToString(dgvxera.Rows[currentindex].Cells[2].Value.ToString());
          string mauxe = Convert.ToString(dgvxera.Rows[currentindex].Cells[7].Value.ToString());
            string updatestr = "UPDATE  thongtinxera set maxe ='" + maxe + "',thoigianra='"+thoigianra+ "',trangthai='" + trangthai  +"',mienphi='"+mienphi+"',giatien='"+giatien+"' where maxe ='" + maxe + "'";
            SqlCommand cmd1 = new SqlCommand(updatestr, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            string updatestr1 = "UPDATE  thongkequanlyxe set maxe ='" + maxe + "',thoigianra='" + thoigianra + "',trangthai='" + trangthai + "',mienphi='" + mienphi + "',giatien='" + giatien + "' where maxe ='" + maxe + "'";
            SqlCommand cmd5 = new SqlCommand(updatestr1, con);
            cmd5.CommandType = CommandType.Text;
            cmd5.ExecuteNonQuery();
            loaddl();
            MessageBox.Show("SỬA DỮ LIỆU THÀNH CÔNG !", "thông báo", MessageBoxButtons.OK);
            con.Close();
            



        }


       private void button3_Click_1(object sender, EventArgs e)
       {
           DBacess db = new DBacess();
           SqlConnection con = db.Getcon();
           con.Open();
           SqlDataAdapter da1 = new SqlDataAdapter("select * from thongtinxera ", con);
           DataTable dt1 = new DataTable();
           dt1.Clear();
           da1.Fill(dt1);
          dgvxera.DataSource = dt1;
           con.Close();
           da1.Dispose();
       }

      
      


    }
}
