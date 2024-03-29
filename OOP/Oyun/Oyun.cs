using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpp
{
    class Oyun
    {
        int max;
        int min;
        string isim;
        int secim;
        int k;
        int tahminSayi;

        static int tahminSayisi = 1;

        public Oyun(int max)
        {
            Random r = new Random();
            this.max = max;
            tahminSayi = r.Next(this.max);
            Console.WriteLine("İsminizi giriniz.");
            string isim = Console.ReadLine();
            this.isim = isim;
            Console.WriteLine("0 ile {0} arasında bir sayı tahmin ediniz.",max);
        }
       
      public Oyun(int min , int max)
        {
            Random r = new Random();
            this.max = max;
            this.min = min;
            if( min < max)
                tahminSayi = r.Next(min,max);
            else if ( min > max)
                tahminSayi = r.Next(max,min);
            else
                new Sayi(max);
          
            Console.WriteLine("İsminizi giriniz.");
            string isim = Console.ReadLine();
            this.isim = isim;
            Console.WriteLine("{0} ile {1} arasında bir sayı tahmin ediniz.",min,max);
        }
            

        

        private void tahmin()
        {
            Console.WriteLine("İlk tamininizi giriniz:");       
            for (int i = 0; ; i++)
            {
                int deger = Convert.ToInt32(Console.ReadLine());
                if (deger == tahminSayi)
                {
                    Console.WriteLine("Tebrikler {0} {1}. tahmininzde buldunuz.",isim, tahminSayisi);
                    
                }
                else if (deger < tahminSayi)
                {
                    Console.WriteLine("Üzgünüm. Tuttuğumuz sayı daha büyük bir değer.");
                    tahminSayisi++;
                }
                else if ( deger > tahminSayi)
                {
                    Console.WriteLine("Üzgünüm. Tuttuğumuz sayı daha küçük bir değer.");
                }
                else
                {
                    Console.WriteLine("Geçerli bir değer giriniz");
                }
            }
        }
        private void tahmin(int sinir)
        {
            Console.WriteLine("İlk tamininizi giriniz:");

            for (int i = 0; i < sinir; i++)
            {
                int deger = Convert.ToInt32(Console.ReadLine());
                if (deger == tahminSayi)
                {
                    Console.WriteLine("Tebrikler {0} {1}. tahmininzde buldunuz.",isim, tahminSayisi);
                    
                }
                else if (deger < tahminSayi)
                {
                    Console.WriteLine("Üzgünüm. Tuttuğumuz sayı daha büyük bir değer.");
                    tahminSayisi++;
                }
                else if ( deger > tahminSayi)
                {
                    Console.WriteLine("Üzgünüm. Tuttuğumuz sayı daha küçük bir değer.");
                }
                else
                {
                    Console.WriteLine("Geçerli bir değer giriniz");
                }
            }

        }

   
        public void basla()
        {
 
            do
            {
                Console.WriteLine("Sınırsız tahmin için 1, sınırlı sayıda tahmin için 2");
                int q = Convert.ToInt32(Console.ReadLine());
                if (q == 1)
                {   
                    tahmin();
                }
                else if (q == 2)
                {
                    Console.WriteLine("Tahmin sınırızı giriniz.");
                    int x = Convert.ToInt32(Console.ReadLine());
                    tahmin(x);
                }
                else
                {
                    Console.WriteLine("Geçerli bir değer giriniz.");
                }

                 Console.WriteLine("Devam etmek için 1 , çıkış için 0");
                 k = Convert.ToInt32(Console.ReadLine());

            } while (k == 1);



        }
        
    }
}
