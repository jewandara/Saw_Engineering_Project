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
    public partial class OfficerForm : Form
    {


        private config callServer = new config();
        private String UserName;

        public OfficerForm(String UID)
        {
            InitializeComponent();
            labelTop.Text = UID;
            UserName = UID;
            sawTabAccess.Text = "  Access  :  " + UID + "  ";
            sawTabStore.Text = "  Store  :  " + UID + "  ";
            string currentMonth = DateTime.Now.Month.ToString();
            string currentYear = DateTime.Now.Year.ToString();

            comboBoxYear.Text = currentYear;
            comboBoxMonth.Text = currentMonth;
            try
            {
                listViewStore.Items.Clear();
                DataTable dt = callServer.sawEngServerCall("LOAD_STORE", " @UserName = '" + UserName + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawName"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyMinLimite"].ToString());
                    listitem.SubItems.Add(dr["ItemDescription"].ToString());
                    listitem.SubItems.Add(dr["InsertDate"].ToString());
                    listViewStore.Items.Add(listitem);
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
                listViewAccess.Items.Clear();
                dt = callServer.sawEngServerCall("VIEW_ACCESS", " @UserName = '" + UserName + "', @Y = '" + currentYear + "', @M =	'" + currentMonth + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["AccID"].ToString());
                    listitem.SubItems.Add(UID);
                    listitem.SubItems.Add(dr["AccDescription"].ToString());
                    listitem.SubItems.Add(dr["InsertDate"].ToString());
                    listViewAccess.Items.Add(listitem);
                }
            }
            catch (Exception) { }
        }

        private void buttonNeed_Click(object sender, EventArgs e)
        {
            try
            {
                listViewStore.Items.Clear();
                DataTable dt = callServer.sawEngServerCall("VIEW_LIMIT", " @UserName = '" + UserName + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawName"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyMinLimite"].ToString());
                    listitem.SubItems.Add(dr["ItemDescription"].ToString());
                    listitem.SubItems.Add(dr["InsertDate"].ToString());
                    listViewStore.Items.Add(listitem);
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                listViewStore.Items.Clear();
                DataTable dt = callServer.sawEngServerCall("LOAD_STORE", " @UserName = '" + UserName + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawID"].ToString());
                    listitem.SubItems.Add(dr["ItemSawName"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                    listitem.SubItems.Add(dr["ItemSawQtyMinLimite"].ToString());
                    listitem.SubItems.Add(dr["ItemDescription"].ToString());
                    listitem.SubItems.Add(dr["InsertDate"].ToString());
                    listViewStore.Items.Add(listitem);
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
            if (radioButtonByID.Checked)
            {
                try
                {
                    listViewStore.Items.Clear();
                    DataTable dt = callServer.sawEngServerCall("SEARCH_ITEM_BYID", " @UserName = '" + UserName + "', @Type = 'ID', @Data = '" + textBoxSearch.Text + "'");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                        listitem.SubItems.Add(dr["ItemSawID"].ToString());
                        listitem.SubItems.Add(dr["ItemSawName"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyMinLimite"].ToString());
                        listitem.SubItems.Add(dr["ItemDescription"].ToString());
                        listitem.SubItems.Add(dr["InsertDate"].ToString());
                        listViewStore.Items.Add(listitem);
                    }
                }
                catch (Exception) { }
            }
            else if (radioButtonName.Checked)
            {
                try
                {
                    listViewStore.Items.Clear();
                    DataTable dt = callServer.sawEngServerCall("SEARCH_ITEM_BYID", " @UserName = '" + UserName + "', @Type = 'NAME', @Data = '" + textBoxSearch.Text + "'");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["ItemID"].ToString());
                        listitem.SubItems.Add(dr["ItemSawID"].ToString());
                        listitem.SubItems.Add(dr["ItemSawName"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyValue"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyType"].ToString());
                        listitem.SubItems.Add(dr["ItemSawQtyMinLimite"].ToString());
                        listitem.SubItems.Add(dr["ItemDescription"].ToString());
                        listitem.SubItems.Add(dr["InsertDate"].ToString());
                        listViewStore.Items.Add(listitem);
                    }
                }
                catch (Exception) { } 
            }
            else { }
        }

        private void radioButtonByID_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSearch.Text = "saw";
        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {

            textBoxSearch.Text = "";
        }

        private void buttonAllAccess_Click(object sender, EventArgs e)
        {
            try
            {
                listViewAccess.Items.Clear();
                DataTable dt = callServer.sawEngServerCall("VIEW_ACCESS", " @UserName = '" + UserName + "', @Y	=	'" + comboBoxYear.SelectedItem.ToString() + "', @M	= '" + comboBoxMonth.SelectedItem.ToString() + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["AccID"].ToString());
                    listitem.SubItems.Add(UserName);
                    listitem.SubItems.Add(dr["AccDescription"].ToString());
                    listitem.SubItems.Add(dr["InsertDate"].ToString());
                    listViewAccess.Items.Add(listitem);
                }
            }
            catch (Exception) { }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ndes.lk/");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.eweo.org/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.eweo.org/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ndes.lk/");
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelAbout.Visible = true;
        }

        private void panelAbout_MouseLeave(object sender, EventArgs e)
        {
            panelAbout.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            panelAbout.Visible = false;
        }

        private void panelAbout_MouseClick(object sender, MouseEventArgs e)
        {
            panelAbout.Visible = false;
        }

        private void OfficerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
