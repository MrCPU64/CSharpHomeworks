using System;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen iki pozitif sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int m = Convert.ToInt32(Console.ReadLine().Trim());
            int[] sayilar = new int[n];
            Console.WriteLine("Lütfen {0} adet pozitif sayı giriniz: ",n);
            for (int i = 0; i < n; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine().Trim());
            }
            Console.WriteLine("İkinci girilen sayıya eşit ya da tam bölünen sayılar: ");
            foreach (var item in sayilar)
            {
                if(item == m || item%m == 0)
                    Console.WriteLine(item);
            }
        }
    }
}
