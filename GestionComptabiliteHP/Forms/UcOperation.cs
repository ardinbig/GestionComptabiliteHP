using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionComptabiliteHP_Lib.Interfaces;
using GestionComptabiliteHP_Lib.Classes;
using ManageSingleConnection;
using GestionComptabiliteHP_Lib.Enum;

namespace GestionComptabiliteHP.Forms
{
    public partial class UcOperation : UserControl
    {
        private IOperation opt = null;
        private bool _initCmbState = false;
        private int _idRefCompte1 = 0;
        private int _idRefCompte2 = 0;

        public UcOperation()
        {
            InitializeComponent();
        }

        private void UcOperation_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadGridControle();
            CmbType1.DataSource = Enum.GetNames(typeof(TypeOperation));
            CmbType2.DataSource = Enum.GetNames(typeof(TypeOperation));
            CmbType1.SelectedIndex = 0;
            CmbType2.SelectedIndex = 1;
        }

        #region Commun

        private void LoadGridControle()
        {
            DgvOperation.DataSource = Glossaire.Instance.LoadGrid("v_list_operations", "id");
        }

        private void LoadComboBox(int index = 0)
        {
            _initCmbState = false;

            if (index == 1)
            {
                CmbCmpt1.DataSource = Glossaire.Instance.LoadString("vrai_compte", "v_list_numero_compte");
            }
            else if (index == 2)
            {
                CmbCmpt2.DataSource = Glossaire.Instance.LoadString("vrai_compte", "v_list_numero_compte");
            }
            else
            {
                CmbCmpt2.DataSource = Glossaire.Instance.LoadString("vrai_compte", "v_list_numero_compte");
                CmbCmpt1.DataSource = Glossaire.Instance.LoadString("vrai_compte", "v_list_numero_compte");
            }

            _initCmbState = true;
        }

        private bool IsNotEmpty()
        {
            if (!string.IsNullOrEmpty(TxtLibelleOperation.Text) &&
                        !string.IsNullOrEmpty(TxtMontant.Text) &&
                        !string.IsNullOrEmpty(CmbCmpt1.Text) &&
                        !string.IsNullOrEmpty(CmbCmpt2.Text) &&
                        !string.IsNullOrEmpty(CmbType1.Text) &&
                        !string.IsNullOrEmpty(CmbType2.Text) &&
                        !string.IsNullOrEmpty(TxtIdOperation.Text) &&
                        CmbType1.Text != CmbType2.Text)
            {
                return true;
            }
            else
                return false;
        }

        private void ClearFields()
        {
            TxtIdOperation.Clear();
            TxtIdOperation.Focus();
            TxtLibelleOperation.Clear();
            TxtMontant.Clear();
            CmbCmpt1.SelectedIndex = -1;
            CmbCmpt2.SelectedIndex = -1;
            CmbType1.SelectedIndex = -1;
            CmbType2.SelectedIndex = -1;
            RbCaisse.Checked = true;
        }

        #endregion

        #region Opérations comptables

