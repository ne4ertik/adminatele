﻿namespace atele_admin1
{
    partial class SearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.button_1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbStr);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(688, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите Имя, Фамилию или номер телефона";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(29, 46);
            this.tbStr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(601, 22);
            this.tbStr.TabIndex = 1;
            this.tbStr.TextChanged += new System.EventHandler(this.tbStr_TextChanged);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(41, 142);
            this.button_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(151, 50);
            this.button_1.TabIndex = 1;
            this.button_1.Text = "Найти";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(727, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button2;
    }
}