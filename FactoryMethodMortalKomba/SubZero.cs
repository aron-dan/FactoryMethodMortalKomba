using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMortalKomba
{
    public class SubZero : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Sub Zero");
        }

        void IPersonagem.Ecolhido()
        {
            Console.WriteLine("Sub Zero");
        }
    }
}
