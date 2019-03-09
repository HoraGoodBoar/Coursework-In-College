namespace Hostel
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.PhotoBtn = new System.Windows.Forms.Button();
            this.DeletePhotoBtn = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(663, 413);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(138, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Зберегти";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveChange);
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(197, 12);
            this.Table.Name = "Table";
            this.Table.RowHeadersVisible = false;
            this.Table.Size = new System.Drawing.Size(604, 395);
            this.Table.TabIndex = 0;
            // 
            // PhotoBtn
            // 
            this.PhotoBtn.Location = new System.Drawing.Point(28, 232);
            this.PhotoBtn.Name = "PhotoBtn";
            this.PhotoBtn.Size = new System.Drawing.Size(138, 23);
            this.PhotoBtn.TabIndex = 1;
            this.PhotoBtn.Text = "Загрузити нове фото";
            this.PhotoBtn.UseVisualStyleBackColor = true;
            this.PhotoBtn.Click += new System.EventHandler(this.LoadNewPhoto);
            // 
            // DeletePhotoBtn
            // 
            this.DeletePhotoBtn.Location = new System.Drawing.Point(28, 261);
            this.DeletePhotoBtn.Name = "DeletePhotoBtn";
            this.DeletePhotoBtn.Size = new System.Drawing.Size(138, 23);
            this.DeletePhotoBtn.TabIndex = 2;
            this.DeletePhotoBtn.Text = "Видалити";
            this.DeletePhotoBtn.UseVisualStyleBackColor = true;
            this.DeletePhotoBtn.Click += new System.EventHandler(this.DeletePhoto);
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Photo.Location = new System.Drawing.Point(12, 12);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(168, 214);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Location = new System.Drawing.Point(28, 290);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(138, 23);
            this.DeleteUserBtn.TabIndex = 5;
            this.DeleteUserBtn.Text = "Видалити профіль";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtnClick);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 448);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.DeletePhotoBtn);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.PhotoBtn);
            this.Controls.Add(this.SaveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(829, 487);
            this.MinimumSize = new System.Drawing.Size(829, 487);
            this.Name = "EditForm";
            this.Text = "Вікно редагування";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button PhotoBtn;
        private System.Windows.Forms.Button DeletePhotoBtn;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button DeleteUserBtn;
    }
}