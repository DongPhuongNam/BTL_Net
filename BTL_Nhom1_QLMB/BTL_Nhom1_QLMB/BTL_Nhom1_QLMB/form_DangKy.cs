using System;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class form_DangKy : Form
    {
        DataSourceDataContext db = new DataSourceDataContext();
        public form_DangKy()
        {
            InitializeComponent();
        }

        private bool textBoxesNotNull()
        {
            return !string.IsNullOrEmpty(tbTaiKhoan.Text)
                && !string.IsNullOrEmpty(tbTaiKhoan.Text)
                && !string.IsNullOrEmpty(tbTaiKhoan.Text)
                && !string.IsNullOrEmpty(tbTaiKhoan.Text)
                && !string.IsNullOrEmpty(tbTaiKhoan.Text)
                && !string.IsNullOrEmpty(tbTaiKhoan.Text)
                && !string.IsNullOrEmpty(tbMatKhau.Text);
        }

        private bool validatePassword()
        {
            return tbMatKhau.Text.ToString().Length >= 8;
        }

        private void form_DangKy_Load(object sender, EventArgs e)
        {
            tbMaKh.Focus();
            chkHienThiMatKhau.Checked = false;

            Random random = new Random();
            int soMa = random.Next(20, 5000);
            tbMaKh.Text = "kh" + soMa;
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            tbMatKhau.PasswordChar = chkHienThiMatKhau.Checked ? '\0' : '*';
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (textBoxesNotNull())
            {
                if (validatePassword())
                {
                    string makh = tbMaKh.Text.ToString();
                    string tenkh = tbTenKh.Text.ToString();
                    string diachi = tbTenKh.Text.ToString();
                    string sdt = tbTenKh.Text.ToString();
                    string cmt = tbCmt.Text.ToString();

                    string taikhoan = tbTaiKhoan.Text.ToString();
                    string matkhau = tbMatKhau.Text.ToString();

                    NguoiDung nd = new NguoiDung();
                    nd.ten_dn = taikhoan;
                    nd.matkhau = matkhau;
                    nd.loainguoidung = 0;            

                    KhachHang kh = new KhachHang();
                    kh.makh = makh;
                    kh.ten = tenkh;
                    kh.diachi = diachi;
                    kh.sdt = sdt;
                    kh.cmt = cmt;
                    kh.ten_dn = taikhoan;
                    kh.dadatcho = 0;

                    db.KhachHangs.InsertOnSubmit(kh);
                    db.NguoiDungs.InsertOnSubmit(nd);
                    db.SubmitChanges();
                    MessageBox.Show("Đăng ký thành công");

                    Program.khachHang = kh;
                    Program.nguoidung = nd;

                    frmMenu form = new frmMenu();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải có độ dài lớn hơn 7 ký tự");
                }

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống");
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

        private void labelChuyenManHinhDangNhpa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_DangNhap form = new form_DangNhap();
            form.Show();
            this.Hide();
        }

        private void form_DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
