using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _00_MasterEntries_00_02_City : System.Web.UI.Page
{
    DL_00_02_City Dl_City = new DL_00_02_City();

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
        }
    }



    private void BindGrid()

    {
        gvCity.DataSource = Dl_City.GetAllCity();
        gvCity.DataBind();

    }
    //Add New Course
    protected void AddCity(City city)
    {
        
       
    }



    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            City city = new City();

            city.CityName = txtCityName.Text;
            city.CityCode = txtCityCode.Text;

            Dl_City.InsertCity(city);


            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("notify('Success','City Added Successfully','success')");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            txtCityName.Text = null;
            txtCityCode.Text = null;
            ShowMessage("City Added Succesfully.", MessageType.Success);


        }
        catch (Exception Ex)
        {

        }

    }


    //Grid Manipulation
    protected void gvCity_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName.Equals("editrecord"))
        {

            GridViewRow gvrow = gvCity.Rows[index];
            hfId.Value = HttpUtility.HtmlDecode(gvrow.Cells[0].Text);

            txtCityNameUpdate.Text = HttpUtility.HtmlDecode(gvrow.Cells[1].Text);
            txtCityCodeUpdate.Text = HttpUtility.HtmlDecode(gvrow.Cells[2].Text);
            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#modal-edit').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "EditModalScript", sb.ToString(), false);
         
        }


        else if (e.CommandName.Equals("deleterecord"))
        {
            GridViewRow gvrow = gvCity.Rows[index];
            string Source = null;
            Source = HttpUtility.HtmlDecode(gvrow.Cells[1].Text).Trim();
            lblDeleteBOld.Text = Source + "!<br>";
            lblDeleteMsg.Text = " Do You Realyy Want to Delete ? ";
            hfId.Value = gvCity.DataKeys[index].Values[0].ToString();

            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#modal-delete').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);


        }

    }
    //Edit Cource
    public  void EditCity()
    {

        try
        {
            City city = new City();
            city.Id =Convert.ToInt32( hfId.Value);
            city.CityName = txtCityNameUpdate.Text;
            city.CityCode = txtCityCodeUpdate.Text;
            Dl_City.UpdateFinancialYear(city);
            BindGrid();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");

            sb.Append("$('#modal-edit').modal('hide');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            ShowMessage("City Updated Succesfully.", MessageType.Info);

        }
        catch (Exception Ex)
        {

          
        }


    }
    //Delete Cource
    protected void btnDelete_Click(object sender, EventArgs e)
    {


        try
        {
            City city = new City();
            city.Id =Convert.ToInt32( hfId.Value);

            Dl_City.DeleteCity(city);
            BindGrid();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(@"<script type='text/javascript'>");

            sb.Append("$('#modal-delete').modal('hide');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "DeleteModalScript", sb.ToString(), false);
            ShowMessage("City Deletd Succesfully.", MessageType.Info);
        }
        catch (Exception Ex)
        {
         
        }

    }



    protected void btnEditCity_Click(object sender, EventArgs e)
    {
        EditCity();
    }
}