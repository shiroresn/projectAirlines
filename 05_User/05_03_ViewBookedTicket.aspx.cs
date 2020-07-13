using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _05_User_05_03_ViewBookedTicket : System.Web.UI.Page
{
    DL_05_03_ViewBookedTicket DalObj = new DL_05_03_ViewBookedTicket();
    BO_Booking BalObj = new BO_Booking();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindGrid();
        }
    }

    public void BindGrid()
    {
        BalObj.UserId = new Guid(Session["UserId"].ToString());
        gvBookedTickets.DataSource = DalObj.GetUpdateData(BalObj);
        gvBookedTickets.DataBind();
    }
}