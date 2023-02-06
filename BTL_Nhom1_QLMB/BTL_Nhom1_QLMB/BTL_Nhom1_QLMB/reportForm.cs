using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Reporting.WinForms;

namespace BTL_Nhom1_QLMB
{
    public partial class reportForm : Form
    {
        public reportForm()
        {
            InitializeComponent();
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            this.reportViewerThonTin.RefreshReport();        
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U9A605I;Initial Catalog=QuanLyChuyenBay;Integrated Security=True");
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from ChuyenBay where macb = '" + Program.macb + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            reportViewerThonTin.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSetChuyenBay", table);
            reportViewerThonTin.LocalReport.ReportPath = @"D:\Ky 1 nam 4\LLNET\Project\BTL_Nhom1_QLMB\BTL_Nhom1_QLMB\reportThongTinChuyenBay.rdlc";
            reportViewerThonTin.LocalReport.DataSources.Add(source);

            KhachHang kh = Program.khachHang;
            ReportParameter[] parms = new ReportParameter[6];
            parms[0] = new ReportParameter("ParameterMaKh", kh.makh);
            parms[1] = new ReportParameter("ParameterTenKh", kh.ten);
            parms[2] = new ReportParameter("ParameterDiaChi", kh.diachi);
            parms[3] = new ReportParameter("ParameterSdt", kh.sdt);
            parms[4] = new ReportParameter("ParameterCmt", kh.cmt);
            parms[5] = new ReportParameter("ParameterTenDn", kh.ten_dn);
            this.reportViewerThonTin.LocalReport.SetParameters(parms);

            reportViewerThonTin.RefreshReport();

            
        }
    }
}
