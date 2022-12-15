using System;
using System.Net.Http.Headers;

namespace Beecrowd_1004
{
    class Program
    {

        static void Main(string[] args)
        {

            int A, B, X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A * B; 

            Console.WriteLine($"PROD = {X}");


        }
    }



}