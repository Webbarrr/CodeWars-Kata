using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Disemvowel("This website is for losers LOL!"));

            Console.ReadLine();
        }
    }
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            string[] letters = { "a", "e", "i", "o", "u","A","E","I","O","U" };
            for (int i = 0; i < letters.Length - 1; i++)
            {
                str = str.Replace(letters[i], null);
            }
            return str;
        }
    }
}
