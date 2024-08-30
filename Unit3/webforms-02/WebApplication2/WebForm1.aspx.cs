using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitControls();
            }
           
        }

        private void InitControls()
        {
            for (int i = 0; i < 50; i++)
            {
                var listItem = new ListItem($"Item {i}", i.ToString());
                //listItem.Text = "";
                    

                DropDownList2.Items.Add(listItem);
            }

            for (int i = 0; i < 50; i++)
            {
                var btn = new Button()
                {
                    Text = $"Button {i}"
                };

                Panel1.Controls.Add(btn);
            }
        }

        protected void btnHello_Click(object sender, EventArgs e)
        {
            var message = $"Hello, {DateTime.Now.ToLongTimeString()}";

            Label1.Text = message;
            h1.InnerText = message;

        }

        protected void link1_Click(object sender, EventArgs e)
        {
            var message = $"Hello, Calendar={calendar1.SelectedDate.ToString()}";

            Label1.Text = message;
            h1.InnerText = message;
        }
    }
}