using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Operation
    {        
        private DateTime date;

        public DateTime Date
        {
            get {return date;}
            set {date = value;}
        }
        
        private string montant;

        public string Montant
        {
            get {return montant;}
            set {montant = value;}
        }

        private string debit;

        public string Debit
        {
            get {return debit;}
            set {debit = value;}
        }

        private string credit;

        public string Credit
        {
            get {return credit;}
            set {credit = value;}
        }

        private string libelle;

        public string Libelle
        {
            get {return libelle;}
            set {libelle = value;}
        }

           public void Afficher ()
        {
            Console.WriteLine();
        }

    }
}

