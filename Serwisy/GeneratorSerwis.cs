using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczuszki_Gra.Serwisy
{
    public class GeneratorSerwis : Interfejsy.IGeneratorSerwis
    {
        public int LosujWspolrzedne(int zakresDolny, int zakresGorny)
        {
            Random rand = new Random();
            int result = rand.Next(zakresDolny, zakresGorny);
            rand = null;
            return result;
        }

        public int LosujWspolrzedne(int zakresDolny, int zakresGorny, int krok)
        {
            return new Random().Next(zakresDolny, zakresGorny)+krok;
        }
    }
}
