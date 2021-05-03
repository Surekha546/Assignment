using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class LoginPage : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=[DataDirectory]\Database.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            disp_data();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table values('"+ Name.Text +"','"+ Movie.Text +"','"+ Review.Text +"','"+ Comment +"')";
            _=cmd.ExecuteNonQuery();

            Name.Text = " ";
            Movie.Text = " ";
            Review.Text = " ";
            Comment.Text = " ";

            disp_data();
        }
        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Table";
            _=cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView.DataSource = dt;
            GridView.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Table where Name='" + Name.Text + "'";
            _ = cmd.ExecuteNonQuery();

            Name.Text = " ";
            disp_data();
        }
    }
}