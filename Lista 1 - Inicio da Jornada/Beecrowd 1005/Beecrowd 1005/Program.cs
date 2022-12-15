
using System; 

namespace Beecrowd_1005
{

    class Program
    {

        static void Main(string[] args)
        {

            double notaA, notaB, media;


            notaA = double.Parse(Console.ReadLine());
            notaB = double.Parse(Console.ReadLine());



            media = ((notaA * 3.5) + (notaB * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {media:f5}");
        }
    }
}