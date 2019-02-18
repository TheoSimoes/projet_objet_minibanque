using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Banque
    {
        #region Attributs
        private List<Compte> comptes = new List<Compte>();
        #endregion

        #region Propriétés
        public void AjouterCompte(Compte compte)
        {
            comptes.Add(compte);
        }

        public void AfficherCompte()
        {
            foreach (Compte compte in comptes)
            {
                compte.AfficherCompte(compte);
            }
        }

        public Compte RechercherCompte(int id)
        {
            foreach (Compte compte in comptes)
            {
                if (compte.Idcompte == id)
                {
                    return compte;
                }
            }
                return null;
        }
        private List<Client> clients = new List<Client>();
        

        
        public void AjouterClient(Client client)
        {
            clients.Add(client);
        }

        public void AfficherClient()
        {
           foreach(Client client in clients)
            {
                client.AfficherClients();
            }
        }

        public Client RechercherClient(int id)
        {
            foreach (Client client in clients)
            {
                if (client.IdClient == id)
                    return client;
            }
            return null;
        }

        public void SupprimerCompte(int id)
        {
            Compte compte = RechercherCompte(id);
            if (compte != null)
            {
                comptes.Remove(compte);
            }
        }

        #endregion
        public void SupprimerClient(int id)
        {
            Client client = RechercherClient(id);
            if (client != null)
            {
                clients.Remove(client);
            }
        }
      

    }
}