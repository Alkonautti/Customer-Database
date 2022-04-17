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

namespace CustomerDatabase
{
    public partial class Add_Customer : Form
    {

        string conString = string.Format("Server={0};Port={1};Database=customerdb;Uid={2};password={3};", Login.server, Login.port, Login.username, Login.password); //create connection string
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void btn_newsave_Click(object sender, EventArgs e) //save new customer button event
        {
            MySqlConnection con = new MySqlConnection(conString); //create connection
            MySqlCommand command = con.CreateCommand(); //create mysql command

            //mysql command for saving new customer to database
            command.CommandText = "Insert Into customers (name, phone, email, street, postal, city, country) Values (@n, @p, @e, @s, @pos, @c, @cou)";

            command.Parameters.AddWithValue("@n", txtbox_newname.Text); //add textbox value to @n for command text
            command.Parameters.AddWithValue("@p", txtbox_newphone.Text); //and so on...
            command.Parameters.AddWithValue("@e", txtbox_newemail.Text);
            command.Parameters.AddWithValue("@s", txtbox_newstreet.Text);
            command.Parameters.AddWithValue("@pos", txtbox_newpostal.Text);
            command.Parameters.AddWithValue("@c", txtbox_newcity.Text);
            command.Parameters.AddWithValue("@cou", txtbox_newcountry.Text);

            if (txtbox_newname.Text != "" && txtbox_newphone.Text != "") //check that customer name or phone number are not empty
            {
                try //error handling
                {
                    lbl_newname.ForeColor = Color.Black; //set name label color to black
                    lbl_newphone.ForeColor = Color.Black; //set phone label color to black

                    con.Open(); //open connection
                    command.ExecuteNonQuery(); //execute command to add new customer to database

                    //clear all textboxes
                    txtbox_newcity.Clear(); 
                    txtbox_newcountry.Clear();
                    txtbox_newemail.Clear();
                    txtbox_newname.Clear();
                    txtbox_newphone.Clear();
                    txtbox_newpostal.Clear();
                    txtbox_newstreet.Clear();
                    
                    MessageBox.Show("New Customer Added"); //display message that new customer has been added succesfully
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //if something went wrong display error message in message box
                }         
            }

            else //if name or phone text box is empty
            {
                lbl_newname.ForeColor = Color.Red; //set name label color to red
                lbl_newphone.ForeColor = Color.Red; //set phone label color to red
            }

            con.Close(); //close connection
        }

        private void btn_newclose_Click(object sender, EventArgs e) //close button event
        {
            this.Close(); //close form
        }
    }
}
