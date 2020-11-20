using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaczuszki_Gra
{
    public partial class Form1 : Form
    {
        private static int ammo = 6;
        int ilosc_kaczek = 5;
        private static int licznikZabojstw = 0;
        private static Modele.Kaczuszka[] kaczuszki;
        private static Queue<Modele.Kaczuszka> kaczuszkiKolejka = new Queue<Modele.Kaczuszka>();
        public Form1()
        {
            InitializeComponent();
            kaczuszki = new Modele.Kaczuszka[ilosc_kaczek];
            kaczuszki = new Serwisy.GeneratorKaczekSerwis(ilosc_kaczek).GenerujKaczuszki();
            foreach (Kaczuszki_Gra.Modele.Kaczuszka kaczuszka in kaczuszki)
            {
                
                kaczuszka.Obraz.Click += new System.EventHandler(ZestrzelenieKaczki);
                kaczuszkiKolejka.Enqueue(kaczuszka);
            }
            glownyTimer.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            WstawKaczke();
            if (ammo == 0)
            {
                MessageBox.Show("GAME OVER");
                return;
            }

            ammo--;
            txtAmmo.Text = "Ammo " + ammo;

            Console.WriteLine("x: " + Cursor.Position.X + " y: " + Cursor.Position.Y);
        }

        private void WstawKaczke()
        {
            if (kaczuszkiKolejka.Count > 0)
            {
                Modele.Kaczuszka kaczuszka = kaczuszkiKolejka.Dequeue();
                kaczuszka.Obraz.Parent = panel1;
            }
        }

        private void ZestrzelenieKaczki(Object obj, EventArgs eventArgs )
        {
            if (ammo == 0)
            {
                MessageBox.Show("GAME OVER");
                return;
            }
            Console.WriteLine("PUFF");
            ammo--;
            txtAmmo.Text = "Ammo " + ammo;
            txtKills.Text = $" Kills: {++licznikZabojstw}";
            progressBar1.Value = progressBar1.Value / 2;
        }

        private void glownyTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
