using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMortalKomba
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoreMethod fm = new FactoreMethod();

            Console.WriteLine("Liu kang | Sub Zero | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Escolha seu personagem:");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.Escolher_Personagem(escolha);
            Console.WriteLine();
            Console.WriteLine("Voce vai jogar com ");
            personagem.Ecolhido();

            Console.ReadKey();

        }
    }
}
