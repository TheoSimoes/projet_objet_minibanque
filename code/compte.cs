
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    
      class Compte
       {
             private int idCompte;
            private string libelle;

            private string type;

            private int solde;

            private DateTime dateOuverture;

            private int debit ;


public int IdCompte
            {
                get {return IdCompte;}
                set { idCompte = value;}
            }
public string Libelle
            {
                get {return Libelle;}
                set { libelle = value;}
            }
public string Type
            {
                get {return Type;}
                set { type = value;}
            }
public int Solde
            {
                get {return Solde;}
                set { solde = value;}
            }
public DateTime DateOuverture
            {
                get {return DateOuverture;}
                set { dateOuverture = value;}
            }

public int Debit
            {
                get {return Debit;}
                set { debit = value;}
            }


             public void Afficher()
            {
                Console.WriteLine(" " + idCompte + " " + libelle + " " + type +" " +solde+ " " +dateOuverture );
            }

             public void Debiter()
            {
                debit = 500 ;
                solde = solde - debit ; 
                
            }



          

            
		
        



            

            


      }
    
}