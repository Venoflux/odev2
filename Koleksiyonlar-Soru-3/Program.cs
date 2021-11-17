using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz: ");

            string input = Console.ReadLine();
            List<char> letters = new List<char>();

            foreach (var letter in input)
                if ("aeioöuüAEIİOÖUÜ".Contains(letter))
                    letters.Add(letter);

            Console.WriteLine("Girdiğiniz cümledeki bütün sesli harfler. ");
            
            foreach (var answer in letters)
                Console.WriteLine(answer);
        }
    }
}
