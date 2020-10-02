using ManageSingleConnection;
using System.Data;
using UtilitiesLibrary;

namespace GestionComptabiliteHP_Lib.Classes
{
    public abstract class Comptes
    {
        public class Compte : Base
        {
            public int RefClasse { get; set; }

            public Compte()
            {

            }    

            public void Save(Compte cpt)
            {
                if (cpt is null)
                {
                    throw new System.ArgumentNullException(nameof(cpt));
                }
                else
                {
                    if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                        ImplementConnection.Instance.Conn.Open();

                    using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
                    {
                        cmd.CommandText = "sp_insert_update_compte";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@designation", 100, DbType.String, Designation));
                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@numero", 4, DbType.Int32, Numero));
                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ref_classe", 4, DbType.Int32, RefClasse));

                        cmd.ExecuteNonQuery();
                    }
                }             
            }
        }

        public class SCompte : Base
        {
            public int RefCompte { get; set; }

            public SCompte()
            {

            }

            public void Save(SCompte cpt)
            {
                if (cpt is null)
                {
                    throw new System.ArgumentNullException(nameof(cpt));
                }
                else
                {
                    if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                        ImplementConnection.Instance.Conn.Open();

                    using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
                    {
                        cmd.CommandText = "sp_insert_update_sCompte";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@designation", 100, DbType.String, Designation));
                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@numero", 4, DbType.Int32, Numero));
                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ref_compte", 4, DbType.Int32, RefCompte));

                        cmd.ExecuteNonQuery();
                    }
                }             
            }
        }

        public class SSCompte : Base
        {
            public int RefSCompte { get; set; }

            public SSCompte()
            {

            }

            public void Save(SSCompte cpt)
            {
                if (cpt is null)
                {
                    throw new System.ArgumentNullException(nameof(cpt));
                }
                else
                {
                    if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                        ImplementConnection.Instance.Conn.Open();

                    using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
                    {
                        cmd.CommandText = "sp_insert_update_ssCompte";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@designation", 100, DbType.String, Designation));
                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@numero", 4, DbType.Int32, Numero));
                        cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ref_scompte", 4, DbType.Int32, RefSCompte));

                        cmd.ExecuteNonQuery();
                    }
                }              
            }
        }
    }
}
