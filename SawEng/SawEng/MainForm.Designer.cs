namespace SawEng
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listViewDialogSaw = new System.Windows.Forms.ListView();
            this.columnHeaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSawID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemDes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxTopBar = new System.Windows.Forms.PictureBox();
            this.buttonNewItem = new System.Windows.Forms.Button();
            this.buttonViewItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelTop = new System.Windows.Forms.Label();
            this.buttonNeed = new System.Windows.Forms.Button();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopBar)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDialogSaw
            // 
            this.listViewDialogSaw.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewDialogSaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDialogSaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDialogSaw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndex,
            this.columnHeaderSawID,
            this.columnHeaderItemName,
            this.columnHeaderItemQty,
            this.columnHeaderItemType,
            this.columnHeaderItemDes});
            this.listViewDialogSaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDialogSaw.FullRowSelect = true;
            this.listViewDialogSaw.GridLines = true;
            this.listViewDialogSaw.Location = new System.Drawing.Point(139, 146);
            this.listViewDialogSaw.MultiSelect = false;
            this.listViewDialogSaw.Name = "listViewDialogSaw";
            this.listViewDialogSaw.Size = new System.Drawing.Size(633, 404);
            this.listViewDialogSaw.TabIndex = 40;
            this.listViewDialogSaw.UseCompatibleStateImageBehavior = false;
            this.listViewDialogSaw.View = System.Windows.Forms.View.Details;
            this.listViewDialogSaw.ItemActivate += new System.EventHandler(this.listViewDialogSaw_ItemActivate);
            this.listViewDialogSaw.SelectedIndexChanged += new System.EventHandler(this.listViewDialogSaw_SelectedIndexChanged);
            // 
            // columnHeaderIndex
            // 
            this.columnHeaderIndex.Text = "ID";
            this.columnHeaderIndex.Width = 28;
            // 
            // columnHeaderSawID
            // 
            this.columnHeaderSawID.Text = "Saw ID";
            this.columnHeaderSawID.Width = 148;
            // 
            // columnHeaderItemName
            // 
            this.columnHeaderItemName.Text = "Item Name";
            this.columnHeaderItemName.Width = 236;
            // 
            // columnHeaderItemQty
            // 
            this.columnHeaderItemQty.Text = "Item Qty";
            this.columnHeaderItemQty.Width = 91;
            // 
            // columnHeaderItemType
            // 
            this.columnHeaderItemType.Text = "";
            this.columnHeaderItemType.Width = 131;
            // 
            // columnHeaderItemDes
            // 
            this.columnHeaderItemDes.Text = "Description";
            this.columnHeaderItemDes.Width = 448;
            // 
            // pictureBoxTopBar
            // 
            this.pictureBoxTopBar.BackColor = System.Drawing.Color.White;
            this.pictureBoxTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxTopBar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopBar.Image")));
            this.pictureBoxTopBar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTopBar.Name = "pictureBoxTopBar";
            this.pictureBoxTopBar.Size = new System.Drawing.Size(784, 112);
            this.pictureBoxTopBar.TabIndex = 41;
            this.pictureBoxTopBar.TabStop = false;
            // 
            // buttonNewItem
            // 
            this.buttonNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewItem.Location = new System.Drawing.Point(12, 183);
            this.buttonNewItem.Name = "buttonNewItem";
            this.buttonNewItem.Size = new System.Drawing.Size(121, 31);
            this.buttonNewItem.TabIndex = 42;
            this.buttonNewItem.Text = "NEW ITEM";
            this.buttonNewItem.UseVisualStyleBackColor = true;
            this.buttonNewItem.Click += new System.EventHandler(this.buttonNewItem_Click);
            // 
            // buttonViewItem
            // 
            this.buttonViewItem.Enabled = false;
            this.buttonViewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewItem.Location = new System.Drawing.Point(12, 220);
            this.buttonViewItem.Name = "buttonViewItem";
            this.buttonViewItem.Size = new System.Drawing.Size(121, 31);
            this.buttonViewItem.TabIndex = 43;
            this.buttonViewItem.Text = "VIEW ITEM";
            this.buttonViewItem.UseVisualStyleBackColor = true;
            this.buttonViewItem.Click += new System.EventHandler(this.buttonViewItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteItem.Enabled = false;
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteItem.Location = new System.Drawing.Point(12, 519);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(121, 31);
            this.buttonDeleteItem.TabIndex = 44;
            this.buttonDeleteItem.Text = "DETETE ITEM";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(701, 30);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(71, 52);
            this.buttonSettings.TabIndex = 45;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(12, 146);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(121, 31);
            this.buttonRefresh.TabIndex = 46;
            this.buttonRefresh.Text = "REFRESH";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelTop
            // 
            this.labelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTop.AutoSize = true;
            this.labelTop.BackColor = System.Drawing.Color.White;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(476, 34);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(89, 33);
            this.labelTop.TabIndex = 47;
            this.labelTop.Text = "Store";
            // 
            // buttonNeed
            // 
            this.buttonNeed.BackColor = System.Drawing.Color.Red;
            this.buttonNeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeed.ForeColor = System.Drawing.Color.White;
            this.buttonNeed.Location = new System.Drawing.Point(12, 257);
            this.buttonNeed.Name = "buttonNeed";
            this.buttonNeed.Size = new System.Drawing.Size(121, 31);
            this.buttonNeed.TabIndex = 48;
            this.buttonNeed.Text = "LIMITED";
            this.buttonNeed.UseVisualStyleBackColor = false;
            this.buttonNeed.Visible = false;
            this.buttonNeed.Click += new System.EventHandler(this.buttonNeed_Click);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(474, 120);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(91, 17);
            this.radioButtonName.TabIndex = 57;
            this.radioButtonName.Text = "By Item Name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Checked = true;
            this.radioButtonID.Location = new System.Drawing.Point(389, 120);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(74, 17);
            this.radioButtonID.TabIndex = 56;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "By Item ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(139, 118);
            this.textBoxSearch.MaxLength = 150;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(244, 22);
            this.textBoxSearch.TabIndex = 55;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.radioButtonID);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonNeed);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonViewItem);
            this.Controls.Add(this.buttonNewItem);
            this.Controls.Add(this.pictureBoxTopBar);
            this.Controls.Add(this.listViewDialogSaw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDialogSaw;
        private System.Windows.Forms.ColumnHeader columnHeaderIndex;
        private System.Windows.Forms.ColumnHeader columnHeaderSawID;
        private System.Windows.Forms.ColumnHeader columnHeaderItemName;
        private System.Windows.Forms.ColumnHeader columnHeaderItemQty;
        private System.Windows.Forms.PictureBox pictureBoxTopBar;
        private System.Windows.Forms.Button buttonNewItem;
        private System.Windows.Forms.Button buttonViewItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ColumnHeader columnHeaderItemDes;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ColumnHeader columnHeaderItemType;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Button buttonNeed;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}