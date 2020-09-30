﻿using System;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Искам функция, която да вдига на квадрат подадено число

            // 2. Искам втора функция, която да намира факториел на дадено число

            //3. Искам трета функция, която да намира корен квадратен на подадено число

            //4. Искам функция, която да приема някоя от трите функции и да печата резултата им. А не да и ма три отделни функции за печатане, които да приемат само числото и вътре да извикват различните методи, защото ще има повтаряемост на кода и той няма да се преизползва!

            //!!!!!Wrong way!!!!!!!!
            //PrintSquare(5);
            //PrintFactorial(5);
            //PrintSquareRoot(5);

            //Correct way - чрез една и съща функция можем да отпечатаме различен резултат, като подаваме друга функция, която изчислява резулата, който да се отпечата. Така преизползваме 3 пъти един и същ метод(функция)
            PrintResult(5, Square);
            PrintResult(5, Factorial);
            PrintResult(5, SquareRoot);

            //Присвояване на цял един метод на променлива!!!
            Func<int, long> square = Square;
            Func<int, long> factorial = Factorial;
            Func<int, long> squareRoot = SquareRoot;

            //Това е еквивалентно на написаното по-горе, само че PrintResult-а използва променлива, на която е присвоен метода, вместо директно името на метода!!!
            PrintResult(5, square);
            PrintResult(5, factorial);
            PrintResult(5, squareRoot);


        }
        //1.
        public static long Square(int number)
        {
            return number * number;
        }

        //2.
        public static long Factorial(int number)
        {
            long result = 1;
            for (int i =2 ; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        //3.
        public static long SquareRoot(int number)
        {
            long result = (long)Math.Sqrt(number);
            return result;
        }


        //4.
        //!!!!!Wrong way!!!!!!!!
        //public static void PrintSquare(int number)
        //{
        //    long result = Square(number);
        //    Console.WriteLine(result);
        //}

        //public static void PrintFactorial(int number)
        //{
        //    long result = Factorial(number);
        //    Console.WriteLine(result);
        //}

        //public static void PrintSquareRoot(int number)
        //{
        //    long result = SquareRoot(number);
        //    Console.WriteLine(result);
        //}

        //Correct way
        public static void PrintResult(int number, Func<int, long> func)
        {
            long result = func(number);
            Console.WriteLine(result);
        }

    }
}
