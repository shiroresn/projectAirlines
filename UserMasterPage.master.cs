using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _05_User_UserMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {if(Session["UserId"]==null)
        {
            Response.Redirect("../01_UserAuthentication/04_02_Login.aspx");
        }
        else
        {
            UserName();
        }

    }
   public void UserName()
    {
        if (Session["UserName"] == null)
        {
            Response.Redirect("../01_UserAuthentication/04_02_Login.aspx");
        }
        else
        {
            lblUserName.Text = Session["UserName"].ToString();
        }
    }
}
