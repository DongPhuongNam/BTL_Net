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
    public partial class frmTraCuu : Form
    {
        public frmTraCuu()
        {
            InitializeComponent();
            loadTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                
                dgvQLCB.DataSource = from cb in db.ChuyenBays
                                     where (cb.macb.Equals(txtMachuyenBay.Text) && cb.sbdi.Equals(txtSanbaydi.Text))
                                     
                                     || cb.sbdi.Equals(txtSanbaydi.Text) 
                                     || cb.macb.Equals(txtMachuyenBay.Text)

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
                
            }
        }

        private void loadTable()
        {
            using (DataSourceDataContext db = new DataSourceDataContext())
            {
                txtMachuyenBay.Focus();
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

             
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_DatCho form = new form_DatCho();
            form.Show();
        }
    }
}
