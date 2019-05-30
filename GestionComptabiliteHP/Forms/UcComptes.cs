using GestionComptabiliteHP_Lib.Classes;
using ManageSingleConnection;
using System;
using System.Windows.Forms;

namespace GestionComptabiliteHP.Forms
{
    public partial class UcComptes : UserControl
    {
        private CategClasseCompte categ = null;
        private ClasseCompte cls = null;
        private Comptes.Compte cpt = null;
        private Comptes.SCompte scpt = null;
        private Comptes.SSCompte sscpt = null; 

        private int _idRefCategClasse = 0;
        private int _idRefClasse = 0;
        private int _idRefCompte = 0;
        private int _idRefSCompte = 0;

        private bool _initCmbState = false;

        public UcComptes()
        {
            InitializeComponent();
        }

        private void UcComptes_Load(object sender, EventArgs e)
        {
            _initCmbState = true;
            LoadComboBox();
            LoadGridControle();
        }

        #region Commun

        private void LoadGridControle(int index = 0)
        {
            if (index == 1)
            {
                DgvCategClasse.DataSource = Glossaire.Instance.LoadGrid("tCategClasse", "id");
            }
            else if (index == 2)
            {
                DgvClasse.DataSource = Glossaire.Instance.LoadGrid("v_list_classe", "id");
            }
            else if (index == 3)
            {
                DgvCompte.DataSource = Glossaire.Instance.LoadGrid("v_list_compte", "id");
            }
            else if (index == 4)
            {
                DgvSCompte.DataSource = Glossaire.Instance.LoadGrid("v_list_scompte", "id");
            }
            else if (index == 5)
            {
                DgvSSCompte.DataSource = Glossaire.Instance.LoadGrid("v_list_sscompte", "id");
            }
            else
            {
                DgvCategClasse.DataSource = Glossaire.Instance.LoadGrid("tCategClasse", "id");
                DgvClasse.DataSource = Glossaire.Instance.LoadGrid("v_list_classe", "id");
                DgvCompte.DataSource = Glossaire.Instance.LoadGrid("v_list_compte", "id");
                DgvSCompte.DataSource = Glossaire.Instance.LoadGrid("v_list_scompte", "id");
                DgvSSCompte.DataSource = Glossaire.Instance.LoadGrid("v_list_sscompte", "id");
            }
        }

        private void LoadComboBox(int index = 0)
        {
            _initCmbState = false;

            if (index == 1)
            {
                CmbCategClasse.DataSource = Glossaire.Instance.LoadString("designation", "tCategClasse");
            }
            else if (index == 2)
            {
                CmbClasseCompte.DataSource = Glossaire.Instance.LoadString("designation", "tClasse");
            }
            else if (index == 3)
            {
                CmbCompte.DataSource = Glossaire.Instance.LoadString("designation", "tCompte");
            }
            else if (index == 4)
            {
                CmbSCompte.DataSource = Glossaire.Instance.LoadString("designation", "tSCompte");
            }
            else
            {
                CmbCategClasse.DataSource = Glossaire.Instance.LoadString("designation", "tCategClasse");
                CmbClasseCompte.DataSource = Glossaire.Instance.LoadString("designation", "tClasse");
                CmbCompte.DataSource = Glossaire.Instance.LoadString("designation", "tCompte");
                CmbSCompte.DataSource = Glossaire.Instance.LoadString("designation", "tSCompte");
            }

            _initCmbState = true;
        }

