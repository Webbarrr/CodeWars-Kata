using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetVowelCount("abracadabra"));
            Console.WriteLine(Kata.GetVowelCount("Nope!"));

            Console.ReadLine();
        }
    }
    public static class Kata
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            // Your code here
            char[] chars = { 'a', 'e', 'i', 'o', 'u', 'y' };
            foreach (char letter in str) if (chars.Contains(letter)) vowelCount++;
            return vowelCount;
        }
    }
}
