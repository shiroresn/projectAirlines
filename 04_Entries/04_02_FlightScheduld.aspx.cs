using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _04_Entries_04_02_FlightScheduld : System.Web.UI.Page
{
    DL_04_02_FlightScheduld DalObj = new DL_04_02_FlightScheduld();
    BO_FlightScheduld BalObj = new BO_FlightScheduld();
    public enum MessageType { Success, Error, Info, Warning };
    protected void ShowMessage(string Message, MessageType type)
    {

        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindGrid();
            BindDDL();
        }
    }

    public void BindGrid()
    {
        gvFlightScheduld.DataSource = DalObj.GetAllFlightSchedulds();
        gvFlightScheduld.DataBind();
    }

    public void BindDDL()
    {
        ddlFlight.DataSource = DalObj.GetFlightsForDDL();
        ddlFlight.DataTextField = "FlightName";
        ddlFlight.DataValueField = "Id";
        ddlFlight.DataBind();

        ddlSource.DataSource = DalObj.GetCityForDDL();
        ddlSource.DataTextField = "CityName";
        ddlSource.DataValueField = "Id";
        ddlSource.DataBind();

        ddlDestiNation.DataSource = DalObj.GetCityForDDL();
        ddlDestiNation.DataTextField = "CityName";
        ddlDestiNation.DataValueField = "Id";
        ddlDestiNation.DataBind();

        ddlFlightUpdate.DataSource = DalObj.GetFlightsForDDL();
        ddlFlightUpdate.DataTextField = "FlightName";
        ddlFlightUpdate.DataValueField = "Id";
        ddlFlightUpdate.DataBind();

        ddlSourceUpdate.DataSource = DalObj.GetCityForDDL();
        ddlSourceUpdate.DataTextField = "CityName";
        ddlSourceUpdate.DataValueField = "Id";
        ddlSourceUpdate.DataBind();

        ddlDestinationUpdate.DataSource = DalObj.GetCityForDDL();
        ddlDestinationUpdate.DataTextField = "CityName";
        ddlDestinationUpdate.DataValueField = "Id";
        ddlDestinationUpdate.DataBind();

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            BalObj.FlightId = ddlFlight.SelectedValue;
            BalObj.Date =Convert.ToDateTime( txtDate.Text);
            BalObj.Time = txtTime.Text;
            BalObj.Source = ddlSource.SelectedValue;
            BalObj.Destination = ddlDestiNation.SelectedValue;
            BalObj.BFare = Convert.ToDecimal(txtBusinesClass.Text);
            BalObj.EFare = Convert.ToDecimal(txtEcoNomy.Text);
            BalObj.EXFare = Convert.ToDecimal(txtExecutive.Text);

            DalObj.InsertFlightScheduld(BalObj);



            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("notify('Success','City Added Successfully','success')");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);

            ShowMessage("Flight Scheduld  Added Succesfully.", MessageType.Success);


        }
        catch (Exception Ex)
        {

        }
    }

    protected void gvFlightScheduld_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName.Equals("editrecord"))
        {
            DataTable dt = new DataTable();
            GridViewRow gvrow = gvFlightScheduld.Rows[index];
            hfId.Value = HttpUtility.HtmlDecode(gvrow.Cells[0].Text);

            BalObj.Id = Convert.ToInt32(hfId.Value);
            dt = DalObj.GetUpdateData(BalObj);

            ddlFlightUpdate.SelectedValue = dt.Rows[0]["FlightId"].ToString();
            ddlSourceUpdate.SelectedValue = dt.Rows[0]["SourceId"].ToString();
            ddlDestinationUpdate.SelectedValue = dt.Rows[0]["DestinationId"].ToString();
            txtDateUpdate.Text= dt.Rows[0]["Date"].ToString();
            txtTimeUpdate.Text = dt.Rows[0]["Time"].ToString();
            txtBFareUpdate.Text = dt.Rows[0]["BFare"].ToString();
            txtEcoUpdate.Text = dt.Rows[0]["EFare"].ToString();
            txtExFareUpdate.Text = dt.Rows[0]["EXFare"].ToString();
           
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#modal-edit').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "EditModalScript", sb.ToString(), false);

        }


        else if (e.CommandName.Equals("deleterecord"))
        {
            GridViewRow gvrow = gvFlightScheduld.Rows[index];
            string Source = null;
            Source = HttpUtility.HtmlDecode(gvrow.Cells[1].Text).Trim();
            lblDeleteBOld.Text = Source + "!<br>";
            lblDeleteMsg.Text = " Do You Realy Want to Delete ? ";
            hfId.Value = gvFlightScheduld.DataKeys[index].Values[0].ToString();


            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#modal-del').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);

        }

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        try
        {

            BalObj.FlightId = ddlFlightUpdate.SelectedValue;
            BalObj.Source = ddlSourceUpdate.SelectedValue;
            BalObj.Destination = ddlDestinationUpdate.SelectedValue;
            BalObj.Date =Convert.ToDateTime( txtDateUpdate.Text);
            BalObj.Time = txtTimeUpdate.Text.ToString();
            BalObj.BFare =Convert.ToDecimal( txtBFareUpdate.Text);
            BalObj.EFare = Convert.ToDecimal(txtEcoUpdate.Text);
            BalObj.EXFare = Convert.ToDecimal(txtExFareUpdate.Text);
            BalObj.Id = Convert.ToInt32(hfId.Value);
            DalObj.UpdateFlightScheduld(BalObj);


            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");

            sb.Append("$('#modal-edit').modal('hide');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            ShowMessage("Flight Scheduled Updated Succesfully.", MessageType.Info);

        }
        catch (Exception Ex)
        {


        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            BalObj.Id = Convert.ToInt32(hfId.Value);

            DalObj.DeleteFlightScheduld(BalObj);
            BindGrid();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(@"<script type='text/javascript'>");

            sb.Append("$('#modal-del').modal('hide');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            ShowMessage("Flight Scheduld Deletd Succesfully.", MessageType.Info);
        }
        catch (Exception Ex)
        {

        }

    }
}