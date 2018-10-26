using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;


namespace KortspelDemo
{
    [Serializable]
    class Spelare
    {
        private string _namn;
        private int _poang;
        private List<Kort> _hand = new List<Kort>(); //Spelarens alla kort i en lista

        public string namn
        {
            get { return _namn; }
        }                                   //Propety för namn

        public int poang
        {
            get { return _poang; }
            set { _poang = value; }
        }                                   //Property för poäng

        public List<Kort> hand
        {
            get { return _hand; }
        }                                   //Property för hand

        public Spelare(string n)
        {
            _namn = n;
        }                                   //Konstruktor

        public Kort geKort(int pos)
        {
            Kort tmpkort;

            tmpkort = _hand.ElementAt(pos);     //Kopiera kortet
            _hand.RemoveAt(pos);                //Ta bort kortet från spelarens hand
            return tmpkort;                     //Return kortet som ska ges ut
        }

        public void taEmotKort(Kort k)
        {
            _hand.Add(k);
        }                                       //Ta emot ett kort till spelarens hand

    }
}
