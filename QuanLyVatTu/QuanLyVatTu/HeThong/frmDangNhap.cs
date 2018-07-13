using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTu
{
    public partial class frmDangNhap : Form
    {
        #region fields
        string thongTinDangNhap = "Bạn hãy nhập đẩy đủ thông tin đăng nhập!";
        string thongTinDangKy = "Bạn hãy nhập đẩy đủ thông tin đăng nhập!";
        string passDK1vsDK2 = "Mật khẩu không khớp!";
        #endregion

        #region Constructor
        public frmDangNhap()
        {
            InitializeComponent();
            
        }
        #endregion

        #region Methods
        void KiemTraThongTin()
        {
            if (txtUSER.Text == "" || txtPass.Text == "")
            {
                DialogResult dialogResult =  MessageBox.Show(thongTinDangNhap , 
                    "Thông báo" , MessageBoxButtons.OK , 
                    MessageBoxIcon.Warning);
                
                
            }
            else if (txtUSER_DK.Text == "" || txtPass_DK1.Text == "" || txtPass_DK2.Text =="")
            {
                MessageBox.Show(thongTinDangKy);
            }
            else if (txtUSER_DK.TextLength > 0)
            {
                if (txtPass_DK1.Text != txtPass_DK2.Text )
                {
                    MessageBox.Show(passDK1vsDK2);
                }
            }
        }
        #endregion

        #region Event
        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            //KiemTraThongTin();
        }

        #endregion
    }
}
