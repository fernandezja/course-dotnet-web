using Starwars.Core.Negocio;

namespace Starwars.AppWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jedis = new JediNegocio().ObtenerTodos();

            listBox1.Items.Clear(); 
            listBox1.Items.AddRange(jedis.ToArray());
        }
    }
}
