using ManageSingleConnection;
using System;
using System.Windows.Forms;

namespace GestionComptabiliteHP.Forms
{
    public partial class FrmLogin : Form
    {
        private ConnectionType connectionType;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CmbTypeDB.DataSource = Enum.GetNames(typeof(ConnectionType));
            CmbTypeDB.SelectedIndex = 0;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                Connection con = new Connection
                {
                    Server = TxtServer.Text,
                    Database = TxtDb.Text,
                    User = TxtUser.Text,
                    Password = TxtPwd.Text
                };

                ImplementConnection.Instance.Initialise(con, connectionType);
                ImplementConnection.Instance.Conn.Open();

                MessageBox.Show("Connection Successfuly !!!", "Connection to DataBase", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // FrmMain.ActivateItems(true);
                Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void CmbTypeDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbTypeDB.SelectedIndex)
            {
                case 0:
                    connectionType = ConnectionType.SQLServer;
                    break;
                case 1:
                    connectionType = ConnectionType.MySQL;
                    break;
                case 2:
                    connectionType = ConnectionType.PostGrsSQL;
                    break;
                case 3:
                    connectionType = ConnectionType.Oracle;
                    break;
                case 4:
                    connectionType = ConnectionType.Access;
                    break;
            }
        }
    }
}
