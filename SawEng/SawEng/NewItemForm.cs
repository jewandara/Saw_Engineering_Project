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
    public partial class NewItemForm : Form
    {

        private config callServer = new config();
        private String UserName;
        public NewItemForm(String UID)
        {
            InitializeComponent();
            UserName = UID;
            labelLog.Text = "USERNAME:" + UID + "";
            comboBoxQtyType.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxItemName.Text.Length > 4)
            {
                try
                {
                    DataTable dt = callServer.sawEngServerCall("NEW_ITEM", " @UserName = '" + UserName + "', @ItemSawID = 'SAW" + textBoxID.Text + "', @ItemSawName = '" + textBoxItemName.Text + "', @ItemSawQtyValue =  " + numericUpDownItemQty.Value.ToString() + ", @ItemSawQtyType	= '" + comboBoxQtyType.SelectedItem.ToString() + "', @ItemSawQtyMinLimite	= " + numericUpDownItemMinQty.Value.ToString() + ", @ItemDescription= '" + textBoxDescription.Text + "'");
                    DataRow dr = dt.Rows[0];
                    if (dr["MSG"].ToString() == "TRUE")
                    {
                        var result = MessageBox.Show("New Item is added to Saw Engineering Store", "New Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else if (dr["MSG"].ToString() == "ERROR")
                    {
                        MessageBox.Show("Item ID is already exists. Use different ID.", "New Item Added", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var result = MessageBox.Show("Database server error. Call the administrator", "New Item Added", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
                MessageBox.Show("Item Name must be more than 4 letters.", "New Item Added", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewItemForm_Load(object sender, EventArgs e)
        {

        }

    }
}
