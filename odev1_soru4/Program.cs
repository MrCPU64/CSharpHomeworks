using System;

namespace soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string cumle = Console.ReadLine();
            int countKelime = 1;
            int countHarf = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i] == ' ')
                    countKelime++;
            }
            Console.WriteLine("Kelime sayısı: "+countKelime);

            for (int j = 0; j < cumle.Length; j++)
            {
                if(cumle[j] == ' ')
                    continue;
                else
                    countHarf++;

            }

            Console.WriteLine("Harf sayısı: "+countHarf);
            
            
        }   
            
    }
}
