using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace MySite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["SiteConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                populate(DropDownList1, "SELECT eMailAddress FROM eMail WHERE id_eMail_Agenda = " + Session["idagenda"].ToString());
            }
        }

        protected void populate(DropDownList ddl, string query)
        {
            
            using (SqlConnection conn = new SqlConnection(CS))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
               // command.Parameters.AddWithValue("@id",Session["idagenda"].ToString());

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ddl.Items.Add(reader[0].ToString());

                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            populate(DropDownList2, "SELECT type1 FROM eMail WHERE id_eMail_Agenda = " + Session["idagenda"].ToString());
        }
    }
}
