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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                populate();
            }
        }

        protected void populate()
        {
            string CS = ConfigurationManager.ConnectionStrings["SiteConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(CS))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT eMailAddress FROM eMail WHERE id_eMail_Agenda = @id", conn);
                command.Parameters.AddWithValue("@id",Session["idagenda"].ToString());

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DropDownList1.Items.Add(reader["eMailAddress"].ToString());

                }
            }

        }
    }
}
