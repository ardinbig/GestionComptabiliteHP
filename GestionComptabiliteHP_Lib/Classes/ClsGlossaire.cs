using ManageSingleConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilitiesLibrary;

namespace GestionComptabiliteHP_Lib.Classes
{
    public class Glossaire
    {
        private static Glossaire _instance = null;
        private SqlDataAdapter adapter = null;
        private DataSet dataset = null;

        public static Glossaire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Glossaire();
                return _instance;
            }
        }

        public void InitializeConnexion()
        {
            try
            {
                if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                    ImplementConnection.Instance.Conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable LoadGrid(string table, string orderBy)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM " + table + " ORDER BY " + orderBy + " DESC";
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter((SqlCommand)cmd);
                adapter.Fill(dt);

                return dt;

            }            
        }

        public List<string> LoadString(string field, string table)
        {
            InitializeConnexion();

            List<string> list = new List<string>();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT " + field + " FROM " + table + " ORDER BY " + field + " ";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(dr[field].ToString());
                }

                dr.Dispose();
            }

            return list;
        }

        public int SelectId(string table, string field)
        {
            InitializeConnexion();

            int id = 0;

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id FROM " + table + " WHERE designation = '" + field + "'";

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"].ToString());
                }

                dr.Dispose();
            }

            return id;
        }

        public int SelectId(string table, string field, string value)
        {
            InitializeConnexion();

            int id = 0;

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT id FROM " + table + " WHERE " + field + " = '" + value + "'";

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"].ToString());
                }

                dr.Dispose();
            }

            return id;
        }

        public void LoadReportJournal(Microsoft.Reporting.WinForms.ReportViewer viewer, DateTime begin, DateTime end)
        {
            try
            {
                InitializeConnexion();

                using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "sp_journal_operation";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@date_debut", 30, DbType.DateTime, begin));
                    cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@date_fin", 30, DbType.DateTime, end));

                    adapter = new SqlDataAdapter((SqlCommand)cmd);
                    dataset = new DataSet();

                    adapter.Fill(dataset, "DataSetJournal");

                    viewer.LocalReport.DataSources.Clear();
                    viewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetJournal", dataset.Tables[0]));
                    viewer.LocalReport.ReportEmbeddedResource = "GestionComptabiliteHP.Reports.RptJournal.rdlc";
                    //viewer.RefreshReport();
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
                    if (ImplementConnection.Instance.Conn.State == System.Data.ConnectionState.Open)
                        ImplementConnection.Instance.Conn.Close();
                }

                if (adapter != null)
                    adapter.Dispose();
                if (dataset != null)
                    dataset.Dispose();
            }
        }
    }
}
