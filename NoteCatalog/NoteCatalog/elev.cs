using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCatalog
{
    internal class Elev
    {
        string nume;
        public void setNume(string x)
        {
            nume = x;
        }
        public string getNume(string x)
        {
            return nume;
        }
        string tata;
        public void setTata(string x) 
        {  tata = x; }
        public string getTata() 
        { return tata; }
        string mama;
        public void setMama (string x)
        { mama = x; }
        public string getMama()
        { return mama; }
        string CNP;
        public void setCNP( string x)
        { CNP = x; }
        public string getCNP()
        { return CNP; }

        int an;
        public void setAn(int n)
        {
            an = n;
        }
        public void setAn(string x)
        {
            an=Int32.Parse(x);
        }
        public int getAn()
        {
            return an;
        }

        int zi;
        public void setZi(int n)
        {
            zi = n;
        }
        public void setZi(string x)
        {
            zi = Int32.Parse(x);
        }
        public int getZi()
        {
            return zi;
        }

        int luna;
        public void setLuna(int n)
        {
            luna = n;
        }
        public bool verificareCNP( string CNP)
        {
            int ok = 1;
            int[] numar = { 2,7,9,1,4,6,3,5,8,2,7,9 }, cnp;
            char[] john= CNP.ToCharArray();
            int s = 0;
            for(int i=11; i>=0; i--)
            {
                s = s+ (Convert.ToInt32(john[i])-'0') * numar[i];
            }
            s = s % 11;
            if (s == 10) s = 1;
            if ((Convert.ToInt32(john[12]) - '0') == s) return true;
            return false;
        }
        public void setLuna(string x)
        {
            luna = Int32.Parse(x);
        }
        public int getLuna()
        {
            return luna;
        }

    }
}
