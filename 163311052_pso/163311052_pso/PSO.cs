using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311052_pso
{
    class PSO
    {
        Random rnd = new Random();
         int parcacikSayisi, altSinir, ustSinir, ogrenmeFaktoru, kosul;
        public PSO(int parcacikSayisi,int altSinir,int ustSinir,int ogrenmeFaktoru,int kosul)
        {
            this.parcacikSayisi = parcacikSayisi;
            this.altSinir = altSinir;
            this.ustSinir = ustSinir;
            this.ogrenmeFaktoru = ogrenmeFaktoru;
            this.kosul = kosul;
            dizileriAta();
            SuruOlustur();
            GBest();
            for (int i = 0; i < kosul; i++)
            {
                HızHesapla();
                KonumHesapla();
                GBest();
            }
            
        }
        
        int parcacikGBest;
        public double gBest = 0;
        public double[,] konumDegerleri;
        public double[,] hızDegerleri;
        public double[,] parcacikDegerleri;
        public double[] uygunlukDegeri;
        private void dizileriAta()
        {
            konumDegerleri = new double[parcacikSayisi, 2];
            hızDegerleri= new double[parcacikSayisi, 2]; 
            parcacikDegerleri= new double[parcacikSayisi, 2]; 
        }
        private void SuruOlustur()
        {
            double x = 0;
            double y = 0;
            uygunlukDegeri = new double[parcacikSayisi];
            for (int i = 0; i < parcacikSayisi; i++)
            {
                do
                {
                    x= rnd.NextDouble() * rnd.Next(altSinir, ustSinir);
                    y= rnd.NextDouble() * rnd.Next(altSinir, ustSinir);

                } while (x==0 || y==0);
                parcacikDegerleri[i, 0] = x;
                parcacikDegerleri[i, 1] = y; 
            }
            for (int i = 0; i < uygunlukDegeri.Length; i++)
            {
                uygunlukDegeri[i] = (4 * Math.Pow(parcacikDegerleri[i, 0], 2)) - (2 * Math.Pow(parcacikDegerleri[i, 0], 4)) + ((1 / 3) * Math.Pow(parcacikDegerleri[i, 0],6))
                    +(parcacikDegerleri[i, 0]* parcacikDegerleri[i, 1])-(4*Math.Pow(parcacikDegerleri[i, 1],2))+(4*Math.Pow(parcacikDegerleri[i, 1],4));
            }
        }
        private void GBest()
        {
            double[] diziYeni = new double[parcacikSayisi];
            for (int i = 0; i < parcacikSayisi; i++)
            {
                diziYeni[i] = Math.Abs(uygunlukDegeri[i]);
            }
            for (int i = 0; i < parcacikSayisi; i++)
            {
                if (diziYeni.Min()==diziYeni[i])
                {
                    parcacikGBest = i;
                }
            }
            gBest = uygunlukDegeri[parcacikGBest];
        }
        private void HızHesapla()
        {

            for (int i = 0; i < parcacikSayisi; i++)
            {
                hızDegerleri[i, 0] = hızDegerleri[i, 0] + ((ogrenmeFaktoru * rnd.NextDouble()) * (parcacikDegerleri[i, 0] - parcacikDegerleri[i, 0]))
                    +(ogrenmeFaktoru*rnd.NextDouble())*(parcacikDegerleri[parcacikGBest,0]-parcacikDegerleri[i,0]);
                hızDegerleri[i, 1] = hızDegerleri[i, 1] + ((ogrenmeFaktoru * rnd.NextDouble()) * (parcacikDegerleri[i, 1] - parcacikDegerleri[i, 1]))
                    + (ogrenmeFaktoru * rnd.NextDouble()) * (parcacikDegerleri[parcacikGBest, 1] - parcacikDegerleri[i, 1]);
            }
        }
        private void KonumHesapla()
        {
            for (int i = 0; i < parcacikSayisi; i++)
            {
                konumDegerleri[i, 0] = parcacikDegerleri[i, 0] + hızDegerleri[i, 0];
                konumDegerleri[i,1]= parcacikDegerleri[i, 1] + hızDegerleri[i, 1];
                parcacikDegerleri[i, 0] = konumDegerleri[i, 0];
                parcacikDegerleri[i, 1] = konumDegerleri[i, 1];
            }
            for (int i = 0; i < uygunlukDegeri.Length; i++)
            {
                uygunlukDegeri[i] = (4 * Math.Pow(parcacikDegerleri[i, 0], 2)) - (2 * Math.Pow(parcacikDegerleri[i, 0], 4)) + ((1 / 3) * Math.Pow(parcacikDegerleri[i, 0], 6))
                    + (parcacikDegerleri[i, 0] * parcacikDegerleri[i, 1]) - (4 * Math.Pow(parcacikDegerleri[i, 1], 2)) + (4 * Math.Pow(parcacikDegerleri[i, 1], 4));
            }
        }

    }
}
