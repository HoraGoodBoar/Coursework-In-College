using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hostel{
    public partial class EditForm : Form{
        public EditForm(){
            InitializeComponent();
        }
        private List<string> Data = null;
        private string NameTable = "";
        private string PathImage = "";
        public void Start(List<string> Data,List<string>TitleName) {
            switch (NameTable=Data[0]) {
                case "Студент": LoadImage(PathImage=Data[8]); break;
                case "Працівник":LoadImage(PathImage=Data[6]); break;
                default: {
                        this.Controls.RemoveByKey("Photo");
                        this.Controls.RemoveByKey("PhotoBtn");
                        this.Controls.RemoveByKey("DeletePhotoBtn");
                        this.Controls.RemoveByKey("DeleteUserBtn");
                        this.Controls["Table"].Dock = DockStyle.Top;
                        this.Controls["Table"].Refresh();
                    } break;
            }
            Data.RemoveAt(0);
            for (int i = 0; i < TitleName.Count; ++i)
                Table.Columns.Add(TitleName[i], TitleName[i]);
            Table.Rows.Add(Data.ToArray());
            Table.Columns[0].ReadOnly = true;
            this.Data = Data;
        }
        private void LoadImage(string Path) {
            Photo.Image = new Bitmap(Path);
        }
        private void LoadNewPhoto(object sender, EventArgs e){
            OpenFileDialog open = new OpenFileDialog() {
                Filter = "Image files(*.jpg)|"
            };
            if (open.ShowDialog() == DialogResult.OK) {
                Photo.Image = null;
                PathImage = "Image\\" + (NameTable=="Студент"?Data[0]:"P"+Data[0]) + ".jpg";
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Copy(open.FileName, PathImage, true);
                LoadImage("Image\\" + (NameTable=="Студент"?Data[0]:"P"+Data[0]) + ".jpg");
                Scripts.UpLoadScript(NameTable,"Фото","'"+PathImage+"'","Ід",Data[0]);
            }
        }
        private void DeletePhoto(object sender, EventArgs e){
            if(PathImage != "Image\\none.jpg"){
                Photo.Image = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(PathImage);
                PathImage = "Image\\none.jpg";
                LoadImage(PathImage);
                Scripts.UpLoadScript(NameTable, "Фото","'"+PathImage+"'", "Ід", Data[0]);
            }
        }
        private void SaveChange(object sender, EventArgs e){
            for (int i = 1; i < Table.Columns.Count; ++i){
                Scripts.UpLoadScript(
                    NameTable,
                    Table.Columns[i].HeaderText,
                    Adapter.GetUpDateString( Table.Rows[0].Cells[i].Value.ToString(), Table.Columns[i].HeaderText),
                    "Ід",
                    Table.Rows[0].Cells[0].Value.ToString()
                );
            }
        }

        private void DeleteUserBtnClick(object sender, EventArgs e){
            if (Scripts.DeleteScript(NameTable, Table.Columns[0].HeaderText, Table.Rows[0].Cells[0].Value.ToString())){
                this.Close();
                (Application.OpenForms[0].Controls["PagesPanel"] as TabControl).TabPages.RemoveByKey(NameTable);
                LoadTable.LoadPage(NameTable);
            }
        }
    }
}

