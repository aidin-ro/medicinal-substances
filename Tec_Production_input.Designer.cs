namespace Studies_of_medicinal_substances
{
    partial class Tec_Production_input
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
            this.Submit = new System.Windows.Forms.Button();
            this.Chemical_combo = new System.Windows.Forms.ComboBox();
            this.Tec_combo = new System.Windows.Forms.ComboBox();
            this.Tec_input = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(569, 272);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "تایید";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Chemical_combo
            // 
            this.Chemical_combo.FormattingEnabled = true;
            this.Chemical_combo.Location = new System.Drawing.Point(546, 191);
            this.Chemical_combo.Name = "Chemical_combo";
            this.Chemical_combo.Size = new System.Drawing.Size(121, 21);
            this.Chemical_combo.TabIndex = 2;
            // 
            // Tec_combo
            // 
            this.Tec_combo.FormattingEnabled = true;
            this.Tec_combo.Location = new System.Drawing.Point(546, 129);
            this.Tec_combo.Name = "Tec_combo";
            this.Tec_combo.Size = new System.Drawing.Size(121, 21);
            this.Tec_combo.TabIndex = 3;
            // 
            // Tec_input
            // 
            this.Tec_input.AutoSize = true;
            this.Tec_input.Location = new System.Drawing.Point(429, 136);
            this.Tec_input.Name = "Tec_input";
            this.Tec_input.Size = new System.Drawing.Size(55, 13);
            this.Tec_input.TabIndex = 4;
            this.Tec_input.Text = "تکنولوژِی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ماده تولیدی:";
            // 
            // Tec_Production_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tec_input);
            this.Controls.Add(this.Tec_combo);
            this.Controls.Add(this.Chemical_combo);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.button1);
            this.Name = "Tec_Production_input";
            this.Text = "Tec_Production_input";
            this.Load += new System.EventHandler(this.Tec_Production_input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox Chemical_combo;
        private System.Windows.Forms.ComboBox Tec_combo;
        private System.Windows.Forms.Label Tec_input;
        private System.Windows.Forms.Label label2;
    }
}