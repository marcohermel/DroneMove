using System;

namespace Drone
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Drone drone = new Drone();
                Console.WriteLine("Digite a entrada:");
                string entrada = Console.ReadLine();
                string saida = drone.Movimentar(entrada);
                Console.WriteLine("Saída:({0})", saida);
            }        
        }
    }
}
