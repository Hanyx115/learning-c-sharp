﻿namespace Electronics_store
{
    partial class checkout
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "CASH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "VISA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "checkout";
            this.Text = "checkout";
            this.Load += new System.EventHandler(this.checkout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}