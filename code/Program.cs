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
            Banque banque = new Banque();
            banque.AjouterClient(new Client()
            {
               IdClient = 1,
               Nom = "dupont", 
               Prenom = "Tnopud",
               TelClient = "06 85 41 23 69",
               MailClient = "dupont.tnopud@jémail.com"
            });
            banque.AjouterClient(new Client()
            {
                IdClient = 2,
                Nom = "Tissier",
                Prenom = "Nicolas",
                TelClient = "07 85 92 10 41",
                MailClient = "nicolastissier@jémail.com"
            });
            banque.AjouterClient(new Client()
            {
                IdClient = 3,
                Nom = "Carayon",
                Prenom = "Gaspar",
                TelClient = "07 74 23 01 02",
                MailClient = "gasparcarayon@jémail.com"
            });


            banque.AfficherClient();

            Compte compte = new Compte()
            {

                IdCompte = 01,
                Libelle = "Compte Courant Michel",
                Type = "Compte Courant",
                Solde = 5000,
                DateOuverture = new DateTime(2018, 05, 04),
                Debit = 179,
                Credit = 450
            };

            banque.AjouterCompte(compte);

            Console.Write("somme à ajouter : ");
            double montantCredit = Convert.ToDouble(Console.ReadLine());
            compte.Crediter(montantCredit);

            Console.Write("somme à retirer : ");
            double montantDebit = Convert.ToDouble(Console.ReadLine());
            compte.Debiter(montantDebit);
            banque.AfficherCompte();


            Operation operation;
            operation = new Operation();
            operation.Date = new DateTime (2015, 03, 02);
            operation.Montant = "850€";
            operation.Debit = "250€";
            operation.Libelle = "Livret A";
            operation.Afficher();
        }

        
    }
}