using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_04_UserAuthentication_04_01_UserRegistration : System.Web.UI.Page
{
    string con = "";
    MongoServer server;
    MongoDatabase regTable;
    public void DAL()
    {
        con = ConfigurationManager.ConnectionStrings["MongoConString"].ConnectionString;
        server = MongoServer.Create(con);
        regTable = server.GetDatabase("AsianAirlines");

    }
    DL_FeedBack obj = new DL_FeedBack();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        try
        {
            DAL();
            Register Reg = new Register();
            Reg.City = txtCity.Text;
            Reg.Email = txtEmail.Text;
            Reg.FirstName = txtFirstName.Text;
            Reg.LastName = txtLastName.Text;
            Reg.Location = ddlLocation.SelectedValue.ToString();
            Reg.Mobile = txtMobile.Text;
            Reg.Password = txtPassword.Text;
            Reg.Gender = ddlGender.SelectedValue;

            insert(Reg);

            Session["UserName"] = txtEmail.Text;
            Session["Password"] = txtPassword.Text;
   
            obj.userinsert(Reg);
            Clear();
            Response.Redirect("../01_UserAuthentication/RegisterationSuccess.aspx");
        }
        catch (Exception Ex)
        {

        }
    }

    public void insert(Register Reg)
    {
        try
        {
            MongoCollection<Register> collection = regTable.GetCollection<Register>("AsianAirlines");
            BsonDocument User = new BsonDocument{
                    {"FirstName",Reg.FirstName},
                     {"LastName",Reg.LastName},
                       {"Location",Reg.Location},
                     {"Mobile",Reg.Mobile},
                       {"Email",Reg.Email},
                     {"Gender",Reg.Gender},
                      {"Password",Reg.Password},
                     {"City",Reg.City}
                    
                };
            collection.Insert(User);
        }
        catch { };
    }

    public void Clear()
    {
       
        txtFirstName.Text = "";
        txtCity.Text = "";
        txtEmail.Text = "";
        txtLastName.Text = "";
        txtMobile.Text = "";
        ddlGender.SelectedIndex = 0;
        ddlLocation.SelectedValue = "0";
        txtPassword.Text = "";
        txtRePassword.Text = "";

    }
}