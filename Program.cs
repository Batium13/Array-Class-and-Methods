using System;

namespace Array_class_and_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            Console.WriteLine("***** SIRASIZ DİZİ ****");
            int[] sayiDizisi = {12,13,45,39,11,19,23,47};
            foreach (var sayi in sayiDizisi)
            {
                 Console.WriteLine(sayi);
            }

            Console.WriteLine("***** SIRALI DİZİ ****");
            Array.Sort(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            // Clear
            Console.WriteLine("***** ARRAY CLEAR *****");
            // sayıDizisi elemanların kullanarak ikinci indexten itibaren iki tane elemanı sıfırlar.
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse

            Console.WriteLine("***** REVERSE *****");

            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            // indexof
            Console.WriteLine("**** INDEXOF ******");

            Console.WriteLine(Array.IndexOf(sayiDizisi,45));
           
            // Resize
            Console.WriteLine("****** RESIZE *****");

            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 999;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
