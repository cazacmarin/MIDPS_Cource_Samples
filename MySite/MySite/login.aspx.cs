using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySite
{
    public partial class login : System.Web.UI.Page
    {
        string log = "user";
        string password = "password";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == log && TextBox2.Text == password)
            {
                Session["islogin"] = true;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("Date eronate");
            }
        }
    }
}
