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

        public void AfficherComptes()
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

        public void SupprimerCompte(int id)
        {
            Compte compte = RechercherCompte(id);
            if (compte != null)
            {
                comptes.Remove(compte);
            }
        }

        #endregion
    }
}