using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace KortspelDemo
{
    class Kort
    {
        public enum kortfarg
        {
            hjärter = 0,
            klöver = 1,
            ruter = 2,
            spader = 3
        }
               
        private int _valor; //v
        private kortfarg _farg; //f
        private Image _bild; //b

        public int valor
        {
            get { return _valor; }
        }

        public kortfarg farg
        {
            get { return  _farg; }
        
        }

        public Image bild
        {
            get { return _bild;  }

        }

        public Kort(int f, int v)
        {
            _farg = (kortfarg)f;
            _valor = v;

        }

        //konstruktor 

        public Kort(int f, int v, Image b)                      // Vid (int f, int v) anropas den äldre konstruktorn
        {
            _farg = (kortfarg)f;
            _valor = v;
            _bild = b; 
        }                                                       // Vid (int f, int v, image bild) anropas den nya

        
            

        
            
            
            
        





    }


}
