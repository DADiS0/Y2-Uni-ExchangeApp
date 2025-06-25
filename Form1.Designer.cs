namespace project_A_F
{
    partial class sine_form
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
            this.p_name_sine = new System.Windows.Forms.Label();
            this.t_name_sine = new System.Windows.Forms.Label();
            this.user_in = new System.Windows.Forms.TextBox();
            this.pass_in = new System.Windows.Forms.TextBox();
            this.p_name_send = new System.Windows.Forms.Button();
            this.user_lable = new System.Windows.Forms.Label();
            this.pass_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p_name_sine
            // 
            this.p_name_sine.AutoSize = true;
            this.p_name_sine.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_name_sine.Location = new System.Drawing.Point(201, 50);
            this.p_name_sine.Name = "p_name_sine";
            this.p_name_sine.Size = new System.Drawing.Size(94, 33);
            this.p_name_sine.TabIndex = 0;
            this.p_name_sine.Text = "Name";
            // 
            // t_name_sine
            // 
            this.t_name_sine.AutoSize = true;
            this.t_name_sine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_name_sine.Location = new System.Drawing.Point(224, 105);
            this.t_name_sine.Name = "t_name_sine";
            this.t_name_sine.Size = new System.Drawing.Size(32, 23);
            this.t_name_sine.TabIndex = 1;
            this.t_name_sine.Text = "tit";
            // 
            // user_in
            // 
            this.user_in.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_in.Location = new System.Drawing.Point(171, 141);
            this.user_in.Name = "user_in";
            this.user_in.Size = new System.Drawing.Size(157, 26);
            this.user_in.TabIndex = 2;
            // 
            // pass_in
            // 
            this.pass_in.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_in.Location = new System.Drawing.Point(171, 190);
            this.pass_in.Name = "pass_in";
            this.pass_in.Size = new System.Drawing.Size(157, 26);
            this.pass_in.TabIndex = 3;
            // 
            // p_name_send
            // 
            this.p_name_send.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_name_send.Location = new System.Drawing.Point(207, 245);
            this.p_name_send.Name = "p_name_send";
            this.p_name_send.Size = new System.Drawing.Size(75, 23);
            this.p_name_send.TabIndex = 4;
            this.p_name_send.Text = "تسجيل";
            this.p_name_send.UseVisualStyleBackColor = true;
            this.p_name_send.Click += new System.EventHandler(this.p_name_send_Click);
            // 
            // user_lable
            // 
            this.user_lable.AutoSize = true;
            this.user_lable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lable.Location = new System.Drawing.Point(365, 148);
            this.user_lable.Name = "user_lable";
            this.user_lable.Size = new System.Drawing.Size(124, 19);
            this.user_lable.TabIndex = 5;
            this.user_lable.Text = "اسم المستخدم";
            // 
            // pass_lable
            // 
            this.pass_lable.AutoSize = true;
            this.pass_lable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lable.Location = new System.Drawing.Point(379, 197);
            this.pass_lable.Name = "pass_lable";
            this.pass_lable.Size = new System.Drawing.Size(86, 19);
            this.pass_lable.TabIndex = 6;
            this.pass_lable.Text = "كلمة السر";
            // 
            // sine_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 280);
            this.Controls.Add(this.pass_lable);
            this.Controls.Add(this.user_lable);
            this.Controls.Add(this.p_name_send);
            this.Controls.Add(this.pass_in);
            this.Controls.Add(this.user_in);
            this.Controls.Add(this.t_name_sine);
            this.Controls.Add(this.p_name_sine);
            this.Name = "sine_form";
            this.Text = "Sine Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p_name_sine;
        private System.Windows.Forms.Label t_name_sine;
        private System.Windows.Forms.TextBox user_in;
        private System.Windows.Forms.TextBox pass_in;
        private System.Windows.Forms.Button p_name_send;
        private System.Windows.Forms.Label user_lable;
        private System.Windows.Forms.Label pass_lable;
    }
}

