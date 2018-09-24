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
    public partial class MainForm : Form
    {

        private config callServer = new config();
        private String UserName;

        public MainForm(String UID)
        {
            InitializeComponent();
            UserName = UID;
            labelTop.Text = UID;
            try
            {
                listViewDialogSaw.Items.Clear();
                DataTable dt = callServer.sawEngServerCall("LOAD_STORE", " @UserName = '" + UserName + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawName"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                    listitem.SubItems.Add(dr["ItemDescription"].ToString());
                    listViewDialogSaw.Items.Add(listitem);
                }
                dt = callServer.sawEngServerCall("COUNT_LIMIT", " @UserName = '" + UserName + "'");
                DataRow drCount = dt.Rows[0];
                if (drCount["MSG"].ToString() == "TRUE") 
                {
                    if (Convert.ToDecimal(drCount["COUNT"].ToString()) > 0)
                    {
                        buttonNeed.Visible = true;
                        buttonNeed.Text = "ITEMS [ " + drCount["COUNT"].ToString() + " ]";
                    }
                    else
                    {
                        buttonNeed.Visible = false;
                    }
                }
            }
            catch (Exception) { }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                listViewDialogSaw.Items.Clear();
                DataTable dt = callServer.sawEngServerCall("LOAD_STORE", " @UserName = '" + UserName + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawName"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                    listitem.SubItems.Add(dr["ItemDescription"].ToString());
                    listViewDialogSaw.Items.Add(listitem);
                }
                dt = callServer.sawEngServerCall("COUNT_LIMIT", " @UserName = '" + UserName + "'");
                DataRow drCount = dt.Rows[0];
                if (drCount["MSG"].ToString() == "TRUE")
                {
                    if (Convert.ToDecimal(drCount["COUNT"].ToString()) > 0)
                    {
                        buttonNeed.Visible = true;
                        buttonNeed.Text = "ITEMS [ " + drCount["COUNT"].ToString() + " ]";
                    }
                    else
                    {
                        buttonNeed.Visible = false;
                    }
                }
            }
            catch (Exception) { }
        }

        private void listViewDialogSaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonViewItem.Enabled = true;
            buttonDeleteItem.Enabled = true;
        }

        private void buttonViewItem_Click(object sender, EventArgs e)
        {
            try
            {
                String ITEMID = listViewDialogSaw.Items[listViewDialogSaw.SelectedIndices[0]].Text;
                ViewForm selectCustForm = new ViewForm(UserName,ITEMID);
                selectCustForm.ShowDialog();
            }
            catch (Exception)
            {
                buttonViewItem.Enabled = false;
                buttonDeleteItem.Enabled = false;
            }
        }

        private void listViewDialogSaw_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                String ITEMID = listViewDialogSaw.Items[listViewDialogSaw.SelectedIndices[0]].Text;
                UpdateByIDForm selectCustForm = new UpdateByIDForm(UserName, ITEMID);
                selectCustForm.ShowDialog();
            }
            catch (Exception)
            {
                buttonViewItem.Enabled = false;
                buttonDeleteItem.Enabled = false;
            }
        }

        private void buttonNewItem_Click(object sender, EventArgs e)
        {
            NewItemForm selectNewForm = new NewItemForm(UserName);
            selectNewForm.ShowDialog();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                String ITEMID = listViewDialogSaw.Items[listViewDialogSaw.SelectedIndices[0]].Text;
                var result = MessageBox.Show("Are You Sure you want to delete this item ?", "Delete Store Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataTable dt = callServer.sawEngServerCall("DELETE_ITEM", " @UserName = '" + UserName + "', @ItemID = '" + ITEMID + "' ");
                    DataRow dr = dt.Rows[0];
                    if (dr["MSG"].ToString() == "TRUE") { MessageBox.Show("Delete Successful !", "Delete Store Item", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }
            catch (Exception)
            {
                buttonViewItem.Enabled = false;
                buttonDeleteItem.Enabled = false;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm selectNewForm = new SettingsForm(UserName);
            selectNewForm.ShowDialog();
        }

        private void buttonNeed_Click(object sender, EventArgs e)
        {
            try
            {
                listViewDialogSaw.Items.Clear();
                DataTable dt = callServer.sawEngServerCall("VIEW_LIMIT", " @UserName = '" + UserName + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawName"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                    listitem.SubItems.Add(dr["ItemDescription"].ToString());
                    listViewDialogSaw.Items.Add(listitem);
                }
                dt = callServer.sawEngServerCall("COUNT_LIMIT", " @UserName = '" + UserName + "'");
                DataRow drCount = dt.Rows[0];
                if (drCount["MSG"].ToString() == "TRUE")
                {
                    if (Convert.ToDecimal(drCount["COUNT"].ToString()) > 0)
                    {
                        buttonNeed.Visible = true;
                        buttonNeed.Text = "ITEMS [ " + drCount["COUNT"].ToString() + " ]";
                    }
                    else
                    {
                        buttonNeed.Visible = false;
                    }
                }
            }
            catch (Exception) { }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonID.Checked)
            {
                try
                {
                    listViewDialogSaw.Items.Clear();
                    DataTable dt = callServer.sawEngServerCall("SEARCH_ITEM_BYID", " @UserName = '" + UserName + "', @Type = 'ID', @Data = '" + textBoxSearch.Text + "'");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                        listitem.SubItems.Add(dr["ItemSawID"].ToString());
                        listitem.SubItems.Add(dr["ItemSawName"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                        listitem.SubItems.Add(dr["ItemDescription"].ToString());
                        listViewDialogSaw.Items.Add(listitem);
                    }
                }
                catch (Exception) { }
            }
            else if (radioButtonName.Checked)
            {
                try
                {
                    listViewDialogSaw.Items.Clear();
                    DataTable dt = callServer.sawEngServerCall("SEARCH_ITEM_BYID", " @UserName = '" + UserName + "', @Type = 'NAME', @Data = '" + textBoxSearch.Text + "'");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                        listitem.SubItems.Add(dr["ItemSawID"].ToString());
                        listitem.SubItems.Add(dr["ItemSawName"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                        listitem.SubItems.Add(dr["ItemDescription"].ToString());
                        listViewDialogSaw.Items.Add(listitem);
                    }
                }
                catch (Exception) { }
            }
            else { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
