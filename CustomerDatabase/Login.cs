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

/*
#############################################
# Simple customer database by Niko Kilponen #
#############################################
*/

namespace CustomerDatabase
{
    public partial class Login : Form
    {

        public static string server = ""; //static server address
        public static string port = ""; // port number
        public static string username = ""; //sql user
        public static string password = ""; //sql user password
        public Login()
        {
            InitializeComponent(); //generated component initialize
        }

        private void btn_exit_Click(object sender, EventArgs e) //exit button event
        {
            Application.Exit(); //exit program when exit button is clicked
        }

        private void btn_login_Click(object sender, EventArgs e) //login button event
        {
            server = txtbox_serveraddr.Text; //get server address from textbox
            port = txtbox_serverport.Text; //get port number from textbox
            username = txtbox_username.Text; //and so on...
            password = txtbox_password.Text;

            //create connection string with input info
            string conString = string.Format("Server={0};Port={1};Database=customerdb;Uid={2};password={3};",server, port, username, password); 
            
            MySqlConnection con = new MySqlConnection(conString); //create new connection

            try //error handling when connecting to database
            {
                con.Open(); //try to open connection to database

                lbl_logininfo.ForeColor = Color.Green; //change info text to green
                lbl_logininfo.Text = "Connected"; //and set text to connected when connection is succesfull

                AppMain appMain = new AppMain(); //create new instance of application main window if connected
                appMain.ShowDialog(); //show application main window
            }

            catch
            {
                lbl_logininfo.ForeColor = Color.Red; //set info text to red
                lbl_logininfo.Text = "Connection failed!"; //and set text to connection failed if connection failed (bad connection or wrong login credentials)
            }

            con.Close(); //close sql connection
        }
    }
}
