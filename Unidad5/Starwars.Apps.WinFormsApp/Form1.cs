using Starwars.Core.Business;
using Starwars.Core.Entities;
using Starwars.Core.Entities.Filters;

namespace Starwars.Apps.WinFormsApp
{
    public partial class Form1 : Form
    {
        private StarwarsConfig _starwarsConfig;
        private JediBusiness _jediBusiness;

        public Form1()
        {
            InitializeComponent();

            //Starwars.Apps.WinFormsApp.Properties.Settings.Default.StarwarsConnectionString

            _starwarsConfig = new StarwarsConfig()
            {
                StarwarsConnectionString = Properties.Settings.Default.StarwarsConnectionString
            };

            _jediBusiness = new JediBusiness(_starwarsConfig);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //var jedis = _jediBusiness.GetAll();

            var filter = new JediFilter()
            {
                Name = txtSearch.Text
            };

            var jedis = _jediBusiness.Search(filter);

            dataGridView1.DataSource = jedis;
        }
    }
}