        private bool IsNotEmpty(int tabIndex, int rank)
        {
            if (tabIndex == 1)
            {
                if (rank == 1)
                {
                    if (!string.IsNullOrEmpty(TxtDesignCategClasse.Text))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else if (rank == 2)
                {
                    if (!string.IsNullOrEmpty(TxtDesignClasse.Text) &&
                        !string.IsNullOrEmpty(TxtNumClasse.Text) &&
                        !string.IsNullOrEmpty(CmbCategClasse.Text))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else if (tabIndex == 2)
            {
                if (rank == 1)
                {
                    if (!string.IsNullOrEmpty(TxtDesignCompte.Text) &&
                        !string.IsNullOrEmpty(TxtNumCompte.Text) &&
                        !string.IsNullOrEmpty(CmbClasseCompte.Text))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else if (rank == 2)
                {
                    if (!string.IsNullOrEmpty(TxtNumSCompte.Text) &&
                        !string.IsNullOrEmpty(TxtDesignSCompte.Text) &&
                        !string.IsNullOrEmpty(CmbCompte.Text))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else if (rank == 3)
                {
                    if (!string.IsNullOrEmpty(TxtNumSSCompte.Text) &&
                        !string.IsNullOrEmpty(TxtDesignSSCompte.Text) &&
                        !string.IsNullOrEmpty(CmbSCompte.Text))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        private void ClearFields(int tabIndex, int rank)
        {
            if (tabIndex == 1)
            {
                if (rank == 1)
                {
                    TxtIdCategClasse.Clear();
                    TxtDesignCategClasse.Clear();
                    TxtDesignCategClasse.Focus();
                    BtnSaveCategClasse.Enabled = false;
                    BtnDeleteCategClasse.Enabled = false;
                }
                else if (rank == 2)
                {
                    TxtIdClasse.Clear();
                    TxtDesignClasse.Clear();
                    TxtNumClasse.Clear();
                    _initCmbState = false;
                    CmbCategClasse.SelectedIndex = -1;
                    _initCmbState = true;
                    TxtDesignClasse.Focus();
                    BtnSaveClasse.Enabled = false;
                    BtnDeleteClasse.Enabled = false;
                }
            }
            else if (tabIndex == 2)
            {
                if (rank == 1)
                {
                    TxtIdCompte.Clear();
                    TxtDesignCompte.Clear();
                    TxtDesignCompte.Focus();
                    TxtNumCompte.Clear();
                    _initCmbState = false;
                    CmbClasseCompte.SelectedIndex = -1;
                    _initCmbState = true;
                    BtnSaveCompte.Enabled = false;
                    BtnDeleteCompte.Enabled = false;
                }
                else if (rank == 2)
                {
                    TxtIdSCompte.Clear();
                    TxtDesignSCompte.Clear();
                    TxtDesignSCompte.Focus();
                    TxtNumSCompte.Clear();
                    _initCmbState = false;
                    CmbCompte.SelectedIndex = -1;
                    _initCmbState = true;
                    BtnSaveSCompte.Enabled = false;
                    BtnDeleteSCompte.Enabled = false;
                }
                else if (rank == 3)
                {
                    TxtIdSSCompte.Clear();
                    TxtDesignSSCompte.Clear();
                    TxtDesignSSCompte.Focus();
                    TxtNumSSCompte.Clear();
                    _initCmbState = false;
                    CmbSCompte.SelectedIndex = -1;
                    _initCmbState = true;
                    BtnSaveSSCompte.Enabled = false;
                    BtnDeleteSSCompte.Enabled = false;
                }
            }
        }

        #endregion

        #region Catégorie classe

        private void NewCategClasse()
        {
            try
            {
                categ = new CategClasseCompte();
                ClearFields(1, 1);
                TxtIdCategClasse.Text = categ.New("tCategClasse").ToString();
                BtnSaveCategClasse.Enabled = true;
                BtnDeleteCategClasse.Enabled = false;
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

        private void ControleCategClasse(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(1, 1))
                    {
                        categ = new CategClasseCompte
                        {
                            Id = Convert.ToInt32(TxtIdCategClasse.Text),
                            Designation = TxtDesignCategClasse.Text
                        };

                        categ.Save(categ);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtIdCategClasse.Text))
                    {
                        categ = new CategClasseCompte
                        {
                            Id = Convert.ToInt32(TxtIdCategClasse.Text),
                            Designation = TxtDesignCategClasse.Text
                        };

                        categ.Delete(categ.Id);
                    }
                }

                LoadComboBox(1);
                LoadGridControle(1);
                ClearFields(1, 1);
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

        private void ControleCategClasse_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewCategClasse":
                    NewCategClasse();
                    break;

                case "BtnSaveCategClasse":
                    ControleCategClasse(true);
                    break;

                case "BtnDeleteCategClasse":
                    ControleCategClasse(false);
                    break;

                default:
                    break;
            }
        }

        private void DgvCategClasse_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvCategClasse.SelectedRows.Count > 0)
                {
                    categ = new CategClasseCompte()
                    {
                        Id = Convert.ToInt32(DgvCategClasse.SelectedRows[0].Cells[0].Value.ToString()),
                        Designation = DgvCategClasse.SelectedRows[0].Cells[1].Value.ToString()
                    };

                    TxtIdCategClasse.Text = categ.Id.ToString();
                    TxtDesignCategClasse.Text = categ.Designation;

                    BtnSaveCategClasse.Enabled = true;
                    BtnDeleteCategClasse.Enabled = true;
                }
                else
                {
                    BtnSaveCategClasse.Enabled = false;
                    BtnDeleteCategClasse.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Classe

        private void NewClasse()
        {
            try
            {
                cls = new ClasseCompte();
                ClearFields(1, 2);
                TxtIdClasse.Text = cls.New("tClasse").ToString();
                BtnSaveClasse.Enabled = true;
                BtnDeleteClasse.Enabled = false;
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

        private void ControleClasse(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(1, 2))
                    {
                        cls = new ClasseCompte
                        {
                            Id = Convert.ToInt32(TxtIdClasse.Text),
                            Designation = TxtDesignClasse.Text,
                            Numero = Convert.ToInt32(TxtNumClasse.Text),
                            RefCategClasse = _idRefCategClasse
                        };

                        cls.Save(cls);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtIdClasse.Text))
                    {
                        cls = new ClasseCompte
                        {
                            Id = Convert.ToInt32(TxtIdClasse.Text),
                            Designation = TxtDesignClasse.Text,
                            Numero = Convert.ToInt32(TxtNumClasse.Text),
                            RefCategClasse = _idRefCategClasse
                        };

                        cls.Delete(cls.Id);
                    }
                }

                LoadComboBox(2);
                LoadGridControle(2);
                ClearFields(1, 2);
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

        private void ControleClasse_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewClasse":
                    NewClasse();
                    break;

                case "BtnSaveClasse":
                    ControleClasse(true);
                    break;

                case "BtnDeleteClasse":
                    ControleClasse(false);
                    break;

                default:
                    break;
            }
        }

        private void DgvClasse_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvClasse.SelectedRows.Count > 0)
                {
                    TxtIdClasse.Text = DgvClasse.SelectedRows[0].Cells[0].Value.ToString();
                    TxtDesignClasse.Text = DgvClasse.SelectedRows[0].Cells[1].Value.ToString();
                    TxtNumClasse.Text = DgvClasse.SelectedRows[0].Cells[3].Value.ToString();
                    CmbCategClasse.Text = DgvClasse.SelectedRows[0].Cells[2].Value.ToString();

                    BtnSaveClasse.Enabled = true;
                    BtnDeleteClasse.Enabled = true;
                }
                else
                {
                    BtnSaveClasse.Enabled = false;
                    BtnDeleteClasse.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmbCategClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _idRefCategClasse = Glossaire.Instance.SelectId("tCategClasse", CmbCategClasse.Text);
            }
            else
            {
                CmbCategClasse.SelectedIndex = -1;
            }
        }

        #endregion

        #region Comptes

        #region Compte

        private void NewCompte()
        {
            try
            {
                cpt = new Comptes.Compte();
                ClearFields(2, 1);
                TxtIdCompte.Text = cpt.New("tCompte").ToString();
                BtnSaveCompte.Enabled = true;
                BtnDeleteCompte.Enabled = false;
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

        private void ControleCompte(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(2, 1))
                    {
                        cpt = new Comptes.Compte
                        {
                            Id = Convert.ToInt32(TxtIdCompte.Text),
                            Designation = TxtDesignCompte.Text,
                            Numero = Convert.ToInt32(TxtNumCompte.Text),
                            RefClasse = _idRefClasse
                        };

                        cpt.Save(cpt);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtIdCompte.Text))
                    {
                        cpt = new Comptes.Compte
                        {
                            Id = Convert.ToInt32(TxtIdCompte.Text),
                            Designation = TxtDesignCompte.Text,
                            Numero = Convert.ToInt32(TxtNumCompte.Text),
                            RefClasse = _idRefClasse
                        };

                        cpt.Delete("tCompte", cpt.Id);
                    }
                }

                LoadComboBox(3);
                LoadGridControle(3);
                ClearFields(2, 1);
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

        private void ControleCompte_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewCompte":
                    NewCompte();
                    break;

                case "BtnSaveCompte":
                    ControleCompte(true);
                    break;

                case "BtnDeleteCompte":
                    ControleCompte(false);
                    break;

                default:
                    break;
            }
        }

