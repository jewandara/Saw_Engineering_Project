namespace SawEng
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonLoginKeeper = new System.Windows.Forms.Button();
            this.buttonLoginAsOfficer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.textBoxUserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginKeeper
            // 
            this.buttonLoginKeeper.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLoginKeeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginKeeper.Location = new System.Drawing.Point(307, 361);
            this.buttonLoginKeeper.Name = "buttonLoginKeeper";
            this.buttonLoginKeeper.Size = new System.Drawing.Size(265, 43);
            this.buttonLoginKeeper.TabIndex = 0;
            this.buttonLoginKeeper.Text = "LOGIN AS STORE KEEPER";
            this.buttonLoginKeeper.UseVisualStyleBackColor = false;
            this.buttonLoginKeeper.Click += new System.EventHandler(this.buttonLoginKeeper_Click);
            // 
            // buttonLoginAsOfficer
            // 
            this.buttonLoginAsOfficer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLoginAsOfficer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginAsOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAsOfficer.Location = new System.Drawing.Point(12, 361);
            this.buttonLoginAsOfficer.Name = "buttonLoginAsOfficer";
            this.buttonLoginAsOfficer.Size = new System.Drawing.Size(265, 43);
            this.buttonLoginAsOfficer.TabIndex = 1;
            this.buttonLoginAsOfficer.Text = "LOGIN AS OFFICER";
            this.buttonLoginAsOfficer.UseVisualStyleBackColor = false;
            this.buttonLoginAsOfficer.Click += new System.EventHandler(this.buttonLoginAsOfficer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(138, 229);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(308, 32);
            this.comboBoxStore.TabIndex = 3;
            // 
            // textBoxUserPass
            // 
            this.textBoxUserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserPass.Location = new System.Drawing.Point(138, 297);
            this.textBoxUserPass.Name = "textBoxUserPass";
            this.textBoxUserPass.PasswordChar = '*';
            this.textBoxUserPass.Size = new System.Drawing.Size(308, 29);
            this.textBoxUserPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelText.Location = new System.Drawing.Point(138, 333);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(29, 13);
            this.labelText.TabIndex = 7;
            this.labelText.Text = "Error";
            this.labelText.Visible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonLoginKeeper;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 416);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserPass);
            this.Controls.Add(this.comboBoxStore);
            this.Controls.Add(this.buttonLoginAsOfficer);
            this.Controls.Add(this.buttonLoginKeeper);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAW Engineering - Login Store";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginKeeper;
        private System.Windows.Forms.Button buttonLoginAsOfficer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.TextBox textBoxUserPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelText;
    }
}