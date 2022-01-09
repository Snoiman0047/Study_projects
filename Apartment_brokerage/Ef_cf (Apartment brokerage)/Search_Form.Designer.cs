namespace Ef_cf__Apartment_brokerage_
{
    partial class Search_Form
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
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ByType = new System.Windows.Forms.ComboBox();
            this.ByCity = new System.Windows.Forms.TextBox();
            this.ByStreet = new System.Windows.Forms.TextBox();
            this.ByTz = new System.Windows.Forms.TextBox();
            this.byFurnitures = new System.Windows.Forms.CheckBox();
            this.ShowAll = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Delate = new System.Windows.Forms.Button();
            this.RentResults = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.ByPrice = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(39, 506);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(321, 40);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(826, 486);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.New_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search apartment\'s";
            // 
            // ByType
            // 
            this.ByType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByType.FormattingEnabled = true;
            this.ByType.Items.AddRange(new object[] {
            "All apartment\'s",
            "Apartment\'s for rent",
            "Apartment\'s for sale"});
            this.ByType.Location = new System.Drawing.Point(39, 128);
            this.ByType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ByType.Name = "ByType";
            this.ByType.Size = new System.Drawing.Size(321, 31);
            this.ByType.TabIndex = 3;
            this.ByType.Text = "Select type of apartment";
            // 
            // ByCity
            // 
            this.ByCity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByCity.Location = new System.Drawing.Point(39, 209);
            this.ByCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ByCity.Multiline = true;
            this.ByCity.Name = "ByCity";
            this.ByCity.Size = new System.Drawing.Size(142, 30);
            this.ByCity.TabIndex = 4;
            this.ByCity.Text = "Search by city";
            // 
            // ByStreet
            // 
            this.ByStreet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByStreet.Location = new System.Drawing.Point(218, 209);
            this.ByStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ByStreet.Multiline = true;
            this.ByStreet.Name = "ByStreet";
            this.ByStreet.Size = new System.Drawing.Size(142, 30);
            this.ByStreet.TabIndex = 5;
            this.ByStreet.Text = "Search by street";
            // 
            // ByTz
            // 
            this.ByTz.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByTz.Location = new System.Drawing.Point(39, 355);
            this.ByTz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ByTz.Multiline = true;
            this.ByTz.Name = "ByTz";
            this.ByTz.Size = new System.Drawing.Size(152, 33);
            this.ByTz.TabIndex = 7;
            this.ByTz.Text = "Search by owner tz";
            // 
            // byFurnitures
            // 
            this.byFurnitures.AutoSize = true;
            this.byFurnitures.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byFurnitures.Location = new System.Drawing.Point(39, 285);
            this.byFurnitures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byFurnitures.Name = "byFurnitures";
            this.byFurnitures.Size = new System.Drawing.Size(345, 24);
            this.byFurnitures.TabIndex = 8;
            this.byFurnitures.Text = "I want only apartment\'s for rent with furnitures";
            this.byFurnitures.UseVisualStyleBackColor = true;
            // 
            // ShowAll
            // 
            this.ShowAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAll.Location = new System.Drawing.Point(39, 556);
            this.ShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(85, 35);
            this.ShowAll.TabIndex = 9;
            this.ShowAll.Text = "Show all";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.Search_Click);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(159, 556);
            this.New.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(85, 35);
            this.New.TabIndex = 10;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Delate
            // 
            this.Delate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delate.Location = new System.Drawing.Point(275, 556);
            this.Delate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delate.Name = "Delate";
            this.Delate.Size = new System.Drawing.Size(85, 35);
            this.Delate.TabIndex = 11;
            this.Delate.Text = "Delate";
            this.Delate.UseVisualStyleBackColor = true;
            this.Delate.Click += new System.EventHandler(this.Delate_Click);
            // 
            // RentResults
            // 
            this.RentResults.AutoSize = true;
            this.RentResults.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentResults.Location = new System.Drawing.Point(422, 596);
            this.RentResults.Name = "RentResults";
            this.RentResults.Size = new System.Drawing.Size(0, 20);
            this.RentResults.TabIndex = 12;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(1175, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(77, 30);
            this.Refresh.TabIndex = 13;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ByPrice
            // 
            this.ByPrice.AutoSize = true;
            this.ByPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByPrice.Location = new System.Drawing.Point(39, 434);
            this.ByPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ByPrice.Name = "ByPrice";
            this.ByPrice.Size = new System.Drawing.Size(314, 44);
            this.ByPrice.TabIndex = 14;
            this.ByPrice.Text = "I want only  apartments that cost less than\r\n the general average";
            this.ByPrice.UseVisualStyleBackColor = true;
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 621);
            this.Controls.Add(this.ByPrice);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.RentResults);
            this.Controls.Add(this.Delate);
            this.Controls.Add(this.New);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.byFurnitures);
            this.Controls.Add(this.ByTz);
            this.Controls.Add(this.ByStreet);
            this.Controls.Add(this.ByCity);
            this.Controls.Add(this.ByType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ByType;
        private System.Windows.Forms.TextBox ByCity;
        private System.Windows.Forms.TextBox ByStreet;
        private System.Windows.Forms.TextBox ByTz;
        private System.Windows.Forms.CheckBox byFurnitures;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Delate;
        private System.Windows.Forms.Label RentResults;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.CheckBox ByPrice;
    }
}

