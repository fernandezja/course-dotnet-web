using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Starwars.WebApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private List<string> _items;

        public WebForm3()
        {
            _items = new List<string> {
                        "Silla",
                        "Mesa",
                        "Sofá"
                };
            //items.Sort();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = _items;
                DropDownList1.DataBind();
            }
        }
    }
}