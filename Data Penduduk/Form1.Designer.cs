namespace Data_Penduduk
{
    partial class Form1
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
            this.textName = new MetroFramework.Controls.MetroTextBox();
            this.textCity = new MetroFramework.Controls.MetroTextBox();
            this.textCountry = new MetroFramework.Controls.MetroTextBox();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.labelCity = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buttonInsert = new MetroFramework.Controls.MetroButton();
            this.buttonUpdate = new MetroFramework.Controls.MetroButton();
            this.buttonDelete = new MetroFramework.Controls.MetroButton();
            this.butttonSearch = new MetroFramework.Controls.MetroButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelID = new MetroFramework.Controls.MetroLabel();
            this.textID = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(124, 132);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(246, 23);
            this.textName.TabIndex = 0;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(124, 170);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(246, 23);
            this.textCity.TabIndex = 1;
            // 
            // textCountry
            // 
            this.textCountry.Location = new System.Drawing.Point(124, 208);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(246, 23);
            this.textCountry.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(52, 133);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            this.labelName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(52, 172);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(31, 19);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            this.labelCity.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 210);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Country";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(52, 249);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(133, 249);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(214, 249);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // butttonSearch
            // 
            this.butttonSearch.Location = new System.Drawing.Point(295, 249);
            this.butttonSearch.Name = "butttonSearch";
            this.butttonSearch.Size = new System.Drawing.Size(75, 23);
            this.butttonSearch.TabIndex = 9;
            this.butttonSearch.Text = "Search";
            this.butttonSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.butttonSearch.Click += new System.EventHandler(this.butttonSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(400, 96);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(291, 150);
            this.dataGridView.TabIndex = 10;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(52, 97);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 19);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "ID";
            this.labelID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(124, 96);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(246, 23);
            this.textID.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 295);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.butttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textCountry);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Citizen Database";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textName;
        private MetroFramework.Controls.MetroTextBox textCity;
        private MetroFramework.Controls.MetroTextBox textCountry;
        private MetroFramework.Controls.MetroLabel labelName;
        private MetroFramework.Controls.MetroLabel labelCity;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buttonInsert;
        private MetroFramework.Controls.MetroButton buttonUpdate;
        private MetroFramework.Controls.MetroButton buttonDelete;
        private MetroFramework.Controls.MetroButton butttonSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private MetroFramework.Controls.MetroLabel labelID;
        private MetroFramework.Controls.MetroTextBox textID;
    }
}

