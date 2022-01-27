using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMortalKomba
{
    public class LiuKang : IPersonagem
    {
         public void Escolhido()
        {
            Console.WriteLine("Liu Kang");
        }

        void IPersonagem.Ecolhido()
        {
            Console.WriteLine("Liu Kang");
        }
    }
}
