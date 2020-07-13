using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _05_User_05_04_CancelTicket : System.Web.UI.Page
{
    public enum MessageType { Success, Error, Info, Warning };
    protected void ShowMessage(string Message, MessageType type)
    {

        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }
    BO_Booking balObj = new BO_Booking();
    DL_05_03_ViewBookedTicket DalObj = new DL_05_03_ViewBookedTicket();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        balObj.TicketNo = txtTicketNo.Text;
        bool value=DalObj.CancelTicket(balObj);

        if(value)
        {
            ShowMessage("Ticket Cancelation Request Recived.", MessageType.Info);
        }
     else
        {
            ShowMessage("Please Try Again.", MessageType.Info);
        }
        Response.Redirect("../05_User/05_03_ViewBookedTicket.aspx");
    }
}