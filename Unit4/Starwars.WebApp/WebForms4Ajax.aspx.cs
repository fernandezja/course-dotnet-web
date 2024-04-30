using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Starwars.WebApp
{
    public partial class WebForms4Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ControlDataBind();
            }

        }

        private void ControlDataBind()
        {
            Label1.Text = DateTime.Now.ToLongTimeString();
            Label2.Text = DateTime.Now.ToLongTimeString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ControlDataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ControlDataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label2.Text = DateTime.Now.ToLongTimeString();
            UpdatePanel1.Update();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}