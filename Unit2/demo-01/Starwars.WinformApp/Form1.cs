using Starwars.Core.Entidades;
using Starwars.Core.Negocio;

namespace Starwars.WinformApp
{
    public partial class Form1 : Form
    {
        private StarwarsNegocio _starwarsNegocio;

        public Form1()
        {
            InitializeComponent();

            _starwarsNegocio = new StarwarsNegocio();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _starwarsNegocio.Saludar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var jedi = new Jedi()
            {
                Nombre = textBox1.Text
            };

            //label2.Text = starwarsNegocio.Saludar(jedi);
        }
    }
}
