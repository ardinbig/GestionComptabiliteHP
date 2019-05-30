using ManageSingleConnection;
using System;
using System.Data;
using UtilitiesLibrary;

namespace GestionComptabiliteHP_Lib.Classes
{
    public class ClasseCompte : Base
    {
        private int _refCategClasse;

        public int RefCategClasse
        {
            get
            {
                return _refCategClasse;
            }

            set
            {
                _refCategClasse = value;
            }
        }

        public ClasseCompte()
        {

        }

        public void Delete(int id)
        {
            if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tClasse WHERE id = @id";

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }

        public void Save(ClasseCompte cls)
        {
            if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_insert_update_classe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@designation", 100, DbType.String, Designation));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@numero", 4, DbType.Int32, Numero));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ref_categClasse", 4, DbType.Int32, RefCategClasse));

                cmd.ExecuteNonQuery();
            }
        }
    }
}
