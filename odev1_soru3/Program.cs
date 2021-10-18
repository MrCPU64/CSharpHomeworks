using System;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Lütfen {0} adet kelime giriniz: ",n);
            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                kelimeler[i] = Console.ReadLine().Trim();

            }

            Console.WriteLine("Kullanıcının girmiş olduğu kelimelerin sondan başa doğru yazılması: ");
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
                
            }

        }
    }
}
