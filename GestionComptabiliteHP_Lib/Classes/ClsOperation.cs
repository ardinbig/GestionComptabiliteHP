using GestionComptabiliteHP_Lib.Interfaces;
using ManageSingleConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UtilitiesLibrary;

namespace GestionComptabiliteHP_Lib.Classes
{
    public class Operation : IOperation
    {
        private int _id;
        private DateTime _date;
        private string _libelle;
        private double _montant;
        private int _ref_compte1;
        private int _ref_compte2;
        private string _type1;
        private string _type2;

        public Operation()
        {

        }

        public DateTime DateOperation
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public double Montant
        {
            get
            {
                return _montant;
            }

            set
            {
                _montant = value;
            }
        }

        public string Libelle
        {
            get
            {
                return _libelle;
            }

            set
            {
                _libelle = ValidateString(value);
            }
        }

        public int RefCompte1
        {
            get
            {
                return _ref_compte1;
            }

            set
            {
                _ref_compte1 = value;
            }
        }

        public int RefCompte2
        {
            get
            {
                return _ref_compte2;
            }

            set
            {
                _ref_compte2 = value;
            }
        }

        public string Type1
        {
            get
            {
                return _type1;
            }

            set
            {
                _type1 = ValidateString(value);
            }
        }

        public string Type2
        {
            get
            {
                return _type2;
            }

            set
            {
                _type2 = ValidateString(value);
            }
        }

        public void Delete(int id)
        {
            if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_delete_operation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, Id));

                cmd.ExecuteNonQuery();
            }
        }

        public int New()
        {
            int id = 0;

            if (ImplementConnection.Instance.Conn.State == System.Data.ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT max(id) AS lastId FROM tOperation";

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

        public void Save(IOperation opt)
        {
            if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_insert_operation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, opt.Id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@date", 100, DbType.DateTime, opt.DateOperation));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@libelle", 100, DbType.String, opt.Libelle));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@montant", 10, DbType.Double, opt.Montant));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ref_sscompte1", 4, DbType.Int32, opt.RefCompte1));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@type1", 10, DbType.String, opt.Type1));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ref_sscompte2", 4, DbType.Int32, opt.RefCompte2));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@type2", 10, DbType.String, opt.Type2));

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(IOperation opt)
        {
            if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                ImplementConnection.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_update_operation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, opt.Id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@date", 100, DbType.DateTime, opt.DateOperation));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@libelle", 100, DbType.String, opt.Libelle));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@montant", 10, DbType.Double, opt.Montant));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ref_sscompte1", 4, DbType.Int32, opt.RefCompte1));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@type1", 10, DbType.String, opt.Type1));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ref_sscompte2", 4, DbType.Int32, opt.RefCompte2));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@type2", 10, DbType.String, opt.Type2));

                cmd.ExecuteNonQuery();
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

    }
}
