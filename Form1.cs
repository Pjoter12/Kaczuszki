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
        int ammo = 6;
        int ilosc_kaczek = 5;
        int ilosc_kaczekNaScenie = 5;
        Modele.Kaczuszka[] kaczuszki = new Modele.Kaczuszka[4];
        Queue<Modele.Kaczuszka> kaczuszkiKolejka = new Queue<Modele.Kaczuszka>();
        public Form1()
        {
            InitializeComponent();
            kaczuszki = new Serwisy.GeneratorKaczekSerwis(4).GenerujKaczuszki();
            foreach (Kaczuszki_Gra.Modele.Kaczuszka kaczuszka in kaczuszki)
            {
                Console.WriteLine(kaczuszka);
                //kaczuszka.Obraz.Parent = panel1;
                kaczuszkiKolejka.Enqueue(kaczuszka);
            }
            glownyTimer.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[]  granice  = new int [2];
            Console.WriteLine(panel1.Left);
            Console.WriteLine(panel1.Right);
            Console.WriteLine(panel1.Top);
            Console.WriteLine(panel1.Bottom);
            //Modele.Kaczuszka kaczuszka = new Modele.Kaczuszka("prawo", new System.Drawing.Point(20, 220), 1);
            //kaczuszka.Obraz.Parent = panel1;
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

            ilosc_kaczek--;
                ammo--;
                txtAmmo.Text = "Ammo " + ammo;
            
            
                
                progressBar1.Value= progressBar1.Value /2 ;

            

            Console.WriteLine("x: " + Cursor.Position.X + " y: " + Cursor.Position.Y);
            Console.WriteLine("ZIobro");
        }

        private void WstawKaczke()
        {
            if (kaczuszkiKolejka.Count > 0)
            {
                Modele.Kaczuszka kaczuszka = kaczuszkiKolejka.Dequeue();
                kaczuszka.Obraz.Parent = panel1;
            }
        }

        private void txtAmmo_Click(object sender, EventArgs e)
        {
           
            
            
            
        }
        private void akcjaKlik(object sender, EventArgs e)
        {


        }

        private void glownyTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
