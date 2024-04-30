
using Starwars.Core.Negocio;
using Starwars.Core.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starwars.WinformAppNETFw
{
    public partial class Form1 : Form
    {
        private StarwarsNegocio starwarsNegocio;

        public Form1()
        {
            InitializeComponent();

            starwarsNegocio = new StarwarsNegocio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           label1.Text =  starwarsNegocio.Saludar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var jedi = new Jedi() { 
                Nombre = textBox1.Text
            };

            label2.Text = starwarsNegocio.Saludar(jedi);
        }
    }
}
