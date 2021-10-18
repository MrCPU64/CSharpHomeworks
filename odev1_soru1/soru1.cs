using System;

namespace odev1
{
    class soru1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******** 1.ÖDEV ********");
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int[] pozitifSayilar = new int[n];
            Console.WriteLine("Lütfen {0} adet pozitif sayı giriniz: ",n);
            for (int i = 0; i < n; i++)
            {
                pozitifSayilar[i] = Convert.ToInt32(Console.ReadLine().Trim());
            }
            
            Console.WriteLine("Çift Sayılar: ");
            foreach (var item in pozitifSayilar)
            {
                if(item%2 == 0)
                    Console.WriteLine(item);
            }

            Console.WriteLine("******************************");

            

            

        }
    }
}
