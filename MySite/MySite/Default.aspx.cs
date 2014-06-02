using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySite
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["islogin"] == null)
                Response.Redirect("login.aspx");
        }

       
        protected void lbInsert_Click(object sender, EventArgs e)
        {
            if (Session["islogin"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                string id = "11";
                SqlDataSource1.InsertParameters["id_address"].DefaultValue = id;
                SqlDataSource1.InsertParameters["city"].DefaultValue =
                    ((TextBox)GridView1.FooterRow.FindControl("TextBoxCity")).Text;

                SqlDataSource1.InsertParameters["street"].DefaultValue =
                    ((TextBox)GridView1.FooterRow.FindControl("TextBoxStreet")).Text;

                SqlDataSource1.InsertParameters["type2"].DefaultValue =
                    ((TextBox)GridView1.FooterRow.FindControl("TextBoxType")).Text;

                SqlDataSource1.Insert();
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["islogin"] == null)
            {
                Response.Redirect("login.aspx");
            }
            
        }
        public void populate()
        {
           // ((DropDownList)GridView1.SelectedRow.FindControl("ddl")).Items.Add("Myvalue");
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            populate();
        }

        protected void SqlDataSource1_Deleted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
        
             e.ExceptionHandled = true;
                LabelError.Text = "Inregistrarea nu poate fi stearsa";
                LabelError.ForeColor = System.Drawing.Color.Red;
            }
        }

       
    }
}
