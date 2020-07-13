using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _00_MasterEntries_00_01_Flight : System.Web.UI.Page
{
    DL_00_01_Flight DlObj = new DL_00_01_Flight();
    BO_Flight BOobj = new BO_Flight();

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
        }
    }

    private void BindGrid()

    {
        gvFlightInfo.DataSource = DlObj.GetAllFlight();
        gvFlightInfo.DataBind();

    }

    protected void gvFlightInfo_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName.Equals("editrecord"))
        {

            GridViewRow gvrow = gvFlightInfo.Rows[index];
            hfId.Value = HttpUtility.HtmlDecode(gvrow.Cells[0].Text);

            txtUpFlightName.Text = HttpUtility.HtmlDecode(gvrow.Cells[1].Text);
            txtUpFlightNumber.Text = HttpUtility.HtmlDecode(gvrow.Cells[2].Text);
            txtFlightUpSP.Text = HttpUtility.HtmlDecode(gvrow.Cells[3].Text);
            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#modal-edit').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "EditModalScript", sb.ToString(), false);

        }


        else if (e.CommandName.Equals("deleterecord"))
        {
            GridViewRow gvrow = gvFlightInfo.Rows[index];
            string Source = null;
            Source = HttpUtility.HtmlDecode(gvrow.Cells[1].Text).Trim();
            lblDeleteBOld.Text = Source + "!<br>";
            lblDeleteMsg.Text = " Do You Realy Want to Delete ? ";
            hfId.Value = gvFlightInfo.DataKeys[index].Values[0].ToString();

            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#modal-delete').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);


        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            BOobj.FlightName = txtFlightName.Text;
            BOobj.FlightNumber = txtFlightNumber.Text;
            BOobj.FlightSP = txtFlightSP.Text;


            DlObj.InsertFlight(BOobj);


            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("notify('Success','City Added Successfully','success')");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            txtFlightName.Text = null;
            txtFlightNumber.Text = null;
            txtFlightSP.Text = null;
            ShowMessage("Flight Added Succesfully.", MessageType.Success);


        }
        catch (Exception Ex)
        {

        }


    }

   

    protected void btnEditFlight_Click(object sender, EventArgs e)
    {
        try
        {

            BOobj.FlightName = txtUpFlightName.Text;
            BOobj.FlightNumber = txtUpFlightNumber.Text;
            BOobj.FlightSP = txtFlightUpSP.Text;
            BOobj.Id =Convert.ToInt32( hfId.Value);

            DlObj.UpdateFlightDeatils(BOobj);
            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");

            sb.Append("$('#modal-edit').modal('hide');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            ShowMessage("Flight Updated Succesfully.", MessageType.Info);

        }
        catch (Exception Ex)
        {


        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            BOobj.Id = Convert.ToInt32(hfId.Value);

            DlObj.DeleteFlight(BOobj);
            BindGrid();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(@"<script type='text/javascript'>");

            sb.Append("$('#modal-delete').modal('hide');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            ShowMessage("Flight Deletd Succesfully.", MessageType.Info);
        }
        catch (Exception Ex)
        {

        }


    }
}