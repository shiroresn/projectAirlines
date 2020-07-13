using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _05_User_05_05_SubmitFeedBack : System.Web.UI.Page
{
    DL_FeedBack Dalobj = new DL_FeedBack();
    public enum MessageType { Success, Error, Info, Warning };
    protected void ShowMessage(string Message, MessageType type)
    {

        ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Dalobj.Message = txtMessage.Text;
        Dalobj.MobileNo = txtMobile.Text;
        Dalobj.Name = txtName.Text;
        Dalobj.Subject = txtSubject.Text;
       bool value= Dalobj.SubmitFeedBack();

        if (value)
        {

            ShowMessage("Feedback Submited Successfully", MessageType.Success);
            txtMessage.Text = "";
            txtMobile.Text = "";
            txtName.Text = "";

            txtSubject.Text = "";

        }
        else
        {
            ShowMessage("Please Try Again", MessageType.Info);

        }

    }
}