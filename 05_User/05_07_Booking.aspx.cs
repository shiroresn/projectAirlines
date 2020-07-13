using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _05_User_05_07_Booking : System.Web.UI.Page
{
    DL_05_07_Booking DalObj = new DL_05_07_Booking();
    BO_Booking BalObj = new BO_Booking();
    DataSet DS = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        BindDetails();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        BookTicket();
    }



   
    public void BindDetails()
    {
        if (Session["FSID"] == null)
        {
            Seats.Text = "No Flight Seleted. Please Try Again!  ";
        }
        else {
            string FlightId = Session["FSID"].ToString();
            //string UserId = Session["UserId"].ToString();


            BalObj.FlightId = FlightId;
            DS = DalObj.GetFlightInfo(BalObj);
            Seats.Text = "Available Seats : " + DS.Tables[0].Rows[0]["Seats"].ToString();

            txtDate.Text = DS.Tables[1].Rows[0]["Date"].ToString();
            txtFlightNumber.Text = DS.Tables[1].Rows[0]["FlightNumber"].ToString();
            txtFlightName.Text = DS.Tables[1].Rows[0]["FlightName"].ToString();
            txtTime.Text = DS.Tables[1].Rows[0]["Time"].ToString();
            txtDestination.Text = DS.Tables[1].Rows[0]["Destination"].ToString();
            txtSource.Text = DS.Tables[1].Rows[0]["Source"].ToString();
        }
    }

    protected void ddlFlightClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlFlightClass.SelectedValue=="1")
        {
            decimal Bfare = Convert.ToDecimal(DS.Tables[1].Rows[0]["BFare"]);
            txtTotalAmount.Text = Math.Round(Convert.ToDecimal(txtPassangers.Text) * Bfare, 2).ToString(); ;
        }
        if (ddlFlightClass.SelectedValue == "2")
        {
            decimal EXfare = Convert.ToDecimal(DS.Tables[1].Rows[0]["EXFare"]);
            txtTotalAmount.Text = Math.Round(Convert.ToDecimal(txtPassangers.Text) * EXfare, 2).ToString(); ;
        }
        if (ddlFlightClass.SelectedValue == "3")
        {
            decimal Efare = Convert.ToDecimal(DS.Tables[1].Rows[0]["EFare"]);
            txtTotalAmount.Text = Math.Round(Convert.ToDecimal(txtPassangers.Text) * Efare, 2).ToString(); ;
        }
    }


    public void BookTicket()
    {
        BalObj.FlightId = Session["FSID"].ToString();
        BalObj.FlightName = txtFlightName.Text;
        BalObj.FlightNumber = txtFlightNumber.Text;
        BalObj.DepartureDate =Convert.ToDateTime( txtDate.Text);
        BalObj.Departuretime = txtTime.Text;
        BalObj.Source = DS.Tables[1].Rows[0]["SourceId"].ToString();
        BalObj.Destination = DS.Tables[1].Rows[0]["DestinationId"].ToString();
        BalObj.Class = ddlFlightClass.SelectedValue;
        BalObj.NoOfPassangers =Convert.ToInt32( txtPassangers.Text);
        BalObj.AmountPayable = Convert.ToDecimal(txtTotalAmount.Text);
        BalObj.UserId = new Guid(Session["UserId"].ToString());
        Random Ra = new Random();
      

        BalObj.TicketNo = "AS-" + Ra.Next(8).ToString()+BalObj.Source+BalObj.Destination+Ra.Next(8);
        DalObj.BookTickets(BalObj);
       
        Session["PrintObj"] = BalObj;

        Response.Redirect("../05_User/05_06_PrintTicket.aspx");
    
    }
}