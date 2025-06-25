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
    // send_form send = new send_form();
    // receive_form receive = new receive_form();


    public partial class exchange_form : Form
    {
        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\fares\Documents\project A F.mdf';Integrated Security = True";
        public string from, to;
        public float p_from, p_to, b_from, b_to, s_from, s_to;


        public int access_id;


        public exchange_form(int accessid)
        {

            access_id = accessid;
            InitializeComponent();
        }



        private void exchange_form_Load(object sender, EventArgs e)
        {
            from = comboBox_from.Text;
            to = comboBox_to.Text;
            // TODO: This line of code loads data into the 'project_A_FDataSet3.currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.project_A_FDataSet3.currency);

            if (access_id == 31 || access_id == 321) { go_send_button.Visible = true; }
            if (access_id == 32 || access_id == 321) { go_receive_button.Visible = true; }

            // to combobox
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT currency_name FROM currency", connection);
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Add each item from the database to the ComboBox
                    comboBox_from.Items.Add(reader["currency_name"].ToString());
                    comboBox_to.Items.Add(reader["currency_name"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //to datagridview
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                string query = "SELECT currency_id, currency_name, currency_sell, currency_buy FROM currency where currency_id not like 1";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                connection.Open();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    int rowIndex = currency_DGV.Rows.Add();
                    currency_DGV.Rows[rowIndex].Cells["currency_id"].Value = row["currency_id"];
                    currency_DGV.Rows[rowIndex].Cells["currency_name"].Value = row["currency_name"];
                    currency_DGV.Rows[rowIndex].Cells["currency_sell"].Value = row["currency_sell"];
                    currency_DGV.Rows[rowIndex].Cells["currency_buy"].Value = row["currency_buy"];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void go_send_button_Click(object sender, EventArgs e)
        {
            
        }

        private void radioSell_CheckedChanged(object sender, EventArgs e)
        {
            exchange();
        }

        private void radioBuy_CheckedChanged(object sender, EventArgs e)
        {
            exchange();
        }

        private void go_receive_button_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("sadsa");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
               
          

            from = comboBox_from.Text;
       
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT currency_buy,currency_sell FROM currency WHERE currency_name = @From ", connection);
                command.Parameters.AddWithValue("@From", from);


                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    // Display the data in the textbox.
                    while (reader.Read())
                    {
                        b_from = float.Parse(reader["currency_buy"].ToString());
                        s_from = float.Parse(reader["currency_sell"].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            exchange();
        }

        private void txt_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void exchange()
        {

            if (txt_from.Text != "")
            {
                float eq;
                if (to == from)
                {
                    txt_from.Text = "";
                    MessageBox.Show("لا يمكن ان تحول نفس العمله", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (radioBuy.Checked) { p_from = b_from;p_to = b_to; }
                    else if(radioSell.Checked) { p_from = s_from; p_to = s_to; }
                    else { MessageBox.Show("يجب اختيار نوع العمليه"); }
                    if (from == "دولار") { eq = float.Parse(txt_from.Text) * p_to; }
                    else if (to == "دولار") { eq = float.Parse(txt_from.Text) / p_from; }
                    else { eq = p_to * (float.Parse(txt_from.Text) / p_from); }
                    txt_to.Text = eq.ToString();
                }

            }
            else { txt_to.Text = ""; }

        }

        private void txt_from_TextChanged(object sender, EventArgs e)
        {
            exchange();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          

       

            to = comboBox_to.Text;
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT currency_sell,currency_buy FROM currency WHERE currency_name = @To ", connection);
                command.Parameters.AddWithValue("@To", to);


                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    // Display the data in the textbox.
                    while (reader.Read())
                    {
                        b_to = float.Parse(reader["currency_buy"].ToString());
                        s_to = float.Parse(reader["currency_sell"].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  1");
            }


            exchange();
        }


    }
}
