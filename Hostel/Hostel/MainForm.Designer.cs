namespace Hostel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PagesPanel = new System.Windows.Forms.TabControl();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.Views = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interiorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FreePlacesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotPaitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ValuesParametr = new System.Windows.Forms.TextBox();
            this.ChoiceParametr = new System.Windows.Forms.ComboBox();
            this.обслуговуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagesPanel
            // 
            this.PagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagesPanel.Location = new System.Drawing.Point(0, 24);
            this.PagesPanel.Name = "PagesPanel";
            this.PagesPanel.SelectedIndex = 0;
            this.PagesPanel.Size = new System.Drawing.Size(800, 426);
            this.PagesPanel.TabIndex = 0;
            this.PagesPanel.Selected += new System.Windows.Forms.TabControlEventHandler(this.SelectPage);
            this.PagesPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelKeyUp);
            // 
            // TopMenu
            // 
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Views,
            this.refrechToolStripMenuItem,
            this.FreePlacesMenuItem,
            this.NotPaitMenuItem,
            this.допомогаToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(800, 24);
            this.TopMenu.TabIndex = 1;
            this.TopMenu.Text = "menuStrip1";
            // 
            // Views
            // 
            this.Views.CheckOnClick = true;
            this.Views.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.studentToolStripMenuItem1,
            this.workersToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.interiorToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.floorToolStripMenuItem,
            this.обслуговуванняToolStripMenuItem});
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(63, 20);
            this.Views.Text = "Таблиці";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Checked = true;
            this.studentToolStripMenuItem.CheckOnClick = true;
            this.studentToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentToolStripMenuItem.Text = "Гуртожиток";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.ViewsClick);
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Checked = true;
            this.studentToolStripMenuItem1.CheckOnClick = true;
            this.studentToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.studentToolStripMenuItem1.Text = "Студент";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.ViewsClick);
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Checked = true;
            this.workersToolStripMenuItem.CheckOnClick = true;
            this.workersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workersToolStripMenuItem.Text = "Працівник";
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.ViewsClick);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Checked = true;
            this.roomToolStripMenuItem.CheckOnClick = true;
            this.roomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomToolStripMenuItem.Text = "Кімната";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.ViewsClick);
            // 
            // interiorToolStripMenuItem
            // 
            this.interiorToolStripMenuItem.Checked = true;
            this.interiorToolStripMenuItem.CheckOnClick = true;
            this.interiorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.interiorToolStripMenuItem.Name = "interiorToolStripMenuItem";
            this.interiorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.interiorToolStripMenuItem.Text = "Інтерєр";
            this.interiorToolStripMenuItem.Click += new System.EventHandler(this.ViewsClick);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Checked = true;
            this.positionToolStripMenuItem.CheckOnClick = true;
            this.positionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.positionToolStripMenuItem.Text = "Посада";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.ViewsClick);
            // 
            // floorToolStripMenuItem
            // 
            this.floorToolStripMenuItem.Checked = true;
            this.floorToolStripMenuItem.CheckOnClick = true;
            this.floorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.floorToolStripMenuItem.Name = "floorToolStripMenuItem";
            this.floorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.floorToolStripMenuItem.Text = "Поверх";
            this.floorToolStripMenuItem.Click += new System.EventHandler(this.ViewsClick);
            // 
            // refrechToolStripMenuItem
            // 
            this.refrechToolStripMenuItem.Name = "refrechToolStripMenuItem";
            this.refrechToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.refrechToolStripMenuItem.Text = "Обновити";
            this.refrechToolStripMenuItem.Click += new System.EventHandler(this.RefrechTable);
            // 
            // FreePlacesMenuItem
            // 
            this.FreePlacesMenuItem.Name = "FreePlacesMenuItem";
            this.FreePlacesMenuItem.Size = new System.Drawing.Size(86, 20);
            this.FreePlacesMenuItem.Text = "Вільні місця";
            this.FreePlacesMenuItem.Click += new System.EventHandler(this.FreePlacesShow);
            // 
            // NotPaitMenuItem
            // 
            this.NotPaitMenuItem.Name = "NotPaitMenuItem";
            this.NotPaitMenuItem.Size = new System.Drawing.Size(105, 20);
            this.NotPaitMenuItem.Text = "Не проплачено";
            this.NotPaitMenuItem.Click += new System.EventHandler(this.NoPaidMenuItemClick);
            // 
            // ValuesParametr
            // 
            this.ValuesParametr.Location = new System.Drawing.Point(589, 4);
            this.ValuesParametr.Name = "ValuesParametr";
            this.ValuesParametr.Size = new System.Drawing.Size(211, 20);
            this.ValuesParametr.TabIndex = 2;
            this.ValuesParametr.TextChanged += new System.EventHandler(this.SearchTxtBox);
            // 
            // ChoiceParametr
            // 
            this.ChoiceParametr.FormattingEnabled = true;
            this.ChoiceParametr.Location = new System.Drawing.Point(411, 3);
            this.ChoiceParametr.Name = "ChoiceParametr";
            this.ChoiceParametr.Size = new System.Drawing.Size(172, 21);
            this.ChoiceParametr.TabIndex = 3;
            // 
            // обслуговуванняToolStripMenuItem
            // 
            this.обслуговуванняToolStripMenuItem.Checked = true;
            this.обслуговуванняToolStripMenuItem.CheckOnClick = true;
            this.обслуговуванняToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.обслуговуванняToolStripMenuItem.Name = "обслуговуванняToolStripMenuItem";
            this.обслуговуванняToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обслуговуванняToolStripMenuItem.Text = "Обслуговування";
            this.обслуговуванняToolStripMenuItem.Click += new System.EventHandler(this.ViewsClick);
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            this.допомогаToolStripMenuItem.Click += new System.EventHandler(this.HelpBtn);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChoiceParametr);
            this.Controls.Add(this.ValuesParametr);
            this.Controls.Add(this.PagesPanel);
            this.Controls.Add(this.TopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Гуртожиток";
            this.Load += new System.EventHandler(this.Start);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TabControl PagesPanel;
        public System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem Views;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interiorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FreePlacesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotPaitMenuItem;
        private System.Windows.Forms.TextBox ValuesParametr;
        private System.Windows.Forms.ComboBox ChoiceParametr;
        private System.Windows.Forms.ToolStripMenuItem обслуговуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
    }
}

