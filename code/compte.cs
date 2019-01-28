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

            private int credit;

            private int debit;

public int Debit
            {
                get{return Debit;}
                set{debit = value;}
            }

public int Credit
            {
                get {return Credit;}
                set {credit = value;}
            }



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

             public void Afficher()
            {
                Console.WriteLine(" " + idCompte + " " + libelle + " " + type +" " +solde+ " " +dateOuverture );
            }

            public void Crediter()
            {
                Console.WriteLine("somme à versez : " + credit);
                solde = solde + credit;
                Console.WriteLine("Le nouveau solde est de " + solde);
            }

            public void Debiter()
            {
                Console.WriteLine("somme à retirez : " + debit);
                solde = solde - debit;
                Console.WriteLine("Le nouveau solde est de " + solde);
            }






    }
    
}