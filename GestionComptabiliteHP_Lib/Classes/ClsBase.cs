using ManageSingleConnection;
using System;
using System.Data;
using UtilitiesLibrary;

namespace GestionComptabiliteHP_Lib.Classes
{
    public abstract class Base
    {
        public int Id { get; set; }

        private string _designation;

        public int Numero { get; set; }

        public string Designation
        {
            get
            {
                return _designation;
            }

            set
            {
                _designation = ValidateString(value);
            }
        }

        private string ValidateString(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (!char.IsLetter(str[0]))
                    throw new InvalidOperationException("The word must begin with letter !!!");
                else
                {
                    str = str.ToLower();
                    return str[0].ToString().ToUpper() + new string(str.ToCharArray(), 1, str.Length - 1);
                }

            }
            else
                throw new InvalidOperationException("The word must have value !!!");
        }

        public int New(string table)
        {
            int id = 0;

            if (ImplementConnection.Instance.Conn.State == System.Data.ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT max(id) AS lastId FROM " + table;

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["lastId"] == DBNull.Value)
                        id = 1;
                    else
                        id = Convert.ToInt32(rd["lastId"].ToString()) + 1;
                }

                rd.Dispose();
            }

            return id;
        }

        public void Delete(string table, int id)
        {
            if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM " + table + " WHERE id = @id";

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }
    }
}
