namespace DLayer
{
    partial class Import_Value_input
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
            this.Chemical_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Import_Volume_txtbox = new System.Windows.Forms.TextBox();
            this.Average_Price_txtbox = new System.Windows.Forms.TextBox();
            this.Dollar_Price_txtbox = new System.Windows.Forms.TextBox();
            this.Import_Year_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chemical_combo
            // 
            this.Chemical_combo.FormattingEnabled = true;
            this.Chemical_combo.Location = new System.Drawing.Point(552, 61);
            this.Chemical_combo.Name = "Chemical_combo";
            this.Chemical_combo.Size = new System.Drawing.Size(121, 21);
            this.Chemical_combo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ماده:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "حجم واردات:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "قیمت میانگین:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ارزش دلاری:";
            // 
            // Import_Volume_txtbox
            // 
            this.Import_Volume_txtbox.Location = new System.Drawing.Point(552, 114);
            this.Import_Volume_txtbox.Name = "Import_Volume_txtbox";
            this.Import_Volume_txtbox.Size = new System.Drawing.Size(121, 20);
            this.Import_Volume_txtbox.TabIndex = 7;
            // 
            // Average_Price_txtbox
            // 
            this.Average_Price_txtbox.Location = new System.Drawing.Point(552, 168);
            this.Average_Price_txtbox.Name = "Average_Price_txtbox";
            this.Average_Price_txtbox.Size = new System.Drawing.Size(121, 20);
            this.Average_Price_txtbox.TabIndex = 8;
            // 
            // Dollar_Price_txtbox
            // 
            this.Dollar_Price_txtbox.Location = new System.Drawing.Point(552, 218);
            this.Dollar_Price_txtbox.Name = "Dollar_Price_txtbox";
            this.Dollar_Price_txtbox.Size = new System.Drawing.Size(121, 20);
            this.Dollar_Price_txtbox.TabIndex = 9;
            // 
            // Import_Year_txtbox
            // 
            this.Import_Year_txtbox.Location = new System.Drawing.Point(552, 263);
            this.Import_Year_txtbox.Name = "Import_Year_txtbox";
            this.Import_Year_txtbox.Size = new System.Drawing.Size(121, 20);
            this.Import_Year_txtbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "سال واردات:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(578, 322);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "تایید";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 13;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Import_Value_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Import_Year_txtbox);
            this.Controls.Add(this.Dollar_Price_txtbox);
            this.Controls.Add(this.Average_Price_txtbox);
            this.Controls.Add(this.Import_Volume_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chemical_combo);
            this.Name = "Import_Value_input";
            this.Text = "واردات";
            this.Load += new System.EventHandler(this.Import_Value_input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Chemical_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Import_Volume_txtbox;
        private System.Windows.Forms.TextBox Average_Price_txtbox;
        private System.Windows.Forms.TextBox Dollar_Price_txtbox;
        private System.Windows.Forms.TextBox Import_Year_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button1;
    }
}