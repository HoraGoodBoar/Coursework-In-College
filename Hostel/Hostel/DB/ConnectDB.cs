using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hostel{
    public static partial class ConnectDB{
        public static OleDbConnection db = null;

        public static void Connect() {
            try{
                db = new OleDbConnection(GetPathDB());
                db.Open();
            }
            catch (Exception e){
                Application.OpenForms[0].Controls.Remove((Application.OpenForms[0].Controls["PagesPanel"] as TabControl));
                MessageBox.Show(e.Message);
                Disconnect();
            }
        }
        public static void Disconnect() {
            if (db != null){
                db.Close();
                db = null;
            }
        }
        private static string GetPathDB(){
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBHostel.accdb;";
        }
    }
}

