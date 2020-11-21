using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczuszki_Gra.Serwisy.Interfejsy
{
   public interface IGeneratorSerwis
    {
        int LosujWspolrzedne(int dolnyZakres, int gornyZakres);
    }
}
