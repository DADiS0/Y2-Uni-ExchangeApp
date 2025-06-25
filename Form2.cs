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
    public partial class send_form : Form
    {

        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\fares\Documents\project A F.mdf';Integrated Security = True";
        public DateTime date = DateTime.Now;
        public int last_tran, mony_dr1, mony, user_id;
        public Boolean update;

        public send_form(string userName, int id)
        {
            user_id = id;
            InitializeComponent();
        }

        void clear(Boolean f1, Boolean f2)
        {
            send_name.Text = rece_name.Text = ph_num_send.Text = ph_num_rece.Text = mony_send.Text = mony_dr.Text= "";

            if (f1==true)
            {
                tran_no.Enabled = false;
                search_button.Visible = false;
                update = false;
                send_button.Enabled = true;
                tran_no.Text = (last_tran + 1).ToString();
                update_button.BackColor = default;
                if(f2==true)
                MessageBox.Show("تم الغاء العمليه");
            }
            
        }



        private void send_form_Load(object sender, EventArgs e)
        {

            /*
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT MAX(tran_no) AS last_tran FROM transfers", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            //  string accessName = reader["user_name"].ToString();

             while (reader.Read())
             {
                 // Get the value of the access_name column.
                 last_tran = (int)command.Parameters["last_tran"].Value;
             }
         //   int lastTran = (int)command.Parameters["last_tran"].Value;

            connection.Close();*/
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SELECT TOP 1 tran_no AS Isst_tran FROM transfers ORDER BY tran_no DESC", connection);

                // Add the last_tran parameter
                command.Parameters.AddWithValue("last_tran", int.MaxValue);

                // Open the connection
                connection.Open();

                // Execute the query
                SqlDataReader reader = command.ExecuteReader();
                //  string accessName = reader["user_name"].ToString();

                // Get the value of the access_name column.
                //  last_tran = (int)command.Parameters["last_tran"].Value;
                if (reader.Read())
                {
                    last_tran = reader.GetInt32(0);
                    // Do something with the ID
                }

                // Get the value of the last tran column


                // Close the connection
                connection.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur.
                MessageBox.Show(ex.Message);
            }

            last_tran += 1;
            tran_no.Text = (last_tran).ToString();

        }

        private void send_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(send_name.Text)) { MessageBox.Show("يجب ادخال اسم المرسل", "بينات مطلوبه", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (string.IsNullOrEmpty(rece_name.Text)) { MessageBox.Show("يجب ادخال اسم المستلم", "بينات مطلوبه", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (string.IsNullOrEmpty(ph_num_send.Text)) { MessageBox.Show("يجب ادخال رقم المرسل", "بينات مطلوبه", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (string.IsNullOrEmpty(ph_num_rece.Text)) { MessageBox.Show("يجب ادخال رقم المستلم", "بينات مطلوبه", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (string.IsNullOrEmpty(mony_send.Text)) { MessageBox.Show("يجب ادخال مبلغ الحواله", "بينات مطلوبه", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                DialogResult conferm;

                conferm = MessageBox.Show("هل تريد تاكيد العمليه", "تاكيد العمليه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (conferm == DialogResult.No)
                {
                    clear(true,true);
                }
                else
                {

                    try
                    {

                        SqlConnection connection = new SqlConnection(connectionString);

                        connection.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO transfers (send_name, ph_send, rece_name, ph_rece, mony_send, received, user_id, date_send) VALUES ('" + send_name.Text + "', '" + ph_num_send.Text + "', '" + rece_name.Text + "', '" + ph_num_rece.Text + "', '" + int.Parse(mony_send.Text) + "', '" + 0 + "', '" + user_id + "', '" + date + "')", connection);



                        command.ExecuteNonQuery();
                        connection.Close();
                        clear(false, false);
                        last_tran += 1;
                        tran_no.Text = (last_tran).ToString(); 
                        // Display a message
                        MessageBox.Show("تم ارسال الحواله بنجاح", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void mony_send_TextChanged(object sender, EventArgs e)
        {
            if (mony_send.Text != "")
            {
                mony = int.Parse(mony_send.Text);


                if (mony > 5000000) { mony = 0; mony_send.Text = ""; mony_dr.Text = ""; MessageBox.Show("لا يمكن ارسال اكبر من 5 مليون في حواله واحده", "المبلغ غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (mony >= 1 && mony <= 50000) { mony_dr1 = 300; }
                else if (mony > 50000 && mony <= 200000) { mony_dr1 = 500; }
                else if (mony > 200000 && mony <= 1000000) { mony_dr1 = 1000; }
                else if (mony > 1000000 && mony <= 5000000) { mony_dr1 = 2000; }
                else { }
                if (mony > 0)
                {
                    mony_dr.Text = mony_dr1.ToString();
                }
            }
            else
            {
                mony_dr.Text = "";
            }

        }

        private void mony_send_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ph_num_send_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ph_num_rece_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dont_send_button_Click(object sender, EventArgs e)
        {
            DialogResult conferm;

            conferm = MessageBox.Show("هل تريد تاكيد الالغاء", "تاكيد الالغاء", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (conferm == DialogResult.Yes)
            {
                clear(true,true);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        { if (update == false)
            {
                tran_no.Enabled = true;
                search_button.Visible = true;
                tran_no.Text = "";
                update = false;
                send_button.Enabled = false;
                clear(false, false);
            }

            if (update == true)
            {
                try
                {
                    int tran_nu = int.Parse(tran_no.Text);

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE transfers SET  send_name = '" + send_name.Text + "', ph_send = '" + ph_num_send.Text + "', rece_name = '" + rece_name.Text + "', ph_rece = '" + ph_num_rece.Text + "', mony_send = '" + int.Parse(mony_send.Text) + "', received = '" + 10 + "', user_id = '" + user_id + "', date_send = '" + date + "' WHERE tran_no = @Tran_nu", connection);

                    command.Parameters.AddWithValue("@Tran_nu", tran_nu);


                    // Execute the command.
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the command was successful.
                    if (rowsAffected > 0)
                    {
                        // Display the message.
                        clear(true,false);
                        MessageBox.Show("تم تعديل الحواله بنجاح", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        
                        MessageBox.Show("Failed to update the transfer.");
                    }

                    // Close the connection.
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tran_no.Text))
            {
                MessageBox.Show("يجب ادخال رقم الحواله", "حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                try
                {
                    int tran_nu = int.Parse(tran_no.Text);

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT send_name, ph_send, rece_name, ph_rece, mony_send FROM transfers WHERE tran_no = @Tran_nu ", connection);

                    command.Parameters.AddWithValue("@Tran_nu", tran_nu);

                    // Execute the command.
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        // Display the data in the textbox.
                        while (reader.Read())
                        {
                            // textBox1.Text += reader["name"].ToString() + "\n";
                            send_name.Text = reader["send_name"].ToString();
                            rece_name.Text = reader["rece_name"].ToString();
                            ph_num_send.Text = reader["ph_send"].ToString();
                            ph_num_rece.Text = reader["ph_rece"].ToString();
                            mony_send.Text = reader["mony_send"].ToString();
                            update = true;
                            update_button.BackColor = Color.DarkViolet;
                        }
                    }
                    else
                    {

                        MessageBox.Show("رقم الحواله غير صحيح", "رقم الحواله غير موجد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                    // Close the reader.
                    reader.Close();

                    // Close the connection.
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void send_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}