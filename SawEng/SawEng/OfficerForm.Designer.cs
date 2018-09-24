namespace SawEng
{
    partial class OfficerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficerForm));
            this.sawTabAccess = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAllAccess = new System.Windows.Forms.Button();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.listViewAccess = new System.Windows.Forms.ListView();
            this.columnHeaderIndexID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStoreName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComLatitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComSMSData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComSMSTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComInsertedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sawTabStore = new System.Windows.Forms.TabPage();
            this.buttonNeed = new System.Windows.Forms.Button();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonByID = new System.Windows.Forms.RadioButton();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listViewStore = new System.Windows.Forms.ListView();
            this.columnHeaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemQtyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemQtyMinValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemAddDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sawTabApplication = new System.Windows.Forms.TabControl();
            this.pictureBoxTopBar = new System.Windows.Forms.PictureBox();
            this.labelTop = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.sawTabAccess.SuspendLayout();
            this.sawTabStore.SuspendLayout();
            this.sawTabApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopBar)).BeginInit();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // sawTabAccess
            // 
            this.sawTabAccess.BackColor = System.Drawing.Color.White;
            this.sawTabAccess.Controls.Add(this.label1);
            this.sawTabAccess.Controls.Add(this.buttonAllAccess);
            this.sawTabAccess.Controls.Add(this.comboBoxMonth);
            this.sawTabAccess.Controls.Add(this.comboBoxYear);
            this.sawTabAccess.Controls.Add(this.listViewAccess);
            this.sawTabAccess.Location = new System.Drawing.Point(4, 22);
            this.sawTabAccess.Name = "sawTabAccess";
            this.sawTabAccess.Padding = new System.Windows.Forms.Padding(3);
            this.sawTabAccess.Size = new System.Drawing.Size(776, 424);
            this.sawTabAccess.TabIndex = 1;
            this.sawTabAccess.Text = "Access : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "YEAR  |  MONTH";
            // 
            // buttonAllAccess
            // 
            this.buttonAllAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAllAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllAccess.Location = new System.Drawing.Point(637, 9);
            this.buttonAllAccess.Name = "buttonAllAccess";
            this.buttonAllAccess.Size = new System.Drawing.Size(131, 24);
            this.buttonAllAccess.TabIndex = 55;
            this.buttonAllAccess.Text = "REFRESH ALL";
            this.buttonAllAccess.UseVisualStyleBackColor = true;
            this.buttonAllAccess.Click += new System.EventHandler(this.buttonAllAccess_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(151, 12);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(68, 21);
            this.comboBoxMonth.TabIndex = 49;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBoxYear.Location = new System.Drawing.Point(8, 12);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(137, 21);
            this.comboBoxYear.TabIndex = 48;
            // 
            // listViewAccess
            // 
            this.listViewAccess.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAccess.AutoArrange = false;
            this.listViewAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewAccess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndexID,
            this.columnHeaderStoreName,
            this.columnHeaderDescription,
            this.columnHeaderDate});
            this.listViewAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAccess.FullRowSelect = true;
            this.listViewAccess.GridLines = true;
            this.listViewAccess.Location = new System.Drawing.Point(3, 39);
            this.listViewAccess.MultiSelect = false;
            this.listViewAccess.Name = "listViewAccess";
            this.listViewAccess.Size = new System.Drawing.Size(760, 376);
            this.listViewAccess.TabIndex = 47;
            this.listViewAccess.UseCompatibleStateImageBehavior = false;
            this.listViewAccess.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderIndexID
            // 
            this.columnHeaderIndexID.Text = "ID";
            this.columnHeaderIndexID.Width = 0;
            // 
            // columnHeaderStoreName
            // 
            this.columnHeaderStoreName.Text = "Store Name";
            this.columnHeaderStoreName.Width = 186;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 557;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 257;
            // 
            // columnHeaderComLatitude
            // 
            this.columnHeaderComLatitude.Text = "Customer Latitude";
            this.columnHeaderComLatitude.Width = 121;
            // 
            // columnHeaderComTitle
            // 
            this.columnHeaderComTitle.Text = "Complaint Title";
            this.columnHeaderComTitle.Width = 140;
            // 
            // columnHeaderComSMSData
            // 
            this.columnHeaderComSMSData.Text = "Complaint SMS Data";
            this.columnHeaderComSMSData.Width = 252;
            // 
            // columnHeaderComSMSTime
            // 
            this.columnHeaderComSMSTime.Text = "Customer SMS Time";
            this.columnHeaderComSMSTime.Width = 145;
            // 
            // columnHeaderComInsertedDate
            // 
            this.columnHeaderComInsertedDate.Text = "Inserted Date";
            this.columnHeaderComInsertedDate.Width = 173;
            // 
            // sawTabStore
            // 
            this.sawTabStore.BackColor = System.Drawing.Color.White;
            this.sawTabStore.Controls.Add(this.buttonNeed);
            this.sawTabStore.Controls.Add(this.radioButtonName);
            this.sawTabStore.Controls.Add(this.radioButtonByID);
            this.sawTabStore.Controls.Add(this.buttonRefresh);
            this.sawTabStore.Controls.Add(this.textBoxSearch);
            this.sawTabStore.Controls.Add(this.listViewStore);
            this.sawTabStore.Location = new System.Drawing.Point(4, 22);
            this.sawTabStore.Name = "sawTabStore";
            this.sawTabStore.Padding = new System.Windows.Forms.Padding(3);
            this.sawTabStore.Size = new System.Drawing.Size(776, 424);
            this.sawTabStore.TabIndex = 0;
            this.sawTabStore.Text = "Store Name : ";
            // 
            // buttonNeed
            // 
            this.buttonNeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNeed.BackColor = System.Drawing.Color.Red;
            this.buttonNeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeed.ForeColor = System.Drawing.Color.White;
            this.buttonNeed.Location = new System.Drawing.Point(500, 9);
            this.buttonNeed.Name = "buttonNeed";
            this.buttonNeed.Size = new System.Drawing.Size(131, 24);
            this.buttonNeed.TabIndex = 49;
            this.buttonNeed.Text = "LIMITED";
            this.buttonNeed.UseVisualStyleBackColor = false;
            this.buttonNeed.Visible = false;
            this.buttonNeed.Click += new System.EventHandler(this.buttonNeed_Click);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(316, 14);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(91, 17);
            this.radioButtonName.TabIndex = 54;
            this.radioButtonName.Text = "By Item Name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // radioButtonByID
            // 
            this.radioButtonByID.AutoSize = true;
            this.radioButtonByID.Checked = true;
            this.radioButtonByID.Location = new System.Drawing.Point(231, 14);
            this.radioButtonByID.Name = "radioButtonByID";
            this.radioButtonByID.Size = new System.Drawing.Size(74, 17);
            this.radioButtonByID.TabIndex = 53;
            this.radioButtonByID.TabStop = true;
            this.radioButtonByID.Text = "By Item ID";
            this.radioButtonByID.UseVisualStyleBackColor = true;
            this.radioButtonByID.CheckedChanged += new System.EventHandler(this.radioButtonByID_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(637, 9);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(131, 24);
            this.buttonRefresh.TabIndex = 52;
            this.buttonRefresh.Text = "REFRESH ALL";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(8, 12);
            this.textBoxSearch.MaxLength = 150;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(207, 22);
            this.textBoxSearch.TabIndex = 49;
            this.textBoxSearch.Text = "saw";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // listViewStore
            // 
            this.listViewStore.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndex,
            this.columnHeaderItemID,
            this.columnHeaderItemName,
            this.columnHeaderItemQty,
            this.columnHeaderItemQtyType,
            this.columnHeaderItemQtyMinValue,
            this.columnHeaderItemDescription,
            this.columnHeaderItemAddDate});
            this.listViewStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewStore.FullRowSelect = true;
            this.listViewStore.GridLines = true;
            this.listViewStore.Location = new System.Drawing.Point(8, 40);
            this.listViewStore.MultiSelect = false;
            this.listViewStore.Name = "listViewStore";
            this.listViewStore.Size = new System.Drawing.Size(760, 376);
            this.listViewStore.TabIndex = 39;
            this.listViewStore.UseCompatibleStateImageBehavior = false;
            this.listViewStore.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderIndex
            // 
            this.columnHeaderIndex.Text = "ID";
            this.columnHeaderIndex.Width = 25;
            // 
            // columnHeaderItemID
            // 
            this.columnHeaderItemID.Text = "ItemID";
            this.columnHeaderItemID.Width = 92;
            // 
            // columnHeaderItemName
            // 
            this.columnHeaderItemName.Text = "Item Name";
            this.columnHeaderItemName.Width = 249;
            // 
            // columnHeaderItemQty
            // 
            this.columnHeaderItemQty.Text = "Item Qty";
            this.columnHeaderItemQty.Width = 110;
            // 
            // columnHeaderItemQtyType
            // 
            this.columnHeaderItemQtyType.Text = "";
            this.columnHeaderItemQtyType.Width = 112;
            // 
            // columnHeaderItemQtyMinValue
            // 
            this.columnHeaderItemQtyMinValue.Text = "Qty Minimum Value";
            this.columnHeaderItemQtyMinValue.Width = 132;
            // 
            // columnHeaderItemDescription
            // 
            this.columnHeaderItemDescription.Text = "Description";
            this.columnHeaderItemDescription.Width = 427;
            // 
            // columnHeaderItemAddDate
            // 
            this.columnHeaderItemAddDate.Text = "Inserterd Date";
            this.columnHeaderItemAddDate.Width = 127;
            // 
            // sawTabApplication
            // 
            this.sawTabApplication.Controls.Add(this.sawTabStore);
            this.sawTabApplication.Controls.Add(this.sawTabAccess);
            this.sawTabApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sawTabApplication.Location = new System.Drawing.Point(0, 112);
            this.sawTabApplication.Name = "sawTabApplication";
            this.sawTabApplication.SelectedIndex = 0;
            this.sawTabApplication.Size = new System.Drawing.Size(784, 450);
            this.sawTabApplication.TabIndex = 2;
            // 
            // pictureBoxTopBar
            // 
            this.pictureBoxTopBar.BackColor = System.Drawing.Color.White;
            this.pictureBoxTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxTopBar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopBar.Image")));
            this.pictureBoxTopBar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTopBar.Name = "pictureBoxTopBar";
            this.pictureBoxTopBar.Size = new System.Drawing.Size(784, 112);
            this.pictureBoxTopBar.TabIndex = 42;
            this.pictureBoxTopBar.TabStop = false;
            // 
            // labelTop
            // 
            this.labelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(467, 38);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(89, 33);
            this.labelTop.TabIndex = 43;
            this.labelTop.Text = "Store";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(701, 32);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(71, 52);
            this.buttonSettings.TabIndex = 57;
            this.buttonSettings.Text = "ABOUT";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAbout.BackColor = System.Drawing.Color.White;
            this.panelAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAbout.Controls.Add(this.buttonClose);
            this.panelAbout.Controls.Add(this.pictureBox3);
            this.panelAbout.Controls.Add(this.label4);
            this.panelAbout.Controls.Add(this.label3);
            this.panelAbout.Controls.Add(this.pictureBox2);
            this.panelAbout.Controls.Add(this.pictureBox1);
            this.panelAbout.Controls.Add(this.label2);
            this.panelAbout.Location = new System.Drawing.Point(117, 198);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(576, 269);
            this.panelAbout.TabIndex = 57;
            this.panelAbout.Visible = false;
            this.panelAbout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAbout_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Institute of Engineering Technology, \r\nKatunayake";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(435, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(430, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eweo Organisation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 52);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bandara  A.M.A.I.\r\n\r\nContact  : +94 77 872 2931\r\nEmail : eweoorg@gmail.com";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(231, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 115);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(466, 218);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(71, 27);
            this.buttonClose.TabIndex = 58;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // OfficerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.sawTabApplication);
            this.Controls.Add(this.pictureBoxTopBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "OfficerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saw Engineering - Officer Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OfficerForm_FormClosing);
            this.sawTabAccess.ResumeLayout(false);
            this.sawTabAccess.PerformLayout();
            this.sawTabStore.ResumeLayout(false);
            this.sawTabStore.PerformLayout();
            this.sawTabApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopBar)).EndInit();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage sawTabAccess;
        private System.Windows.Forms.ListView listViewAccess;
        private System.Windows.Forms.ColumnHeader columnHeaderIndexID;
        private System.Windows.Forms.ColumnHeader columnHeaderStoreName;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderComLatitude;
        private System.Windows.Forms.ColumnHeader columnHeaderComTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderComSMSData;
        private System.Windows.Forms.ColumnHeader columnHeaderComSMSTime;
        private System.Windows.Forms.ColumnHeader columnHeaderComInsertedDate;
        private System.Windows.Forms.TabPage sawTabStore;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonByID;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListView listViewStore;
        private System.Windows.Forms.ColumnHeader columnHeaderIndex;
        private System.Windows.Forms.ColumnHeader columnHeaderItemID;
        private System.Windows.Forms.ColumnHeader columnHeaderItemName;
        private System.Windows.Forms.ColumnHeader columnHeaderItemQty;
        private System.Windows.Forms.ColumnHeader columnHeaderItemQtyType;
        private System.Windows.Forms.ColumnHeader columnHeaderItemQtyMinValue;
        private System.Windows.Forms.ColumnHeader columnHeaderItemDescription;
        private System.Windows.Forms.TabControl sawTabApplication;
        private System.Windows.Forms.PictureBox pictureBoxTopBar;
        private System.Windows.Forms.Button buttonAllAccess;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.ColumnHeader columnHeaderItemAddDate;
        private System.Windows.Forms.Button buttonNeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonClose;

    }
}