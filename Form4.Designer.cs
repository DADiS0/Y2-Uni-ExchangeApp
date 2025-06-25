namespace project_A_F
{
    partial class exchange_form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.p_name_exchange_label = new System.Windows.Forms.Label();
            this.t_name_exchange_label = new System.Windows.Forms.Label();
            this.go_receive_button = new System.Windows.Forms.Button();
            this.go_send_button = new System.Windows.Forms.Button();
            this.comboBox_from = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_A_FDataSet3 = new project_A_F.project_A_FDataSet6();
            this.currencyTableAdapter = new project_A_F.project_A_FDataSet6TableAdapters.currencyTableAdapter();
            this.comboBox_to = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.radioBuy = new System.Windows.Forms.RadioButton();
            this.radioSell = new System.Windows.Forms.RadioButton();
            this.currency_DGV = new System.Windows.Forms.DataGridView();
            this.currency_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_A_FDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currency_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // p_name_exchange_label
            // 
            this.p_name_exchange_label.AutoSize = true;
            this.p_name_exchange_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_name_exchange_label.Location = new System.Drawing.Point(569, 41);
            this.p_name_exchange_label.Name = "p_name_exchange_label";
            this.p_name_exchange_label.Size = new System.Drawing.Size(72, 25);
            this.p_name_exchange_label.TabIndex = 0;
            this.p_name_exchange_label.Text = "Name";
            // 
            // t_name_exchange_label
            // 
            this.t_name_exchange_label.AutoSize = true;
            this.t_name_exchange_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_name_exchange_label.Location = new System.Drawing.Point(569, 96);
            this.t_name_exchange_label.Name = "t_name_exchange_label";
            this.t_name_exchange_label.Size = new System.Drawing.Size(46, 25);
            this.t_name_exchange_label.TabIndex = 1;
            this.t_name_exchange_label.Text = "TIT";
            // 
            // go_receive_button
            // 
            this.go_receive_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_receive_button.Location = new System.Drawing.Point(686, 355);
            this.go_receive_button.Name = "go_receive_button";
            this.go_receive_button.Size = new System.Drawing.Size(152, 46);
            this.go_receive_button.TabIndex = 2;
            this.go_receive_button.Text = "استلام الحوالة";
            this.go_receive_button.UseVisualStyleBackColor = true;
            this.go_receive_button.Visible = false;
            this.go_receive_button.Click += new System.EventHandler(this.go_receive_button_Click);
            // 
            // go_send_button
            // 
            this.go_send_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_send_button.Location = new System.Drawing.Point(1099, 355);
            this.go_send_button.Name = "go_send_button";
            this.go_send_button.Size = new System.Drawing.Size(152, 46);
            this.go_send_button.TabIndex = 3;
            this.go_send_button.Text = "ارسال الحوالة";
            this.go_send_button.UseVisualStyleBackColor = true;
            this.go_send_button.Visible = false;
            this.go_send_button.Click += new System.EventHandler(this.go_send_button_Click);
            // 
            // comboBox_from
            // 
            this.comboBox_from.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_from.FormattingEnabled = true;
            this.comboBox_from.Location = new System.Drawing.Point(1099, 527);
            this.comboBox_from.Name = "comboBox_from";
            this.comboBox_from.Size = new System.Drawing.Size(152, 27);
            this.comboBox_from.TabIndex = 4;
            this.comboBox_from.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "currency";
            this.currencyBindingSource.DataSource = this.project_A_FDataSet3;
            // 
            // project_A_FDataSet3
            // 
            this.project_A_FDataSet3.DataSetName = "project_A_FDataSet3";
            this.project_A_FDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_to
            // 
            this.comboBox_to.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_to.FormattingEnabled = true;
            this.comboBox_to.Location = new System.Drawing.Point(686, 527);
            this.comboBox_to.Name = "comboBox_to";
            this.comboBox_to.Size = new System.Drawing.Size(152, 27);
            this.comboBox_to.TabIndex = 5;
            this.comboBox_to.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // currencyBindingSource1
            // 
            this.currencyBindingSource1.DataMember = "currency";
            this.currencyBindingSource1.DataSource = this.project_A_FDataSet3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1158, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "من";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(742, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "إلى";
            // 
            // txt_from
            // 
            this.txt_from.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txt_from.Location = new System.Drawing.Point(1099, 603);
            this.txt_from.Multiline = true;
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(152, 27);
            this.txt_from.TabIndex = 8;
            this.txt_from.TextChanged += new System.EventHandler(this.txt_from_TextChanged);
            this.txt_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_from_KeyPress);
            // 
            // txt_to
            // 
            this.txt_to.BackColor = System.Drawing.Color.SkyBlue;
            this.txt_to.Enabled = false;
            this.txt_to.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txt_to.Location = new System.Drawing.Point(686, 603);
            this.txt_to.Multiline = true;
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(152, 27);
            this.txt_to.TabIndex = 9;
            // 
            // radioBuy
            // 
            this.radioBuy.AutoSize = true;
            this.radioBuy.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBuy.Location = new System.Drawing.Point(735, 427);
            this.radioBuy.Name = "radioBuy";
            this.radioBuy.Size = new System.Drawing.Size(64, 33);
            this.radioBuy.TabIndex = 10;
            this.radioBuy.TabStop = true;
            this.radioBuy.Text = "بيع";
            this.radioBuy.UseVisualStyleBackColor = true;
            this.radioBuy.CheckedChanged += new System.EventHandler(this.radioBuy_CheckedChanged);
            // 
            // radioSell
            // 
            this.radioSell.AutoSize = true;
            this.radioSell.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSell.Location = new System.Drawing.Point(1132, 427);
            this.radioSell.Name = "radioSell";
            this.radioSell.Size = new System.Drawing.Size(86, 33);
            this.radioSell.TabIndex = 11;
            this.radioSell.TabStop = true;
            this.radioSell.Text = "شراء";
            this.radioSell.UseVisualStyleBackColor = true;
            this.radioSell.CheckedChanged += new System.EventHandler(this.radioSell_CheckedChanged);
            // 
            // currency_DGV
            // 
            this.currency_DGV.AllowUserToAddRows = false;
            this.currency_DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currency_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.currency_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currency_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currency_id,
            this.currency_name,
            this.currency_sell,
            this.currency_buy});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currency_DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.currency_DGV.Location = new System.Drawing.Point(80, 355);
            this.currency_DGV.Name = "currency_DGV";
            this.currency_DGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currency_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.currency_DGV.Size = new System.Drawing.Size(446, 275);
            this.currency_DGV.TabIndex = 12;
            // 
            // currency_id
            // 
            this.currency_id.HeaderText = "currency_id";
            this.currency_id.Name = "currency_id";
            this.currency_id.ReadOnly = true;
            this.currency_id.Visible = false;
            // 
            // currency_name
            // 
            this.currency_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currency_name.HeaderText = "العملة";
            this.currency_name.Name = "currency_name";
            this.currency_name.ReadOnly = true;
            // 
            // currency_sell
            // 
            this.currency_sell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currency_sell.HeaderText = "بيع";
            this.currency_sell.Name = "currency_sell";
            this.currency_sell.ReadOnly = true;
            // 
            // currency_buy
            // 
            this.currency_buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currency_buy.HeaderText = "شراء";
            this.currency_buy.Name = "currency_buy";
            this.currency_buy.ReadOnly = true;
            // 
            // exchange_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.t_name_exchange_label);
            this.Controls.Add(this.p_name_exchange_label);
            this.Controls.Add(this.currency_DGV);
            this.Controls.Add(this.radioSell);
            this.Controls.Add(this.radioBuy);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_to);
            this.Controls.Add(this.comboBox_from);
            this.Controls.Add(this.go_send_button);
            this.Controls.Add(this.go_receive_button);
            this.Name = "exchange_form";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.exchange_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_A_FDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currency_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p_name_exchange_label;
        private System.Windows.Forms.Label t_name_exchange_label;
        private System.Windows.Forms.Button go_receive_button;
        private System.Windows.Forms.Button go_send_button;
        private System.Windows.Forms.ComboBox comboBox_from;
        private project_A_FDataSet6 project_A_FDataSet3;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private project_A_FDataSet6TableAdapters.currencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_to;
        private System.Windows.Forms.BindingSource currencyBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.RadioButton radioBuy;
        private System.Windows.Forms.RadioButton radioSell;
        private System.Windows.Forms.DataGridView currency_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_buy;
    }
}