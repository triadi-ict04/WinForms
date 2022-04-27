using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WinForms
{
    public partial class FormPrintListTransaksi : Form
    {
        string i_str_date = "";
        public FormPrintListTransaksi(string s_date)
        {
            InitializeComponent();

            i_str_date = s_date;
        }

        private void FormPrintListTransaksi_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            LocalReport lcl_report = reportViewer1.LocalReport;

            lcl_report.ReportPath = "ReportListTransaksi.rdlc";

            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("TGL_PROD", i_str_date);
            lcl_report.SetParameters(param);


            processReport(lcl_report);

            this.reportViewer1.RefreshReport();

        }

        private void processReport(LocalReport s_report)
        {
            DSJT18TableAdapters.VW_T_TRANSAKSI_SLIPTableAdapter i_tadap_data = new DSJT18TableAdapters.VW_T_TRANSAKSI_SLIPTableAdapter();
            DSJT18.VW_T_TRANSAKSI_SLIPDataTable i_dtab_data = new DSJT18.VW_T_TRANSAKSI_SLIPDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetTransByDate(i_str_date).Select("", "TRANS_DATETIME ASC");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            ReportDataSource ds_config = new ReportDataSource("DS_TRANS", i_dset_data.Tables[0]);
            s_report.DataSources.Add(ds_config);

        }
    }
}
