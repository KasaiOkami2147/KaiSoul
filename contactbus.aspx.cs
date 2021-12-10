using System;
namespace UsingSessionState
{
public partial class WebForm1
    : System.Web.UI.Page
    {
        protected void Page_Load
        (object sender, EventArgs e)
        {
            if (Session["Name"] != null)
                Response.Redirect("WebForm2.aspx");
        }
        protected void Button1_Click
            (object sender, EventArgs e)
        {
            Session.Add("Name", TextBox1.Text);
            Response.Redirect("WebForm2.aspx");
        }
    }
}
