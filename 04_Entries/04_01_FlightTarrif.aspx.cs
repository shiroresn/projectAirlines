using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _04_Entries_04_01_FlightTarrif : System.Web.UI.Page
{
    DL_04_01_FlightTarrif DLObj = new DL_04_01_FlightTarrif();
    BOFlightTarrif BOObj = new BOFlightTarrif();
   
   
    public enum MessageType { Success, Error, Info, Warning };
    protected void ShowMessage(string Message, MessageType type)
    {
      
        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
            BindDDL();
        }
    }

    private void BindGrid()

    {
        gvFlightTarrif.DataSource = DLObj.GetAllFlightTarrifInfo();
        gvFlightTarrif.DataBind();

    }


    public void BindDDL()
    {
        DataTable dt = new DataTable();
        dt = DLObj.GetFlightsForDDL();
        ddlFlight.DataSource = dt;
        ddlFlight.DataTextField = "FlightName";
        ddlFlight.DataValueField = "Id";

        ddlFlight.DataBind();
        ddlUFlight.DataSource = dt;
        ddlUFlight.DataTextField = "FlightName";
        ddlUFlight.DataValueField = "Id";

        ddlUFlight.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            BOObj.Flight = ddlFlight.SelectedValue;
            BOObj.Class = ddlFlightClass.SelectedValue;
            BOObj.Seats =Convert.ToInt32( txtNumberSeats.Text);
            BOObj.Fare = Convert.ToDecimal(txtFare.Text);
            DLObj.InsertFlightTarrif(BOObj);



            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("notify('Success','City Added Successfully','success')");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
           
            ShowMessage("Flight Tarrif  Added Succesfully.", MessageType.Success);


        }
        catch (Exception Ex)
        {

        }

    }

    protected void gvFlightTarrif_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName.Equals("editrecord"))
        {
            DataTable dt = new DataTable();
            GridViewRow gvrow = gvFlightTarrif.Rows[index];
            hfId.Value = HttpUtility.HtmlDecode(gvrow.Cells[0].Text);

            BOObj.Id =Convert.ToInt32( hfId.Value);
            dt = DLObj.GetUpdateInfo(BOObj);

            ddlUFlight.SelectedValue = dt.Rows[0]["Flight"].ToString();
            ddlUClass.SelectedValue = dt.Rows[0]["FlightClass"].ToString();
            txtUFare.Text= dt.Rows[0]["Fare"].ToString();
            txtIUSeats.Text= dt.Rows[0]["NoOfSeats"].ToString();
            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#modal-edit').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "EditModalScript", sb.ToString(), false);

        }


        else if (e.CommandName.Equals("deleterecord"))
        {
            GridViewRow gvrow = gvFlightTarrif.Rows[index];
            string Source = null;
            Source = HttpUtility.HtmlDecode(gvrow.Cells[1].Text).Trim();
            lblDeleteBOld.Text = Source + "!<br>";
            lblDeleteMsg.Text = " Do You Realy Want to Delete ? ";
            hfId.Value = gvFlightTarrif.DataKeys[index].Values[0].ToString();

           
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

            BOObj.Flight = ddlUFlight.SelectedValue;
            BOObj.Class = ddlUClass.SelectedValue;
            BOObj.Seats = Convert.ToInt32(txtIUSeats.Text);
            BOObj.Fare = Convert.ToDecimal(txtUFare.Text);
            BOObj.Id = Convert.ToInt32(hfId.Value);
            DLObj.UpdateFlightTarrif(BOObj);


            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");

            sb.Append("$('#modal-edit').modal('hide');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            ShowMessage("Flight Tarrif Updated Succesfully.", MessageType.Info);

        }
        catch (Exception Ex)
        {


        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            BOObj.Id = Convert.ToInt32(hfId.Value);

            DLObj.DeleteFlightTarrif(BOObj);
            BindGrid();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(@"<script type='text/javascript'>");

            sb.Append("$('#modal-delete').modal('hide');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            ShowMessage("Flight Tarrif Deletd Succesfully.", MessageType.Info);
        }
        catch (Exception Ex)
        {

        }
    }
}