using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Hostel{
    public static  class LoadTable{
        public static void LoadPage(string nameTable){
            ConnectDB.Connect();
            if (ConnectDB.db != null){
                try{
                    OleDbCommand command = new OleDbCommand(@"Select * from " + nameTable, ConnectDB.db);
                    OleDbDataReader reader = command.ExecuteReader();
                    List<string> NameColumns = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++){
                        NameColumns.Add(reader.GetName(i));
                    }
                    ControlPanel.AddPage(nameTable, NameColumns);
                    while (reader.Read()){
                        List<string> Values = new List<string>();
                        for (int i = 0; i < NameColumns.Count; i++){
                            Values.Add(reader.GetValue(i).ToString());
                        }
                        ControlPanel.AddRow(Values);
                    }
                    reader.Close();
                }
                catch (Exception s){
                    MessageBox.Show(s.Message);
                }
            }
            ConnectDB.Disconnect();
        }

        public static void LoadAll(){
            Scripts.InteriorUpLoad();
            Scripts.HostelUpLoad();
            LoadPage("Поверх");
            LoadPage("Гуртожиток");
            LoadPage("Інтерєр");
            LoadPage("Посада");
            LoadPage("Студент");
            Scripts.RoomUpLoad();
            LoadPage("Кімната");
            LoadPage("Працівник");
            LoadPage("Обслуговування");
        }
    }
}
