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
    public partial class AppMain : Form
    {
        //create connection string
        string conString = string.Format("Server={0};Port={1};Database=customerdb;Uid={2};password={3};", Login.server, Login.port, Login.username, Login.password);

        //create string for selecting all names from database
        string selectname = "Select name From customers";

        public AppMain()
        {
            InitializeComponent();
            Get_Customers(); //call Get_Customers method
        }

        public List<String> customers = new List<string>(); //List for storing customers from database
        int userid = 0; //user id number from database
        public void Get_Customers() //method for filling customer list box
        {
            lstbox_customerlist.Items.Clear(); //clear all items from customer list box
            customers.Clear(); //clear customers list

            MySqlConnection con = new MySqlConnection(conString); //create new connection to database
            MySqlCommand command = con.CreateCommand(); //create new command
            command.CommandText = selectname; //command for database
         
            try //error handling
            {
                con.Open(); //open connection
                MySqlDataReader reader = command.ExecuteReader(); //execute data reader

                while (reader.Read()) //while reading data
                {
                    customers.Add(reader["name"].ToString()); //add new customer name to customers list
                }

                foreach (string name in customers) //parse throu customer names in customers list
                {
                    lstbox_customerlist.Items.Add(name); //add customer name to customers list box
                }
            }

            catch(Exception ex) //in case of exeption
            {
                MessageBox.Show(ex.Message); //display error message
            }

            con.Close(); //close connection
        }

        private void txtbox_findcustomer_TextChanged(object sender, EventArgs e) //customer search box text has changed event
        {
            lstbox_customerlist.Items.Clear(); //clear customers list box

            foreach (string name in customers) //parse throu customers list
            {
                if (name.ToUpper().Contains(txtbox_findcustomer.Text.ToUpper())) //if search box input matches name in customer list
                {
                    lstbox_customerlist.Items.Add(name); //add found names to customer list box
                }
            }
        }

        private void lstbox_customerlist_DoubleClick(object sender, EventArgs e) //customer list box double click event
        {
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand command = con.CreateCommand();

            //select from database according to name clicked in customer list box
            command.CommandText = string.Format("Select * From customers Where name = '{0}'", lstbox_customerlist.GetItemText(lstbox_customerlist.SelectedItem));
            
            try //error handling
            {
                con.Open(); //open connection

                MySqlDataReader reader = command.ExecuteReader(); //execute reader

                while (reader.Read()) //while reading data
                {
                    userid = Convert.ToInt32(reader["id"]); //store user id
                    txtbox_infoname.Text = reader["name"].ToString(); //add customer name to contact info text box
                    txtbox_infophone.Text = reader["phone"].ToString(); //and so on...
                    txtbox_infoemail.Text = reader["email"].ToString();
                    txtbox_infostreet.Text = reader["street"].ToString();
                    txtbox_infopostal.Text = reader["postal"].ToString();
                    txtbox_infocity.Text = reader["city"].ToString();
                    txtbox_infocountry.Text = reader["country"].ToString();
                    rtbox_opencoms.Text = reader["opencoms"].ToString();
                    rtbox_actions.Text = reader["actions"].ToString();
                }
            }

            catch(Exception ex) //in case of error
            {
                MessageBox.Show(ex.Message); //display error message
            }

            con.Close(); //close connection
        }

        private void btn_infosave_Click(object sender, EventArgs e) //save customer data button
        {
            MySqlConnection con = new MySqlConnection(conString); //create connection
            MySqlCommand command = con.CreateCommand(); //create command

            //create string for updating customer info
            command.CommandText = "Update customers Set name = @n, phone = @p, email = @e, street = @s, postal = @pos, city = @c, country = @cou, opencoms = @o, actions = @a Where id = @id";
            
            command.Parameters.AddWithValue("@n", txtbox_infoname.Text); //add name text box data to @n
            command.Parameters.AddWithValue("@p", txtbox_infophone.Text); //and so on...
            command.Parameters.AddWithValue("@e", txtbox_infoemail.Text);
            command.Parameters.AddWithValue("@s", txtbox_infostreet.Text);
            command.Parameters.AddWithValue("@pos", txtbox_infopostal.Text);
            command.Parameters.AddWithValue("@c", txtbox_infocity.Text);
            command.Parameters.AddWithValue("@cou", txtbox_infocountry.Text);
            command.Parameters.AddWithValue("@o", rtbox_opencoms.Text); //add open comments rich text box data to @o
            command.Parameters.AddWithValue("@a", rtbox_actions.Text); //and so on..
            command.Parameters.AddWithValue("@id", userid); //add user id to @id as integer

            try //error handling
            {
                con.Open(); //open connection
                command.ExecuteNonQuery(); //execute sql query
            }

            catch (Exception ex) //in case of error
            {
                MessageBox.Show(ex.Message); //display error message
            }

            con.Close(); //close connection
        }

        private void btn_exittologin_Click(object sender, EventArgs e) //logout button event
        {
            this.Close(); //close application main form
        }

        private void btn_addcustomer_Click(object sender, EventArgs e) //add new customer button event
        {
            Add_Customer addcustomer = new Add_Customer(); //open add customer form
            addcustomer.ShowDialog(); //show add customer form
        }

        private void btn_deletecustomer_Click(object sender, EventArgs e) //delete customer button event
        {
            MySqlConnection con = new MySqlConnection(conString); //create connection
            MySqlCommand command = con.CreateCommand(); //create command
            command.CommandText = "Delete From customers Where name = @n"; //command string
            command.Parameters.AddWithValue("@n", lstbox_customerlist.GetItemText(lstbox_customerlist.SelectedItem)); //add value to @n from selected customer

            try //error handling
            {
                con.Open(); //open connection
                command.ExecuteNonQuery(); //execute query
                customers.Remove(string.Format("{0}", lstbox_customerlist.SelectedItem)); //remove customer from customers list
            }

            catch (Exception ex) //in case of error
            {
                MessageBox.Show(ex.Message); //show message
            }

            Get_Customers(); //call Get_Customers method
            con.Close(); //close connection
        }

        private void btn_refreshcustomerlist_Click(object sender, EventArgs e) //refresh button event
        {
            Get_Customers(); //call FGet_Customers method
        }
    }
}
