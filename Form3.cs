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
using System.IO;

namespace project_A_F
{
    public partial class receive_form : Form
    {
        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\fares\Documents\project A F.mdf';Integrated Security = True";
        public int mony, mony_dr1,user_id_rece, tran_nu;
        public Boolean consel=false;
        public DateTime date = DateTime.Now;
        public byte[] imageBytes;
        public Image originalImage;
        public receive_form(string accessName, int id)
        {
            user_id_rece = id;
            InitializeComponent();
        }

        private void receive_form_Load(object sender, EventArgs e)
        {
           originalImage = pictureBox1.Image;
        }

        void clear()
        {
            send_name.Text = rece_name.Text = ph_num_send.Text = ph_num_rece.Text = mony_send.Text = mony_dr.Text = tran_no.Text = "";
            consel = receive_button.Enabled  = pictureBox1.Visible= pictureBox1.Enabled= false; search_button.Text = "بحث"; pictureBox1.Image = originalImage; tran_no.Enabled = true;

        }

        private void bh_num_send_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (consel == false)
            {

                if (string.IsNullOrEmpty(tran_no.Text))
                {
                    MessageBox.Show("يجب ادخال رقم الحواله", "حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {



                    try
                    {
                        tran_nu = int.Parse(tran_no.Text);

                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();
                        SqlCommand command = new SqlCommand("SELECT send_name, ph_send, rece_name, ph_rece, mony_send, received FROM transfers WHERE tran_no = @Tran_nu ", connection);

                        command.Parameters.AddWithValue("@Tran_nu", tran_nu);

                        SqlDataReader reader = command.ExecuteReader();



                        // Execute the command.

                        if (reader.HasRows)
                        {



                            // Display the data in the textbox.
                            while (reader.Read())
                            {

                                if (reader["received"].ToString() == "1")
                                {
                                    MessageBox.Show("الحواله مستلم بالفعل", "حواله مستلمه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                                else
                                {

                                    // textBox1.Text += reader["name"].ToString() + "\n";
                                    send_name.Text = reader["send_name"].ToString();
                                    rece_name.Text = reader["rece_name"].ToString();
                                    ph_num_send.Text = reader["ph_send"].ToString();
                                    ph_num_rece.Text = reader["ph_rece"].ToString();
                                    mony_send.Text = reader["mony_send"].ToString();
                                    search_button.Text = "الغاء";
                                    consel = true; pictureBox1.Visible= pictureBox1.Enabled = true; tran_no.Enabled = false;
                                }
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
            //consel code
            else {

                DialogResult conferm;
                conferm = MessageBox.Show("هل تريد تاكيد العمليه", "تاكيد العمليه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (conferm == DialogResult.Yes)
                {
                    clear();
                }
               
                }
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                receive_button.Enabled = receive_button.Visible = true;
            }
        }

        private void receive_button_Click(object sender, EventArgs e)
        {
            DialogResult conferm;

            conferm = MessageBox.Show("هل تريد تاكيد العمليه", "تاكيد العمليه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (conferm == DialogResult.Yes)
            {


                try
                {
                    int tran_nu = int.Parse(tran_no.Text);

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE transfers SET  received = '" + 1 + "', user_id_rece = '" + user_id_rece + "', date_rece = '" + date + "', rece_img = '" + imageBytes + "' WHERE tran_no = @Tran_nu", connection);

                    command.Parameters.AddWithValue("@Tran_nu", tran_nu);


                    // Execute the command.
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the command was successful.
                    if (rowsAffected > 0)
                    {
                        // Display the message.
                        clear();
                        MessageBox.Show("تم استلام الحواله بنجاح", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            else
            {
                clear();
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
    }
    }

