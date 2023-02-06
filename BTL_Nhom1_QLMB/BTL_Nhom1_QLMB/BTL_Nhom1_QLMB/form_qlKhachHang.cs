using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class form_qlKhachHang : Form
    {
        public form_qlKhachHang()
        {
            InitializeComponent();
        }

        private bool textBoxesNotNull()
        {
            return !string.IsNullOrWhiteSpace(tbMaKh.Text)
                && !string.IsNullOrWhiteSpace(tbTenKH.Text)
                && !string.IsNullOrWhiteSpace(tbDiaChi.Text)
                && !string.IsNullOrWhiteSpace(tbSdt.Text)
                && !string.IsNullOrWhiteSpace(tbCmnd.Text)
                && !string.IsNullOrWhiteSpace(tbTenDn.Text);
        }

        private void clearAllText()
        {
            tbMaKh.Clear();
            tbTenKH.Clear();
            tbDiaChi.Clear();
            tbSdt.Clear();
            tbCmnd.Clear();
            tbTenDn.Clear();
            tbMaKh.Focus();
        }

        private void loadTable()
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                dgvKhachHang.DataSource = from kh in db.KhachHangs
                                               select new
                                               {
                                                   makh  = kh.makh,
                                                   ten = kh.ten,
                                                   diachi = kh.diachi,
                                                   sdt = kh.sdt,
                                                   cmt = kh.cmt,
                                                   ten_dn = kh.ten_dn,
                                               };
            }
        }

        private void form_qlKhachHang_Load(object sender, EventArgs e)
        {
            tbMaKh.Focus();
            loadTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                if (textBoxesNotNull())
                {
                    string ma = tbMaKh.Text.ToString();
                    string ten = tbTenKH.Text.ToString();
                    string diachi = tbDiaChi.Text.ToString();
                    string sdt = tbSdt.Text.ToString();
                    string cmt = tbCmnd.Text.ToString();
                    string tendn = tbTenDn.Text.ToString();

                    KhachHang insert = new KhachHang();
                    insert.makh = ma;
                    insert.ten = ten;
                    insert.diachi = diachi;
                    insert.sdt = sdt;
                    insert.cmt = cmt;
                    insert.ten_dn = tendn;

                    db.KhachHangs.InsertOnSubmit(insert);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công");

                }
                else
                {
                    MessageBox.Show("Bạn nhập thiếu dữ liệu");
                }
            }
            loadTable();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                if (textBoxesNotNull())
                {

                    string ma = tbMaKh.Text.ToString();
                    string ten = tbTenKH.Text.ToString();
                    string diachi = tbDiaChi.Text.ToString();
                    string sdt = tbSdt.Text.ToString();
                    string cmt = tbCmnd.Text.ToString();
                    string tendn = tbTenDn.Text.ToString();

                    KhachHang edit = db.KhachHangs.Where(d => d.makh.Equals(ma)).SingleOrDefault();
                    edit.ten = ten;
                    edit.diachi = diachi;
                    edit.sdt = sdt;
                    edit.cmt = cmt;
                    edit.ten_dn = tendn;

                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Bạn nhập thiếu dữ liệu");
                }
            }
            loadTable();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                using (DataSourceDataContext db = new DataSourceDataContext())
                {
                    string makh = dgvKhachHang.SelectedCells[0].OwningRow.Cells["makh"].Value.ToString();
                    KhachHang delete = db.KhachHangs.Where(d => d.makh.Equals(makh)).SingleOrDefault();

                    db.KhachHangs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                }
                loadTable();
            }              
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = -1;
            selected_row = dgvKhachHang.CurrentRow.Index;
            int allRows = dgvKhachHang.RowCount;

            if (selected_row >= 0 && selected_row < allRows)
            {
                tbMaKh.Text = dgvKhachHang.Rows[selected_row].Cells["makh"].Value.ToString();
                tbTenKH.Text = dgvKhachHang.Rows[selected_row].Cells["ten"].Value.ToString();
                tbDiaChi.Text = dgvKhachHang.Rows[selected_row].Cells["diachi"].Value.ToString();
                tbSdt.Text = dgvKhachHang.Rows[selected_row].Cells["sdt"].Value.ToString();
                tbCmnd.Text = dgvKhachHang.Rows[selected_row].Cells["cmt"].Value.ToString();
                tbTenDn.Text = dgvKhachHang.Rows[selected_row].Cells["ten_dn"].Value.ToString();
            }
            else
            {
                clearAllText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
