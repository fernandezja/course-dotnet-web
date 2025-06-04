using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Starwars.WebApp
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        //private string _user = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUser.Text = UserSession;
                txtDemoApp.Text = DemoApp;
            }
        }   

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //_user = txtUser.Text;

            //ViewState.Add("user", _user);

            UserSession = txtUser.Text;
        }


        public string UserViewState
        {
            get {

                if (ViewState["user"] == null)
                {
                    return string.Empty;
                }

                return ViewState["user"].ToString();

            }
            set {
                ViewState.Add("user", value);
            }
        }


        public string UserSession
        {
            get
            {

                if (Session["user"] == null)
                {
                    return string.Empty;
                }

                return Session["user"].ToString();

            }
            set
            {
                Session["user"] = value;
            }
        }


        public string DemoApp
        {
            get
            {

                if (Application["demoapp"] == null)
                {
                    return string.Empty;
                }

                return Application["demoapp"].ToString();

            }
            set
            {
                Application["demoapp"] = value;
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            DemoApp = txtDemoApp.Text;
        }
    }
}