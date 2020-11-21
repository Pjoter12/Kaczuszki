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

        public GeneratorKaczekSerwis(int ileKaczek) : base()
        {
            IleKaczek = ileKaczek;
        }

        private string WyznaczKierunekKaczki()
        {
            int kierunek = LosujWspolrzedne(0, 2);
            return kierunek == 0 ? "prawo" : "lewo";
        }

        private int WyznaczXKaczki()
        {
            int strona = LosujWspolrzedne(0, 2);
            if (strona == 0)
                return XCords[0];
            return XCords[1];
        }

        private int WyznaczYKaczki()
        {
            int y = LosujWspolrzedne(0,4);
            int yCord = 0;
            switch (y)
            {
                case 0:
                    yCord = 10;
                    break;
                case 1:
                    yCord = 100;
                    break;
                case 2:
                    yCord = 190;
                    break;
                default:
                    yCord = 280;
                    break;

            }
            return yCord;
        }

        private Modele.Kaczuszka GenerujKaczke()
        {
            string kierunekKaczki = WyznaczKierunekKaczki();
            int x, y = 0;
            if( kierunekKaczki == "lewo")
            {
                x = 500;
            }
            else
            {
                x = 25;
            }
            y = WyznaczYKaczki();
            Modele.Kaczuszka kaczuszka = new Modele.Kaczuszka(kierunekKaczki,new System.Drawing.Point(x,y),1);
            return kaczuszka;
        }

        public Modele.Kaczuszka[] GenerujKaczuszki()
        {
            Kaczuszki_Gra.Modele.Kaczuszka[] kaczuszki = new Modele.Kaczuszka[IleKaczek];
            Modele.Kaczuszka kaczuszka = null;
            for(int i = 0; i < IleKaczek; i++)
            {
                kaczuszka = GenerujKaczke();
                kaczuszki[i] = kaczuszka;
                stosKaczuszek.Push(kaczuszki[i]);

            }
            return kaczuszki;
        }
    }
}
