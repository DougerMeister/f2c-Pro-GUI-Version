using System;

namespace f2c
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
            this.F2cButton = new System.Windows.Forms.Button();
            this.C2fButton = new System.Windows.Forms.Button();
            this.ProgramTitleLabel = new System.Windows.Forms.Label();
            this.FahrenheitLabel = new System.Windows.Forms.Label();
            this.CelsiusLabel = new System.Windows.Forms.Label();
            this.FahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.CelsiusTextBox = new System.Windows.Forms.TextBox();
            this.ConvertedTemp = new System.Windows.Forms.Label();
            this.ConvertedTempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // F2cButton
            // 
            this.F2cButton.Location = new System.Drawing.Point(255, 184);
            this.F2cButton.Name = "F2cButton";
            this.F2cButton.Size = new System.Drawing.Size(75, 23);
            this.F2cButton.TabIndex = 0;
            this.F2cButton.Text = "F2C";
            this.F2cButton.UseVisualStyleBackColor = true;
            this.F2cButton.Click += new System.EventHandler(this.F2cButton_Click);
            // 
            // C2fButton
            // 
            this.C2fButton.Location = new System.Drawing.Point(255, 229);
            this.C2fButton.Name = "C2fButton";
            this.C2fButton.Size = new System.Drawing.Size(75, 23);
            this.C2fButton.TabIndex = 1;
            this.C2fButton.Text = "C2F";
            this.C2fButton.UseVisualStyleBackColor = true;
            this.C2fButton.Click += new System.EventHandler(this.C2fButton_Click);
            // 
            // ProgramTitleLabel
            // 
            this.ProgramTitleLabel.AutoSize = true;
            this.ProgramTitleLabel.Location = new System.Drawing.Point(328, 25);
            this.ProgramTitleLabel.Name = "ProgramTitleLabel";
            this.ProgramTitleLabel.Size = new System.Drawing.Size(149, 13);
            this.ProgramTitleLabel.TabIndex = 2;
            this.ProgramTitleLabel.Text = "F2C and C2F Conversion Tool";
            // 
            // FahrenheitLabel
            // 
            this.FahrenheitLabel.AutoSize = true;
            this.FahrenheitLabel.Location = new System.Drawing.Point(73, 187);
            this.FahrenheitLabel.Name = "FahrenheitLabel";
            this.FahrenheitLabel.Size = new System.Drawing.Size(57, 13);
            this.FahrenheitLabel.TabIndex = 3;
            this.FahrenheitLabel.Text = "Fahrenheit";
            // 
            // CelsiusLabel
            // 
            this.CelsiusLabel.AutoSize = true;
            this.CelsiusLabel.Location = new System.Drawing.Point(73, 229);
            this.CelsiusLabel.Name = "CelsiusLabel";
            this.CelsiusLabel.Size = new System.Drawing.Size(40, 13);
            this.CelsiusLabel.TabIndex = 4;
            this.CelsiusLabel.Text = "Celsius";
            // 
            // FahrenheitTextBox
            // 
            this.FahrenheitTextBox.Location = new System.Drawing.Point(136, 184);
            this.FahrenheitTextBox.Name = "FahrenheitTextBox";
            this.FahrenheitTextBox.Size = new System.Drawing.Size(100, 20);
            this.FahrenheitTextBox.TabIndex = 5;
            this.FahrenheitTextBox.Text = "0";
            this.FahrenheitTextBox.TextChanged += new System.EventHandler(this.FahrenheitTextBox_TextChanged);
            // 
            // CelsiusTextBox
            // 
            this.CelsiusTextBox.Location = new System.Drawing.Point(136, 229);
            this.CelsiusTextBox.Name = "CelsiusTextBox";
            this.CelsiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.CelsiusTextBox.TabIndex = 6;
            this.CelsiusTextBox.Text = "0";
            // 
            // ConvertedTemp
            // 
            this.ConvertedTemp.AutoSize = true;
            this.ConvertedTemp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConvertedTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConvertedTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.25F);
            this.ConvertedTemp.ForeColor = System.Drawing.Color.Black;
            this.ConvertedTemp.Location = new System.Drawing.Point(442, 101);
            this.ConvertedTemp.MinimumSize = new System.Drawing.Size(250, 250);
            this.ConvertedTemp.Name = "ConvertedTemp";
            this.ConvertedTemp.Size = new System.Drawing.Size(250, 250);
            this.ConvertedTemp.TabIndex = 7;
            this.ConvertedTemp.Text = "0.0";
            this.ConvertedTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvertedTempLabel
            // 
            this.ConvertedTempLabel.AutoSize = true;
            this.ConvertedTempLabel.Location = new System.Drawing.Point(500, 78);
            this.ConvertedTempLabel.Name = "ConvertedTempLabel";
            this.ConvertedTempLabel.Size = new System.Drawing.Size(119, 13);
            this.ConvertedTempLabel.TabIndex = 8;
            this.ConvertedTempLabel.Text = "Converted Temperature";
            this.ConvertedTempLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConvertedTempLabel);
            this.Controls.Add(this.ConvertedTemp);
            this.Controls.Add(this.CelsiusTextBox);
            this.Controls.Add(this.FahrenheitTextBox);
            this.Controls.Add(this.CelsiusLabel);
            this.Controls.Add(this.FahrenheitLabel);
            this.Controls.Add(this.ProgramTitleLabel);
            this.Controls.Add(this.C2fButton);
            this.Controls.Add(this.F2cButton);
            this.Name = "Form1";
            this.Text = "F2C Conversion Tool (Pro-Gui Version)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button F2cButton;
        private System.Windows.Forms.Button C2fButton;
        private System.Windows.Forms.Label ProgramTitleLabel;
        private System.Windows.Forms.Label FahrenheitLabel;
        private System.Windows.Forms.Label CelsiusLabel;
        private System.Windows.Forms.TextBox FahrenheitTextBox;
        private System.Windows.Forms.TextBox CelsiusTextBox;
        private System.Windows.Forms.Label ConvertedTemp;
        private System.Windows.Forms.Label ConvertedTempLabel;



        /** My Custom Code **/




        /* End My Custom Code */


    }
}

