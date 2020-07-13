using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _04_Entries_04_07_Passangerlist : System.Web.UI.Page
{
    PassangerList pas = new PassangerList();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadEMployee();
        }
    }

    private void LoadEMployee()
    {

        try
        {

            GridView1.DataSource = pas.getPassangerList().ToList();
            GridView1.DataBind();
        }
        catch (Exception) { }
    }

}
