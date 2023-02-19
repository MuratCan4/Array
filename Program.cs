using System;

namespace dizi
{
    class Program
    {
        static void Main (string[] args)
        {
            int [] sayilar = {22,74,99,4,3,45,29};
            Console.WriteLine("***** Sırasız Sayılar Dizisi *****");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Array.Sort(sayilar);
            Console.WriteLine("***** Sıralı Sayı Dizisi*****");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("Diziden Eleman Silme");
            Array.Clear(sayilar,2,3);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
             Console.WriteLine("Dizi elemanlarının yerlerini değiştirme");
            Array.Reverse(sayilar);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine(Array.IndexOf(sayilar,74));

            Array.Resize<int>(ref sayilar,8);
            sayilar[7] = 49;
            
             foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        } 
    }
}