using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionComptabiliteHP_Lib.Interfaces
{
    public interface IOperation
    {
        int Id { get; set; }

        DateTime DateOperation { get; set; }

        double Montant { get; set; }

        string Libelle { get; set; }

        int RefCompte1 { get; set; }

        int RefCompte2 { get; set; }

        string Type1 { get; set; }

        string Type2 { get; set; }

        int New();

        void Save(IOperation opt);

        void Update(IOperation opt);

        void Delete(int id);
    }
}
