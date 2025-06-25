using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_A_F
{
    public partial class sine_form : Form
    {
        //private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=&quot;C:\Users\F\Documents\project A F.mdf&quot;;Integrated Security=True";

        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\USERS\FARES\DOCUMENTS\PROJECT A F.MDF';Integrated Security = True";
        public int accessid;
        public int id;
       
        

        public sine_form()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_A_FDataSet.users' table. You can move, or remove it, as needed.
          //  this.usersTableAdapter.Fill(this.project_A_FDataSet.users);
        }

        private void p_name_send_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                string userName = user_in.Text;
                string password = pass_in.Text;
              

                // Connect to the database.

                connection.Open();

                // Create a command object.
                //SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE user_name = @UserName AND user_pass = @Password", connection);
                // SqlCommand command = new SqlCommand("SELECT u.user_name,u.user_pass,a.access_name from Users s ,access a  WHERE u.user_name = @UserName AND u.user_pass = @Password AND (a.access_id=u.access_id)", connection);
       SqlCommand command = new SqlCommand("SELECT user_id, user_name, user_pass, access_id from Users  WHERE user_pass = @Password and user_name =@UserName", connection);



                // Set the parameters of the command object.
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);
                



                // Execute the command object.
                SqlDataReader reader = command.ExecuteReader();
                //  string accessName = reader["user_name"].ToString();
               
                while (reader.Read())
                {
                    // Get the value of the access_name column.
                    id = reader.GetInt32(0);
                    accessid = reader.GetInt32(3);
                    
                }

              
                exchange_form exchange = new exchange_form(accessid);
                send_form send = new send_form(userName,id);
                receive_form receive = new receive_form(userName, id);
                blane_form blane = new blane_form(userName);
                admin admin = new admin();
             
                // Check if the user exists in the database.
                if (string.IsNullOrEmpty(user_in.Text) || string.IsNullOrEmpty(pass_in.Text))
                {
                    MessageBox.Show("اسم المستخد وكلمت المرور يجب ان لا يكون فارغ", "حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    if (reader.HasRows)
                    {
                        // this.Hide();
                       
                        switch (accessid)
                        {
                            case 1:
                                send.Show();
                                break;
                            case 2:
                                receive.Show();
                                break;
                            case 3:
                                exchange.Show();
                                break;
                            case 4:
                                blane.Show();
                                break;
                            case 5:
                                admin.Show();
                                break;
                            case 6:
                                admin.Show();
                                break;
                            case 31:
                                exchange.Show();
                                break;
                            case 32:
                                exchange.Show();
                                break;
                            default://3_2_1
                                exchange.Show();
                                //   exchange.Show();
                                break;
                        }
                    }

                    else
                    {

                        MessageBox.Show("اسم المتخد او كلمة المرور غير صحيحه", "خط في تسجل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle any errors that occur.
                MessageBox.Show(ex.Message+"dsadsa");
            }
            // Close the connection to the database.
          connection.Close();
        }
    }

      
    }
    

