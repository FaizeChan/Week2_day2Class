using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day2Class
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstNames = { "Faizon", "Posiden", "Zues", "Amaterasu", "Micheal", "Lucifer" };
            Console.WriteLine(Array.IndexOf(firstNames, "Faizon"));

            int[] luckyNumber = { 1, 5, 7, 22, 44, 25 };
            Console.WriteLine(Array.LastIndexOf(luckyNumber, 7));

            char[] alphebetCharacters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine(alphebetCharacters[12]);

            string[] studentNames = { "JD", "Raz", "David", "Dan", "Monica", "Faizon", "Brian" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames[studentNames.Length -1]);












        }
    }
}
