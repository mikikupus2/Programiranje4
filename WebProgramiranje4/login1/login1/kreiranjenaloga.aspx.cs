using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login1
{
    public partial class kreiranjenaloga : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["korisnicics"].ConnectionString.ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            string commandText = "INSERT INTO [korisnici] ([korime], [lozinka],[email],[pitanje],[odgovor], [uloga]) VALUES (@korime, @lozinka, @email, @pitanje, @odgovor, @uloga)";
            SqlCommand command = new SqlCommand(commandText, connection);

            command.Parameters.Add("@korime", SqlDbType.VarChar);
            command.Parameters["@korime"].Value = CreateUserWizard1.UserName;

            command.Parameters.Add("@lozinka", SqlDbType.VarChar);
            command.Parameters["@lozinka"].Value = CreateUserWizard1.Password;

            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters["@email"].Value = CreateUserWizard1.Email;

            command.Parameters.Add("@pitanje", SqlDbType.VarChar);
            command.Parameters["@pitanje"].Value = CreateUserWizard1.Question;

            command.Parameters.Add("@odgovor", SqlDbType.VarChar);
            command.Parameters["@odgovor"].Value = CreateUserWizard1.Answer;

            command.Parameters.Add("@uloga", SqlDbType.VarChar);
            command.Parameters["@uloga"].Value = tbuloga.Text;

            command.ExecuteNonQuery();

        }
    }
}