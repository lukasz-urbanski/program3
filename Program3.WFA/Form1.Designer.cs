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
            this.WynikLabel = new System.Windows.Forms.Label();
            this.LicznikLabel = new System.Windows.Forms.Label();
            this.OutputMaxValueTextBox = new System.Windows.Forms.TextBox();
            this.OutputIntervalTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TypeOfCounterGroupBox = new System.Windows.Forms.GroupBox();
            this.DigitRadioButton = new System.Windows.Forms.RadioButton();
            this.TextRadioButton = new System.Windows.Forms.RadioButton();
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
            // WynikLabel
            // 
            this.WynikLabel.AutoSize = true;
            this.WynikLabel.Location = new System.Drawing.Point(753, 428);
            this.WynikLabel.Name = "WynikLabel";
            this.WynikLabel.Size = new System.Drawing.Size(35, 13);
            this.WynikLabel.TabIndex = 5;
            this.WynikLabel.Text = "label2";
            // 
            // LicznikLabel
            // 
            this.LicznikLabel.AutoSize = true;
            this.LicznikLabel.Location = new System.Drawing.Point(459, 315);
            this.LicznikLabel.Name = "LicznikLabel";
            this.LicznikLabel.Size = new System.Drawing.Size(35, 13);
            this.LicznikLabel.TabIndex = 4;
            this.LicznikLabel.Text = "label2";
            // 
            // OutputMaxValueTextBox
            // 
            this.OutputMaxValueTextBox.Location = new System.Drawing.Point(500, 314);
            this.OutputMaxValueTextBox.Name = "OutputMaxValueTextBox";
            this.OutputMaxValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputMaxValueTextBox.TabIndex = 2;
            // 
            // OutputIntervalTextBox
            // 
            this.OutputIntervalTextBox.Location = new System.Drawing.Point(606, 314);
            this.OutputIntervalTextBox.Name = "OutputIntervalTextBox";
            this.OutputIntervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputIntervalTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(713, 310);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "button1";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TypeOfCounterGroupBox
            // 
            this.TypeOfCounterGroupBox.Controls.Add(this.DigitRadioButton);
            this.TypeOfCounterGroupBox.Controls.Add(this.TextRadioButton);
            this.TypeOfCounterGroupBox.Location = new System.Drawing.Point(152, 10);
            this.TypeOfCounterGroupBox.Name = "TypeOfCounterGroupBox";
            this.TypeOfCounterGroupBox.Size = new System.Drawing.Size(90, 70);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeOfCounterGroupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.GenerateCountersButton);
            this.Controls.Add(this.WynikLabel);
            this.Controls.Add(this.LicznikLabel);
            this.Controls.Add(this.OutputIntervalTextBox);
            this.Controls.Add(this.OutputMaxValueTextBox);
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
        private System.Windows.Forms.Label WynikLabel;
        private System.Windows.Forms.Label LicznikLabel;
        private System.Windows.Forms.TextBox OutputMaxValueTextBox;
        private System.Windows.Forms.TextBox OutputIntervalTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox TypeOfCounterGroupBox;
        private System.Windows.Forms.RadioButton DigitRadioButton;
        private System.Windows.Forms.RadioButton TextRadioButton;
    }
}

