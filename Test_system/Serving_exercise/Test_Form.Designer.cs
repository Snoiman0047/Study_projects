namespace Serving_exercise
{
    partial class Test_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.Regular_Panel = new System.Windows.Forms.Panel();
            this.Answer_text = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.American_Panel = new System.Windows.Forms.Panel();
            this.Sol_3 = new System.Windows.Forms.RadioButton();
            this.Sol_2 = new System.Windows.Forms.RadioButton();
            this.Sol_1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Regular_Panel.SuspendLayout();
            this.American_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(106, 211);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(134, 38);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Question
            // 
            this.Question.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(82, 148);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(97, 27);
            this.Question.TabIndex = 2;
            this.Question.Text = "Question";
            this.Question.Visible = false;
            // 
            // Regular_Panel
            // 
            this.Regular_Panel.Controls.Add(this.Answer_text);
            this.Regular_Panel.Location = new System.Drawing.Point(30, 193);
            this.Regular_Panel.Name = "Regular_Panel";
            this.Regular_Panel.Size = new System.Drawing.Size(299, 68);
            this.Regular_Panel.TabIndex = 3;
            this.Regular_Panel.Visible = false;
            // 
            // Answer_text
            // 
            this.Answer_text.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_text.Location = new System.Drawing.Point(16, 15);
            this.Answer_text.Multiline = true;
            this.Answer_text.Name = "Answer_text";
            this.Answer_text.Size = new System.Drawing.Size(265, 41);
            this.Answer_text.TabIndex = 0;
            this.Answer_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(240, 402);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(89, 33);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.Location = new System.Drawing.Point(21, 402);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(89, 33);
            this.Finish.TabIndex = 5;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Visible = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // American_Panel
            // 
            this.American_Panel.Controls.Add(this.Sol_3);
            this.American_Panel.Controls.Add(this.Sol_2);
            this.American_Panel.Controls.Add(this.Sol_1);
            this.American_Panel.Location = new System.Drawing.Point(30, 285);
            this.American_Panel.Name = "American_Panel";
            this.American_Panel.Size = new System.Drawing.Size(299, 102);
            this.American_Panel.TabIndex = 1;
            this.American_Panel.Visible = false;
            // 
            // Sol_3
            // 
            this.Sol_3.AutoSize = true;
            this.Sol_3.Location = new System.Drawing.Point(36, 74);
            this.Sol_3.Name = "Sol_3";
            this.Sol_3.Size = new System.Drawing.Size(17, 16);
            this.Sol_3.TabIndex = 2;
            this.Sol_3.TabStop = true;
            this.Sol_3.UseVisualStyleBackColor = true;
            // 
            // Sol_2
            // 
            this.Sol_2.AutoSize = true;
            this.Sol_2.Location = new System.Drawing.Point(36, 45);
            this.Sol_2.Name = "Sol_2";
            this.Sol_2.Size = new System.Drawing.Size(17, 16);
            this.Sol_2.TabIndex = 1;
            this.Sol_2.TabStop = true;
            this.Sol_2.UseVisualStyleBackColor = true;
            // 
            // Sol_1
            // 
            this.Sol_1.AutoSize = true;
            this.Sol_1.Location = new System.Drawing.Point(36, 15);
            this.Sol_1.Name = "Sol_1";
            this.Sol_1.Size = new System.Drawing.Size(17, 16);
            this.Sol_1.TabIndex = 0;
            this.Sol_1.TabStop = true;
            this.Sol_1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.American_Panel);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Regular_Panel);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Test_Form";
            this.Text = "Test_Form";
            this.Regular_Panel.ResumeLayout(false);
            this.Regular_Panel.PerformLayout();
            this.American_Panel.ResumeLayout(false);
            this.American_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Panel Regular_Panel;
        private System.Windows.Forms.TextBox Answer_text;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Panel American_Panel;
        private System.Windows.Forms.RadioButton Sol_3;
        private System.Windows.Forms.RadioButton Sol_2;
        private System.Windows.Forms.RadioButton Sol_1;
        private System.Windows.Forms.Label label2;
    }
}