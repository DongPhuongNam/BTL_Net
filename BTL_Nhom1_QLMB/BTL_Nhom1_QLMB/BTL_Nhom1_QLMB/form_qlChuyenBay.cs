using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class form_qlChuyenBay : Form
    {        
        public form_qlChuyenBay()
        {
            InitializeComponent();
        }

        private bool textBoxesNotNull()
        {
            return !string.IsNullOrWhiteSpace(tbMaChuyenBay.Text)
                && !string.IsNullOrWhiteSpace(tbSanBayDi.Text)
                && !string.IsNullOrWhiteSpace(tbSanBayDen.Text)
                && !string.IsNullOrWhiteSpace(dtpGioDi.Text)
                && !string.IsNullOrWhiteSpace(dtpGioDen.Text);
        }

        private void clearAllText()
        {
            tbMaChuyenBay.Clear();
            tbSanBayDi.Clear();
            tbSanBayDen.Clear();
            dtpGioDi.Value = Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss tt"));
            dtpGioDen.Value = Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss tt"));
        }

        private void loadTable()
        {
            using(DataSourceDataContext db = new DataSourceDataContext())
            {
                tbMaChuyenBay.Focus();
                dgvQLCB.DataSource = from cb in db.ChuyenBays
                                     select new
                                     {
                                         macb = cb.macb,
                                         sbdi = cb.sbdi,
                                         sbden = cb.sbden,
                                         giodi = cb.giodi,
                                         gioden = cb.gioden,
                                         ngaydi = cb.ngaydi,
                                         ngayden = cb.ngayden,
                                         sohieu = cb.sohieu,
                                       };

                var list = (from mb in db.MayBays select mb).ToList();

                cbSoHieu.DataSource = list;
                cbSoHieu.ValueMember = "sohieu";
                cbSoHieu.DisplayMember = "sohieu";
            }
        }

        private void form_qlChuyenBay_Load(object sender, EventArgs e)
        {
            dtpGioDi.Format = DateTimePickerFormat.Custom;
            dtpGioDi.CustomFormat = "HH:mm tt";
            dtpGioDen.Format = DateTimePickerFormat.Custom;
            dtpGioDen.CustomFormat = "HH:mm tt";
            loadTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                if (textBoxesNotNull())
                {
                    string ma = tbMaChuyenBay.Text.ToString();
                    string sbdi = tbSanBayDi.Text.ToString();
                    string sbden = tbSanBayDen.Text.ToString();
                    TimeSpan giodi = TimeSpan.Parse(dtpGioDi.Value.TimeOfDay.ToString());
                    TimeSpan gioden = TimeSpan.Parse(dtpGioDen.Value.TimeOfDay.ToString());
                    DateTime ngaydi = dtpNgayDi.Value;
                    DateTime ngayden = dtpNgayDen.Value;
                    string sohieu = cbSoHieu.SelectedValue.ToString();

                    ChuyenBay insert = new ChuyenBay();
                    insert.macb = ma;
                    insert.sbdi = sbdi;
                    insert.sbden = sbden;
                    insert.giodi = giodi;
                    insert.gioden = gioden;
                    insert.ngaydi = ngaydi;
                    insert.ngayden = ngayden;
                    insert.sohieu = sohieu;

                    db.ChuyenBays.InsertOnSubmit(insert);
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
                    string ma = dgvQLCB.SelectedCells[0].OwningRow.Cells["macb"].Value.ToString();
                    string sbdi = tbSanBayDi.Text.ToString();
                    string sbden = tbSanBayDen.Text.ToString();
                    TimeSpan giodi = TimeSpan.Parse(dtpGioDi.Value.TimeOfDay.ToString());
                    TimeSpan gioden = TimeSpan.Parse(dtpGioDen.Value.TimeOfDay.ToString());
                    DateTime ngaydi = dtpNgayDi.Value;
                    DateTime ngayden = dtpNgayDen.Value;
                    string sohieu = cbSoHieu.SelectedValue.ToString();

                    ChuyenBay edit = db.ChuyenBays.Where(d => d.macb.Equals(ma)).SingleOrDefault();
                    edit.sbdi = sbdi;
                    edit.sbden = sbden;
                    edit.giodi = giodi;
                    edit.gioden = gioden;
                    edit.ngaydi = ngaydi;
                    edit.ngayden = ngayden;
                    edit.sohieu = sohieu;

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

        private void dgvQLCB_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = -1;
            selected_row = dgvQLCB.CurrentRow.Index;
            int allRows = dgvQLCB.RowCount;

            if (selected_row >= 0 && selected_row < allRows)
            {
                tbMaChuyenBay.Text = dgvQLCB.Rows[selected_row].Cells["macb"].Value.ToString();
                tbSanBayDi.Text = dgvQLCB.Rows[selected_row].Cells["sbdi"].Value.ToString();
                tbSanBayDen.Text = dgvQLCB.Rows[selected_row].Cells["sbden"].Value.ToString();
                dtpGioDi.Value = Convert.ToDateTime(dgvQLCB.Rows[selected_row].Cells["ngaydi"].Value).Date + TimeSpan.Parse(dgvQLCB.Rows[selected_row].Cells["giodi"].Value.ToString());
                dtpGioDen.Value = Convert.ToDateTime(dgvQLCB.Rows[selected_row].Cells["ngayden"].Value).Date + TimeSpan.Parse(dgvQLCB.Rows[selected_row].Cells["gioden"].Value.ToString());
                dtpNgayDi.Value = Convert.ToDateTime(dgvQLCB.Rows[selected_row].Cells["ngaydi"].Value);
                dtpNgayDen.Value = Convert.ToDateTime(dgvQLCB.Rows[selected_row].Cells["ngayden"].Value);
                cbSoHieu.SelectedValue = dgvQLCB.Rows[selected_row].Cells["sohieu"].Value;
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
                    string macb = dgvQLCB.SelectedCells[0].OwningRow.Cells["macb"].Value.ToString();
                    ChuyenBay delete = db.ChuyenBays.Where(d => d.macb.Equals(macb)).SingleOrDefault();

                    db.ChuyenBays.DeleteOnSubmit(delete);
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
