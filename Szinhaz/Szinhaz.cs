using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Szinhaz
{
   public class Szinhaz
    {
        public List<S_Szinhaz> adatok {get; set;}

        public int[] stat = new int[3];
        private string filePath;
        public Szinhaz(string path) {
            adatok = new List<S_Szinhaz>();  
            filePath = path;
            beolvas(path);
            statElkeszit();
        }

        private void statElkeszit()
        {
            int osszes = 0;
            foreach(var i  in adatok) { 
                foreach(var j in i.sor)
                {
                    if(j == 'x') osszes++;
                }          
            }
            int vaneUres = 0; //1 ha igen;
            int o = 0;

            while(adatok.Count > o && vaneUres != 1) 
            {
                int a = 0;
                while (adatok[o].sor.Count > a && adatok[o].sor[a] != 'x') a++;
                if(a == adatok[o].sor.Count){
                    vaneUres = 1;
                }
                o++;
            }
            int tiznel = -1;
            o = 0;
            while(adatok.Count > o && tiznel == -1)
            {
                if (adatok[o].sor.Where(i => i == 'x').Count() > 10) tiznel = o + 1;
                o++;
            }
            stat[0] = osszes;
            stat[1] = vaneUres;
            stat[2] = tiznel;
           
        }
        public void beolvas(string p)
        {
            string[] strings = File.ReadAllLines(p);

            int sorokSzama = strings.Length;
            foreach(var i in strings)
            {
                adatok.Add(new S_Szinhaz(i, sorokSzama));
            }                      
        }
        public void Foglal(int sor, int oszlop)
        {
            adatok[sor - 1].sor[oszlop - 1] = 'x';
            string[] kiir = new string[adatok.Count];

            for(int i = 0; i < adatok.Count; i++) 
            {
                kiir[i] = string.Join("", adatok[i].sor);
            }
            File.WriteAllLines(filePath, kiir);
        }
        public struct S_Szinhaz
        {
            public static int sorokSzama;
            public static int maxSzekPerSor;
            public List<char> sor;

            public S_Szinhaz(string beolvasott, int sorok) {
                sorokSzama = sorok;
                sor = beolvasott.ToList();  
                if(sor.Count > maxSzekPerSor)
                {
                    maxSzekPerSor = sor.Count;
                }         
            }
        } 
        
    }
}
