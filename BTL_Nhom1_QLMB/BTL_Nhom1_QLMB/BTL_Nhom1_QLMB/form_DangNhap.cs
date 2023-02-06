using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class form_DangNhap : Form
    {
        DataSourceDataContext db = new DataSourceDataContext();
        public form_DangNhap()
        {
            InitializeComponent();
        }

        private bool textBoxesNotNull()
        {
            return !string.IsNullOrEmpty(tbTaiKhoan.Text)
                && !string.IsNullOrEmpty(tbMatKhau.Text);
        }

        private void form_DangNhap_Load(object sender, EventArgs e)
        {
            tbTaiKhoan.Focus();
            chkHienThiMatKhau.Checked = false;
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            tbMatKhau.PasswordChar = chkHienThiMatKhau.Checked ? '\0' : '*';
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(textBoxesNotNull())
            {
                string taikhoan = tbTaiKhoan.Text.ToString();
                string matkhau = tbMatKhau.Text.ToString();
                
                NguoiDung nd = db.NguoiDungs.Where(d => d.ten_dn.Equals(taikhoan) && d.matkhau.Equals(matkhau)).SingleOrDefault();
                Program.khachHang = db.KhachHangs.Where(d => d.ten_dn.Equals(taikhoan)).SingleOrDefault();
                if(nd != null)
                {
                    Program.nguoidung = nd;
                    frmMenu form = new frmMenu();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Error", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void form_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbTaiKhoan.Text.Trim() == "")
                    MessageBox.Show("Tài khoản không thể để trống!",
                        "Thống báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                    tbMatKhau.Focus();
            }
        }

        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbMatKhau.Text.Trim() == "")
                    MessageBox.Show("Mật khẩu không thể để trống!",
                        "Thống báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                    btnDangnhap_Click(sender, e);
            }
        }

        private void labelChuyenManHinhDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_DangKy form = new form_DangKy();
            form.Show();
            this.Hide();
        }
    }
}
