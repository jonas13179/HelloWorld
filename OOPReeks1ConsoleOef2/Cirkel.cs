using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReeks1ConsoleOef2
{
    internal class Cirkel
    {
        //Velden
        string _kleur;
        double _straal;

        //Eigenschappen
        public string kleur
        {
            get { return _kleur; }
            set { _kleur = value; }

        }
        public double Straal
        {
            get { return _straal; }
            set { _straal = value; }

        }
        //methodes
        public double Omtrek()
        {
            return Math.Round(2 * Math.PI * _straal, 2);

        }
        public double Oppervlakte()
        {
            return  Math.Round(Math.PI * Math.Pow(_straal, 2),3);

        }
        //constructor
        public Cirkel() //overlaoding
        {
            _straal = 10;
            _kleur = "blauw";
        }
        public Cirkel(string kleur, double straal) //overlaoding
        {
            _straal = straal;
            _kleur = kleur;

           
  
        }
    }
}
