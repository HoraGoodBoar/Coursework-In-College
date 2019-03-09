using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hostel{
    public static class Scripts{
        public static void InteriorUpLoad() {
            UpLoadScript("Інтерєр", "Використано", SumScript("Кімната", "КількістьЛіжок").ToString(), "Імя", "'Ліжко'");
            UpLoadScript("Інтерєр", "Використано", SumScript("Кімната", "КількістьТумбочок").ToString(), "Імя", "'Тумбочка'");
            UpLoadScript("Інтерєр", "Використано", SumScript("Кімната", "КількістьМатрасів").ToString(), "Імя", "'Матрас'");
            UpLoadScript("Інтерєр", "Використано", SumScript("Кімната", "КількістьКрісел").ToString(), "Імя", "'Крісло'");
            UpLoadScript("Інтерєр", "Використано", SumScript("Кімната", "КількістьСтолів").ToString(), "Імя", "'Стіл'");
        }
        public static void HostelUpLoad() {
            if (CountScript("Гуртожиток", "Ід") != 0)
                DeleteScript("Гуртожиток","Ід","1",true,">=");
            InsertScript(
                "Гуртожиток",
                new string[] {
                    "КількістьКімнат",
                    "ВсьогоСтудентів",
                    "КількістьПрацівників"
                },
                new string[] {
                    CountScript("Кімната","Ід").ToString(),
                    CountScript("Студент","Ід").ToString(),
                    CountScript("Працівник","Ід").ToString()
                }
            );
        }
        public static void RoomUpLoad() {
            List<string> IdRoom = new List<string>();
            DataGridView load =  ((Application.OpenForms[0].Controls["PagesPanel"] as TabControl).TabPages["Студент"].Controls["Table"] as DataGridView);
            for (int i = 0; i < load.Rows.Count; ++i)
                if (!IdRoom.Contains(load.Rows[i].Cells[3].Value.ToString()))
                    IdRoom.Add(load.Rows[i].Cells[3].Value.ToString());
            for (int i = 0; i < IdRoom.Count; ++i)
                UpLoadScript("Кімната", "Проживають", WhereCountScript("Студент","ІдКімнати", "ІдКімнати",IdRoom[i]).ToString(),"Ід",  IdRoom[i]);
        }
        private static int SumScript(string NameTable,string Name) {
            string script = "SELECT sum ("+ Name + ") FROM "+ NameTable;
            return ScalarScript(script);
        }
        private static int WhereCountScript(string NameTable,string Name,string WhereName, string WhereValue){
            string script = "SELECT COUNT(" + Name + ") FROM " + NameTable + " where "+WhereName + " = "+WhereValue;
            return ScalarScript(script);
        }
        private static int ScalarScript(string script) {
            ConnectDB.Connect();
            try{
                OleDbCommand command = new OleDbCommand(script, ConnectDB.db);
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception s){
                MessageBox.Show(s.Message);
            }
            ConnectDB.Disconnect();
            return -1;
        }
        private static int CountScript(string NameTable,string Name) {
            string script = "SELECT COUNT("+Name+") FROM "+NameTable;
            return ScalarScript(script);
        }
        private static void NonQueryScript(string script){
            ConnectDB.Connect();
            try{
                OleDbCommand command = new OleDbCommand(script, ConnectDB.db);
                command.ExecuteNonQuery();
            }
            catch (Exception s){
                MessageBox.Show(s.Message);
            }
            ConnectDB.Disconnect();
        }
        public static void UpLoadScript(string NameTabel,string NameSet,string ValueSet,string WhereName,string WhereValue) {
            string script = "Update "+NameTabel + " set "+NameSet+" = "+ValueSet+" where "+WhereName+" = "+WhereValue;
            NonQueryScript(script);
        }
        public static void InsertScript(string NameTable,string[] Name,string[] Value) {
            string script = "INSERT INTO " + NameTable + " (";
            for (int i = 0; i < Name.Count()-1; ++i)
                script += Name[i] + ",";
            script +=Name[Name.Count()-1] +") Values (";
            for (int i = 0; i < Value.Count()-1; ++i)
                script += Value[i]+",";
            script += Value[Value.Count()-1]+ ")";
            NonQueryScript(script);
        }
        public static bool DeleteScript(string NameTable, string WhereName, string WhereValue,bool Admin=false,string Operation="="){
            if (!Admin){
                if (MessageBox.Show("Ви впевнені?", "Дані відновити, буде не можливо!", MessageBoxButtons.YesNoCancel) == DialogResult.Yes){
                    string script = $"DELETE  FROM {NameTable} WHERE {WhereName}{Operation}{Adapter.GetUpDateString(WhereValue, WhereName)}";
                    NonQueryScript(script);
                    return true;
                }
            }
            else{
                string script = $"DELETE  FROM {NameTable} WHERE {WhereName}{Operation}{Adapter.GetUpDateString(WhereValue, WhereName)}";
                NonQueryScript(script);
                return true;
            }
            return false;
        }
    }
}
