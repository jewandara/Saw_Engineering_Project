namespace SawEng
{
    partial class ViewForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.numericUpDownItemMinQty = new System.Windows.Forms.NumericUpDown();
            this.textBoxIDSAW = new System.Windows.Forms.TextBox();
            this.numericUpDownItemQty = new System.Windows.Forms.NumericUpDown();
            this.comboBoxQtyType = new System.Windows.Forms.ComboBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.labelIDText = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemMinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "( Minimum Value For Worning Message )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "MIN QTY  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "QTY TYPE  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ITEM QTY  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ITEM DESCRIPTION  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ITEM NAME  :";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(171, 100);
            this.textBoxDescription.MaxLength = 2000;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(350, 74);
            this.textBoxDescription.TabIndex = 26;
            // 
            // numericUpDownItemMinQty
            // 
            this.numericUpDownItemMinQty.DecimalPlaces = 2;
            this.numericUpDownItemMinQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownItemMinQty.Location = new System.Drawing.Point(171, 262);
            this.numericUpDownItemMinQty.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.numericUpDownItemMinQty.Name = "numericUpDownItemMinQty";
            this.numericUpDownItemMinQty.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownItemMinQty.TabIndex = 25;
            this.numericUpDownItemMinQty.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            // 
            // textBoxIDSAW
            // 
            this.textBoxIDSAW.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxIDSAW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIDSAW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDSAW.Location = new System.Drawing.Point(171, 28);
            this.textBoxIDSAW.Name = "textBoxIDSAW";
            this.textBoxIDSAW.ReadOnly = true;
            this.textBoxIDSAW.Size = new System.Drawing.Size(179, 22);
            this.textBoxIDSAW.TabIndex = 24;
            // 
            // numericUpDownItemQty
            // 
            this.numericUpDownItemQty.DecimalPlaces = 2;
            this.numericUpDownItemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownItemQty.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownItemQty.Location = new System.Drawing.Point(171, 188);
            this.numericUpDownItemQty.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.numericUpDownItemQty.Name = "numericUpDownItemQty";
            this.numericUpDownItemQty.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownItemQty.TabIndex = 23;
            this.numericUpDownItemQty.Value = new decimal(new int[] {
            1000,
            0,
            0,
            131072});
            // 
            // comboBoxQtyType
            // 
            this.comboBoxQtyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQtyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQtyType.FormattingEnabled = true;
            this.comboBoxQtyType.Items.AddRange(new object[] {
            "NO  ( One )",
            "NOS ( More Then One )",
            "M ( Meters )",
            "KG ( kilograms )",
            "L ( Liters )",
            "FT ( Feet )"});
            this.comboBoxQtyType.Location = new System.Drawing.Point(171, 224);
            this.comboBoxQtyType.Name = "comboBoxQtyType";
            this.comboBoxQtyType.Size = new System.Drawing.Size(179, 24);
            this.comboBoxQtyType.TabIndex = 22;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemName.Location = new System.Drawing.Point(171, 64);
            this.textBoxItemName.MaxLength = 500;
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.ReadOnly = true;
            this.textBoxItemName.Size = new System.Drawing.Size(350, 22);
            this.textBoxItemName.TabIndex = 21;
            // 
            // labelIDText
            // 
            this.labelIDText.AutoSize = true;
            this.labelIDText.Location = new System.Drawing.Point(64, 32);
            this.labelIDText.Name = "labelIDText";
            this.labelIDText.Size = new System.Drawing.Size(85, 13);
            this.labelIDText.TabIndex = 19;
            this.labelIDText.Text = "NEW ITEM ID  :";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(171, 311);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(446, 311);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLog.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLog.Location = new System.Drawing.Point(12, 340);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(30, 12);
            this.labelLog.TabIndex = 33;
            this.labelLog.Text = "LOG";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.numericUpDownItemMinQty);
            this.Controls.Add(this.textBoxIDSAW);
            this.Controls.Add(this.numericUpDownItemQty);
            this.Controls.Add(this.comboBoxQtyType);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.labelIDText);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCancel);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ViewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saw Engineering - Store Keeper - View Item";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemMinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.NumericUpDown numericUpDownItemMinQty;
        private System.Windows.Forms.TextBox textBoxIDSAW;
        private System.Windows.Forms.NumericUpDown numericUpDownItemQty;
        private System.Windows.Forms.ComboBox comboBoxQtyType;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelIDText;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLog;

    }
}