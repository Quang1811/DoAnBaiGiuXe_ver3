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
    public partial class formbaocao : Form
    {
        public formbaocao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indsxevao f = new indsxevao();
           if(f.Visible ==false)
           {
               f = new indsxevao();
               f.Show();
           }
           else
           {
               f.Activate();
               f.Focus();
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forminnhanvien f = new forminnhanvien();
           if(f.Visible ==false)
           {
               f = new forminnhanvien();
               f.Show();
           }
           else
           {
               f.Activate();
               f.Focus();
           }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            indsxera f = new indsxera();
            if (f.Visible == false)
            {
                f = new indsxera();
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
            lapbienban f = new lapbienban();
            if (f.Visible == false)
            {
                f = new lapbienban();
                f.Show();
            }
            else
            {
                f.Activate();
                f.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thongkexeravao f = new thongkexeravao();
            if (f.Visible == false)
            {
                f = new thongkexeravao();
                f.Show();
            }
            else
            {
                f.Activate();
                f.Focus();
            }
        }

     
        
    }
}
