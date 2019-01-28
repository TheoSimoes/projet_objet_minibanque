using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Client dupont;
            dupont = new Client();
            dupont.Nom = " Dupont";
            dupont.Prenom = " Tnopud";
            dupont.MailClient = " dupont.tnopud@jémail.com";
            dupont.TelClient = "06 95 25 14 36";
            dupont.Afficher();

            Operation operationDupont;
            operationDupont = new Operation();
            operationDupont.Date = new DateTime (2015, 03, 02);
            operationDupont.Montant = "850€";
            operationDupont.Debit = "250€";
            operationDupont.Libelle = "Livret A";

            operationDupont.Afficher();


            Compte compteDupont = new Compte();

            compteDupont.IdCompte = 01;
            compteDupont.Libelle = "Compte Courant Michel";
            compteDupont.Type = "Compte Courant";
            compteDupont.Solde = 5000;
            compteDupont.DateOuverture = new DateTime(2018, 05, 04);

            compteDupont.Afficher();
            //785485248524852

        }



    }
}
