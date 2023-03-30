using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Third();
            Fourth();
            Fifth();
            Sixth();
            Seventh();
            Eighth();
            Ninth();

            Console.ReadLine();
        }

        static void First()
        {
            Console.Write("Введите число: ");
            int userNum = int.Parse(Console.ReadLine());

            Console.WriteLine(userNum > 0 ? userNum + 5 : userNum - 5);
        }

        static void Second()
        {
            var playerNums = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите число: ");
                playerNums.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Максимальное число: {playerNums.Max()}");
        }

        static void Third()
        {
            var positiveNums = new List<double>();
            double result = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите число: ");
                double playerNum = double.Parse(Console.ReadLine());

                if (playerNum < 0)
                    continue;

                result += playerNum;
                positiveNums.Add(playerNum);
            }

            Console.WriteLine($"Сумма положительных: {result}");

            foreach (var num in positiveNums)
                Console.WriteLine($"Положительное число: {num}");
        }

        static void Fourth()
        {
            Console.Write("Введите число: ");
            var playerNum = double.Parse(Console.ReadLine());

            Console.WriteLine(playerNum > 10 ? playerNum * 2 : playerNum);
        }

        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Fifth()
        {
            Console.Write("Введите день по счету: ");

            var thDay = int.Parse(Console.ReadLine());

            if (thDay > 7 || thDay < 1)
                return;

            Console.WriteLine((DayOfWeek)thDay);
        }

        static void Sixth()
        {
            int initialNum = 200;

            while(true)
            {
                if (++initialNum % 17 == 0)
                    break;
            }

            Console.WriteLine("Больше 200 и делиться на 17: " + initialNum);
        }

        static void Seventh()
        {
            double firstDayDistance = 10;
            int dayTo20 = 0;
            int dayTo100 = 0;
            int curDay = 0;

            while (dayTo100 < 1)
            {
                curDay++;

                double dayDistance = firstDayDistance + (firstDayDistance / 100) * curDay;

                if (dayTo20 < 1 && dayDistance >= 20)
                    dayTo20 = curDay;

                if (dayDistance >= 100)
                    dayTo100 = curDay;
            }

            Console.WriteLine($"Дней до 20: {dayTo20}\nДней до 100: {dayTo100}");
        }

        static void Eighth()
        {
            Console.Write("Факториал числа: ");
            int iteractions = int.Parse(Console.ReadLine());
            int factorial = 0;

            if (iteractions > 0)
            {
                factorial = 1;

                for (int i = 2; i <= iteractions; i++)
                    factorial *= i;
            }

            Console.WriteLine($"Факториал чила {iteractions} = {factorial}");
        }

        static void Ninth()
        {
            int playerNum = 0;

            while (playerNum < 2)
            {
                Console.Write("Введите число:");
                playerNum = int.Parse(Console.ReadLine());

                if (playerNum > 2)
                    break;

                Console.WriteLine("Нельзя провести операцию с числом меньше 2!");
            }

            int smallestDivisor = 0;

            for (int i = 2; smallestDivisor < 1; i++)
            {
                if (playerNum % i == 0)
                    smallestDivisor = i;
            }

            Console.WriteLine($"Наименьший делитель числа {playerNum} = {smallestDivisor}");
        }
    }
}
