using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite Boardgame?");
            var boardGame = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your Age?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your Lucky Number?");
            int num2 = int.Parse(Console.ReadLine());

            var result = Multiply(num1, num2);
            var resultb = Sum(num1, num2, 56);

            Console.WriteLine($"One day {name} found themself playing {boardGame} with their friends, when suddenly an enraged {animal} burst into the room and knocked over the table!  Their {result} point game was ruined! They'll go for {resultb} next week.");
        }
        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i<list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