        private void NewOperation()
        {
            try
            {
                opt = new Operation();
                ClearFields();
                TxtIdOperation.Text = opt.New().ToString();
                BtnSaveOperation.Enabled = true;
                BtnEditOperation.Enabled = false;
                BtnDeleteOperation.Enabled = false;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementConnection.Instance.Conn != null)
                {
                    if (ImplementConnection.Instance.Conn.State == System.Data.ConnectionState.Open)
                        ImplementConnection.Instance.Conn.Close();
                }
            }
        }

        private void ControleOperation(bool save, bool modify = false)
        {
            try
            {
                if (save && modify == false)
                {
                    if (IsNotEmpty())
                    {
                        opt = new Operation();
                        opt.Id = Convert.ToInt32(TxtIdOperation.Text);
                        opt.DateOperation = Convert.ToDateTime(DtDateOperation.Text);
                        opt.Libelle = TxtLibelleOperation.Text.Trim();
                        opt.Montant = Convert.ToDouble(TxtMontant.Text);
                        opt.RefCompte1 = _idRefCompte1;
                        opt.Type1 = CmbType1.Text;
                        opt.RefCompte2 = _idRefCompte2;
                        opt.Type2 = CmbType2.Text;

                        opt.Save(opt);
                        ClearFields();
                    }                   
                }
                else if (save == false && modify == true)
                {
                    if (IsNotEmpty())
                    {
                        opt = new Operation();
                        opt.Id = Convert.ToInt32(TxtIdOperation.Text);
                        opt.DateOperation = Convert.ToDateTime(DtDateOperation.Text);
                        opt.Libelle = TxtLibelleOperation.Text.Trim();
                        opt.Montant = Convert.ToDouble(TxtMontant.Text);
                        opt.RefCompte1 = _idRefCompte1;
                        opt.Type1 = CmbType1.Text;
                        opt.RefCompte2 = _idRefCompte2;
                        opt.Type2 = CmbType2.Text;

                        opt.Update(opt);
                        ClearFields();
                    }
                }
                else if (save == false && modify == false)
                {
                    if (!string.IsNullOrEmpty(TxtIdOperation.Text))
                    {
                        opt = new Operation();
                        opt.Id = Convert.ToInt32(TxtIdOperation.Text);
                        opt.DateOperation = Convert.ToDateTime(DtDateOperation.Text);
                        opt.Libelle = TxtLibelleOperation.Text.Trim();
                        opt.Montant = Convert.ToDouble(TxtMontant.Text);
                        opt.RefCompte1 = _idRefCompte1;
                        opt.Type1 = CmbType1.Text;
                        opt.RefCompte2 = _idRefCompte2;
                        opt.Type2 = CmbType2.Text;

                        opt.Delete(opt.Id);
                        ClearFields();
                    }
                }

                LoadGridControle();
                
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementConnection.Instance.Conn != null)
                {
                    if (ImplementConnection.Instance.Conn.State == System.Data.ConnectionState.Open)
                        ImplementConnection.Instance.Conn.Close();
                }
            }
        }

        private void ControleOperation_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewOperation":
                    NewOperation();
                    break;

                case "BtnSaveOperation":
                    ControleOperation(true, false);
                    break;

                case "BtnEditOperation":
                    ControleOperation(false, true);
                    break;

                case "BtnDeleteOperation":
                    ControleOperation(false, false);
                    break;

                default:
                    break;
            }
        }

        private void DgvOperation_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvOperation.SelectedRows.Count > 0)
                {
                    TxtIdOperation.Text = DgvOperation.SelectedRows[0].Cells[0].Value.ToString();
                    DtDateOperation.Text = DgvOperation.SelectedRows[0].Cells[1].Value.ToString();
                    TxtLibelleOperation.Text = DgvOperation.SelectedRows[0].Cells[2].Value.ToString();
                    TxtMontant.Text = DgvOperation.SelectedRows[0].Cells["DgvColMontantD"].Value.ToString();
                    CmbCmpt1.Text = DgvOperation.SelectedRows[0].Cells["DgvColCompteD"].Value.ToString();
                    CmbCmpt2.Text = DgvOperation.SelectedRows[0].Cells["DgvColCompteC"].Value.ToString();
                    CmbType1.Text = DgvOperation.SelectedRows[0].Cells["DgvColTypeD"].Value.ToString();
                    CmbType2.Text = DgvOperation.SelectedRows[0].Cells["DgvColTypeC"].Value.ToString();

                    BtnEditOperation.Enabled = true;
                    BtnDeleteOperation.Enabled = true;
                    BtnSaveOperation.Enabled = false;
                }
                else
                {
                    BtnEditOperation.Enabled = false;
                    BtnDeleteOperation.Enabled = false;
                    BtnSaveOperation.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _idRefCompte1 = Glossaire.Instance.SelectId("v_list_numero_compte", "vrai_compte", CmbCmpt1.Text);
                _idRefCompte2 = Glossaire.Instance.SelectId("v_list_numero_compte", "vrai_compte", CmbCmpt2.Text);
            }
            else
            {
                CmbCmpt1.SelectedIndex = -1;
                CmbCmpt2.SelectedIndex = -1;
            }
        }

        private void CmbTypeOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "CmbType1":
                    if (CmbType1.Text.Equals("Débit"))
                    {
                        CmbType2.SelectedText = "Crédit";
                    }
                    else if (CmbType1.Text.Equals("Crédit"))
                    {
                        CmbType2.SelectedText = "Débit";
                    }

                    break;

                case "CmbType2":
                    //if (CmbType2.Text.Equals(TypeOperation.Débit))
                    //{
                    //    CmbType1.SelectedItem = TypeOperation.Crédit;
                    //}
                    //else if (CmbType2.Text.Equals(TypeOperation.Crédit))
                    //{
                    //    CmbType1.SelectedItem = TypeOperation.Débit;
                    //}
                    //break;

                default:
                    break;
            }
        }

        #endregion
    }
}
