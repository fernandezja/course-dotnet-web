
using Starwars.Core.Negocio;
using System.Windows.Forms;

namespace Starwars.App.WinformApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CargarJedis();
        }

        private void CargarJedis()
        {
            var jediNegocio = new JediNegocio();
            var jedis = jediNegocio.GetAll();
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = jedis;
        }
    }
}
