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
    public partial class UpdateByIDForm : Form
    {

        private config callServer = new config();
        private String UserName;
        private String ItemId;

        public UpdateByIDForm(String UID, String ID)
        {
            InitializeComponent(); 
            UserName = UID;
            ItemId = ID;
            labelLog.Text = "USERNAME:" + UID + " [ITEMID:" + ID + "]";
            try
            {
                DataTable dt = callServer.sawEngServerCall("VIEW_ITEM_BYID", " @UserName = '" + UID + "', @ItemID = '" + ID + "'");
                DataRow dr = dt.Rows[0];
                labelID.Text = "Item ID : "+ dr["ItemSawID"].ToString();
                labelName.Text = dr["ItemSawName"].ToString();
                numericUpDownItemQty.Value = Convert.ToDecimal(dr["ItemSawQtyValue"].ToString());
            }
            catch (Exception) { }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = callServer.sawEngServerCall("UPDATE_ITEM_BYID", " @UserName = '" + UserName + "', @ItemID = '" + ItemId + "', @ItemSawQtyValue = " + numericUpDownItemQty.Value.ToString());
                DataRow dr = dt.Rows[0];
                if (dr["MSG"].ToString() == "TRUE")
                {
                    var result = MessageBox.Show("Item Qty is updated to Saw Engineering Store", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    var result = MessageBox.Show("Database server error. Call the administrator", "Update Item", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception) { }
        }

        private void UpdateByIDForm_Load(object sender, EventArgs e)
        {

        }

    }
}
