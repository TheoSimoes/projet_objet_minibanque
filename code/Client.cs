using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Client
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;

        public string Prenom
        {
            get {return prenom;}
            set {prenom = value;}
        }

        private string mailClient;

        public string MailClient
        {
            get {return mailClient; }
            set {mailClient = value; }
        }
        

        private string telClient;

        public string TelClient
        {
            get {return telClient;}
            set {telClient = value; }
        }


        public void AfficherClients ()
        {
            Console.WriteLine("nom :" + nom + ", prénom :" + prenom + ", mail du client :" + mailClient + ", tel du client");
        }
    }
}