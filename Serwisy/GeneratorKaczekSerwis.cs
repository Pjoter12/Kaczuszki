using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczuszki_Gra.Serwisy
{
    public class GeneratorKaczekSerwis : GeneratorSerwis
    {
        
        int IleKaczek { get; set; }
        Stack<Modele.Kaczuszka> stosKaczuszek = new Stack<Modele.Kaczuszka>();

        public GeneratorKaczekSerwis(int ileKaczek)
        {
            IleKaczek = ileKaczek;
        }

        private string WyznaczKierunekKaczki()
        {
            int kierunek = LosujWspolrzedne(0, 2);
            return kierunek == 0 ? "prawo" : "lewo";
        }

        private int WyznaczXKaczki(int lewaMax, int prawaMax)
        {
            int strona = LosujWspolrzedne(0, 2);
            if (strona == 0)
                return prawaMax;
            return lewaMax;
        }

        private int WyznaczYKaczki(int goraMax, int dolMax)
        {
            int y = LosujWspolrzedne(50,200,80);
            if(stosKaczuszek.Count != 0)
            {
                Modele.Kaczuszka kaczuszka = stosKaczuszek.Pop();
                if (kaczuszka.Wspolrzedne.Y - y < 80)
                    y = LosujWspolrzedne(50 + 80, 200);
            }
            
            return y;
        }

        public Modele.Kaczuszka[] GenerujKaczuszki()
        {
            Kaczuszki_Gra.Modele.Kaczuszka[] kaczuszki = new Modele.Kaczuszka[IleKaczek];
            for(int i = 0; i < IleKaczek; i++)
            {
                kaczuszki[i] = new Modele.Kaczuszka(WyznaczKierunekKaczki(), new System.Drawing.Point(WyznaczXKaczki(100, 320), WyznaczYKaczki(0,200)),1);
                stosKaczuszek.Push(kaczuszki[i]);
            }
            return kaczuszki;
        }
    }
}
