using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace KortspelDemo
{
    class Kortlek
    {
        private LinkedList<Kort> hogen = new LinkedList<Kort>();
        private List<Image> kortBilder = new List<Image>();

        public Kortlek()
        {
            for (int f = 0; f <= 3; f++)
            {
                for (int v = 2; v <= 14; v++)
                {
                    hogen.AddLast(new Kort(f, v));

                }
            }

            blanda();
        }

        public Kortlek(bool medbild)
        {
            int bildNr = 0;
            hamtaBilder();
            
                for (int f = 0; f <= 3; f++)
                    for (int v = 2; v <= 14; v++)
                    {
                        Image b = kortBilder.ElementAt(bildNr);
                        b.Tag = f.ToString() + v.ToString();

                        hogen.AddLast(new Kort(f, v, b));
                        bildNr++;
                    }

            blanda(); 
         
        }

        public int antkort
        {
            get { return hogen.Count;  }
        }
        
               
        public Kort geKort() //Delar ut det översta kortet i högen
        {
            Kort tmpKort;

            tmpKort = hogen.ElementAt(0); //Kopiera kortet
            hogen.RemoveFirst(); //Ta bort kortet
            return tmpKort; //Retunera kopian
        }

        public void blanda() //blandar kortleken
        {
            List<Kort> tmpLek = new List<Kort>();
            short slump;
            Random rnd = new Random();

            for (int i = hogen.Count() - 1; i >= 0; i--)
            {
                slump = (short)rnd.Next(0, i);
                tmpLek.Add(hogen.ElementAt(slump)); //Koperia ett kort från en slumpad plats
                hogen.Remove(hogen.ElementAt(slump)); //Ta bort kortet från listan

            }

            hogen.Clear(); //Töm listan

            foreach (Kort tmpKort in tmpLek) //Kopiera tillbaka från temporär lista
            {
                hogen.AddLast(tmpKort);
            }

            
        }

        private void hamtaBilder() //Hämta bilder till korten 
        {
            DirectoryInfo sokvag = new DirectoryInfo("kortbilder"); //sökväg till bilderna
            FileInfo[] bildArr = sokvag.GetFiles("*.png", SearchOption.TopDirectoryOnly);

            foreach (FileInfo bild in bildArr) //Läser bilderna till listan
                kortBilder.Add(Image.FromFile(bild.FullName));
        }

        public bool kortlekOK()
        {
            if (hogen.Count > 1)
                return false;
            else return true; 

        }

        

        





    }
}
