using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _05_User_05_06_PrintTicket : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["PrintObj"] == null)
        {
            Response.Redirect("../05_User/05_01_ViewFlightScheduld.aspx");
          

        }
        else {
            PrintTicket();
        }
    }

    public void PrintTicket()
    {
        BO_Booking BalObj   = (BO_Booking)Session["PrintObj"];

        lblClass.Text = BalObj.Class;
        lblDate.Text = BalObj.DepartureDate.ToShortDateString();
        lblDestination.Text = BalObj.Destination;
        LblFlightName.Text = BalObj.FlightName;
        lblFlightNumber.Text = BalObj.FlightNumber;
        lblNoofPassangers.Text = BalObj.NoOfPassangers.ToString() ;
        lblSeatNo.Text = "10C";
        lblSource.Text = BalObj.Source;
        lblTicketNo.Text = BalObj.TicketNo;
        lblTotalAmount.Text = BalObj.AmountPayable.ToString();
        lblTime.Text = BalObj.Departuretime;

    }
}