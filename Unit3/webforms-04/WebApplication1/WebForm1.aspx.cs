using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CargarItemsPorDefault();
            }

            
        }

        private void CargarItemsPorDefault()
        {
            for (int i = 1; i <= 10; i++)
            {
                AddItem($"Item {i}");
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty( txtName2.Text))
            {
                AddItem(txtName2.Text);
            }
            if (!string.IsNullOrEmpty(txtName1.Value))
            {
                AddItem(txtName1.Value);
            }

            if (listItems.SelectedItem != null)
            {
                lblItemSeleccionado.Text = listItems.SelectedItem.Text;
            }
            
        }

        private void AddItem(string text)
        {
            listItems.Items.Add(text);
        }
    }
}