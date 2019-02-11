using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Banque
    {
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
                if (client.Id == id)
                    return client;
            }
            return null;
        }

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