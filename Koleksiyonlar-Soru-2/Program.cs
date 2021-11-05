using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_array = new int[20];
            int[] small_array = new int[3];
            int[] big_array = new int[3];

            Console.WriteLine("Lütfen 20 tane tam sayı giriniz.");
            for (int i = 0; i < 20; i++)
                my_array[i] = ReadNumber();  
            Array.Sort(my_array);

            for (int i = 0; i < 3; i++)
                small_array[i] = my_array[i];
            
            Array.Reverse(my_array);
            for (int i = 0; i < 3; i++)
                big_array[i] = my_array[i];

            
            Console.WriteLine("\nGirilen en büyük 3 sayı.");
            foreach (var number in big_array)
                Console.WriteLine(number);
            double big_avg = Average(big_array);
            Console.WriteLine("Ortalama: " + big_avg);

            Console.WriteLine("\nGirilen en küçük 3 sayı.");
            foreach (var number in small_array)
                Console.WriteLine(number);
            double small_avg = Average(small_array);
            Console.WriteLine("Ortalama: " + small_avg);


            Console.WriteLine("\nOrtalamaların toplamı: " + (big_avg+small_avg));
        }


        /// <summary>
        /// Kullanıcıyı bir sayı girmeye zorlar
        /// </summary>
        /// <returns>girilen sayı</returns>
        private static int ReadNumber()
        {
            int number;
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Tam sayı dışında bir veri girdiniz.");
            }

            return number;
        }

        /// <summary>
        /// Listenin ortalamasını verir
        /// </summary>
        /// <returns>listenin int ortalama sayısı</returns>
        private static double Average(int[] arr)
        {
            return (Total(arr)*1.0)/arr.Length;
        }

        /// <summary>
        /// Listenin toplamını verir
        /// </summary>
        /// <returns>listenin int toplam sayısı</returns>
        private static int Total(int[] arr)
        {
            int total = 0;
            foreach (int number in arr)
                total += number;

            return total;
        }
    }
}
