using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SawEng.Config
{
    class SqlConfigClass
    {
        private String connectionString = null;
        private SqlConnection con;

        private void InitializeSql()
        {
            connectionString = "Data source=SQL5020.Smarterasp.net;Initial catalog=DB_9EF296_engineeringsaw;User Id=DB_9EF296_engineeringsaw_admin;Password=engineeringsaw;";
            con = new SqlConnection(connectionString);
        }

        private DataTable dialogServerSendMessage(String SqlComd)
        {
            try
            {
                InitializeSql();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlComd, con);
                DataTable sqlDataTable = new DataTable();
                sqlDataAdapter.Fill(sqlDataTable);
                return sqlDataTable;
            }
            catch (Exception)
            {
                var result = MessageBox.Show("Server Error", "Exit From Programe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                Application.Exit();
                return null;
            }
        }

        public DataTable dialogServerSendMessagePublic(String SqlComd)
        {
            return dialogServerSendMessage(SqlComd);
        }
    }

    public class config
    {
        private SqlConfigClass sqlMessageServerDataTable = new SqlConfigClass();
        public DataTable sawEngServerCall(String sqlEvent, String IDEventData = "")
        {
            switch (sqlEvent)
            {

                case "LOAD_APP":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("SELECT UserName FROM dbo.saw_User");
                case "LOGIN_APP":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_LoginUser " + IDEventData);
                case "CHANGE_PASS":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_ChangePass " + IDEventData);
                case "COUNT_LIMIT":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_CountQty " + IDEventData);
                case "VIEW_LIMIT":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_ViewCountQty " + IDEventData);

                case "LOAD_STORE":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_ViewItem " + IDEventData);
                case "LOAD_ACCESS":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_ViewAccess " + IDEventData);
                case "NEW_ITEM":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_NewItem " + IDEventData);
                case "VIEW_ITEM_BYID":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE dbo._sp_saw_ViewItemByID " + IDEventData);
                case "SEARCH_ITEM_BYID":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE dbo._sp_saw_ViewItemSearch " + IDEventData);
                case "VIEW_ACCESS":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE dbo._sp_saw_ViewAccess " + IDEventData);

                case "DELETE_ITEM":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_DeleteItem " + IDEventData);
                case "UPDATE_ITEM":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_UpdateItem " + IDEventData);
                case "UPDATE_ITEM_BYID":
                    return sqlMessageServerDataTable.dialogServerSendMessagePublic("EXECUTE _sp_saw_UpdateItemBYID " + IDEventData);
            }
            return null;
        }
    }
}
