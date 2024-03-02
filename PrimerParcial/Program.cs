using System;

namespace Desafío_1
{
    class Program
    {
        static void Main(string[] args)
        {
          Desafio1();
        }
        public static void Desafio1()
        {
            Console.WriteLine("Ingrese Numero Positivo");
            int numerosABucar = int.Parse(Console.ReadLine());
            while (numerosABucar !=1)
            {
                for(int i = 1; i <(numerosABucar); i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine("Los numeros Pares son {0}", i);
                    }
                    if(i % 2 >= 1)
                    {
                        continue;
                    }
                }

                Console.WriteLine("Ingrese Numero Positivo");
                numerosABucar = int.Parse(Console.ReadLine());
            }
        }
    }
}
