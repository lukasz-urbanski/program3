using System;

namespace Program3.WFA
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
            this.label1 = new System.Windows.Forms.Label();
            this.LicznikiTextBox = new System.Windows.Forms.TextBox();
            this.OutputMaxValueTextBox = new System.Windows.Forms.TextBox();
            this.OutputIntervalTextBox = new System.Windows.Forms.TextBox();
            this.LicznikLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.WynikLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba";
            // 
            // LicznikiTextBox
            // 
            this.LicznikiTextBox.Location = new System.Drawing.Point(58, 13);
            this.LicznikiTextBox.Name = "LicznikiTextBox";
            this.LicznikiTextBox.Size = new System.Drawing.Size(100, 20);
            this.LicznikiTextBox.TabIndex = 1;
            // 
            // OutputMaxValueTextBox
            // 
            this.OutputMaxValueTextBox.Location = new System.Drawing.Point(419, 19);
            this.OutputMaxValueTextBox.Name = "OutputMaxValueTextBox";
            this.OutputMaxValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputMaxValueTextBox.TabIndex = 2;
            // 
            // OutputIntervalTextBox
            // 
            this.OutputIntervalTextBox.Location = new System.Drawing.Point(525, 19);
            this.OutputIntervalTextBox.Name = "OutputIntervalTextBox";
            this.OutputIntervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputIntervalTextBox.TabIndex = 3;
            // 
            // LicznikLabel
            // 
            this.LicznikLabel.AutoSize = true;
            this.LicznikLabel.Location = new System.Drawing.Point(378, 20);
            this.LicznikLabel.Name = "LicznikLabel";
            this.LicznikLabel.Size = new System.Drawing.Size(35, 13);
            this.LicznikLabel.TabIndex = 4;
            this.LicznikLabel.Text = "label2";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(175, 9);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "button1";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(632, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "button1";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // WynikLabel
            // 
            this.WynikLabel.AutoSize = true;
            this.WynikLabel.Location = new System.Drawing.Point(753, 428);
            this.WynikLabel.Name = "WynikLabel";
            this.WynikLabel.Size = new System.Drawing.Size(35, 13);
            this.WynikLabel.TabIndex = 5;
            this.WynikLabel.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(381, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 342);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.WynikLabel);
            this.Controls.Add(this.LicznikLabel);
            this.Controls.Add(this.OutputIntervalTextBox);
            this.Controls.Add(this.OutputMaxValueTextBox);
            this.Controls.Add(this.LicznikiTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LicznikiTextBox;
        private System.Windows.Forms.TextBox OutputMaxValueTextBox;
        private System.Windows.Forms.TextBox OutputIntervalTextBox;
        private System.Windows.Forms.Label LicznikLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label WynikLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

