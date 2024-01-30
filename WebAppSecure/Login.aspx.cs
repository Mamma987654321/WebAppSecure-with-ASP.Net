using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSecure
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lblmsg.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Lblmsg.Visible = true;
            if((TxtName.Text=="sam")&&(Txtpwd.Text=="sam@1234"))
            {
                FormsAuthentication.RedirectFromLoginPage(TxtName.Text, true);
            }
            else
            {
                Lblmsg.Text = "Invalid Credential";
            }

        }
    }
}