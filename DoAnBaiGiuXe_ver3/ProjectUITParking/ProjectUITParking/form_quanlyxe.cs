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
    public partial class form_quanlyxe : Form
    {
        public form_quanlyxe()
        {
            InitializeComponent();
        }
        public DataTable    ShowCSDL(string sql)
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
     
        private void form_quanlyxe_Load_1(object sender, EventArgs e)
        {
            comboBoxcachtim.Text = "Mã xe";
            DBacess db = new DBacess();
            SqlConnection con = db.Getcon();
            con.Open();
            //SqlCommand cmd = new SqlCommand("insert into thongkequanlyxe(maxe,thoigianvao,thoigianra,mathexe,trangthai,giatien,mienphi,loaixe,mauxe) form ( select thongtinxera.maxe,thongtinxevao.thoigianvao,thongtinxera.thoigianra,thongtinxera.mathexe,thongtinxera.trangthai,thongtinxera.giatien,thongtinxera.mienphi,thongtinxera.loaixe,thongtinxera.mauxe from  thongtinxevao  JOIN thongtinxera ON thongtinxevao.maxe =thongtinxera.maxe) ", con);
            //cmd.ExecuteNonQuery();       
            //string updatestr = "insert into thongkequanlyxe(maxe,thoigianvao,thoigianra,mathexe,trangthai,giatien,mienphi,loaixe,mauxe)";
            //SqlCommand cmd = new SqlCommand(updatestr, con);
            ////cmd.ExecuteNonQuery();
          
            SqlDataAdapter da = new SqlDataAdapter(" select maxe as [MÃ XE],thoigianvao as [THỜI GIAN VÀO],thoigianra as [THỜI GIAN RA],mathexe as [MÃ SỐ THẺ],giatien as [GIÁ TIỀN],mienphi as [MIỄN PHÍ], loaixe as [LOẠI XE],mauxe as [MÀU XE] from thongkequanlyxe ", con);
           DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("insert thongkequanlyxe(maxe,thoigianvao,thoigianra,mathexe,trangthai,giatien,mienphi,loaixe,mauxe) select thongtinxera.maxe,thongtinxevao.thoigianvao,thongtinxera.thoigianra,thongtinxera.mathexe,thongtinxera.trangthai,thongtinxera.giatien,thongtinxera.mienphi,thongtinxera.loaixe,thongtinxera.mauxe from  thongtinxevao  JOIN thongtinxera ON thongtinxevao.maxe =thongtinxera.maxe  ", con);
            //DataTable dt = new DataTable();
            dt.Clear();
            //cmd.ExecuteNonQuery();
            da.Fill(dt);
            dgvquanlixe.DataSource = dt;
            con.Close();
            da.Dispose();
        }
        //private void label4_Click(object sender, EventArgs e) //tinh tong tien
        //{
        //    DBacess db = new DBacess();
        //    SqlConnection con = db.Getcon();
        //    con.Open();
        //    SqlDataAdapter da1 = new SqlDataAdapter("SELECT sum(giatien) from thongtinxevao  JOIN thongtinxera ON thongtinxevao.maxe =thongtinxera.maxe ", con);
              
        //}

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBoxcachtim.Text == "Mã xe")
            {
                dgvquanlixe.DataSource = ShowCSDL("select maxe as [MÃ XE],thoigianvao as [THỜI GIAN VÀO],thoigianra as [THỜI GIAN RA],mathexe as [MÃ SỐ THẺ],giatien as [GIÁ TIỀN],mienphi as [MIỄN PHÍ], loaixe as [LOẠI XE],mauxe as [MÀU XE] from thongkequanlyxe where maxe like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBoxcachtim.Text == "Mã thẻ xe")
            {
                dgvquanlixe.DataSource = ShowCSDL("select maxe as [MÃ XE],thoigianvao as [THỜI GIAN VÀO],thoigianra as [THỜI GIAN RA],mathexe as [MÃ SỐ THẺ],giatien as [GIÁ TIỀN],mienphi as [MIỄN PHÍ], loaixe as [LOẠI XE],mauxe as [MÀU XE] from thongkequanlyxe where mathexe like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBoxcachtim.Text == "Loại xe")
            {
                dgvquanlixe.DataSource = ShowCSDL(" select maxe as [MÃ XE],thoigianvao as [THỜI GIAN VÀO],thoigianra as [THỜI GIAN RA],mathexe as [MÃ SỐ THẺ],giatien as [GIÁ TIỀN],mienphi as [MIỄN PHÍ], loaixe as [LOẠI XE],mauxe as [MÀU XE] from thongkequanlyxe where loaixe like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBoxcachtim.Text == "Trạng thái")
            {
                dgvquanlixe.DataSource = ShowCSDL("select maxe as [MÃ XE],thoigianvao as [THỜI GIAN VÀO],thoigianra as [THỜI GIAN RA],mathexe as [MÃ SỐ THẺ],giatien as [GIÁ TIỀN],mienphi as [MIỄN PHÍ], loaixe as [LOẠI XE],mauxe as [MÀU XE] from thongkequanlyxe  where like '%" + textBox1.Text.Trim() + "%'");
            }
            if (comboBoxcachtim.Text == "Thời gian vào")
            {
                dgvquanlixe.DataSource = ShowCSDL("select maxe as [MÃ XE],thoigianvao as [THỜI GIAN VÀO],thoigianra as [THỜI GIAN RA],mathexe as [MÃ SỐ THẺ],giatien as [GIÁ TIỀN],mienphi as [MIỄN PHÍ], loaixe as [LOẠI XE],mauxe as [MÀU XE] from thongkequanlyxe where CONVERT(varchar,thoigianvao,103) ='" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'");
            } if (comboBoxcachtim.Text == "Thời gian ra")
                {
                    dgvquanlixe.DataSource = ShowCSDL("select maxe as [MÃ XE],thoigianvao as [THỜI GIAN VÀO],thoigianra as [THỜI GIAN RA],mathexe as [MÃ SỐ THẺ],giatien as [GIÁ TIỀN],mienphi as [MIỄN PHÍ], loaixe as [LOẠI XE],mauxe as [MÀU XE] from thongkequanlyxe where CONVERT(varchar,thoigianra,103) ='" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'");
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_quanlyxevao f = new form_quanlyxevao();
                 if(f.Visible == false)
                 {
                     f = new form_quanlyxevao();
                     f.Show();
                 }
                 else
                 {
                     f.Activate();
                     f.Focus();
                 }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_quanlyxera f = new form_quanlyxera();
            if (f.Visible == false)
            {
                f = new form_quanlyxera();
                f.Show();
            }
            else
            {
                f.Activate();
                f.Focus();
            }
        }

 

        private void txtsum_Click(object sender, EventArgs e)
        {
            int sum = dgvquanlixe.Rows.Count;
            float thanhtien = 0;

            for (int i = 0; i < sum; i++)
            {
                thanhtien += float.Parse(dgvquanlixe.Rows[i].Cells["Giá tiền"].Value.ToString());

            }
            txtsum.Text = thanhtien.ToString() +" "+ "VND";
     
      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("dd"  + "/"+ "MM" +"/"+ "yyyy" +"  "+"hh:mm:ss");
        }
        public DataTable taobang(string sql)
        {
            DBacess db = new DBacess();
            SqlConnection con = db.Getcon();
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, con);
            ds.Fill(dt);
            return (dt);

        }


        private void button4_Click(object sender, EventArgs e)
        {
            DBacess db = new DBacess();
            SqlConnection con = db.Getcon();
            con.Open();
            string sql = "Select Count(maxe) As soluong from thongtinxera where trangthai='chua lay'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                button4.Text = dr["soluong"].ToString() + "/200";
            }
            dr.Close();


 
            }

     

     

  
    }
}

