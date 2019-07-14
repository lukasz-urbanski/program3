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
            this.AmountOfCountersLabel = new System.Windows.Forms.Label();
            this.LicznikiTextBox = new System.Windows.Forms.TextBox();
            this.GenerateCountersButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.TypeOfCounterGroupBox = new System.Windows.Forms.GroupBox();
            this.DigitRadioButton = new System.Windows.Forms.RadioButton();
            this.TextRadioButton = new System.Windows.Forms.RadioButton();
            this.ThreadsListBox = new System.Windows.Forms.ListBox();
            this.RomanRadioButton = new System.Windows.Forms.RadioButton();
            this.TypeOfCounterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AmountOfCountersLabel
            // 
            this.AmountOfCountersLabel.AutoSize = true;
            this.AmountOfCountersLabel.Location = new System.Drawing.Point(13, 13);
            this.AmountOfCountersLabel.Name = "AmountOfCountersLabel";
            this.AmountOfCountersLabel.Size = new System.Drawing.Size(87, 13);
            this.AmountOfCountersLabel.TabIndex = 0;
            this.AmountOfCountersLabel.Text = "Liczba liczników:";
            // 
            // LicznikiTextBox
            // 
            this.LicznikiTextBox.Location = new System.Drawing.Point(106, 10);
            this.LicznikiTextBox.Name = "LicznikiTextBox";
            this.LicznikiTextBox.Size = new System.Drawing.Size(40, 20);
            this.LicznikiTextBox.TabIndex = 1;
            // 
            // GenerateCountersButton
            // 
            this.GenerateCountersButton.Location = new System.Drawing.Point(16, 48);
            this.GenerateCountersButton.Name = "GenerateCountersButton";
            this.GenerateCountersButton.Size = new System.Drawing.Size(119, 23);
            this.GenerateCountersButton.TabIndex = 6;
            this.GenerateCountersButton.Text = "Generuj liczniki";
            this.GenerateCountersButton.UseVisualStyleBackColor = true;
            this.GenerateCountersButton.Click += new System.EventHandler(this.GenerateCountersButton_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(248, 13);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(74, 13);
            this.ProgressLabel.TabIndex = 5;
            this.ProgressLabel.Text = "ProgressLabel";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(16, 85);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(119, 23);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TypeOfCounterGroupBox
            // 
            this.TypeOfCounterGroupBox.Controls.Add(this.RomanRadioButton);
            this.TypeOfCounterGroupBox.Controls.Add(this.DigitRadioButton);
            this.TypeOfCounterGroupBox.Controls.Add(this.TextRadioButton);
            this.TypeOfCounterGroupBox.Location = new System.Drawing.Point(152, 10);
            this.TypeOfCounterGroupBox.Name = "TypeOfCounterGroupBox";
            this.TypeOfCounterGroupBox.Size = new System.Drawing.Size(90, 98);
            this.TypeOfCounterGroupBox.TabIndex = 9;
            this.TypeOfCounterGroupBox.TabStop = false;
            this.TypeOfCounterGroupBox.Text = "Rodaj licznika";
            // 
            // DigitRadioButton
            // 
            this.DigitRadioButton.AutoSize = true;
            this.DigitRadioButton.Checked = true;
            this.DigitRadioButton.Location = new System.Drawing.Point(7, 44);
            this.DigitRadioButton.Name = "DigitRadioButton";
            this.DigitRadioButton.Size = new System.Drawing.Size(65, 17);
            this.DigitRadioButton.TabIndex = 1;
            this.DigitRadioButton.TabStop = true;
            this.DigitRadioButton.Text = "liczbowy";
            this.DigitRadioButton.UseVisualStyleBackColor = true;
            // 
            // TextRadioButton
            // 
            this.TextRadioButton.AutoSize = true;
            this.TextRadioButton.Location = new System.Drawing.Point(7, 20);
            this.TextRadioButton.Name = "TextRadioButton";
            this.TextRadioButton.Size = new System.Drawing.Size(67, 17);
            this.TextRadioButton.TabIndex = 0;
            this.TextRadioButton.TabStop = true;
            this.TextRadioButton.Text = "tekstowy";
            this.TextRadioButton.UseVisualStyleBackColor = true;
            // 
            // ThreadsListBox
            // 
            this.ThreadsListBox.FormattingEnabled = true;
            this.ThreadsListBox.Location = new System.Drawing.Point(374, 10);
            this.ThreadsListBox.Name = "ThreadsListBox";
            this.ThreadsListBox.Size = new System.Drawing.Size(100, 342);
            this.ThreadsListBox.TabIndex = 10;
            // 
            // RomanRadioButton
            // 
            this.RomanRadioButton.AutoSize = true;
            this.RomanRadioButton.Location = new System.Drawing.Point(7, 68);
            this.RomanRadioButton.Name = "RomanRadioButton";
            this.RomanRadioButton.Size = new System.Drawing.Size(59, 17);
            this.RomanRadioButton.TabIndex = 2;
            this.RomanRadioButton.TabStop = true;
            this.RomanRadioButton.Text = "rzymski";
            this.RomanRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThreadsListBox);
            this.Controls.Add(this.TypeOfCounterGroupBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GenerateCountersButton);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.LicznikiTextBox);
            this.Controls.Add(this.AmountOfCountersLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TypeOfCounterGroupBox.ResumeLayout(false);
            this.TypeOfCounterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmountOfCountersLabel;
        private System.Windows.Forms.TextBox LicznikiTextBox;
        private System.Windows.Forms.Button GenerateCountersButton;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox TypeOfCounterGroupBox;
        private System.Windows.Forms.RadioButton DigitRadioButton;
        private System.Windows.Forms.RadioButton TextRadioButton;
        private System.Windows.Forms.ListBox ThreadsListBox;
        private System.Windows.Forms.RadioButton RomanRadioButton;
    }
}

