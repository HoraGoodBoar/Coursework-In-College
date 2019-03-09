using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hostel{
    public static  class ControlPanel {
        public static void AddPage(string namePage,List<string> nameColumns) {
            TabPage a = new TabPage(namePage) {
                Name =namePage
            };
            a.Controls.Add(Table(nameColumns));
            a.Controls.Add(TableFromAdd(nameColumns));
            a.Controls.Add(Navigate());
            (Application.OpenForms[0].Controls["PagesPanel"] as TabControl).TabPages.Add(a);
            (Application.OpenForms[0].Controls["PagesPanel"] as TabControl).SelectedTab = (Application.OpenForms[0].Controls["PagesPanel"] as TabControl).TabPages[(Application.OpenForms[0].Controls["PagesPanel"] as TabControl).TabPages.Count-1];
        }
        public static void AddRow(List<string> Values) {
           ((Application.OpenForms[0].Controls["PagesPanel"] as TabControl).TabPages[(Application.OpenForms[0].Controls["PagesPanel"] as TabControl).SelectedIndex].Controls["Table"] as DataGridView).Rows.Add(Values.ToArray());
        }
        public static DataGridView Table (List<string> nameColumn,bool Event=true) {
            DataGridView dt = new DataGridView() {
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Dock = DockStyle.Fill,
                Name = "Table",
                AllowUserToAddRows = false,
                RowHeadersVisible = false
            };
            if(Event)
                dt.CellMouseDoubleClick += DataGridCellDoubleClick;
            for (int i = 0; i < nameColumn.Count; ++i)
                dt.Columns.Add(nameColumn[i], nameColumn[i]);
            return dt;
        }
        private static DataGridView TableFromAdd(List<string> nameColumn) {
            DataGridView dt = new DataGridView()
            {
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Height = 100,
                Dock = DockStyle.Bottom,
                Name = "TableFromAdd",
                RowHeadersVisible = false
            };
            for (int i = 0; i < nameColumn.Count; ++i)
                dt.Columns.Add(nameColumn[i], nameColumn[i]);
            dt.Columns[0].ReadOnly = true;
            return dt;
        }
        private static Panel Navigate() {
            Panel nav = new Panel(){
                Height = 20,
                Dock = DockStyle.Bottom
            };
            nav.Controls.Add(CreateButtonFromPanel("RefrechBtn", "Обновити", DockStyle.Right));
            nav.Controls.Add(CreateButtonFromPanel("AddBtn", "Добавити", DockStyle.Right));
            (nav.Controls["AddBtn"] as Button).MouseClick += AddBtnClick;
            (nav.Controls["RefrechBtn"] as Button).MouseClick += RefrechBtnPage;
            return nav;
        }

        private static void RefrechBtnPage(object sender, MouseEventArgs e){
            string TableName = (Application.OpenForms[0].Controls["PagesPanel"] as TabControl).SelectedTab.Text;
            (Application.OpenForms[0].Controls["PagesPanel"] as TabControl).TabPages.RemoveByKey(TableName);
            LoadTable.LoadPage(TableName);
        }

        private static void AddBtnClick(object sender, MouseEventArgs e){
            DataGridView table = ((Application.OpenForms[0].Controls["PagesPanel"] as TabControl).SelectedTab.Controls["TableFromAdd"] as DataGridView);
            for (int i = 0; i < table.Rows.Count-1; i++) {
                bool result = true;
                for (int j = 1; j < table.Columns.Count; j++)
                    if (table.Rows[i].Cells[j].Value ==null) {
                        result = false;
                        MessageBox.Show("Заповніть всі поля правильно!");
                        return;
                    }
                if(result)
                    Scripts.InsertScript(
                        (Application.OpenForms[0].Controls["PagesPanel"] as TabControl).SelectedTab.Text,
                        ToListDataGridViewColumn(table.Columns),
                        ToListDataGridViewRow(table.Rows[i], ToListDataGridViewColumn(table.Columns))
                    );
            }
        }
        private static string[] ToListDataGridViewColumn(DataGridViewColumnCollection col) {
            string[] list = new string[col.Count-1];
            for (int i = 1; i < col.Count; ++i)
                list[i-1]=col[i].HeaderText;
            return list;
        }
        private static string[] ToListDataGridViewRow(DataGridViewRow row,string[] ColumnName){
            string[] list = new string[row.Cells.Count-1];
            for (int i = 1; i < row.Cells.Count; ++i)
                list[i-1]=Adapter.GetUpDateString(row.Cells[i].Value.ToString(), ColumnName[i-1]);
            return list;
        }
        private static Button CreateButtonFromPanel(string NameBtn,string TextBtn,DockStyle style) {
            return new Button(){
                Text = TextBtn,
                Name=NameBtn,
                Dock = style
            };
        }
        private static void DataGridCellDoubleClick(object sender, DataGridViewCellMouseEventArgs e){
            EditForm edit = new EditForm();
            List<string> Data = new List<string>();
            List<string> TitleName = new List<string>();
            Data.Add((Application.OpenForms[0].Controls["PagesPanel"] as TabControl).SelectedTab.Text);
            DataGridView dt = ((Application.OpenForms[0].Controls["PagesPanel"] as TabControl).SelectedTab.Controls["Table"] as DataGridView);
            for (int i = 0; i < dt.Columns.Count; ++i){
                Data.Add(dt.Rows[e.RowIndex].Cells[i].Value.ToString());
                TitleName.Add(dt.Columns[i].HeaderText);
            }
            edit.Start(Data,TitleName);
            edit.Show();
        }
    }
}
