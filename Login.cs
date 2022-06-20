using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Baw_Baw
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            txt_password.MaxLength = 10;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbl_invalid.Visible = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_username.Clear();

            lbl_invalid.Visible = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lbl_invalid.Visible = false;

            string username = txt_username.Text;
            string password = txt_password.Text;

            if(username != "" && password != "")
            {
                dbConn dbconnection = new dbConn();
                dbconnection.Open();

                string query = "select * from user where username = '" + username + "' and password = '" + password + "'";
                MySqlDataReader row;
                row = dbconnection.ExecuteReader(query);

                if (row.HasRows)
                {
                    this.Hide();
                    Dashboard home = new Dashboard();
                    home.Show();
                }
                else
                {
                    lbl_invalid.Visible = true;
                }
            }
            else
            {
                lbl_invalid.Visible = true;
            }
        }
    }
}
