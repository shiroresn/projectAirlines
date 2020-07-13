using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_04_UserAuthentication_04_02_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    string con = "";
    MongoServer server;
    MongoDatabase emptbl;
    DL_FeedBack DlObj = new DL_FeedBack();
    Register reg = new Register();
    DataTable user = new DataTable();
    public void DAL()
    {
        con = ConfigurationManager.ConnectionStrings["MongoConString"].ConnectionString;
        server = MongoServer.Create(con);
        emptbl = server.GetDatabase("AsianAirlines");

    }
    public bool GetAllUserList()
    {
        bool Status = false;


        if (txtLogin.Text == "admin@admin.com" & txtPassword.Text == "Admin")
        {
            Session["UserName"] = "Admin";
            Session["UserId"] = "9D9686A0-021E-4340-8584-64AD47AD72EA";
            Response.Redirect("../00_MasterEntries/00_01_Flight.aspx");
        }
        else
        {
            DAL();
            

            List<Register> list = new List<Register>();

            var collection = emptbl.GetCollection<Register>("AsianAirlines");
            foreach (Register emp in collection.FindAll())
            {
                list.Add(emp);

            }


            List<bool> st = new List<bool>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Email == txtLogin.Text && list[i].Password == txtPassword.Text)
                {
                    st.Add(true);
                    Status = true;
                }
                else
                {
                    st.Add(false);

                }
            }
            if (st.Contains(true))
            {
                Status = true;
                reg.Email = txtLogin.Text;
                reg.Password = txtPassword.Text;
                user = DlObj.GetUserId(reg);
                Session["UserId"] = user.Rows[0]["UserId"];

                Session["UserName"] = txtLogin.Text;
                Response.Redirect("../05_User/05_01_ViewFlightScheduld.aspx");


            }
            else
            {
                LoginStatus.Text = "Invalid Login Credentials! Please Try Again!";

            }




        }
        return Status;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        GetAllUserList();
    }
}