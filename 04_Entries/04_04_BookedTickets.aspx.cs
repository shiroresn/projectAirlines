using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _04_Entries_04_04_BookedTickets : System.Web.UI.Page
{
    DL_Reports DalObj = new DL_Reports();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindGrid();
        }
    }


    public void BindGrid()
    {

        gvBookedTickets.DataSource = DalObj.GetBookedTicketSForAdmin();
        gvBookedTickets.DataBind();
    }
}