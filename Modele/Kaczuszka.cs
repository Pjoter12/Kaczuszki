using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczuszki_Gra.Modele
{
    public class Kaczuszka
    {
        public string KierunekLotu { get; set; }
        public System.Drawing.Point Wspolrzedne { get; set; }
        public System.Windows.Forms.PictureBox Obraz { get; set; }
        public System.Windows.Forms.Timer TimerLotu { get; set; }

        public Kaczuszka(string kierunek, System.Drawing.Point wspolrzedne, int rodzaj)
        {
            KierunekLotu = kierunek;
            Wspolrzedne = wspolrzedne;
            KierunekLotu = kierunek;
            Obraz = UstawObraz();
            TimerLotu = UstawTimer(2000);
            TimerLotu.Start();
        }

        private System.Windows.Forms.PictureBox UstawObraz()
        {
            System.Windows.Forms.PictureBox obrazKaczki = new System.Windows.Forms.PictureBox();
            obrazKaczki.Tag = "Kaczka";
            if (KierunekLotu == "lewo")
                obrazKaczki.Image = Kaczuszki_Gra.Resources.GraficzneZasoby.kaczka1Lewo;
            else
                obrazKaczki.Image = Kaczuszki_Gra.Resources.GraficzneZasoby.kaczka1Prawo;
            obrazKaczki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            obrazKaczki.BackColor = System.Drawing.Color.DodgerBlue;
            obrazKaczki.Top = Wspolrzedne.Y;
            obrazKaczki.Left = Wspolrzedne.X;
            obrazKaczki.Click += new System.EventHandler(UtrataZycia);
            return obrazKaczki;
        }
        
        private System.Windows.Forms.Timer UstawTimer(int czas)
        {
            System.Windows.Forms.Timer timerKaczki = new System.Windows.Forms.Timer();
            timerKaczki.Interval = czas;
            return timerKaczki;
        }


        public void UtrataZycia(Object obj, EventArgs eventArgs)
        {
            this.Obraz.Parent = null;
        }


        private void Lot(object sender, EventArgs eventArgs)
        {

        }

        public override string ToString()
        {
            return $"Kierunek Kaczki {this.KierunekLotu} , pozycja X : {this.Wspolrzedne.X}, pozycja Y:{this.Wspolrzedne.Y}";
        }
    }
}
