﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.Show();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNguoiDung frmQLNguoiDung = new frmQLNguoiDung();
            frmQLNguoiDung.Show();
        }
    }
}
