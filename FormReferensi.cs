using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormReferensi : Form
    {
        public FormReferensi()
        {
            InitializeComponent();
            pv_cust_loadEntity();
            pv_cust_loadEntityAktif();
            pv_cust_loadProduct();
            pv_cust_loadProductEntity();
            pv_cust_loadProductAktif();
            pv_cust_loadContractor();
            pv_cust_loadContractorAktif();
            pv_cust_loadCPP();
            pv_cust_loadCPPEntity();
            pv_cust_loadCPPAktif();
            pv_cust_loadStockpile();
            pv_cust_loadStockpileAktif();
        }

        #region entity

        private void pv_cust_loadEntity()
        {
            try
            {
                DSJT18TableAdapters.TBL_R_ENTITYTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_ENTITYTableAdapter();
                DSJT18.TBL_R_ENTITYDataTable i_dtab_data = new DSJT18.TBL_R_ENTITYDataTable();
                System.Data.DataRow[] i_drow_data;
                DataSet i_dset_data = new DataSet();

                i_drow_data = i_tadap_data.GetData().Select("", "ENTITY_NAME ASC");

                foreach (var i_data in i_drow_data)
                {
                    i_dtab_data.ImportRow(i_data);
                }

                i_dset_data.Tables.Add(i_dtab_data);

                dgvEntity.DataSource = i_dset_data.Tables[0];

                //foreach(DataGridViewRow row in dgv_condition.Rows)
                //{
                //    if (row.Cells["Cond_code"].Value.ToString() == "")
                //    {
                //        row.Cells["COnd_code"].ReadOnly = false;
                //    }
                //}

                //dgv_condition.Rows[dgv_condition.Rows.Add() - 1].Cells["COND_CODE"].ReadOnly = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load entity : \n" + ex.Message.ToString());
            }

        }


        private void dgvEntity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Color icolor = dgvEntity.CurrentRow.DefaultCellStyle.SelectionBackColor;

                dgvEntity.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Crimson;



                if (MessageBox.Show("Yakin Menghapus data ini", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        DSJT18TableAdapters.TBL_R_ENTITYTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_ENTITYTableAdapter();

                        i_tadap.DeleteEntity(dgvEntity.CurrentRow.Cells["ENTITY_CODE"].Value.ToString());

                        pv_cust_loadEntity();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error delete : \n " + ex.Message.ToString());
                    }
                }

                dgvEntity.CurrentRow.DefaultCellStyle.SelectionBackColor = icolor;
            }
        }

        private void dgvEntity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeEntity.Text = dgvEntity.Rows[e.RowIndex].Cells["ENTITY_CODE"].Value.ToString();
            txtDescEntity.Text = dgvEntity.Rows[e.RowIndex].Cells["ENTITY_NAME"].Value.ToString();
            cbAktifEntity.Text = dgvEntity.Rows[e.RowIndex].Cells["ENTITY_AKTIF"].Value.ToString();

            btnSaveEntity.Text = "UPDATE";
        }

        private void btnSaveEntity_Click(object sender, EventArgs e)
        {
            DSJT18TableAdapters.TBL_R_ENTITYTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_ENTITYTableAdapter();

            try
            {


                if (txtCodeEntity.Text.ToString().Trim().Length != 0 && txtDescEntity.Text.ToString().Trim().Length != 0)
                {

                    if (btnSaveEntity.Text.ToString() == "SAVE")
                    {
                        i_tadap.InsertEntity(txtCodeEntity.Text.ToString(), txtDescEntity.Text.ToString(), "1");

                        MessageBox.Show("Insert data berhasil");
                    }
                    else
                    {
                        i_tadap.UpdateEntity(txtDescEntity.Text, txtCodeEntity.Text);

                        MessageBox.Show("Update data berhasil");
                    }

                    pv_cust_loadEntity();
                    btnSaveEntity.Text = "SAVE";
                    txtCodeEntity.Text = "";
                    txtDescEntity.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trans entity : \n" + ex.Message.ToString());
            }
        }

        private void pv_cust_loadEntityAktif()
        {
            DSJT18TableAdapters.TBL_R_ENTITYTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_ENTITYTableAdapter();
            DSJT18.TBL_R_ENTITYDataTable i_dtab_data = new DSJT18.TBL_R_ENTITYDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            //i_drow_data = i_tadap_data.GetData().Select("", "ENTITY_AKTIF ASC");
            i_drow_data = i_tadap_data.GetData().Select("", "");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            cbAktifEntity.DataSource = i_dset_data.Tables[0];
            cbAktifEntity.ValueMember = i_dset_data.Tables[0].Columns["ENTITY_AKTIF"].ColumnName.ToString();
            cbAktifEntity.DisplayMember = i_dset_data.Tables[0].Columns["ENTITY_AKTIF"].ColumnName.ToString();

        }
        #endregion

        #region product
        private void pv_cust_loadProduct()
        {
            try
            {
                DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter();
                DSJT18.TBL_R_PRODUCTDataTable i_dtab_data = new DSJT18.TBL_R_PRODUCTDataTable();
                System.Data.DataRow[] i_drow_data;
                DataSet i_dset_data = new DataSet();

                i_drow_data = i_tadap_data.GetData().Select("", "PRODUCT_NAME ASC");

                foreach (var i_data in i_drow_data)
                {
                    i_dtab_data.ImportRow(i_data);
                }

                i_dset_data.Tables.Add(i_dtab_data);

                dgvProduct.DataSource = i_dset_data.Tables[0];

                //foreach(DataGridViewRow row in dgv_condition.Rows)
                //{
                //    if (row.Cells["Cond_code"].Value.ToString() == "")
                //    {
                //        row.Cells["COnd_code"].ReadOnly = false;
                //    }
                //}

                //dgv_condition.Rows[dgv_condition.Rows.Add() - 1].Cells["COND_CODE"].ReadOnly = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load product : \n" + ex.Message.ToString());
            }
        }
        private void pv_cust_loadProductEntity()
        {
            DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter();
            DSJT18.TBL_R_PRODUCTDataTable i_dtab_data = new DSJT18.TBL_R_PRODUCTDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            //i_drow_data = i_tadap_data.GetData().Select("", "ENTITY_AKTIF ASC");
            i_drow_data = i_tadap_data.GetData().Select("", "");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            for (int x = 0; x <= i_dset_data.Tables[0].Rows.Count - 1; x++)
            {
                auto.Add(i_dset_data.Tables[0].Rows[x]["PRODUCT_ENTITY"].ToString());
            }
            cbEntityProduct.DataSource = i_dset_data.Tables[0];
            cbEntityProduct.ValueMember = i_dset_data.Tables[0].Columns["PRODUCT_ENTITY"].ColumnName.ToString();
            cbEntityProduct.DisplayMember = i_dset_data.Tables[0].Columns["PRODUCT_ENTITY"].ColumnName.ToString();

            cbEntityProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEntityProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEntityProduct.AutoCompleteCustomSource = auto;

        }
        private void pv_cust_loadProductAktif()
        {
            DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter();
            DSJT18.TBL_R_PRODUCTDataTable i_dtab_data = new DSJT18.TBL_R_PRODUCTDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            //i_drow_data = i_tadap_data.GetData().Select("", "ENTITY_AKTIF ASC");
            i_drow_data = i_tadap_data.GetData().Select("", "");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            cbAktifProduct.DataSource = i_dset_data.Tables[0];
            cbAktifProduct.ValueMember = i_dset_data.Tables[0].Columns["PRODUCT_ACTIVE"].ColumnName.ToString();
            cbAktifProduct.DisplayMember = i_dset_data.Tables[0].Columns["PRODUCT_ACTIVE"].ColumnName.ToString();

        }
        private void dgvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Color icolor = dgvProduct.CurrentRow.DefaultCellStyle.SelectionBackColor;

                dgvProduct.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Crimson;



                if (MessageBox.Show("Yakin Menghapus data ini", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter();

                        i_tadap.DeleteProduct(dgvProduct.CurrentRow.Cells["PRODUCT_CODE"].Value.ToString());

                        pv_cust_loadProduct();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error delete : \n " + ex.Message.ToString());
                    }
                }

                dgvProduct.CurrentRow.DefaultCellStyle.SelectionBackColor = icolor;
            }
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeProduct.Text = dgvProduct.Rows[e.RowIndex].Cells["PRODUCT_CODE"].Value.ToString();
            cbEntityProduct.Text = dgvProduct.Rows[e.RowIndex].Cells["PRODUCT_ENTITY"].Value.ToString();
            txtNamaProduct.Text = dgvProduct.Rows[e.RowIndex].Cells["PRODUCT_NAME"].Value.ToString();
            txtDescProduct.Text = dgvProduct.Rows[e.RowIndex].Cells["PRODUCT_DESC"].Value.ToString();
            cbAktifProduct.Text = dgvProduct.Rows[e.RowIndex].Cells["PRODUCT_ACTIVE"].Value.ToString();

            btnSaveProduct.Text = "UPDDATE";
        }
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_PRODUCTTableAdapter();

            try
            {


                if (txtCodeProduct.Text.ToString().Trim().Length != 0 && txtNamaProduct.Text.ToString().Trim().Length != 0 && txtDescProduct.Text.ToString().Trim().Length != 0)
                {

                    if (btnSaveProduct.Text.ToString() == "SAVE")
                    {
                        i_tadap.InsertProduct(txtCodeProduct.Text.ToString(), cbEntityProduct.SelectedValue.ToString(), txtNamaProduct.Text.ToString(), txtDescProduct.Text.ToString(), "1");

                        MessageBox.Show("Insert data berhasil");
                    }
                    else
                    {
                        i_tadap.UpdateProduct(cbEntityProduct.Text, txtNamaProduct.Text, txtDescProduct.Text, txtCodeProduct.Text);

                        MessageBox.Show("Update data berhasil");
                    }

                    pv_cust_loadProduct();
                    btnSaveProduct.Text = "SAVE";
                    txtCodeProduct.Text = "";
                    txtNamaProduct.Text = "";
                    txtDescProduct.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trans product : \n" + ex.Message.ToString());
            }
        }

        #endregion

        #region contractor

        private void pv_cust_loadContractor()
        {
            try
            {
                DSJT18TableAdapters.TBL_R_CONTRACTORTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_CONTRACTORTableAdapter();
                DSJT18.TBL_R_CONTRACTORDataTable i_dtab_data = new DSJT18.TBL_R_CONTRACTORDataTable();
                System.Data.DataRow[] i_drow_data;
                DataSet i_dset_data = new DataSet();

                i_drow_data = i_tadap_data.GetData().Select("", "CONTRACTOR_CODE ASC");

                foreach (var i_data in i_drow_data)
                {
                    i_dtab_data.ImportRow(i_data);
                }

                i_dset_data.Tables.Add(i_dtab_data);

                dgvContractor.DataSource = i_dset_data.Tables[0];

                //foreach(DataGridViewRow row in dgv_condition.Rows)
                //{
                //    if (row.Cells["Cond_code"].Value.ToString() == "")
                //    {
                //        row.Cells["COnd_code"].ReadOnly = false;
                //    }
                //}

                //dgv_condition.Rows[dgv_condition.Rows.Add() - 1].Cells["COND_CODE"].ReadOnly = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load contractor : \n" + ex.Message.ToString());
            }

        }
        private void pv_cust_loadContractorAktif()
        {
            DSJT18TableAdapters.TBL_R_CONTRACTORTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_CONTRACTORTableAdapter();
            DSJT18.TBL_R_CONTRACTORDataTable i_dtab_data = new DSJT18.TBL_R_CONTRACTORDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            //i_drow_data = i_tadap_data.GetData().Select("", "ENTITY_AKTIF ASC");
            i_drow_data = i_tadap_data.GetData().Select("", "");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            cbAktifContractor.DataSource = i_dset_data.Tables[0];
            cbAktifContractor.ValueMember = i_dset_data.Tables[0].Columns["CONTRACTOR_AKTIF"].ColumnName.ToString();
            cbAktifContractor.DisplayMember = i_dset_data.Tables[0].Columns["CONTRACTOR_AKTIF"].ColumnName.ToString();

        }
        private void dgvContractor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Color icolor = dgvContractor.CurrentRow.DefaultCellStyle.SelectionBackColor;

                dgvContractor.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Crimson;



                if (MessageBox.Show("Yakin Menghapus data ini", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        DSJT18TableAdapters.TBL_R_CONTRACTORTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_CONTRACTORTableAdapter();

                        i_tadap.DeleteContractor(dgvContractor.CurrentRow.Cells["CONTRACTOR_CODE"].Value.ToString());

                        pv_cust_loadContractor();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error delete : \n " + ex.Message.ToString());
                    }
                }

                dgvContractor.CurrentRow.DefaultCellStyle.SelectionBackColor = icolor;
            }
        }

        private void dgvContractor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeContractor.Text = dgvContractor.Rows[e.RowIndex].Cells["CONTRACTOR_CODE"].Value.ToString();
            txtNameContractor.Text = dgvContractor.Rows[e.RowIndex].Cells["CONTRACTOR_NAME"].Value.ToString();
            cbAktifContractor.Text = dgvContractor.Rows[e.RowIndex].Cells["CONTRACTOR_AKTIF"].Value.ToString();

            btnSaveContractor.Text = "UPDATE";
        }

        private void btnSaveContractor_Click(object sender, EventArgs e)
        {
            DSJT18TableAdapters.TBL_R_CONTRACTORTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_CONTRACTORTableAdapter();

            try
            {


                if (txtCodeContractor.Text.ToString().Trim().Length != 0 && txtNameContractor.Text.ToString().Trim().Length != 0)
                {

                    if (btnSaveContractor.Text.ToString() == "SAVE")
                    {
                        i_tadap.InsertContractor(txtCodeContractor.Text.ToString(), txtNameContractor.Text.ToString(), "1");

                        MessageBox.Show("Insert data berhasil");
                    }
                    else
                    {
                        i_tadap.UpdateContractor(txtNameContractor.Text, txtCodeContractor.Text);

                        MessageBox.Show("Update data berhasil");
                    }

                    pv_cust_loadContractor();
                    btnSaveContractor.Text = "SAVE";
                    txtCodeContractor.Text = "";
                    txtNameContractor.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trans contractor : \n" + ex.Message.ToString());
            }
        }

        #endregion

        #region cpp
        private void pv_cust_loadCPP()
        {
            try
            {
                DSJT18TableAdapters.TBL_R_CPPTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_CPPTableAdapter();
                DSJT18.TBL_R_CPPDataTable i_dtab_data = new DSJT18.TBL_R_CPPDataTable();
                System.Data.DataRow[] i_drow_data;
                DataSet i_dset_data = new DataSet();

                i_drow_data = i_tadap_data.GetData().Select("", "CPP_ENTITY ASC");

                foreach (var i_data in i_drow_data)
                {
                    i_dtab_data.ImportRow(i_data);
                }

                i_dset_data.Tables.Add(i_dtab_data);

                dgvCPP.DataSource = i_dset_data.Tables[0];

                //foreach(DataGridViewRow row in dgv_condition.Rows)
                //{
                //    if (row.Cells["Cond_code"].Value.ToString() == "")
                //    {
                //        row.Cells["COnd_code"].ReadOnly = false;
                //    }
                //}

                //dgv_condition.Rows[dgv_condition.Rows.Add() - 1].Cells["COND_CODE"].ReadOnly = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load cpp : \n" + ex.Message.ToString());
            }
        }
        private void pv_cust_loadCPPEntity()
        {
            DSJT18TableAdapters.TBL_R_CPPTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_CPPTableAdapter();
            DSJT18.TBL_R_CPPDataTable i_dtab_data = new DSJT18.TBL_R_CPPDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            //i_drow_data = i_tadap_data.GetData().Select("", "ENTITY_AKTIF ASC");
            i_drow_data = i_tadap_data.GetData().Select("", "");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            for (int x = 0; x <= i_dset_data.Tables[0].Rows.Count - 1; x++)
            {
                auto.Add(i_dset_data.Tables[0].Rows[x]["CPP_ENTITY"].ToString());
            }
            cbEntityCPP.DataSource = i_dset_data.Tables[0];
            cbEntityCPP.ValueMember = i_dset_data.Tables[0].Columns["CPP_ENTITY"].ColumnName.ToString();
            cbEntityCPP.DisplayMember = i_dset_data.Tables[0].Columns["CPP_ENTITY"].ColumnName.ToString();

            cbEntityCPP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbEntityCPP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEntityCPP.AutoCompleteCustomSource = auto;

        }
        private void pv_cust_loadCPPAktif()
        {
            DSJT18TableAdapters.TBL_R_CPPTableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_CPPTableAdapter();
            DSJT18.TBL_R_CPPDataTable i_dtab_data = new DSJT18.TBL_R_CPPDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            //i_drow_data = i_tadap_data.GetData().Select("", "ENTITY_AKTIF ASC");
            i_drow_data = i_tadap_data.GetData().Select("", "");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            cbAktifCPP.DataSource = i_dset_data.Tables[0];
            cbAktifCPP.ValueMember = i_dset_data.Tables[0].Columns["CPP_AKTIF"].ColumnName.ToString();
            cbAktifCPP.DisplayMember = i_dset_data.Tables[0].Columns["CPP_AKTIF"].ColumnName.ToString();

        }
        private void dgvCPP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Color icolor = dgvCPP.CurrentRow.DefaultCellStyle.SelectionBackColor;

                dgvCPP.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Crimson;



                if (MessageBox.Show("Yakin Menghapus data ini", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        DSJT18TableAdapters.TBL_R_CPPTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_CPPTableAdapter();

                        i_tadap.DeleteCPP(dgvCPP.CurrentRow.Cells["CPP_CODE"].Value.ToString());

                        pv_cust_loadCPP();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error delete : \n " + ex.Message.ToString());
                    }
                }

                dgvCPP.CurrentRow.DefaultCellStyle.SelectionBackColor = icolor;
            }
        }

        private void dgvCPP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeCPP.Text = dgvCPP.Rows[e.RowIndex].Cells["CPP_CODE"].Value.ToString();
            cbEntityCPP.Text = dgvCPP.Rows[e.RowIndex].Cells["CPP_ENTITY"].Value.ToString();
            txtLokasiCPP.Text = dgvCPP.Rows[e.RowIndex].Cells["CPP_LOKASI"].Value.ToString();
            txtDescCPP.Text = dgvCPP.Rows[e.RowIndex].Cells["CPP_DESC"].Value.ToString();
            cbAktifCPP.Text = dgvCPP.Rows[e.RowIndex].Cells["CPP_AKTIF"].Value.ToString();

            btnSaveCPP.Text = "UPDATE";
        }

        private void btnSaveCPP_Click(object sender, EventArgs e)
        {
            DSJT18TableAdapters.TBL_R_CPPTableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_CPPTableAdapter();

            try
            {


                if (txtCodeCPP.Text.ToString().Trim().Length != 0 && txtLokasiCPP.Text.ToString().Trim().Length != 0 && txtDescCPP.Text.ToString().Trim().Length != 0)
                {

                    if (btnSaveCPP.Text.ToString() == "SAVE")
                    {
                        i_tadap.InsertCPP(txtCodeCPP.Text.ToString(), cbEntityCPP.SelectedValue.ToString(), txtLokasiCPP.Text.ToString(), txtDescCPP.Text.ToString(), "1");

                        MessageBox.Show("Insert data berhasil");
                    }
                    else
                    {
                        i_tadap.UpdateCPP(cbEntityCPP.Text, txtLokasiCPP.Text, txtDescCPP.Text, txtCodeCPP.Text);

                        MessageBox.Show("Update data berhasil");
                    }

                    pv_cust_loadCPP();
                    btnSaveCPP.Text = "SAVE";
                    txtCodeCPP.Text = "";
                    txtLokasiCPP.Text = "";
                    txtDescCPP.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trans cpp : \n" + ex.Message.ToString());
            }
        }

        #endregion

        #region stockpile
        private void pv_cust_loadStockpile()
        {
            try
            {
                DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter();
                DSJT18.TBL_R_STOCKPILEDataTable i_dtab_data = new DSJT18.TBL_R_STOCKPILEDataTable();
                System.Data.DataRow[] i_drow_data;
                DataSet i_dset_data = new DataSet();

                i_drow_data = i_tadap_data.GetData().Select("", "STOCKPILE_NAME ASC");

                foreach (var i_data in i_drow_data)
                {
                    i_dtab_data.ImportRow(i_data);
                }

                i_dset_data.Tables.Add(i_dtab_data);

                dgvStockpile.DataSource = i_dset_data.Tables[0];

                //foreach(DataGridViewRow row in dgv_condition.Rows)
                //{
                //    if (row.Cells["Cond_code"].Value.ToString() == "")
                //    {
                //        row.Cells["COnd_code"].ReadOnly = false;
                //    }
                //}

                //dgv_condition.Rows[dgv_condition.Rows.Add() - 1].Cells["COND_CODE"].ReadOnly = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load stockpile : \n" + ex.Message.ToString());
            }
        }
        private void pv_cust_loadStockpileAktif()
        {
            DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter i_tadap_data = new DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter();
            DSJT18.TBL_R_STOCKPILEDataTable i_dtab_data = new DSJT18.TBL_R_STOCKPILEDataTable();
            System.Data.DataRow[] i_drow_data;
            DataSet i_dset_data = new DataSet();

            //i_drow_data = i_tadap_data.GetData().Select("", "ENTITY_AKTIF ASC");
            i_drow_data = i_tadap_data.GetData().Select("", "");

            foreach (var i_data in i_drow_data)
            {
                i_dtab_data.ImportRow(i_data);
            }

            i_dset_data.Tables.Add(i_dtab_data);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            for (int x = 0; x <= i_dset_data.Tables[0].Rows.Count - 1; x++)
            {
                auto.Add(i_dset_data.Tables[0].Rows[x]["STOCKPILE_AKTIF"].ToString());
            }

            cbAktifStockpile.DataSource = i_dset_data.Tables[0];
            cbAktifStockpile.ValueMember = i_dset_data.Tables[0].Columns["STOCKPILE_AKTIF"].ColumnName.ToString();
            cbAktifStockpile.DisplayMember = i_dset_data.Tables[0].Columns["STOCKPILE_AKTIF"].ColumnName.ToString();

            cbAktifStockpile.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbAktifStockpile.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAktifStockpile.AutoCompleteCustomSource = auto;

        }
        private void dgvStockpile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Color icolor = dgvStockpile.CurrentRow.DefaultCellStyle.SelectionBackColor;

                dgvStockpile.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Crimson;



                if (MessageBox.Show("Yakin Menghapus data ini", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter();

                        i_tadap.DeleteStockPile(dgvStockpile.CurrentRow.Cells["STOCKPILE_CODE"].Value.ToString());

                        pv_cust_loadStockpile();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error delete : \n " + ex.Message.ToString());
                    }
                }

                dgvStockpile.CurrentRow.DefaultCellStyle.SelectionBackColor = icolor;
            }
        }

        private void dgvStockpile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeStockpile.Text = dgvStockpile.Rows[e.RowIndex].Cells["STOCKPILE_CODE"].Value.ToString();
            txtNameStockpile.Text = dgvStockpile.Rows[e.RowIndex].Cells["STOCKPILE_NAME"].Value.ToString();
            txtLokasiStockpile.Text = dgvStockpile.Rows[e.RowIndex].Cells["STOCKPILE_LOKASI"].Value.ToString();
            txtDescStockpile.Text = dgvStockpile.Rows[e.RowIndex].Cells["STOCKPILE_DESC"].Value.ToString();
            cbAktifStockpile.Text = dgvStockpile.Rows[e.RowIndex].Cells["STOCKPILE_AKTIF"].Value.ToString();

            btnSaveStockpile.Text = "UPDATE";
        }

        private void btnSaveStockpile_Click(object sender, EventArgs e)
        {
            DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter i_tadap = new DSJT18TableAdapters.TBL_R_STOCKPILETableAdapter();

            try
            {


                if (txtCodeStockpile.Text.ToString().Trim().Length != 0 && txtNameStockpile.Text.ToString().Trim().Length != 0 && txtLokasiStockpile.Text.ToString().Trim().Length != 0 && txtDescStockpile.Text.ToString().Trim().Length != 0)
                {

                    if (btnSaveStockpile.Text.ToString() == "SAVE")
                    {
                        i_tadap.InsertStockPile(txtCodeStockpile.Text.ToString(), txtNameStockpile.Text.ToString(), txtLokasiStockpile.Text.ToString(), txtDescStockpile.Text.ToString(), "1");

                        MessageBox.Show("Insert data berhasil");
                    }
                    else
                    {
                        i_tadap.UpdateStockPile(txtNameStockpile.Text,txtLokasiStockpile.Text, txtDescStockpile.Text, txtCodeStockpile.Text);

                        MessageBox.Show("Update data berhasil");
                    }

                    pv_cust_loadStockpile();
                    btnSaveStockpile.Text = "SAVE";
                    txtCodeStockpile.Text = "";
                    txtNameStockpile.Text = "";
                    txtLokasiStockpile.Text = "";
                    txtDescStockpile.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trans stockpile : \n" + ex.Message.ToString());
            }
        }

        #endregion

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
