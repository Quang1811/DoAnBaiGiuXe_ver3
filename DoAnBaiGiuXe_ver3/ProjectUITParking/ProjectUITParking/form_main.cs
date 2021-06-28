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
    public partial class formmain : Form
    {
        
 
        public formmain()
        {
            InitializeComponent();
          
         
        }
    
        private void check_permission()
        {
            cmdAbout.Enabled = true;
            cmdBaoCao.Enabled = true;
           
            cmdQuanLyTT.Enabled = true;
            cmdThoat.Enabled = true;
        }
        private void cmdQuanLyTT_Click(object sender, EventArgs e)
        {
            form_quanlytt f = new form_quanlytt();
            f.TopLevel = false;
            f.Show();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(f);
        }

        private void cmdBaoCao_Click(object sender, EventArgs e)
        {

            formbaocao f = new formbaocao();
            f.TopLevel = false;
            f.Show();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(f);
        }


       private void cmdThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       private void formmain_Load(object sender, EventArgs e)
       {
           
       }

       private void panel_main_Paint(object sender, PaintEventArgs e)
       {
           
       }

       private void cmdThoat_Click_1(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void cmdAbout_Click(object sender, EventArgs e)
       {
           MessageBox.Show(" \n PHẦN MỀM BÃI GIỮ XE được thực hiện bởi nhóm Group4-HTCL2014 , các thành viên nhóm : \n    #1     Ngô Thanh Bình \n    #2     Đoàn Thiện Hòa \n    #3    Trần Anh Đức \n   facebook : https://www.facebook.com/groups/htcl2014/");

       }

        


    }
}
