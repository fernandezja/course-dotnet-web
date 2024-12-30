using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Demo1 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Init();
            }
            
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = $"Hello World {DateTime.Now.ToLongTimeString()}";

            
        }

        private void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                ListBox1.Items.Add(new ListItem($"Item {i}", i.ToString()));

                DropDownList1.Items.Add(new ListItem($"Item {i}", i.ToString()));
            }
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            var item = DropDownList1.SelectedItem;

            if (item != null)
            {
                lblSeleccion.Text = $"Seleccionado: {item.Text} (Valor {item.Value})";
            }
        }
    }
}