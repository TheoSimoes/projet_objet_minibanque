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

            private double solde;

            private DateTime dateOuverture;

            private double credit;

            private double debit;

public int Idcompte
        {
            get { return Idcompte; }
            set { idCompte = value; }
        }


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
public double Solde
            {
                get {return Solde;}
                set { solde = value;}
            }
public DateTime DateOuverture
            {
                get {return DateOuverture;}
                set { dateOuverture = value;}
            }

public void AfficherCompte(Compte compte)
            {
                Console.WriteLine(" " + compte.IdCompte + " " + compte.Libelle + " " + compte.Type + " " + compte.Solde + " " + compte.DateOuverture);
            }
            public double Crediter(double credit)
            {
                solde = solde + credit;
                return solde;
            }

            public double Debiter(double debit)
            {
                solde = solde - debit;
                return solde;
            }
    }
}