namespace project_A_F
{
    partial class send_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.p_name_send = new System.Windows.Forms.Label();
            this.t_name_send = new System.Windows.Forms.Label();
            this.tran_no = new System.Windows.Forms.TextBox();
            this.tran_no_lablel = new System.Windows.Forms.Label();
            this.send_name_label = new System.Windows.Forms.Label();
            this.send_name = new System.Windows.Forms.TextBox();
            this.rece_name = new System.Windows.Forms.TextBox();
            this.rece_name_label = new System.Windows.Forms.Label();
            this.mony_send_label = new System.Windows.Forms.Label();
            this.mony_send = new System.Windows.Forms.TextBox();
            this.mony_dr_label = new System.Windows.Forms.Label();
            this.mony_dr = new System.Windows.Forms.TextBox();
            this.ph_num_rece_label = new System.Windows.Forms.Label();
            this.ph_num_send_label = new System.Windows.Forms.Label();
            this.ph_num_rece = new System.Windows.Forms.TextBox();
            this.ph_num_send = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.dont_send_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p_name_send
            // 
            this.p_name_send.AutoSize = true;
            this.p_name_send.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_name_send.Location = new System.Drawing.Point(607, 23);
            this.p_name_send.Name = "p_name_send";
            this.p_name_send.Size = new System.Drawing.Size(90, 33);
            this.p_name_send.TabIndex = 0;
            this.p_name_send.Text = "name";
            // 
            // t_name_send
            // 
            this.t_name_send.AutoSize = true;
            this.t_name_send.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_name_send.Location = new System.Drawing.Point(618, 96);
            this.t_name_send.Name = "t_name_send";
            this.t_name_send.Size = new System.Drawing.Size(57, 33);
            this.t_name_send.TabIndex = 1;
            this.t_name_send.Text = "TiT";
            // 
            // tran_no
            // 
            this.tran_no.Enabled = false;
            this.tran_no.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tran_no.Location = new System.Drawing.Point(973, 176);
            this.tran_no.Name = "tran_no";
            this.tran_no.Size = new System.Drawing.Size(187, 26);
            this.tran_no.TabIndex = 2;
            // 
            // tran_no_lablel
            // 
            this.tran_no_lablel.AutoSize = true;
            this.tran_no_lablel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tran_no_lablel.Location = new System.Drawing.Point(1176, 176);
            this.tran_no_lablel.Name = "tran_no_lablel";
            this.tran_no_lablel.Size = new System.Drawing.Size(111, 23);
            this.tran_no_lablel.TabIndex = 3;
            this.tran_no_lablel.Text = "رقم الحوالة";
            // 
            // send_name_label
            // 
            this.send_name_label.AutoSize = true;
            this.send_name_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_name_label.Location = new System.Drawing.Point(993, 294);
            this.send_name_label.Name = "send_name_label";
            this.send_name_label.Size = new System.Drawing.Size(129, 23);
            this.send_name_label.TabIndex = 5;
            this.send_name_label.Text = "اسم المرسل";
            // 
            // send_name
            // 
            this.send_name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_name.Location = new System.Drawing.Point(790, 291);
            this.send_name.Name = "send_name";
            this.send_name.Size = new System.Drawing.Size(187, 26);
            this.send_name.TabIndex = 4;
            this.send_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.send_name_KeyPress);
            // 
            // rece_name
            // 
            this.rece_name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rece_name.Location = new System.Drawing.Point(790, 357);
            this.rece_name.Name = "rece_name";
            this.rece_name.Size = new System.Drawing.Size(187, 26);
            this.rece_name.TabIndex = 4;
            // 
            // rece_name_label
            // 
            this.rece_name_label.AutoSize = true;
            this.rece_name_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rece_name_label.Location = new System.Drawing.Point(993, 360);
            this.rece_name_label.Name = "rece_name_label";
            this.rece_name_label.Size = new System.Drawing.Size(132, 23);
            this.rece_name_label.TabIndex = 5;
            this.rece_name_label.Text = "اسم المستلم";
            // 
            // mony_send_label
            // 
            this.mony_send_label.AutoSize = true;
            this.mony_send_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mony_send_label.Location = new System.Drawing.Point(990, 429);
            this.mony_send_label.Name = "mony_send_label";
            this.mony_send_label.Size = new System.Drawing.Size(62, 23);
            this.mony_send_label.TabIndex = 7;
            this.mony_send_label.Text = "المبلغ";
            // 
            // mony_send
            // 
            this.mony_send.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mony_send.Location = new System.Drawing.Point(787, 426);
            this.mony_send.Name = "mony_send";
            this.mony_send.Size = new System.Drawing.Size(187, 26);
            this.mony_send.TabIndex = 6;
            this.mony_send.TextChanged += new System.EventHandler(this.mony_send_TextChanged);
            this.mony_send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mony_send_KeyPress);
            // 
            // mony_dr_label
            // 
            this.mony_dr_label.AutoSize = true;
            this.mony_dr_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mony_dr_label.Location = new System.Drawing.Point(503, 429);
            this.mony_dr_label.Name = "mony_dr_label";
            this.mony_dr_label.Size = new System.Drawing.Size(132, 23);
            this.mony_dr_label.TabIndex = 13;
            this.mony_dr_label.Text = "رسوم الحوالة";
            // 
            // mony_dr
            // 
            this.mony_dr.Enabled = false;
            this.mony_dr.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mony_dr.Location = new System.Drawing.Point(300, 426);
            this.mony_dr.Name = "mony_dr";
            this.mony_dr.Size = new System.Drawing.Size(187, 26);
            this.mony_dr.TabIndex = 12;
            // 
            // ph_num_rece_label
            // 
            this.ph_num_rece_label.AutoSize = true;
            this.ph_num_rece_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph_num_rece_label.Location = new System.Drawing.Point(506, 360);
            this.ph_num_rece_label.Name = "ph_num_rece_label";
            this.ph_num_rece_label.Size = new System.Drawing.Size(118, 23);
            this.ph_num_rece_label.TabIndex = 10;
            this.ph_num_rece_label.Text = "رقم لمستلم";
            // 
            // ph_num_send_label
            // 
            this.ph_num_send_label.AutoSize = true;
            this.ph_num_send_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph_num_send_label.Location = new System.Drawing.Point(506, 294);
            this.ph_num_send_label.Name = "ph_num_send_label";
            this.ph_num_send_label.Size = new System.Drawing.Size(121, 23);
            this.ph_num_send_label.TabIndex = 11;
            this.ph_num_send_label.Text = "رقم المرسل";
            // 
            // ph_num_rece
            // 
            this.ph_num_rece.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph_num_rece.Location = new System.Drawing.Point(303, 357);
            this.ph_num_rece.Name = "ph_num_rece";
            this.ph_num_rece.Size = new System.Drawing.Size(187, 26);
            this.ph_num_rece.TabIndex = 8;
            this.ph_num_rece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ph_num_rece_KeyPress);
            // 
            // ph_num_send
            // 
            this.ph_num_send.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph_num_send.Location = new System.Drawing.Point(303, 291);
            this.ph_num_send.Name = "ph_num_send";
            this.ph_num_send.Size = new System.Drawing.Size(187, 26);
            this.ph_num_send.TabIndex = 9;
            this.ph_num_send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ph_num_send_KeyPress);
            // 
            // send_button
            // 
            this.send_button.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_button.Location = new System.Drawing.Point(844, 523);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(95, 39);
            this.send_button.TabIndex = 14;
            this.send_button.Text = "ارسال";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // dont_send_button
            // 
            this.dont_send_button.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dont_send_button.Location = new System.Drawing.Point(624, 523);
            this.dont_send_button.Name = "dont_send_button";
            this.dont_send_button.Size = new System.Drawing.Size(95, 39);
            this.dont_send_button.TabIndex = 15;
            this.dont_send_button.Text = "الغاء";
            this.dont_send_button.UseVisualStyleBackColor = true;
            this.dont_send_button.Click += new System.EventHandler(this.dont_send_button_Click);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(410, 523);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(95, 39);
            this.update_button.TabIndex = 16;
            this.update_button.Text = "تعديل";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(808, 167);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(95, 39);
            this.search_button.TabIndex = 17;
            this.search_button.Text = "بحث";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Visible = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // send_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dont_send_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.mony_dr_label);
            this.Controls.Add(this.mony_dr);
            this.Controls.Add(this.ph_num_rece_label);
            this.Controls.Add(this.ph_num_send_label);
            this.Controls.Add(this.ph_num_rece);
            this.Controls.Add(this.ph_num_send);
            this.Controls.Add(this.mony_send_label);
            this.Controls.Add(this.mony_send);
            this.Controls.Add(this.rece_name_label);
            this.Controls.Add(this.send_name_label);
            this.Controls.Add(this.rece_name);
            this.Controls.Add(this.send_name);
            this.Controls.Add(this.tran_no_lablel);
            this.Controls.Add(this.tran_no);
            this.Controls.Add(this.t_name_send);
            this.Controls.Add(this.p_name_send);
            this.Name = "send_form";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.send_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p_name_send;
        private System.Windows.Forms.Label t_name_send;
        private System.Windows.Forms.TextBox tran_no;
        private System.Windows.Forms.Label tran_no_lablel;
        private System.Windows.Forms.Label send_name_label;
        private System.Windows.Forms.TextBox send_name;
        private System.Windows.Forms.TextBox rece_name;
        private System.Windows.Forms.Label rece_name_label;
        private System.Windows.Forms.Label mony_send_label;
        private System.Windows.Forms.TextBox mony_send;
        private System.Windows.Forms.Label mony_dr_label;
        private System.Windows.Forms.TextBox mony_dr;
        private System.Windows.Forms.Label ph_num_rece_label;
        private System.Windows.Forms.Label ph_num_send_label;
        private System.Windows.Forms.TextBox ph_num_rece;
        private System.Windows.Forms.TextBox ph_num_send;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button dont_send_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button search_button;
    }
}