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
    public partial class admin : Form
    {
        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\fares\Documents\project A F.mdf';Integrated Security = True";
        public Boolean call , insert, call2, insert2;
        DateTime c_date,DT = DateTime.Now;
        int user_id, cid;
        string sta;

        public admin()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_A_FDataSet6.currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.project_A_FDataSet6.currency);
            // TODO: This line of code loads data into the 'project_A_FDataSet.access' table. You can move, or remove it, as needed.
            this.accessTableAdapter.Fill(this.project_A_FDataSet.access);

            access_user.SelectedIndex = user_id = -1;

            refreah(false);
            rcu(false);

        }
        void clear()
        {
            refreah(true);
            user_nameTXT.Text = user_passTXT.Text = ""; access_user.SelectedIndex = user_stat.SelectedIndex = -1;
            user_nameTXT.Enabled = user_passTXT.Enabled = access_user.Enabled = user_stat.Enabled = false;
            update.Text = "تعديل";doo.Text = "استعراض";
            add.Text = "اضافة"; insert = call = false;

        }
        void refreah(Boolean clear)
        {
            if (clear == true)
            {
                usersDGV.Rows.Clear();
            }
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT u.user_id, u.user_name, u.user_pass, u.USER_STATE, u.date_created, a.access_name FROM users u INNER JOIN access a ON u.access_id = a.access_id";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            connection.Open();
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                int rowIndex = usersDGV.Rows.Add();
                usersDGV.Rows[rowIndex].Cells["id"].Value = row["user_id"];
                usersDGV.Rows[rowIndex].Cells["name"].Value = row["user_name"];
                usersDGV.Rows[rowIndex].Cells["pass"].Value = row["user_pass"];
                usersDGV.Rows[rowIndex].Cells["stat"].Value = row["USER_STATE"];
                usersDGV.Rows[rowIndex].Cells["date"].Value = row["date_created"];
                usersDGV.Rows[rowIndex].Cells["access"].Value = row["access_name"];
            }

            connection.Close();
        }

        void clc()
        {
            rcu(true);
            cname.Text = csell.Text = cbuy.Text = "";
            cname.Enabled = csell.Enabled = cbuy.Enabled = false;
            update2.Text = "تعديل"; doo2.Text = "استعراض";
            add2.Text = "اضافة"; insert2 = call2 = false;

        }

        void rcu(Boolean clear)
        {
            if (clear == true)
            {
                currency_DGV.Rows.Clear();
            }
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

            private void button1_Click(object sender, EventArgs e)
        {
            
            user_nameTXT.Enabled = user_passTXT.Enabled = access_user.Enabled = user_stat.Enabled = true;
            if (add.Text != "حذف")  
            {
                if (insert == false)
                {
                    insert = true;
                    call = false;
                    add.Text = "حفظ";
                    doo.Text = "اضافة";
                }
                else
                {
                    if (string.IsNullOrEmpty(user_nameTXT.Text)|| string.IsNullOrEmpty(user_passTXT.Text)||access_user.SelectedIndex==-1||user_stat.SelectedIndex==-1)
                    {
                        MessageBox.Show("يجب ادخال جميع الحقول");
                    }
                    else
                    {
                        try
                        {

                            SqlConnection connection = new SqlConnection(connectionString);

                            connection.Open();
                            SqlCommand command = new SqlCommand("INSERT INTO users (user_name, user_pass, USER_STATE, date_created, access_id) VALUES ('" + user_nameTXT.Text + "', '" + user_passTXT.Text + "', '" + user_stat.SelectedItem + "', '" + DT + "', '" + access_user.SelectedIndex + "')", connection);



                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("تم انشاء مستخدم جديد", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }

            }
            else  //delete
            {

                if (sta != "Disabled")
                {
                    MessageBox.Show("لا يمكن حذف المستخدم وهو نشط", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DT < c_date.AddDays(7))
                {
                    MessageBox.Show("لا يمكن ان يتم حذف المستخدم الى بعد 7 ايام من تعطيله", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult de;
                    de = MessageBox.Show("هل انت متاكد من انك تريد حذف هذا المستخدم", "تاكيد العمليه", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (de == DialogResult.No)
                    {

                    }
                    else
                    {

                        try
                        {
                            SqlConnection connection = new SqlConnection(connectionString);

                            connection.Open();
                            SqlCommand command = new SqlCommand("DELETE FROM users WHERE user_id = " + user_id, connection);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected <0)
                            {
                                MessageBox.Show("تم الحذف بنجاح", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clear();
                            }
                            else
                            {
                                MessageBox.Show("لم تتم عملية الحذف", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
        }


       


        private void update_Click(object sender, EventArgs e)
        {
            if (call == false)
            {
                clear();
                call = true;
                doo.Text = "تعديل";

            }
            else
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE users SET user_pass = '" + user_passTXT.Text + "', user_name = '" + user_nameTXT.Text + "', USER_STATE = '" + user_stat.SelectedItem + "', date_created = '" + DT + "', access_id = '" + access_user.SelectedValue + "' WHERE user_id = " + user_id, connection);

                   

                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the command was successful.
                    if (rowsAffected > 0)
                    {
                        // Display the message.

                        MessageBox.Show("تم التعديل", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {

                        MessageBox.Show("اختار مستخدم للتعديل");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void usersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (call == true)
            {
                DataGridView dta = new DataGridView();
                dta = usersDGV;

                user_id = int.Parse(dta.CurrentRow.Cells[0].Value.ToString());
                user_nameTXT.Text = dta.CurrentRow.Cells[1].Value.ToString();
                user_passTXT.Text = dta.CurrentRow.Cells[2].Value.ToString();
                c_date = DateTime.Parse(dta.CurrentRow.Cells[3].Value.ToString());
                user_stat.SelectedItem = dta.CurrentRow.Cells[4].Value.ToString();
                sta = dta.CurrentRow.Cells[4].Value.ToString();
                string targetValue = dta.CurrentRow.Cells[5].Value.ToString();
                access_user.SelectedIndex = access_user.FindStringExact(targetValue);
                //  MessageBox.Show(targetValue+"  " +i );
                user_nameTXT.Enabled = user_passTXT.Enabled = access_user.Enabled = user_stat.Enabled = true;
                update.Text = "حفظ";
                add.Text = "حذف";
            }
            else
            {
                MessageBox.Show("يرجا اختيار عملية اولاً");
            }
        }

        private void currency_Click(object sender, EventArgs e)
        {

        }

        private void cancel2_Click(object sender, EventArgs e)
        {
            clc();
            
        }

        private void update2_Click(object sender, EventArgs e)
        {
            if (call2 == false)
            {
                clc();
                call2 = true;
                doo2.Text = "تعديل";

            }
            else
            {
                if (float.Parse(cbuy.Text) >= float.Parse(csell.Text))
                {
                    MessageBox.Show("لا يمكن ان يكون سعر البيع اقل من الشراء", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);

                        connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE currency SET currency_name = '" + cname.Text + "', currency_sell = '" + csell.Text + "', currency_buy = '" + cbuy.Text , connection);



                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the command was successful.
                        if (rowsAffected > 0)
                        {
                            // Display the message.

                            MessageBox.Show("تم التعديل", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clc();
                        }
                        else
                        {

                            MessageBox.Show("اختار عملة للتعديل");
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void add2_Click(object sender, EventArgs e)
        {

            cname.Enabled = csell.Enabled = cbuy.Enabled = true;
            if (add2.Text != "حذف")   //delete
            {
                if (insert2 == false)
                {
                    insert2 = true;
                    call2 = false;
                    add2.Text = "حفظ";
                    doo2.Text = "اضافة";
                }
                else
                {
                    if (string.IsNullOrEmpty(cname.Text) || string.IsNullOrEmpty(csell.Text) || string.IsNullOrEmpty(cbuy.Text))
                    {
                        MessageBox.Show("يجب ادخال جميع الحقول");
                    }
                    else
                    {
                        try
                        {
                            if (float.Parse(cbuy.Text) >= float.Parse(csell.Text))
                            {
                                MessageBox.Show("لا يمكن ان يكون سعر البيع اقل من الشراء", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                SqlConnection connection = new SqlConnection(connectionString);

                                connection.Open();
                                SqlCommand command = new SqlCommand("INSERT INTO currency (currency_name, currency_sell, currency_buy) VALUES ('" + cname.Text + "', '" + csell.Text + "', '" + cbuy.Text + "')", connection);



                                command.ExecuteNonQuery();
                                connection.Close();

                                MessageBox.Show("تم اضافة عمله جديده", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clc();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            else     //delete
            {

                DialogResult de;
                de = MessageBox.Show("هل انت متاكد من انك تريد حذف هذا العملة", "تاكيد العمليه", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (de == DialogResult.No)
                {

                }
                else
                {

                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);

                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM currency WHERE currency_id = " + cid, connection);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("تم الحذف بنجاح", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clc();
                        }
                        else
                        {
                            MessageBox.Show("لم تتم عملية الحذف", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
        }

        private void currency_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (call2 == true)
            {
                DataGridView dta = new DataGridView();
                dta = currency_DGV;

                cid = int.Parse(dta.CurrentRow.Cells[0].Value.ToString());
                cname.Text = dta.CurrentRow.Cells[1].Value.ToString();
                csell.Text = dta.CurrentRow.Cells[2].Value.ToString();
                cbuy.Text = dta.CurrentRow.Cells[3].Value.ToString();
               
                cname.Enabled = csell.Enabled = cbuy.Enabled= true;
                update2.Text = "حفظ";
                add2.Text = "حذف";
            }
            else
            {
                MessageBox.Show("يرجا اختيار عملية اولاً");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
          
        }

       
    }
    }
    

