namespace Serving_exercise
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
            this.Profil_comboBox = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Topic_comboBox = new System.Windows.Forms.ComboBox();
            this.Lets_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delate = new System.Windows.Forms.Button();
            this.First_panel = new System.Windows.Forms.Panel();
            this.Techer_panel = new System.Windows.Forms.Panel();
            this.Question_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.American = new System.Windows.Forms.RadioButton();
            this.Regular = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.First_panel.SuspendLayout();
            this.Techer_panel.SuspendLayout();
            this.Question_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Profil_comboBox
            // 
            this.Profil_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Profil_comboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profil_comboBox.FormattingEnabled = true;
            this.Profil_comboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.Profil_comboBox.Location = new System.Drawing.Point(115, 71);
            this.Profil_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Profil_comboBox.Name = "Profil_comboBox";
            this.Profil_comboBox.Size = new System.Drawing.Size(192, 35);
            this.Profil_comboBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(18, 72);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 23);
            this.label.TabIndex = 2;
            this.label.Text = "Profile:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Topic:";
            // 
            // Topic_comboBox
            // 
            this.Topic_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Topic_comboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topic_comboBox.FormattingEnabled = true;
            this.Topic_comboBox.Location = new System.Drawing.Point(115, 139);
            this.Topic_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Topic_comboBox.Name = "Topic_comboBox";
            this.Topic_comboBox.Size = new System.Drawing.Size(192, 35);
            this.Topic_comboBox.TabIndex = 4;
            // 
            // Lets_start
            // 
            this.Lets_start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lets_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lets_start.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lets_start.ForeColor = System.Drawing.Color.Black;
            this.Lets_start.Location = new System.Drawing.Point(18, 243);
            this.Lets_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lets_start.Name = "Lets_start";
            this.Lets_start.Size = new System.Drawing.Size(292, 40);
            this.Lets_start.TabIndex = 5;
            this.Lets_start.Text = "let\'s start";
            this.Lets_start.UseVisualStyleBackColor = false;
            this.Lets_start.Click += new System.EventHandler(this.Lets_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(714, 318);
            this.dataGridView1.TabIndex = 7;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(38, 361);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(120, 27);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Location = new System.Drawing.Point(304, 361);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(120, 28);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delate
            // 
            this.Delate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delate.Location = new System.Drawing.Point(583, 361);
            this.Delate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delate.Name = "Delate";
            this.Delate.Size = new System.Drawing.Size(120, 28);
            this.Delate.TabIndex = 10;
            this.Delate.Text = "Delate";
            this.Delate.UseVisualStyleBackColor = false;
            this.Delate.Click += new System.EventHandler(this.Delate_Click);
            // 
            // First_panel
            // 
            this.First_panel.Controls.Add(this.Lets_start);
            this.First_panel.Controls.Add(this.label1);
            this.First_panel.Controls.Add(this.Profil_comboBox);
            this.First_panel.Controls.Add(this.Topic_comboBox);
            this.First_panel.Controls.Add(this.label);
            this.First_panel.Location = new System.Drawing.Point(12, 56);
            this.First_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.First_panel.Name = "First_panel";
            this.First_panel.Size = new System.Drawing.Size(333, 290);
            this.First_panel.TabIndex = 11;
            // 
            // Techer_panel
            // 
            this.Techer_panel.Controls.Add(this.dataGridView1);
            this.Techer_panel.Controls.Add(this.Delate);
            this.Techer_panel.Controls.Add(this.Edit);
            this.Techer_panel.Controls.Add(this.Add);
            this.Techer_panel.Location = new System.Drawing.Point(12, 372);
            this.Techer_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Techer_panel.Name = "Techer_panel";
            this.Techer_panel.Size = new System.Drawing.Size(744, 399);
            this.Techer_panel.TabIndex = 12;
            // 
            // Question_panel
            // 
            this.Question_panel.Controls.Add(this.button1);
            this.Question_panel.Controls.Add(this.American);
            this.Question_panel.Controls.Add(this.Regular);
            this.Question_panel.Location = new System.Drawing.Point(379, 129);
            this.Question_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Question_panel.Name = "Question_panel";
            this.Question_panel.Size = new System.Drawing.Size(314, 217);
            this.Question_panel.TabIndex = 13;
            this.Question_panel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click to Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // American
            // 
            this.American.AutoSize = true;
            this.American.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.American.Location = new System.Drawing.Point(34, 109);
            this.American.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.American.Name = "American";
            this.American.Size = new System.Drawing.Size(184, 27);
            this.American.TabIndex = 1;
            this.American.TabStop = true;
            this.American.Text = "American question";
            this.American.UseVisualStyleBackColor = true;
            // 
            // Regular
            // 
            this.Regular.AutoSize = true;
            this.Regular.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regular.Location = new System.Drawing.Point(34, 56);
            this.Regular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Regular.Name = "Regular";
            this.Regular.Size = new System.Drawing.Size(169, 27);
            this.Regular.TabIndex = 0;
            this.Regular.TabStop = true;
            this.Regular.Text = "Regular question";
            this.Regular.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(42, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Question_panel);
            this.Controls.Add(this.Techer_panel);
            this.Controls.Add(this.First_panel);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.First_panel.ResumeLayout(false);
            this.First_panel.PerformLayout();
            this.Techer_panel.ResumeLayout(false);
            this.Question_panel.ResumeLayout(false);
            this.Question_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Profil_comboBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Topic_comboBox;
        private System.Windows.Forms.Button Lets_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delate;
        private System.Windows.Forms.Panel First_panel;
        private System.Windows.Forms.Panel Techer_panel;
        private System.Windows.Forms.Panel Question_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton American;
        private System.Windows.Forms.RadioButton Regular;
        private System.Windows.Forms.Button button2;
    }
}

