using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Starwars.WebApp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ControlDataBind();
        }

        private void ControlDataBind()
        {
            Thread.Sleep(2000);

            Label1.Text = DateTime.Now.ToLongTimeString();
            Label2.Text = DateTime.Now.ToLongTimeString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ControlDataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label2.Text = "Button3 Event";
            UpdatePanel1.Update();
        }
    }
}