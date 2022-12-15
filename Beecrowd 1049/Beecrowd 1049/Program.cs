using System;

namespace Beecrowd_1049
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string caracteristica1 = Console.ReadLine();
            string caracteristica2 = Console.ReadLine();
            string caracteristica3 = Console.ReadLine();

            if (caracteristica1 == "vertebrado")
            {
                if (caracteristica2 == "ave" && caracteristica3 == "onivoro")
                {
                    Console.WriteLine("pomba");
                }
                else if (caracteristica3  == "carnivoro"){
                    Console.WriteLine("aguia");
                }
                if (caracteristica2 == "mamifero" && caracteristica3 == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else if (caracteristica3 == "herbivoro")
                {
                    Console.WriteLine("vaca");
                }

            }
            else if (caracteristica1 == "invertebrado")
            {
                if (caracteristica2 == "inseto" && caracteristica3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else if (caracteristica3 == "herbivoro")
                {
                    Console.WriteLine("lagarta");
                }
                if (caracteristica2 == "anelideo" && caracteristica3 == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else if (caracteristica3 == "onivoro")
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}
