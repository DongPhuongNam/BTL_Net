using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class form_qlDatCho : Form
    {
        public form_qlDatCho()
        {
            InitializeComponent();
        }

        private bool textBoxesNotNull()
        {
            return !string.IsNullOrEmpty(tbMaKh.Text)
                && !string.IsNullOrEmpty(tbSoGhe.Text);
        }

        private void clearAllText()
        {
            tbSoGhe.Clear();
            tbMaKh.Clear();
            cbMaChuyenBay.SelectedIndex = 0;
            tbSoGhe.Focus();
        }

        private string getSoGhe()
        {
            int selected_row = -1;
            selected_row = dgvDatCho.CurrentRow.Index;
            string soghe = dgvDatCho.Rows[selected_row].Cells["soghe"].Value.ToString();
            return soghe;
        }

        private string getMaKh()
        {
            int selected_row = -1;
            selected_row = dgvDatCho.CurrentRow.Index;
            string makh = dgvDatCho.Rows[selected_row].Cells["makh"].Value.ToString();
            return makh;
        }
         

        private void loadTable()
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                dgvDatCho.DataSource = from dc in db.DatChos
                                       select new
                                       {
                                           soghe = dc.soghe,
                                           makh = dc.makh,
                                           thoigiandi = dc.thoigiandi,
                                           macb = dc.macb,
                                       };

                var list = (from cb in db.ChuyenBays select cb).ToList();

                cbMaChuyenBay.DataSource = list;
                cbMaChuyenBay.ValueMember = "macb";
                cbMaChuyenBay.DisplayMember = "macb";


                
                dgvKhachHang.DataSource = from kh in db.KhachHangs
                                          select new
                                          {
                                              makh = kh.makh,                                             
                                              dadatcho = kh.dadatcho,
                                          };
            }
        }

        private void form_qlDatCho_Load(object sender, EventArgs e)
        {
            loadTable();
            tbSoGhe.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                if (textBoxesNotNull())
                {
                    string soghe = getSoGhe();
                    string makh = tbMaKh.Text;
                    DateTime ngaydi = dtpNgayDi.Value;
                    string macb = cbMaChuyenBay.SelectedValue.ToString();

                    string makhEdit = tbMaKh.Text;
                    KhachHang edit = db.KhachHangs.Where(d => d.makh.Equals(makhEdit)).SingleOrDefault();
                    edit.dadatcho = 1;

                    DatCho insert = db.DatChos.Where(d => d.soghe.Equals(soghe)).SingleOrDefault();
                    insert.makh = makh;
                    insert.thoigiandi = ngaydi;
                    insert.macb = macb;

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
                    string soghe = getSoGhe();
                    string makh = tbMaKh.Text.ToString();
                    DateTime ngaydi = dtpNgayDi.Value;
                    string macb = cbMaChuyenBay.SelectedValue.ToString();

                    string makhEdit = getMaKh();
                    KhachHang editKH = db.KhachHangs.Where(d => d.makh.Equals(makhEdit)).SingleOrDefault();
                    editKH.dadatcho = 1;

                    DatCho edit = db.DatChos.Where(d => d.soghe.Equals(soghe)).SingleOrDefault();
                    edit.makh = makh;
                    edit.thoigiandi = ngaydi;
                    edit.macb = macb;

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
                    string soghe = getSoGhe();

                    DatCho delete = db.DatChos.Where(d => d.soghe.Equals(soghe)).SingleOrDefault();
                    delete.makh = null;
                    delete.macb = null;
                    delete.thoigiandi = null;

                    KhachHang deleteKh = db.KhachHangs.Where(p => p.makh.Equals(getMaKh())).SingleOrDefault();
                    deleteKh.dadatcho = 0;
                  
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

        private void dgvDatCho_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = -1;
            selected_row = dgvDatCho.CurrentRow.Index;
            int allRows = dgvDatCho.RowCount;

            if (selected_row >= 0 && selected_row < allRows )
            {
                if(dgvDatCho.Rows[selected_row].Cells["makh"].Value != null
                    && dgvDatCho.Rows[selected_row].Cells["thoigiandi"].Value != null
                    && dgvDatCho.Rows[selected_row].Cells["macb"].Value != null)
                {
                    tbSoGhe.Text = dgvDatCho.Rows[selected_row].Cells["soghe"].Value.ToString();
                    tbMaKh.Text = dgvDatCho.Rows[selected_row].Cells["makh"].Value.ToString();
                    dtpNgayDi.Value = Convert.ToDateTime(dgvDatCho.Rows[selected_row].Cells["thoigiandi"].Value.ToString());
                    cbMaChuyenBay.SelectedValue = dgvDatCho.Rows[selected_row].Cells["macb"].Value.ToString();
                }
                else
                {
                    tbSoGhe.Text = dgvDatCho.Rows[selected_row].Cells["soghe"].Value.ToString();
                    tbMaKh.Clear();
                    dtpNgayDi.Value = DateTime.Today;
                    cbMaChuyenBay.SelectedIndex = 0;
                }
            }
            else
            {
                clearAllText();
            }
        }
    }
}
