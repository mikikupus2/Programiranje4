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
    public partial class adminprijava : System.Web.UI.Page
    {
        bool dozvola = false;
        string conn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (AdminValidacija(Login1.UserName, Login1.Password))
            {
                Login1.Visible = false;
                Label1.Visible = true;
                AdminKorime.Visible = true;
                ChangePassword1.Visible = true;
                dozvola = true;
            }
            else if (Validacija(Login1.UserName, Login1.Password))
            {
                Login1.Visible = false;
                Label1.Visible = false;
                AdminKorime.Visible = false;
                ChangePassword1.Visible = true;
                dozvola = false;
            }
            else
                e.Authenticated = false;
        }
        private bool AdminValidacija(string k, string p)
        {
            bool boolReturnValue = false;
            string strConnection = ConfigurationManager.ConnectionStrings["zastita3grupaConnectionString"].ConnectionString.ToString();
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            string SQLQuery = "SELECT * FROM [adminnalozi]";
            SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
            SqlDataReader Dr;
            sqlConnection.Open();
            Dr = command.ExecuteReader();
            while(Dr.Read())
            {
                if ((k == Dr["korime"].ToString()) && (p == Dr["lozinka"].ToString()))
                {
                    boolReturnValue = true;
                    break;
                }

            }
            Dr.Close();
            return boolReturnValue;
        }
        private bool Validacija(string k, string p)
        {
            bool boolReturnValue = false;
            string strConnection = ConfigurationManager.ConnectionStrings["korisnicics"].ConnectionString.ToString();
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            string SQLQuery = "SELECT * FROM [korisnici]";
            SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
            SqlDataReader Dr;
            sqlConnection.Open();
            Dr = command.ExecuteReader();
            while (Dr.Read())
            {
                if ((k == Dr["korime"].ToString()) && (p == Dr["lozinka"].ToString()))
                {
                    boolReturnValue = true;
                    break;
                }

            }
            Dr.Close();
            return boolReturnValue;
        }

        protected void changepassword_Click(object sender, EventArgs e)
        {
            if (dozvola)
            {
                conn = ConfigurationManager.ConnectionStrings["korisnicics"].ConnectionString.ToString();
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                string commandText = "UPDATE [korisnici] SET [lozinka] = @lozinka WHERE [korime] = @korime AND [lozinka] = @korloz";
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@korime", SqlDbType.VarChar);
                command.Parameters["@korime"].Value = AdminKorime.Text;

                command.Parameters.Add("@lozinka", SqlDbType.VarChar);
                command.Parameters["@lozinka"].Value = ChangePassword1.NewPassword;
                command.Parameters.Add("@korloz", SqlDbType.VarChar);
                command.Parameters["@korloz"].Value = Session["Password"];

                conn = ConfigurationManager.ConnectionStrings["zastita3grupaConnectionString"].ConnectionString.ToString();
                connection = new SqlConnection(conn);
                connection.Open();
                commandText = "UPDATE [korisnici] SET [lozinka] = @lozinka WHERE [korime] = @korime";
                command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@korime", SqlDbType.VarChar);
                command.Parameters["@korime"].Value = AdminKorime.Text;

                command.Parameters.Add("@lozinka", SqlDbType.VarChar);
                command.Parameters["@lozinka"].Value = ChangePassword1.NewPassword;
                /*command.Parameters.Add("@korloz", SqlDbType.VarChar);
                command.Parameters["@korloz"].Value = Session["Password"];*/

            }
            else
            {
                conn = ConfigurationManager.ConnectionStrings["korisnicics"].ConnectionString.ToString();
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                string commandText = "UPDATE [korisnici] SET [lozinka] = @lozinka WHERE [korime] = @korime";
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@korime", SqlDbType.VarChar);
                command.Parameters["@korime"].Value = Session["UserName"];

                command.Parameters.Add("@lozinka", SqlDbType.VarChar);
                command.Parameters["@lozinka"].Value = ChangePassword1.NewPassword;
                /*command.Parameters.Add("@korloz", SqlDbType.VarChar);
                command.Parameters["@korloz"].Value = Session["Password"];*/
                command.ExecuteNonQuery();
            }
        }


        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Session["UserName"] = Login1.UserName;
            Session["Password"] = Login1.Password;
        }

    
    }
}