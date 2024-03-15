using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eval
{
    internal class Automobile
    {
        private int numero;
        private string modele;
        private string marque;
        private int categorie;
        private int puissanceFiscle;
        private int kmParcouru;

        public int Numero { get => numero; set => numero = value; }
        public string Modele { get => modele; set => modele = value; }
        public string Marque { get => marque; set => marque = value; }
        public int Categorie { get => categorie; set => categorie = value; }
        public int PuissanceFiscle { get => puissanceFiscle; set => puissanceFiscle = value; }
        public int KmParcouru { get => kmParcouru; set => kmParcouru = value; }

        public Automobile(int numero, string modele, string marque,int categorie, int puissanceFiscle,int kmParcouru)
        {
            this.Numero = numero;
            this.Modele = modele;
            this.Marque = marque;
            this.Categorie = categorie;
            this.PuissanceFiscle=puissanceFiscle;
            this.KmParcouru =kmParcouru;

        }

        public Automobile()
        {
            
        }

        public double calculeRemboursementKmca1()
        {
            double Remboursement = this.KmParcouru * PuissanceFiscle * 0.0625;
            return Remboursement;
        }

        public double calculeRemboursementKmca2()
        {
            double Remboursement = this.KmParcouru * PuissanceFiscle * 0.0940;
            return Remboursement;
        }

        public double calculeRemboursementKmca3()
        {
            double Remboursement = this.KmParcouru * PuissanceFiscle * 0.16;
            return Remboursement;
        }

        public string AutoInfo()
        {
            if (this.categorie == 1)
            {
                string messageA = "l'automobile << " + Modele + " >> (numéro " + Numero + ") est une citadine de la marque " + Marque + " (de puissance " + PuissanceFiscle + " CV) et qui a parcouru " + KmParcouru + " km. Le remboursement sera de " + calculeRemboursementKmca1() + " euro.";
                return messageA;
            }
            if (this.categorie == 2)
            {
                string messageB = "l'automobile << " + Modele + " >> (numéro " + Numero + ") est une routière de la marque " + Marque + " (de puissance " + PuissanceFiscle + " CV) et qui a parcouru " + KmParcouru + " km. Le remboursement sera de " + calculeRemboursementKmca2() + " euro.";
                return messageB;
            }
            if (this.categorie == 3)
            {
                string messageC = "l'automobile << " + Modele + " >> (numéro " + Numero + ") est une monospace de la marque " + Marque + " (de puissance " + PuissanceFiscle + " CV) et qui a parcouru " + KmParcouru + " km. Le remboursement sera de " + calculeRemboursementKmca3() + " euro.";
                    return messageC; ;
            }
            else
            {
                string msgError = "La catégorie du véhicule choisie est mauvaise veuiller ressayer";
                return msgError;
            }



        }
    }
}
