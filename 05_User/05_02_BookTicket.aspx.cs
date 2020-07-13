using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _05_User_05_02_BookTicket : System.Web.UI.Page
{
    DL_05_01_ViewFlightScheduld DalObj = new DL_05_01_ViewFlightScheduld();
    BO_FlightScheduld BalObj = new BO_FlightScheduld();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDDl();
        }
    }


    public void BindDDl()
    {
        DL_04_02_FlightScheduld ddlobj = new DL_04_02_FlightScheduld();
        ddlSource.DataSource = ddlobj.GetCityForDDL();
        ddlSource.DataTextField = "CityName";
        ddlSource.DataValueField = "Id";
        ddlSource.DataBind();

        ddlDestination.DataSource = ddlobj.GetCityForDDL();
        ddlDestination.DataTextField = "CityName";
        ddlDestination.DataValueField = "Id";
        ddlDestination.DataBind();
    }

    public void ByDate()
    {
        BalObj.FromDate = Convert.ToDateTime(txtFromDate.Text);
        BalObj.ToDate = Convert.ToDateTime(txtToDate.Text);
        gvViewScheduld.DataSource = DalObj.GetDataByDates(BalObj);
        gvViewScheduld.DataBind();
    }
    public void BySD()
    {
        BalObj.Source = ddlSource.SelectedValue;
        BalObj.Destination = ddlDestination.SelectedValue;
        gvViewScheduld.DataSource = DalObj.GetDataBySD(BalObj);
        gvViewScheduld.DataBind();
    }


    protected void btnViewbyDate_Click(object sender, EventArgs e)
    {

        ByDate();


    }

    protected void btnViewBySd_Click(object sender, EventArgs e)
    {

        BySD();

    }

    protected void gvViewScheduld_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName.Equals("editrecord"))
        {

            GridViewRow gvrow = gvViewScheduld.Rows[index];
            hfId.Value = HttpUtility.HtmlDecode(gvrow.Cells[0].Text);
            Session["FSID"] = hfId.Value;
            Response.Redirect("../05_User/05_07_Booking.aspx");

        }



    }
}