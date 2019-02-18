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
            dupont.idClient = 1;
            dupont.Nom = " Dupont";
            dupont.Prenom = " Tnopud";
            dupont.MailClient = " dupont.tnopud@jémail.com";
            dupont.TelClient = "06 95 25 14 36";
            dupont.AfficherClients();

            Operation operationDupont;
            operation = new Operation();
            operation.Date = new DateTime (2015, 03, 02);
            operation.Montant = "850€";
            operation.Debit = "250€";
            operation.Libelle = "Livret A";
            operation.Afficher();

            Compte compteDupont = new Compte();
            compteDupont.IdCompte = 01;
            compteDupont.Libelle = "Compte Courant Michel";
            compteDupont.Type = "Compte Courant";
            compteDupont.Solde = 5000;
            compteDupont.DateOuverture = new DateTime(2018, 05, 04);
            compteDupont.Debit = 179;
            compteDupont.Credit = 450;
            compteDupont.Crediter();
            compteDupont.Debiter();
            compteDupont.AfficherCompte(compteDupont);
            //785485248524852

        }

        
    }
}