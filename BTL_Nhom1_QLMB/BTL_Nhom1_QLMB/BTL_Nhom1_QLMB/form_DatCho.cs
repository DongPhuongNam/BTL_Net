using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    public partial class form_DatCho : Form
    {
        public form_DatCho()
        {
            InitializeComponent();
        }

        private bool textBoxesNotNull()
        {
            return !string.IsNullOrEmpty(tbMaKh.Text)
                && !string.IsNullOrEmpty(tbTenKH.Text)
                 && !string.IsNullOrEmpty(tbDiaChi.Text)
                  && !string.IsNullOrEmpty(tbCMT.Text)
                   && !string.IsNullOrEmpty(tbSdt.Text);
        }

        private void form_DatCho_Load(object sender, EventArgs e)
        {
            tbTenDN.Text = Program.nguoidung.ten_dn;
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                dgvLichBay.DataSource = from cb in db.ChuyenBays
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
                tbMaKh.Text = Program.khachHang.makh.ToString();
                tbTenKH.Text = Program.khachHang.ten.ToString();
                tbDiaChi.Text = Program.khachHang.diachi.ToString();
                tbSdt.Text = Program.khachHang.sdt.ToString();
                tbCMT.Text = Program.khachHang.cmt.ToString();

            }
          
        }   

        private void dgvLichBay_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = -1;
            selected_row = dgvLichBay.CurrentRow.Index;
            int allRows = dgvLichBay.RowCount;

            if (selected_row >= 0 && selected_row < allRows)
            {
                tbMaCb.Text = dgvLichBay.Rows[selected_row].Cells["macb"].Value.ToString();
                tbSanBayDi.Text = dgvLichBay.Rows[selected_row].Cells["sbdi"].Value.ToString();
                tbSanBayDen.Text = dgvLichBay.Rows[selected_row].Cells["sbden"].Value.ToString();
                dtpGioDi.Value = Convert.ToDateTime(dgvLichBay.Rows[selected_row].Cells["ngaydi"].Value).Date + TimeSpan.Parse(dgvLichBay.Rows[selected_row].Cells["giodi"].Value.ToString());
                dtpGioDen.Value = Convert.ToDateTime(dgvLichBay.Rows[selected_row].Cells["ngayden"].Value).Date + TimeSpan.Parse(dgvLichBay.Rows[selected_row].Cells["gioden"].Value.ToString());
                dtpNgayDi.Value = Convert.ToDateTime(dgvLichBay.Rows[selected_row].Cells["ngaydi"].Value);
                dtpNgayDen.Value = Convert.ToDateTime(dgvLichBay.Rows[selected_row].Cells["ngayden"].Value);
                tbSoHieu.Text = dgvLichBay.Rows[selected_row].Cells["sohieu"].Value.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMaKh.Clear();
            tbTenKH.Clear();
            tbDiaChi.Clear();
            tbSdt.Clear();
            tbCMT.Clear();
        }       

        private void btnDatCho_Click(object sender, EventArgs e)
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                if (textBoxesNotNull())
                {
                    string macb = tbMaCb.Text.ToString();


                    KhachHang edit = db.KhachHangs.Where(d => d.makh.Equals(Program.khachHang.makh)).SingleOrDefault();
                    edit.dadatcho = 1;
                   
                    db.SubmitChanges();
                    MessageBox.Show("Đặt chô thành công");
                    DialogResult result = MessageBox.Show("Bạn có muốn nhận phiếu đặt chỗ không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Program.macb = tbMaCb.Text.ToString();
                        reportForm form = new reportForm();
                        form.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn nhập thiếu dữ liệu");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
