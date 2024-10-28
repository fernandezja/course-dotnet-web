using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Starwars.WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                var demo1 = TextBox1.Text;
                var name = txtName.Value;

                for (int i = 1; i <= 10; i++)
                {
                    panel1.Controls.Add(new TextBox());
                }
            }
            

            Session["Variable1"] = DateTime.Now;
            ViewState["Variable1"] = DateTime.Now;
            Application["Variable1"] = DateTime.Now;
        }
    }
}