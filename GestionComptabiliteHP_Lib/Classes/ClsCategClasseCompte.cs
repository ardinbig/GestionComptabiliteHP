using ManageSingleConnection;
using System;
using System.Data;
using UtilitiesLibrary;

namespace GestionComptabiliteHP_Lib.Classes
{
    public class CategClasseCompte : Base
    {
        public CategClasseCompte()
        {

        }

        public void Delete(int id)
        {
            if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tCategClasse WHERE id = @id";

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }

        public void Save(CategClasseCompte categ)
        {
            if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_insert_update_categClasse";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@designation", 100, DbType.String, Designation));
                
                cmd.ExecuteNonQuery();
            }
        }
    }
}
