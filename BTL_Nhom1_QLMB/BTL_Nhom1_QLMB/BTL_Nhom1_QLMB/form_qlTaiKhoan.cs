using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class form_qlTaiKhoan : Form
    {
        public form_qlTaiKhoan()
        {
            InitializeComponent();
        }

        private bool textBoxesNotNull()
        {
            return !string.IsNullOrEmpty(tbTenDn.Text)
                && !string.IsNullOrEmpty(tbMatKhau.Text);
        }

        private void clearAllText()
        {
            tbTenDn.Clear();
            tbMatKhau.Clear();
            radKhachHang.Checked = true;
            tbTenDn.Focus();
        }

        private void loadTable()
        {
            using(DataSourceDataContext db = new DataSourceDataContext())
            {
                dgvTaiKhoan.DataSource = db.NguoiDungs.Select(d => d);
            }
        }

        private void form_qlTaiKhoan_Load(object sender, EventArgs e)
        {
            tbTenDn.Focus();
            loadTable();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                if (textBoxesNotNull())
                {
                    string tendn = tbTenDn.Text.ToString();
                    string matkhau = tbMatKhau.Text.ToString();
                    int loainguoidung;
                    if(radAdmin.Checked)
                    {
                        loainguoidung = 1;
                    }
                    else
                    {
                        loainguoidung = 0;
                    }

                    NguoiDung insert = new NguoiDung();
                    insert.ten_dn = tendn;
                    insert.matkhau = matkhau;
                    insert.loainguoidung = loainguoidung;

                    db.NguoiDungs.InsertOnSubmit(insert);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                }
                loadTable();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                if (textBoxesNotNull())
                {
                    string tendn = tbTenDn.Text.ToString();
                    string matkhau = tbMatKhau.Text.ToString();
                    int loainguoidung;
                    if (radAdmin.Checked)
                    {
                        loainguoidung = 1;
                    }
                    else
                    {
                        loainguoidung = 0;
                    }

                    NguoiDung edit = db.NguoiDungs.Where(d => d.ten_dn.Equals(tendn)).SingleOrDefault();
                    edit.matkhau = matkhau;
                    edit.loainguoidung = loainguoidung;

                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công");
                }
                loadTable();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                using (DataSourceDataContext db = new DataSourceDataContext())
                {
                    string tendn = tbTenDn.Text.ToString();

                    NguoiDung delete = db.NguoiDungs.Where(d => d.ten_dn.Equals(tendn)).SingleOrDefault();

                    db.NguoiDungs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");

                    loadTable();
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = -1;
            selected_row = dgvTaiKhoan.CurrentRow.Index;
            int allRows = dgvTaiKhoan.RowCount - 1;

            if (selected_row >= 0 && selected_row < allRows)
            {
                tbTenDn.Text = dgvTaiKhoan.Rows[selected_row].Cells["ten_dn"].Value.ToString();
                tbMatKhau.Text = dgvTaiKhoan.Rows[selected_row].Cells["matkhau"].Value.ToString();
                int loainguoidung = Convert.ToInt32(dgvTaiKhoan.Rows[selected_row].Cells["loainguoidung"].Value.ToString());
                if (loainguoidung == 1)
                {
                    radAdmin.Checked = true;
                }
                else
                {
                    radKhachHang.Checked = true;
                }
            }
            else
            {
                clearAllText();
            }
        }
    }
}
