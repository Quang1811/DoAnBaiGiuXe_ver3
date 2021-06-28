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
    public partial class quanlynhanvien : Form
    {
        public quanlynhanvien()
        {
            InitializeComponent();
        }
        public void cmdadd_Click(object sender, EventArgs e)
        {
            try
            {
                DBacess db = new DBacess();
                SqlConnection con = db.Getcon();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ttnhanvien (MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DiaChi, DienThoai, Email, BangCap, CMND, NgayVaoLam) values ('" + txtmaNhanVien.Text + "', '" + txttenNhanVien.Text + "', '" + txtGioiTinh.Text + "', '" + txtNgaySinh.Text + "', '" + txtDiaChi.Text + "', '" + txtDienThoai.Text + "', '" + txtemail.Text + "', '" + txtbangcap.Text + "', '" + txtcmnd.Text + "', '" + txtngayvaolam.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridViewNhanvien.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Thêm thành công", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm nhân viên thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      private void quanlynhanvien_Load(object sender, EventArgs e)
      {
          comboBox1.Text = "Mã Nhân Viên";
       
          DBacess db = new DBacess();
          SqlConnection con = db.Getcon();
          con.Open();
          SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND as [CMND], NgayVaoLam as [Ngày vào làm] from ttnhanvien ", con);
          DataTable dt = new DataTable();
          dt.Clear();
          da.Fill(dt);
          dataGridViewNhanvien.DataSource = dt;
          con.Close();
          da.Dispose();
      } 

      private void cmdrepair_Click(object sender, EventArgs e)
      {
          DBacess db = new DBacess();
          SqlConnection con = db.Getcon();
          con.Open();   
          SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien ", con);
          DataTable dt = new DataTable();
          dt.Clear();
          da.Fill(dt);
          dataGridViewNhanvien.DataSource = dt;
          con.Close();
          da.Dispose();
      }

      private void cmddelete_Click(object sender, EventArgs e)
      {
          try
          {
              DBacess db = new DBacess();
              SqlConnection con = db.Getcon();
              con.Open();
              SqlCommand cmd3 = new SqlCommand("delete ttnhanvien where MaNhanVien = '" + txtmaNhanVien.Text + "'  ", con);
              cmd3.ExecuteNonQuery();
              con.Close();
              con.Open();
              SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien ", con);
              DataTable dt = new DataTable();
              dt.Clear();
              da.Fill(dt);
              dataGridViewNhanvien.DataSource = dt;
              con.Close();
              da.Dispose();
              MessageBox.Show("Xóa nhân viên thành công", "Quản lý  Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          catch
          {
              MessageBox.Show("Xóa nhân viên thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }
        public DataTable Showdl(string sql)
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
      private void cmdfind_Click(object sender, EventArgs e)
      {
          if (comboBox1.Text == "Mã Nhân Viên")
          {
              dataGridViewNhanvien.DataSource = Showdl("Select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien where MaNhanVien like '%" + txtmaNhanVien.Text.Trim() + "%'");
          }
           if (comboBox1.Text == "Tên Nhân Viên")  
              dataGridViewNhanvien.DataSource = Showdl("Select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien where TenNhanVien like '%" + txttenNhanVien.Text.Trim() + "%'");
       if (comboBox1.Text == "Giới tính")
          dataGridViewNhanvien.DataSource = Showdl("Select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien where GioiTinh like '%" + txtGioiTinh.Text.Trim() + "%'");
         if (comboBox1.Text == "Điện thoại")
          dataGridViewNhanvien.DataSource = Showdl("Select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien where DienThoai like '%" + txtDienThoai.Text.Trim() + "%'");
          if (comboBox1.Text == "Bằng cấp")
          dataGridViewNhanvien.DataSource = Showdl("Select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien where BangCap like '%" + txtbangcap.Text.Trim() + "%'");
          if (comboBox1.Text == "Địa chỉ")
          dataGridViewNhanvien.DataSource = Showdl("Select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien where DiaChi like '%" + txtDiaChi.Text.Trim() + "%'");
          if (comboBox1.Text =="Ngày Vào Làm")
              dataGridViewNhanvien.DataSource = Showdl(" Select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien where CONVERT(varchar,NgayVaoLam,103)= '" + txtngayvaolam.Value.ToString("dd/MM/yyyy")+"'"  );
          if(comboBox1.Text == "Ngày Sinh")
              dataGridViewNhanvien.DataSource = Showdl(" Select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from ttnhanvien where CONVERT(varchar,NgaySinh,103)= '" + txtNgaySinh.Value.ToString("dd/MM/yyyy") + "'");
      }
    }
}
