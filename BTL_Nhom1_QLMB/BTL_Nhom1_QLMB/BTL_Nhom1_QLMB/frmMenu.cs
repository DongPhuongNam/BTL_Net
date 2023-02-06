using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_qlTaiKhoan form = new form_qlTaiKhoan();
            form.Show();
        }

        private void đặtChỗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_DatCho form = new form_DatCho();
            form.Show();
        }

        private void đăngKýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_DangKy form = new form_DangKy();
            form.Show();
        }

        private void đặtChỗToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_DatCho form = new form_DatCho();
            form.Show();
        }

        private void đăngKýToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form_qlTaiKhoan form = new form_qlTaiKhoan();
            form.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_qlKhachHang form = new form_qlKhachHang();
            form.Show();
        }

        private void đặtChỗToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form_qlDatCho form = new form_qlDatCho();
            form.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_qlChuyenBay form = new form_qlChuyenBay();
            form.Show();
        }

        private void quảnLýLoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_qlLoaiMayBay form = new form_qlLoaiMayBay();
            form.Show();
        }

        private void quảnLýLịchBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_qlMayBay form = new form_qlMayBay();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_qlChuyenBay form = new form_qlChuyenBay();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_DatCho form = new form_DatCho();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTraCuu form = new frmTraCuu();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if(Program.nguoidung.loainguoidung == 0)
            {
                adminToolStripMenuItem.Visible = false;
                hệThốngToolStripMenuItem.Visible=false;
               
            }
            else
            {
                adminToolStripMenuItem.Visible = true;
                hệThốngToolStripMenuItem.Visible=true;
            }
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportForm form = new reportForm();
            form.Show();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuu form = new frmTraCuu();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            form_DangNhap form = new form_DangNhap();
            form.Show();
        }

        private void cácLoạiVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaVe form = new frmGiaVe();
            form.Show();
        }

        private void hìnhThứcThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongdan form = new frmHuongdan();
            form.Show();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongdan form = new frmHuongdan();
            form.Show();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngKýToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            form_DangKy form = new form_DangKy();
            form.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            form_DangNhap form = new form_DangNhap();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmHuongdan from = new frmHuongdan();
            from.Show();
        }
    }
}
