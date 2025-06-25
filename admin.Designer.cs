namespace project_A_F
{
    partial class admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.users = new System.Windows.Forms.TabPage();
            this.doo = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.access = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.access_user = new System.Windows.Forms.ComboBox();
            this.accessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_A_FDataSet = new project_A_F.project_A_FDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.user_stat = new System.Windows.Forms.ComboBox();
            this.lab2 = new System.Windows.Forms.Label();
            this.user_passTXT = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.user_nameTXT = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.currency = new System.Windows.Forms.TabPage();
            this.doo2 = new System.Windows.Forms.Label();
            this.cancel2 = new System.Windows.Forms.Button();
            this.update2 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbuy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.csell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.TextBox();
            this.currency_DGV = new System.Windows.Forms.DataGridView();
            this.currency_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new project_A_F.project_A_FDataSetTableAdapters.usersTableAdapter();
            this.accessTableAdapter = new project_A_F.project_A_FDataSetTableAdapters.accessTableAdapter();
            this.project_A_FDataSet6 = new project_A_F.project_A_FDataSet6();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyTableAdapter = new project_A_F.project_A_FDataSet6TableAdapters.currencyTableAdapter();
            this.tableAdapterManager = new project_A_F.project_A_FDataSet6TableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            this.users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_A_FDataSet)).BeginInit();
            this.currency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currency_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_A_FDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.users);
            this.tabControl1.Controls.Add(this.currency);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1354, 729);
            this.tabControl1.TabIndex = 1;
            // 
            // users
            // 
            this.users.AutoScroll = true;
            this.users.Controls.Add(this.doo);
            this.users.Controls.Add(this.cancel);
            this.users.Controls.Add(this.usersDGV);
            this.users.Controls.Add(this.update);
            this.users.Controls.Add(this.label2);
            this.users.Controls.Add(this.access_user);
            this.users.Controls.Add(this.label1);
            this.users.Controls.Add(this.user_stat);
            this.users.Controls.Add(this.lab2);
            this.users.Controls.Add(this.user_passTXT);
            this.users.Controls.Add(this.lab);
            this.users.Controls.Add(this.user_nameTXT);
            this.users.Controls.Add(this.add);
            this.users.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.Location = new System.Drawing.Point(4, 22);
            this.users.Name = "users";
            this.users.Padding = new System.Windows.Forms.Padding(3);
            this.users.Size = new System.Drawing.Size(1346, 703);
            this.users.TabIndex = 1;
            this.users.Text = "ألمستخدمين";
            this.users.UseVisualStyleBackColor = true;
            // 
            // doo
            // 
            this.doo.AutoSize = true;
            this.doo.BackColor = System.Drawing.Color.DarkGray;
            this.doo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doo.Location = new System.Drawing.Point(12, 179);
            this.doo.Name = "doo";
            this.doo.Size = new System.Drawing.Size(139, 33);
            this.doo.TabIndex = 13;
            this.doo.Text = "استعراض";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(826, 552);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(114, 46);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "الغاء";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // usersDGV
            // 
            this.usersDGV.AllowUserToAddRows = false;
            this.usersDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.NullValue = null;
            this.usersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.usersDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.usersDGV.ColumnHeadersHeight = 30;
            this.usersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.pass,
            this.date,
            this.stat,
            this.access});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDGV.DefaultCellStyle = dataGridViewCellStyle14;
            this.usersDGV.Location = new System.Drawing.Point(18, 314);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.ReadOnly = true;
            this.usersDGV.Size = new System.Drawing.Size(765, 284);
            this.usersDGV.TabIndex = 11;
            this.usersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDGV_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "رقم المستخدم";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "اسم المستخدم";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pass.HeaderText = "كلمةالمرور";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "تاريخ الانشاء";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // stat
            // 
            this.stat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stat.HeaderText = "حالة المستخدم";
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            // 
            // access
            // 
            this.access.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.access.HeaderText = "الصلاحيه";
            this.access.Name = "access";
            this.access.ReadOnly = true;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(1021, 552);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(114, 46);
            this.update.TabIndex = 10;
            this.update.Text = "تعديل";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1166, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "الصلاحية";
            // 
            // access_user
            // 
            this.access_user.DataSource = this.accessBindingSource;
            this.access_user.DisplayMember = "access_name";
            this.access_user.Enabled = false;
            this.access_user.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.access_user.FormattingEnabled = true;
            this.access_user.Location = new System.Drawing.Point(1092, 481);
            this.access_user.Name = "access_user";
            this.access_user.Size = new System.Drawing.Size(236, 31);
            this.access_user.TabIndex = 8;
            this.access_user.ValueMember = "access_id";
            // 
            // accessBindingSource
            // 
            this.accessBindingSource.DataMember = "access";
            this.accessBindingSource.DataSource = this.project_A_FDataSet;
            // 
            // project_A_FDataSet
            // 
            this.project_A_FDataSet.DataSetName = "project_A_FDataSet";
            this.project_A_FDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1180, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "الحالة";
            // 
            // user_stat
            // 
            this.user_stat.Enabled = false;
            this.user_stat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_stat.FormattingEnabled = true;
            this.user_stat.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.user_stat.Location = new System.Drawing.Point(1092, 343);
            this.user_stat.Name = "user_stat";
            this.user_stat.Size = new System.Drawing.Size(236, 31);
            this.user_stat.TabIndex = 6;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.Location = new System.Drawing.Point(887, 455);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(114, 23);
            this.lab2.TabIndex = 5;
            this.lab2.Text = "كلمة المرور";
            // 
            // user_passTXT
            // 
            this.user_passTXT.Enabled = false;
            this.user_passTXT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_passTXT.Location = new System.Drawing.Point(826, 481);
            this.user_passTXT.Name = "user_passTXT";
            this.user_passTXT.Size = new System.Drawing.Size(236, 30);
            this.user_passTXT.TabIndex = 4;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(870, 318);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(149, 23);
            this.lab.TabIndex = 3;
            this.lab.Text = "اسم المستخدم";
            // 
            // user_nameTXT
            // 
            this.user_nameTXT.Enabled = false;
            this.user_nameTXT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_nameTXT.Location = new System.Drawing.Point(826, 344);
            this.user_nameTXT.Name = "user_nameTXT";
            this.user_nameTXT.Size = new System.Drawing.Size(236, 30);
            this.user_nameTXT.TabIndex = 2;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(1214, 552);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 46);
            this.add.TabIndex = 1;
            this.add.Text = "اضافه";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // currency
            // 
            this.currency.Controls.Add(this.doo2);
            this.currency.Controls.Add(this.cancel2);
            this.currency.Controls.Add(this.update2);
            this.currency.Controls.Add(this.add2);
            this.currency.Controls.Add(this.label5);
            this.currency.Controls.Add(this.cbuy);
            this.currency.Controls.Add(this.label3);
            this.currency.Controls.Add(this.csell);
            this.currency.Controls.Add(this.label4);
            this.currency.Controls.Add(this.cname);
            this.currency.Controls.Add(this.currency_DGV);
            this.currency.Location = new System.Drawing.Point(4, 22);
            this.currency.Name = "currency";
            this.currency.Padding = new System.Windows.Forms.Padding(3);
            this.currency.Size = new System.Drawing.Size(1346, 703);
            this.currency.TabIndex = 0;
            this.currency.Text = "العملات";
            this.currency.UseVisualStyleBackColor = true;
            this.currency.Click += new System.EventHandler(this.currency_Click);
            // 
            // doo2
            // 
            this.doo2.AutoSize = true;
            this.doo2.BackColor = System.Drawing.Color.DarkGray;
            this.doo2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doo2.Location = new System.Drawing.Point(8, 174);
            this.doo2.Name = "doo2";
            this.doo2.Size = new System.Drawing.Size(139, 33);
            this.doo2.TabIndex = 16;
            this.doo2.Text = "استعراض";
            // 
            // cancel2
            // 
            this.cancel2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel2.Location = new System.Drawing.Point(975, 533);
            this.cancel2.Name = "cancel2";
            this.cancel2.Size = new System.Drawing.Size(114, 46);
            this.cancel2.TabIndex = 15;
            this.cancel2.Text = "الغاء";
            this.cancel2.UseVisualStyleBackColor = true;
            this.cancel2.Click += new System.EventHandler(this.cancel2_Click);
            // 
            // update2
            // 
            this.update2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update2.Location = new System.Drawing.Point(975, 423);
            this.update2.Name = "update2";
            this.update2.Size = new System.Drawing.Size(114, 46);
            this.update2.TabIndex = 14;
            this.update2.Text = "تعديل";
            this.update2.UseVisualStyleBackColor = true;
            this.update2.Click += new System.EventHandler(this.update2_Click);
            // 
            // add2
            // 
            this.add2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add2.Location = new System.Drawing.Point(975, 304);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(114, 46);
            this.add2.TabIndex = 13;
            this.add2.Text = "اضافه";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(782, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "شراء";
            // 
            // cbuy
            // 
            this.cbuy.Enabled = false;
            this.cbuy.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbuy.Location = new System.Drawing.Point(691, 549);
            this.cbuy.Name = "cbuy";
            this.cbuy.Size = new System.Drawing.Size(236, 30);
            this.cbuy.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(791, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "بيع";
            // 
            // csell
            // 
            this.csell.Enabled = false;
            this.csell.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csell.Location = new System.Drawing.Point(691, 439);
            this.csell.Name = "csell";
            this.csell.Size = new System.Drawing.Size(236, 30);
            this.csell.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "العملة";
            // 
            // cname
            // 
            this.cname.Enabled = false;
            this.cname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.Location = new System.Drawing.Point(691, 330);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(236, 30);
            this.cname.TabIndex = 6;
            // 
            // currency_DGV
            // 
            this.currency_DGV.AllowUserToAddRows = false;
            this.currency_DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currency_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.currency_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currency_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currency_id,
            this.currency_name,
            this.currency_sell,
            this.currency_buy});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currency_DGV.DefaultCellStyle = dataGridViewCellStyle10;
            this.currency_DGV.Location = new System.Drawing.Point(227, 304);
            this.currency_DGV.Name = "currency_DGV";
            this.currency_DGV.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.currency_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.currency_DGV.Size = new System.Drawing.Size(446, 275);
            this.currency_DGV.TabIndex = 0;
            this.currency_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currency_DGV_CellClick);
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
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.project_A_FDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // accessTableAdapter
            // 
            this.accessTableAdapter.ClearBeforeFill = true;
            // 
            // project_A_FDataSet6
            // 
            this.project_A_FDataSet6.DataSetName = "project_A_FDataSet6";
            this.project_A_FDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "currency";
            this.currencyBindingSource.DataSource = this.project_A_FDataSet6;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accessTableAdapter = null;
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.currencyTableAdapter = this.currencyTableAdapter;
            this.tableAdapterManager.operationTableAdapter = null;
            this.tableAdapterManager.transfersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project_A_F.project_A_FDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.tabControl1);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.users.ResumeLayout(false);
            this.users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_A_FDataSet)).EndInit();
            this.currency.ResumeLayout(false);
            this.currency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currency_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_A_FDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage users;
        private System.Windows.Forms.TabPage currency;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox user_nameTXT;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox user_passTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox access_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox user_stat;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat;
        private System.Windows.Forms.DataGridViewTextBoxColumn access;
        private project_A_FDataSet project_A_FDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private project_A_FDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource accessBindingSource;
        private project_A_FDataSetTableAdapters.accessTableAdapter accessTableAdapter;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label doo;
        private System.Windows.Forms.DataGridView currency_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_buy;
        private project_A_FDataSet6 project_A_FDataSet6;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private project_A_FDataSet6TableAdapters.currencyTableAdapter currencyTableAdapter;
        private project_A_FDataSet6TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox csell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cbuy;
        private System.Windows.Forms.Button cancel2;
        private System.Windows.Forms.Button update2;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.Label doo2;
    }
}