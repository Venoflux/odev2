using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 20 tane sayı giriniz.");

            List<uint> prime = new List<uint>();
            List<uint> non_prime = new List<uint>();

            uint input;
            for (int i = 0; i < 20; i++)
            {
                input = ReadNumber();
                if (isPrime(input))
                    prime.Add(input);
                else
                    non_prime.Add(input);
            }

            prime.Sort();
            prime.Reverse();
            non_prime.Sort();
            non_prime.Reverse();

            Console.WriteLine("\nGirdiğiniz asal sayılar. ");
            foreach(var item in prime)
                Console.WriteLine(item);

            Console.WriteLine("Girdiğiniz asal olmayan sayılar");
            foreach(var item in non_prime)
                Console.WriteLine(item);
            
            Console.WriteLine("\nToplam asal sayılar: " + Total(prime));
            Console.WriteLine("Ortalama: " + Average(prime));

            Console.WriteLine("\nToplam asal olmayan sayılar: " + Total(non_prime));
            Console.WriteLine("Ortalama: " + Average(non_prime));

        }


        /// <summary>
        /// Kullanıcıyı pozitif bir sayı girmeye zorlar
        /// </summary>
        /// <returns>girilen sayı</returns>
        private static uint ReadNumber()
        {
            uint number;
            while (!UInt32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Pozitif tam sayı dışında bir veri girdiniz.");
            }

            return number;
        }

        /// <summary>
        /// Sayının asal olup olmadığını kontrol eder
        /// </summary>
        /// <returns>bool değer</returns>
        private static bool isPrime(uint n)
        {
            if (n <= 1)
                return false;
            
            for (int i = 2; i<n; i++)
                if (n % i == 0)
                    return false;
            
            return true;
        }

        /// <summary>
        /// Listenin ortalamasını verir
        /// </summary>
        /// <returns>listenin int ortalama sayısı</returns>
        private static int Average(List<uint> list)
        {
            int total = 0;
            foreach (int number in list)
                total += number;
            return total/list.Count;
        }

        /// <summary>
        /// Listenin toplamını verir
        /// </summary>
        /// <returns>listenin int toplam sayısı</returns>
        private static int Total(List<uint> list)
        {
            int total = 0;
            foreach (int number in list)
                total += number;
            return total;
        }
    }
}
