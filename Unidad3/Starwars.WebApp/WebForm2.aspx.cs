using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Starwars.WebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private List<string> _items = new List<string> {
                        "Silla",
                        "Mesa",
                        "Sofá"
                };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Inicializar controles (db, etc)
                //ObtenerDatosDesdeDB();
                ObtenerDatosDesdeDB2();
            }
           
        }

        private void ObtenerDatosDesdeDB()
        {          
            DropDownList1.DataSource = _items;
            DropDownList1.DataBind();

            ///DropDownList1.Items.Add(new ListItem())

        }

        private void ObtenerDatosDesdeDB2()
        {
            var negocio = new Starwars.Core.Negocio.StarwarsNegocio(); //TODO DI

            DropDownList1.DataSource = negocio.GetAll();
            DropDownList1.DataTextField = "Nombre";
            DropDownList1.DataValueField = "ProductoId";
            DropDownList1.DataBind();


        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Label1.Text = $"{txtName.Text} {DropDownList1.SelectedItem.Value}";
        }
    }
}