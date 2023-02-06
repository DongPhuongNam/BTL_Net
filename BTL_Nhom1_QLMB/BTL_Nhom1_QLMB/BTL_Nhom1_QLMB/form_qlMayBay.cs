using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class form_qlMayBay : Form
    {
        public form_qlMayBay()
        {
            InitializeComponent();
        }
        private bool textBoxesNotNull()
        {
            return !string.IsNullOrWhiteSpace(tbSoHieu.Text)
                && !string.IsNullOrWhiteSpace(cbMaLoai.Text);
        }

        private void clearAllText()
        {
            tbSoHieu.Clear();
            tbSoHieu.Focus();
        }

        private void loadTable()
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                dgvMayBay.DataSource = from mb in db.MayBays
                                          select new
                                          {
                                             sohieu = mb.sohieu,
                                             maloai = mb.maloai,
                                          };

                var list = (from lmb in db.LoaiMayBays select lmb).ToList();

                cbMaLoai.DataSource = list;
                cbMaLoai.ValueMember = "maloai";
                cbMaLoai.DisplayMember = "maloai";
            }
        }


        private void qlMayBay_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using(DataSourceDataContext db = new DataSourceDataContext())
            {
                if(textBoxesNotNull())
                {
                    string sohieu = tbSoHieu.Text.ToString();
                    string maloai = cbMaLoai.SelectedValue.ToString();

                    MayBay insert = new MayBay();
                    insert.sohieu = sohieu;
                    insert.maloai = maloai;

                    db.MayBays.InsertOnSubmit(insert);
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
                    string sohieu = tbSoHieu.Text.ToString();
                    string maloai = cbMaLoai.SelectedValue.ToString();

                    MayBay edit = db.MayBays.Where(d => d.sohieu.Equals(sohieu)).SingleOrDefault();
                    edit.maloai = maloai;

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
                    string sohieu = tbSoHieu.Text.ToString();

                    MayBay delete = db.MayBays.Where(d => d.sohieu.Equals(sohieu)).SingleOrDefault();

                    db.MayBays.DeleteOnSubmit(delete);
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

        private void dgvMayBay_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = -1;
            selected_row = dgvMayBay.CurrentRow.Index;
            int allRows = dgvMayBay.RowCount;

            if (selected_row >= 0 && selected_row < allRows)
            {
                tbSoHieu.Text = dgvMayBay.Rows[selected_row].Cells["sohieu"].Value.ToString();
                cbMaLoai.SelectedValue = dgvMayBay.Rows[selected_row].Cells["maloai"].Value.ToString();
            }
            else
            {
                clearAllText();
            }
        }
    }
}
