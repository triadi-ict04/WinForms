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
    public partial class FormPrintTransaksi : Form
    {
        //string i_str_date = "";
        string id = "";
        public FormPrintTransaksi(string raw_id)
        {
            InitializeComponent();

            //i_str_date = s_date;
            id = raw_id;
        }

        private void FormPrintTransaksi_Load(object sender, EventArgs e)
        {
            loadDSTrans();

            reportViewer1.RefreshReport();
        }
        private void loadDSConfig()
        {
            DSJT18TableAdapters.TBL_M_CONFIGURATIONTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_M_CONFIGURATIONTableAdapter();
            DSJT18.TBL_M_CONFIGURATIONDataTable i_dtab_data = new DSJT18.TBL_M_CONFIGURATIONDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetData().Select();

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            ReportDataSource ds_config = new ReportDataSource("DS_CONFIG", i_dset_data.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Add(ds_config);
            this.reportViewer1.LocalReport.Refresh();
        }
        private void loadDSTrans()
        {
            DSJT18TableAdapters.VW_T_TRANSAKSI_SLIPTableAdapter i_tadap_data = new DSJT18TableAdapters.VW_T_TRANSAKSI_SLIPTableAdapter();
            DSJT18.VW_T_TRANSAKSI_SLIPDataTable i_dtab_data = new DSJT18.VW_T_TRANSAKSI_SLIPDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            i_drow_data = i_tadap_data.GetDataReport(id).Select();

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            ReportDataSource ds_config = new ReportDataSource("DS_TRANS", i_dset_data.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Add(ds_config);
            this.reportViewer1.LocalReport.Refresh();
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            reportViewer1.PrintDialog();
        }
    }
}
