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
        int ilosc_kaczek =5;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[]  granice  = new int [2];
            Console.WriteLine(panel1.Left);
            Console.WriteLine(panel1.Right);
            Console.WriteLine(panel1.Top);
            Console.WriteLine(panel1.Bottom);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (ammo == 0)
            {
                MessageBox.Show("GAME OVER");

            }

            ilosc_kaczek--;
                ammo--;
                txtAmmo.Text = "Ammo " + ammo;
            
            
                
                progressBar1.Value= progressBar1.Value /2 ;

            

            Console.WriteLine("x: " + Cursor.Position.X + " y: " + Cursor.Position.Y);
            Console.WriteLine("ZIobro");
        }
       
        private void txtAmmo_Click(object sender, EventArgs e)
        {
           
            
            
            
        }
        private void akcjaKlik(object sender, EventArgs e)
        {


        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
