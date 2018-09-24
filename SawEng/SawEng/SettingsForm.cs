using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SawEng.Config;

namespace SawEng
{
    public partial class SettingsForm : Form
    {

        private config callServer = new config();
        private String UserName;

        public SettingsForm(String UID)
        {
            InitializeComponent();
            UserName = UID;
            textBoxStoreName.Text = UID;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNewPass.Text.Length > 5)
            {
                if (textBoxNewConPass.Text == textBoxNewPass.Text)
                {
                    try
                    {
                        DataTable dt = callServer.sawEngServerCall("CHANGE_PASS", " @UserName = '" + UserName + "', @OldPass = '" + textBoxOldPass.Text + "', @NewPass = '" + textBoxNewPass.Text + "'");
                        DataRow dr = dt.Rows[0];
                        if (dr["MSG"].ToString() == "TRUE")
                        {
                            var result = MessageBox.Show("Password changed Successfully !", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else if (dr["MSG"].ToString() == "ERROR")
                        {
                            labelError.Visible = true;
                            labelError.Text = "Password Error, Try Again.";
                        }
                        else
                        {
                            var result = MessageBox.Show("Database server error. Call the administrator", "Change Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (result == DialogResult.Cancel)
                            {
                                this.Close();
                            }
                        }
                    }
                    catch (Exception) { }
                }
                else
                {
                    labelError.Visible = true;
                    labelError.Text = "Password doesn't match, Try Again.";
                }
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "Password must be more than 6 letters, Try Again.";
            }
        }

    }
}
