using GestionComptabiliteHP.Forms;
using ManageSingleConnection;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionComptabiliteHP
{
    public partial class FrmMain : Form
    {
        private Form frm = null;
        private UserControl uc = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ActivateItems();

            PnlAccueilColor.BackColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(155)))));
            PnlCompteColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlOperationColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlRapportColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));

            uc = new UcAccueil();
            LoadUserControles(uc);

            //frm = new FrmApropos();
            //frm.ShowDialog();
        }

        public void LoadUserControles(UserControl uc)
        {
            this.PnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.PnlMain.Controls.Add(uc);
            uc.Show();
        }

        private bool ConnectionExists()
        {
            if (ImplementConnection.Instance.Conn != null)
            {
                return true;
            }
            else
                return false;
        }

        public void ActivateItems(bool active = true)
        {
            if (ConnectionExists())
            {
                PnlBlanc.Enabled = true;
                LblConnection.Text = "Déconnexion";

                if (active == false)
                {
                    if (ImplementConnection.Instance.Conn != null)
                    {
                        if (ImplementConnection.Instance.Conn.State == System.Data.ConnectionState.Open)
                            ImplementConnection.Instance.Conn.Close();

                        PnlAccueilColor.BackColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(155)))));
                        PnlCompteColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
                        PnlOperationColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
                        PnlRapportColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));

                        uc = new UcAccueil();
                        LoadUserControles(uc);

                        LblConnection.Text = "Connexion";
                        PnlBlanc.Enabled = false;
                    }
                }
            }
            else
            {
                PnlBlanc.Enabled = false;
            }
        }

        private void MenuAccueil_Click(object sender, EventArgs e)
        {
            PnlAccueilColor.BackColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(155)))));
            PnlCompteColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlOperationColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlRapportColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));

            uc = new UcAccueil();
            LoadUserControles(uc);          
        }

        private void MenuComptes_Click(object sender, EventArgs e)
        {
            PnlAccueilColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlCompteColor.BackColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(155)))));
            PnlOperationColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlRapportColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));

            uc = new UcComptes();
            LoadUserControles(uc);           
        }

        private void MenuOperation_Click(object sender, EventArgs e)
        {
            PnlAccueilColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlCompteColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlOperationColor.BackColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(155)))));
            PnlRapportColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));

            uc = new UcOperation();
            LoadUserControles(uc);
        }

        private void MenuRapport_Click(object sender, EventArgs e)
        {
            PnlAccueilColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlCompteColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlOperationColor.BackColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            PnlRapportColor.BackColor = Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(155)))));

            this.PnlMain.Controls.Clear();

            frm = new FrmReport
            {
                Icon = this.Icon
            };
            frm.ShowDialog();
        }

        private void MenuApropos_Click(object sender, EventArgs e)
        {
            frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void ButtonConnection_Click(object sender, MouseEventArgs e)
        {
            if (LblConnection.Text == "Connexion")
            {
                frm = new FrmLogin
                {
                    Icon = this.Icon
                };
                frm.ShowDialog();

                ActivateItems();
            }
            else
            {
                ActivateItems(false);
            }
        }
    }
}
