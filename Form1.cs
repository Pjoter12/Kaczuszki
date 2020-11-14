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
            
            Console.WriteLine("x: " + Cursor.Position.X + " y: " + Cursor.Position.Y);
        }
        
    }
}
