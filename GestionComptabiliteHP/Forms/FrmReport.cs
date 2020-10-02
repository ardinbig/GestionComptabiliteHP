using ManageSingleConnection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UtilitiesLibrary;

namespace GestionComptabiliteHP.Forms
{
    public partial class FrmReport : Form
    {
        private SqlDataAdapter adapter = null;
        private DataSet dataset = null;

        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            RptViewer.RefreshReport();
        }

        public void LoadReportJournal(DateTime begin, DateTime end)
        {
            try
            {
                if (ImplementConnection.Instance.Conn.State == System.Data.ConnectionState.Closed)
                    ImplementConnection.Instance.Conn.Open();

                using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "sp_journal_operation";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@date_debut", 30, DbType.DateTime, begin));
                    cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@date_fin", 30, DbType.DateTime, end));

                    adapter = new SqlDataAdapter((SqlCommand)cmd);
                    dataset = new DataSet();

                    adapter.Fill(dataset, "DataSetJournal");

                    RptViewer.LocalReport.DataSources.Clear();
                    RptViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetJournal", dataset.Tables[0]));
                    RptViewer.LocalReport.ReportEmbeddedResource = "GestionComptabiliteHP.Reports.RptJournal.rdlc";
                    RptViewer.PrinterSettings.DefaultPageSettings.Landscape = true;
                    RptViewer.RefreshReport();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error when Selecting data, " + ex.Message, "Selecting data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error when Selecting data, " + ex.Message, "Selecting data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when Selecting data, " + ex.Message, "Selecting data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementConnection.Instance.Conn != null)
                {
                    if (ImplementConnection.Instance.Conn.State == ConnectionState.Open)
                        ImplementConnection.Instance.Conn.Close();
                }

                if (adapter != null)
                    adapter.Dispose();
                if (dataset != null)
                    dataset.Dispose();
            }
        }

        public void LoadReportBilan(DateTime begin, DateTime end)
        {
            try
            {
                if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                    ImplementConnection.Instance.Conn.Open();

                using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "sp_bilan_operations";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@date_debut", 30, DbType.DateTime, begin));
                    cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@date_fin", 30, DbType.DateTime, end));

                    adapter = new SqlDataAdapter((SqlCommand)cmd);
                    dataset = new DataSet();

                    adapter.Fill(dataset, "DataSetBilan");

                    RptViewer.LocalReport.DataSources.Clear();
                    RptViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetBilan", dataset.Tables[0]));
                    RptViewer.LocalReport.ReportEmbeddedResource = "GestionComptabiliteHP.Reports.RptBilan.rdlc";
                    RptViewer.RefreshReport();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error when Selecting data, " + ex.Message, "Selecting data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error when Selecting data, " + ex.Message, "Selecting data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when Selecting data, " + ex.Message, "Selecting data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementConnection.Instance.Conn != null)
                {
                    if (ImplementConnection.Instance.Conn.State == ConnectionState.Open)
                        ImplementConnection.Instance.Conn.Close();
                }

                if (adapter != null)
                    adapter.Dispose();
                if (dataset != null)
                    dataset.Dispose();
            }
        }

        private void BtnPrintJournal_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadReportJournal(DtDebut.Value, DtFin.Value);
            Cursor.Current = Cursors.Default;
        }

        private void BtnPrintBilan_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadReportBilan(DtDebut.Value, DtFin.Value);
            Cursor.Current = Cursors.Default;
        }
    }
}
