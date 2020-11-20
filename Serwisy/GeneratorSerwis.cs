using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczuszki_Gra.Serwisy
{
    public class GeneratorSerwis : Interfejsy.IGeneratorSerwis
    {
        private static Random rand;
        protected static int[] XCords = new int[] { 25, 500 };
        protected static int[] YCords = new int[] { 10, 100, 190, 280 };

        public GeneratorSerwis()
        {
            rand = new Random(); 
        }

        public int LosujWspolrzedne(int zakresDolny, int zakresGorny)
        {
            int result = 0;
            try
            {
                result = rand.Next(zakresDolny, zakresGorny);
            }
            catch (System.NullReferenceException nullException)
            {
                result = new Random().Next(zakresDolny, zakresGorny);
            }
            return result;
        }
    }
}
