using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hostel{
    public partial class MainForm : Form{
        private List<List<string>> search =null;
        public MainForm(){
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e){
            LoadTable.LoadAll();
        }

        private void ViewsClick(object sender, EventArgs e){
            if (PagesPanel.TabPages.ContainsKey((sender as ToolStripMenuItem).Text) && !(sender as ToolStripMenuItem).Checked){
                PagesPanel.TabPages.RemoveByKey((sender as ToolStripMenuItem).Text);
            }
            else {
                LoadTable.LoadPage((sender as ToolStripMenuItem).Text);
            }
        }

        private void PanelKeyUp(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.ShiftKey ){
                PagesPanel.SelectedTab = PagesPanel.TabPages[PagesPanel.SelectedIndex+1== PagesPanel.TabCount ? 0: PagesPanel.SelectedIndex + 1];
            }
        }

        private void RefrechTable(object sender, EventArgs e){
            PagesPanel.TabPages.Clear();
            LoadTable.LoadAll();
            for (int i = 0; i < Views.DropDownItems.Count; ++i)
                (Views.DropDownItems[i] as ToolStripMenuItem).Checked = true;
        }
        private void FreePlacesShow(object sender, EventArgs e){
            Form show = new Form() {
                Width=900,
                Height=500,
                Text="Вільні Місця"
            };
            if (!PagesPanel.TabPages.ContainsKey("Кімната"))
                LoadTable.LoadPage("Кімната");
            (Views.DropDownItems["roomToolStripMenuItem"] as ToolStripMenuItem).Checked = true;
            DataGridView url = (PagesPanel.TabPages["Кімната"].Controls["Table"] as DataGridView);
            List<string> TitleName = new List<string>();
            for (int i = 0; i < url.Columns.Count; ++i)
                TitleName.Add(url.Columns[i].HeaderText);
            DataGridView table = ControlPanel.Table(TitleName,false);
            
            for (int i = 0; i < url.Rows.Count; ++i) {
                if (Convert.ToInt32(url.Rows[i].Cells[2].Value) > Convert.ToInt32(url.Rows[i].Cells[3].Value)) {
                    List<string> data = new List<string>();
                    for (int j = 0; j < url.Columns.Count; ++j)
                        data.Add(url.Rows[i].Cells[j].Value.ToString());
                    table.Rows.Add(data.ToArray());
                }            
            }
            show.Controls.Add(table);
            show.Show();
        }
        private void NoPaidMenuItemClick(object sender, EventArgs e){
            Form show = new Form(){
                Width = 900,
                Height = 500,
                Text = "Не проплачено"
            };
            if (!PagesPanel.TabPages.ContainsKey("Студент"))
                LoadTable.LoadPage("Студент");
            (Views.DropDownItems["roomToolStripMenuItem"] as ToolStripMenuItem).Checked = true;
            DataGridView url = (PagesPanel.TabPages["Студент"].Controls["Table"] as DataGridView);
            List<string> TitleName = new List<string>();
            for (int i = 0; i < url.Columns.Count; ++i)
                TitleName.Add(url.Columns[i].HeaderText);
            DataGridView table = ControlPanel.Table(TitleName,false);
            for (int i = 0; i < url.Rows.Count; ++i){
                if (url.Rows[i].Cells[6].Value.ToString()=="False"){
                    List<string> data = new List<string>();
                    for (int j = 0; j < url.Columns.Count; ++j)
                        data.Add(url.Rows[i].Cells[j].Value.ToString());
                    table.Rows.Add(data.ToArray());
                }
            }
            show.Controls.Add(table);
            show.Show();
        }

        public void SelectPage(object sender, TabControlEventArgs e){
            search = new List<List<string>>();
            ChoiceParametr.Text = "";
            if (PagesPanel.SelectedTab != null){
                DataGridView dt = (PagesPanel.SelectedTab.Controls["Table"] as DataGridView);
                for (int i = 0; i < dt.Rows.Count; ++i){
                    search.Add(new List<string>());
                    for (int j = 0; j < dt.Columns.Count; ++j)
                    {
                        search[i].Add(dt.Rows[i].Cells[j].Value.ToString());
                    }
                }
                ChoiceParametr.Items.Clear();
                for (int i = 0; i < dt.Columns.Count; ++i)
                    ChoiceParametr.Items.Add(dt.Columns[i].HeaderText);
            }
        }
        private void SearchTxtBox(object sender, EventArgs e){
            if (search.Count == 0) {
                search = new List<List<string>>();
                if (PagesPanel.SelectedTab != null){
                    DataGridView dt = (PagesPanel.SelectedTab.Controls["Table"] as DataGridView);
                    for (int i = 0; i < dt.Rows.Count; ++i)
                    {
                        search.Add(new List<string>());
                        for (int j = 0; j < dt.Columns.Count; ++j)
                            search[i].Add(dt.Rows[i].Cells[j].Value.ToString());
                    }
                }
            }
            DataGridView dtt = (PagesPanel.SelectedTab.Controls["Table"] as DataGridView);
            if (ChoiceParametr.SelectedItem != null){
                int index = 0;
                for (int i = 0; i < dtt.Columns.Count; ++i)
                    if (dtt.Columns[i].HeaderText == ChoiceParametr.Text)
                        index = i;
                dtt.Rows.Clear();
                if (ValuesParametr.Text == ""){
                    for (int i = 0; i < search.Count; ++i)
                        dtt.Rows.Add(search[i].ToArray());
                }
                else{
                    for(int i=0;i<search.Count;++i)
                        if(search[i][index].Contains(ValuesParametr.Text))
                            dtt.Rows.Add(search[i].ToArray());
                }
            }
        }

        private void HelpBtn(object sender, EventArgs e){
            MessageBox.Show("Щоб редагувати дані, натисніть мишкою два рази, на вибраному полі!"+
                "\n----------------------------------------------------------------------------------------\n"+
                "Щоб додати дані, виберіть нижню таблицю, заповніть рядок та нажміть на кнопку \"Добавити\"!"+
                "\n----------------------------------------------------------------------------------------\n"+
                "Якщо дані не обновилися, переобновіть всі таблиці за допомогою кнопки в верхньому меню \"Обновити\" ",
                "Допомога");
        }
    }
}
