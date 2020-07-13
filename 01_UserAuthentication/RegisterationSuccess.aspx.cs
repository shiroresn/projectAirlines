using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_04_UserAuthentication_RegisterationSuccess : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Variables();
    }

    public void Variables()
    {
        lblUserName.Text = Session["UserName"].ToString();
        lblPassword.Text = Session["Password"].ToString();
    }
}