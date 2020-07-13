using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


public partial class MainMasterPage : System.Web.UI.MasterPage
{
    DataTable dt = new DataTable();
 
   // DAL_00_MainMasterPage DALObj = new DAL_00_MainMasterPage();
    protected void Page_Load(object sender, EventArgs e)
    {
    
        
        //ChekSession();
        //CustomMenue();
        //CustomMenuForTop();
    }




    //public void CustomMenue()
    //{
    //    BlMasterPage = new Bl_00_MasterPage();
    //    BO_00_MasterPage BoMasterPage = new BO_00_MasterPage();

    //    if (Request.QueryString["eq"] == null)
    //    {
    //        Response.Redirect("~/DummyDefault.aspx");
    //    }
    //    else {
    //        string Id = Request.QueryString["eq"].ToString();
    //        BoMasterPage.Id = Convert.ToInt32(Id);
    //        dt = BlMasterPage.GetAllSubMenu(BoMasterPage);

    //        if (dt.Rows.Count > 0)
    //        {
    //            //For Loop For Adding Main Menue With icon
    //            foreach (DataRow drOutput in dt.Rows)
    //            {


    //                HtmlGenericControl li = new HtmlGenericControl("li");
    //                tabs.Controls.Add(li);

    //                //HtmlGenericControl span = new HtmlGenericControl("span");
    //                //span.Attributes.Add("class", "fa fa-chevron-down");

    //                HtmlGenericControl anchor = new HtmlGenericControl("a");
    //                anchor.InnerHtml = "<i class=" + '"' + drOutput["Icon"].ToString() + '"' + " ></i> " + Convert.ToString(drOutput["SubMenuName"]);
    //                // anchor.Controls.Add(span);

    //                anchor.Attributes.Add("href", Convert.ToString("http://testerp.tbdev.in/" + drOutput["SubMenuURL"] + "?eq=" + drOutput["MainMenuId"]));

    //                li.Controls.Add(anchor);


    //                HtmlGenericControl ul = new HtmlGenericControl("ul");
    //                ul.Attributes.Add("class", "nav child_menu");
    //                ul.Attributes.Add("style", "display: none");



    //                //DataTable dtOutputList = BlMasterPage.GetAllSubMenu(BoMasterPage);

    //                //var SubMenue = (from row in dtOutputList.AsEnumerable()
    //                //                where row.Field<int>("MainMenuId") == Int32.Parse(drOutput["MainMenuId"].ToString())
    //                //                select row);
    //                //if (SubMenue.Count() > 0)
    //                //{    //For Loop For Adding SubMenue 
    //                //    foreach (DataRow drOutputList in SubMenue.CopyToDataTable().Rows)
    //                //    {
    //                //        HtmlGenericControl ili = new HtmlGenericControl("li");
    //                //        ul.Controls.Add(ili);
    //                //        HtmlGenericControl ianchor = new HtmlGenericControl("a");
    //                //        foreach (DataColumn dcOutputList in dtOutputList.Columns)
    //                //        {
    //                //            ianchor.Attributes.Add("href", Convert.ToString("http://localhost:50927/" + drOutputList["SubMenuURL"]));
    //                //        }
    //                //        ianchor.InnerText = Convert.ToString(drOutputList["SubMenuName"]);
    //                //        ili.Controls.Add(ianchor);
    //                //        li.Controls.Add(ul);
    //                //    }

    //                //}


    //            }
    //        }
    //    }

    //}

    //public void CustomMenuForTop()
    //{
    //    BlMasterPage = new Bl_00_MasterPage();
    //    BO_00_MasterPage BoMasterPage = new BO_00_MasterPage();
    //    dt = BlMasterPage.GetAllSuperMenu(BoMastePage);

    //    foreach (DataRow drOutput in dt.Rows)
    //    {
    //        HtmlGenericControl li = new HtmlGenericControl("li");
    //        menu1.Controls.Add(li);

    //        HtmlGenericControl anchor = new HtmlGenericControl("a");
    //        anchor.InnerHtml = "<span class='"+drOutput["Icon"]+"'</span> <span> <span> " + drOutput["MenuName"] + " </span> </span>";
    //        anchor.Attributes.Add("href", Convert.ToString("http://testerp.tbdev.in/" + drOutput["MenuURL"] + "?eq=" + drOutput["MainMenuId"]));
    //        li.Controls.Add(anchor);
    //    }

    //}

  


    //public void ChekSession()
    //{
    //    if (Session["UserName"] == null)
    //    {
    //        Response.Redirect("01_UserAuthentication/01_01_Default.aspx");
         
    //    }
       
    //}

}