        private void DgvCompte_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvCompte.SelectedRows.Count > 0)
                {
                    TxtIdCompte.Text = DgvCompte.SelectedRows[0].Cells[0].Value.ToString();
                    TxtDesignCompte.Text = DgvCompte.SelectedRows[0].Cells[1].Value.ToString();
                    TxtNumCompte.Text = DgvCompte.SelectedRows[0].Cells[2].Value.ToString();
                    CmbClasseCompte.Text = DgvCompte.SelectedRows[0].Cells[3].Value.ToString();

                    BtnSaveCompte.Enabled = true;
                    BtnDeleteCompte.Enabled = true;
                }
                else
                {
                    BtnSaveCompte.Enabled = false;
                    BtnDeleteCompte.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmbClasseCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _idRefClasse = Glossaire.Instance.SelectId("tClasse", CmbClasseCompte.Text);
            }
            else
            {
                CmbClasseCompte.SelectedIndex = -1;
            }
        }

        #endregion

        #region Sous compte

        private void NewSCompte()
        {
            try
            {
                scpt = new Comptes.SCompte();
                ClearFields(2, 2);
                TxtIdSCompte.Text = scpt.New("tSCompte").ToString();
                BtnSaveSCompte.Enabled = true;
                BtnDeleteSCompte.Enabled = false;
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

        private void ControleSCompte(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(2, 2))
                    {
                        scpt = new Comptes.SCompte
                        {
                            Id = Convert.ToInt32(TxtIdSCompte.Text),
                            Designation = TxtDesignSCompte.Text,
                            Numero = Convert.ToInt32(TxtNumSCompte.Text),
                            RefCompte = _idRefCompte
                        };

                        scpt.Save(scpt);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtIdSCompte.Text))
                    {
                        scpt = new Comptes.SCompte
                        {
                            Id = Convert.ToInt32(TxtIdSCompte.Text),
                            Designation = TxtDesignSCompte.Text,
                            Numero = Convert.ToInt32(TxtNumSCompte.Text),
                            RefCompte = _idRefCompte
                        };

                        scpt.Delete("tSCompte", scpt.Id);
                    }
                }

                LoadComboBox(4);
                LoadGridControle(4);
                ClearFields(2, 2);
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

        private void ControleSCompte_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewSCompte":
                    NewSCompte();
                    break;

                case "BtnSaveSCompte":
                    ControleSCompte(true);
                    break;

                case "BtnDeleteSCompte":
                    ControleSCompte(false);
                    break;

                default:
                    break;
            }
        }

        private void DgvSCompte_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvSCompte.SelectedRows.Count > 0)
                {
                    TxtIdSCompte.Text = DgvSCompte.SelectedRows[0].Cells[0].Value.ToString();
                    TxtDesignSCompte.Text = DgvSCompte.SelectedRows[0].Cells[1].Value.ToString();
                    TxtNumSCompte.Text = DgvSCompte.SelectedRows[0].Cells[2].Value.ToString();
                    CmbCompte.Text = DgvSCompte.SelectedRows[0].Cells[3].Value.ToString();

                    BtnSaveSCompte.Enabled = true;
                    BtnDeleteSCompte.Enabled = true;
                }
                else
                {
                    BtnSaveSCompte.Enabled = false;
                    BtnDeleteSCompte.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmbCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _idRefCompte = Glossaire.Instance.SelectId("tCompte", CmbCompte.Text);
            }
            else
            {
                CmbCompte.SelectedIndex = -1;
            }
        }

        #endregion

        #region Sous sous compte

        private void NewSSCompte()
        {
            try
            {
                sscpt = new Comptes.SSCompte();
                ClearFields(2, 3);
                TxtIdSSCompte.Text = sscpt.New("tSSCompte").ToString();
                BtnSaveSSCompte.Enabled = true;
                BtnDeleteSSCompte.Enabled = false;
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

        private void ControleSSCompte(bool save)
        {
            try
            {
                if (save)
                {
                    if (IsNotEmpty(2, 3))
                    {
                        sscpt = new Comptes.SSCompte
                        {
                            Id = Convert.ToInt32(TxtIdSSCompte.Text),
                            Designation = TxtDesignSSCompte.Text,
                            Numero = Convert.ToInt32(TxtNumSSCompte.Text),
                            RefSCompte = _idRefSCompte
                        };
                       
                        sscpt.Save(sscpt);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtIdSSCompte.Text))
                    {
                        sscpt = new Comptes.SSCompte
                        {
                            Id = Convert.ToInt32(TxtIdSSCompte.Text),
                            Designation = TxtDesignSSCompte.Text,
                            Numero = Convert.ToInt32(TxtNumSSCompte.Text),
                            RefSCompte = _idRefSCompte
                        };

                        sscpt.Delete("tSSCompte", sscpt.Id);
                    }
                }

                LoadGridControle(5);
                ClearFields(2, 3);
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

        private void ControleSSCompte_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "BtnNewSSCompte":
                    NewSSCompte();
                    break;

                case "BtnSaveSSCompte":
                    ControleSSCompte(true);
                    break;

                case "BtnDeleteSSCompte":
                    ControleSSCompte(false);
                    break;

                default:
                    break;
            }
        }

        private void DgvSSCompte_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvSSCompte.SelectedRows.Count > 0)
                {
                    TxtIdSSCompte.Text = DgvSSCompte.SelectedRows[0].Cells[0].Value.ToString();
                    TxtDesignSSCompte.Text = DgvSSCompte.SelectedRows[0].Cells[1].Value.ToString();
                    TxtNumSSCompte.Text = DgvSSCompte.SelectedRows[0].Cells[2].Value.ToString();
                    CmbSCompte.Text = DgvSSCompte.SelectedRows[0].Cells[3].Value.ToString();

                    BtnSaveSSCompte.Enabled = true;
                    BtnDeleteSSCompte.Enabled = true;
                }
                else
                {
                    BtnSaveSSCompte.Enabled = false;
                    BtnDeleteSSCompte.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue pendant l'opération ! " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmbSCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _idRefSCompte = Glossaire.Instance.SelectId("tSCompte", CmbSCompte.Text);
            }
            else
            {
                CmbSCompte.SelectedIndex = -1;
            }
        }

        #endregion

        #endregion
    }
}
