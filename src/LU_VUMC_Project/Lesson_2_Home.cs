using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LU_VUMC_Project
{
    class Lesson_2_Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //================================================================================

            Console.WriteLine("Ka tevi sauc?");
            string userName = Console.ReadLine();
            Console.WriteLine("Sveiks, " + userName);

            Console.WriteLine("Kads ir tavs vecums?");
            string userAgeStr = Console.ReadLine();
            int userAge = int.Parse(userAgeStr);
            int userAgeNewYear = userAge + 1;
            bool isAdult = userAge >= 18;
            Console.WriteLine($"Nakam gad tev paliks {userAgeNewYear}, Tu esi pilngadigs: {isAdult}");

            Console.WriteLine("Ievadi 2 veselus skaitlus");
            int userIn1 = int.Parse(Console.ReadLine());
            int userIn2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Max skaitlis: {Math.Max(userIn1, userIn2)}");
            Console.WriteLine($"Min skaitlis: {Math.Min(userIn1, userIn2)}");

            Console.WriteLine($"Dalisanas atlikuma skaitlis: {userIn1 %= userIn2}");

            Console.Write("Ievadi 1 veselu skaitli: ");
            int userIn3 = int.Parse(Console.ReadLine());
            bool userBool = userIn3 % 2 == 0;
            Console.WriteLine($"Skaitlis {userIn3} ir paraskaitlis: {userBool}");

            //Square
            Console.WriteLine("Ievadi 2 skaitlus lai aprekinat taisnstūra laukumu");
            double userIn5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double userIn6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Taisnstūra laukums ir vienads ar {Math.Round(userIn5 * userIn6, 2)}");

            //Triangle
            double userNum6 = Math.Round((Math.Sqrt(3)/4)*(userIn3 * userIn3), 2);
            Console.WriteLine($"Vienādsānu trijstūra laukums ir vienads ar {userNum6}");

        }
    }
}
