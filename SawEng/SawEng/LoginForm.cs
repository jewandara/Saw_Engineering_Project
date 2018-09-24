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
    public partial class LoginForm : Form
    {
        private config callServer = new config();

        public LoginForm()
        {
            InitializeComponent();
            try
            {
                DataTable dt = callServer.sawEngServerCall("LOAD_APP", "");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    comboBoxStore.Items.Insert(i, dr["UserName"].ToString());
                }
                comboBoxStore.SelectedIndex = 0;
            }
            catch(Exception){}
        }

        private void buttonLoginKeeper_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = callServer.sawEngServerCall("LOGIN_APP", " @UserName = '" + comboBoxStore.SelectedItem.ToString() + "', @LogPass = '" + textBoxUserPass.Text + "' ");
                DataRow dr = dt.Rows[0];
                if (dr["MSG"].ToString() == "TRUE")
                {
                    this.Hide();
                    MainForm selectForm = new MainForm(comboBoxStore.SelectedItem.ToString());
                    selectForm.Show();
                }
                else if (dr["MSG"].ToString() == "ERROR")
                {
                    labelText.Visible = true;
                    labelText.Text = "Password Error, Contact Administrator.";
                }
                else
                {
                    labelText.Visible = true;
                    labelText.Text = "Password Error, Contact Administrator.";
                }
            }
            catch (Exception) { }
        }

        private void buttonLoginAsOfficer_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficerForm selectForm = new OfficerForm(comboBoxStore.SelectedItem.ToString());
            selectForm.Show();
        }

    }
}
