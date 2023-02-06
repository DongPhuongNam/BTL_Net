using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class form_qlLoaiMayBay : Form
    {
        public form_qlLoaiMayBay()
        {
            InitializeComponent();
        }

        private bool textBoxesNotNull()
        {
            return !string.IsNullOrWhiteSpace(tbMaLoai.Text)
                && !string.IsNullOrWhiteSpace(tbHangSanXuat.Text);
        }

        private void clearAllText()
        {
            tbMaLoai.Clear();
            tbHangSanXuat.Clear();
            tbMaLoai.Focus();
        }

        private void loadTable()
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                dgvLoaiMayBay.DataSource =  db.LoaiMayBays.Select(d => d);
            }
        }

        private void form_qlLoaiMayBay_Load(object sender, EventArgs e)
        {
            
            tbMaLoai.Focus();
            loadTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                if (textBoxesNotNull())
                {
                    string ma = tbMaLoai.Text.ToString();
                    string hang = tbHangSanXuat.Text.ToString();

                    LoaiMayBay insert = new LoaiMayBay();
                    insert.maloai = ma;
                    insert.hang_sx = hang;

                    db.LoaiMayBays.InsertOnSubmit(insert);
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
                    string ma = tbMaLoai.Text.ToString();
                    string hang = tbHangSanXuat.Text.ToString();

                    LoaiMayBay edit = db.LoaiMayBays.Where(d => d.maloai.Equals(ma)).SingleOrDefault();
                    edit.hang_sx = hang;

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

        private void dgvLoaiMayBay_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = -1;
            selected_row = dgvLoaiMayBay.CurrentRow.Index;
            int allRows = dgvLoaiMayBay.RowCount - 1;

            if (selected_row >= 0 && selected_row < allRows)
            {
                tbMaLoai.Text = dgvLoaiMayBay.Rows[selected_row].Cells["maloai"].Value.ToString();
                tbHangSanXuat.Text = dgvLoaiMayBay.Rows[selected_row].Cells["hang_sx"].Value.ToString();             
            }
            else
            {
                clearAllText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                using (DataSourceDataContext db = new DataSourceDataContext())
                {
                    string ma = dgvLoaiMayBay.SelectedCells[0].OwningRow.Cells["maloai"].Value.ToString();
                    LoaiMayBay delete = db.LoaiMayBays.Where(d => d.maloai.Equals(ma)).SingleOrDefault();

                    db.LoaiMayBays.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                }
                loadTable();
            }           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
