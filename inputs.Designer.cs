namespace Studies_of_medicinal_substances
{
    partial class inputs
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
            this.Chemical_input_btn = new System.Windows.Forms.Button();
            this.Companies_input_btn = new System.Windows.Forms.Button();
            this.Consumer_input_btn = new System.Windows.Forms.Button();
            this.Constituent_Chemicals_input_btn = new System.Windows.Forms.Button();
            this.Manufacturing_Companies_input_btn = new System.Windows.Forms.Button();
            this.Tec_input_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chemical_input_btn
            // 
            this.Chemical_input_btn.Location = new System.Drawing.Point(44, 43);
            this.Chemical_input_btn.Name = "Chemical_input_btn";
            this.Chemical_input_btn.Size = new System.Drawing.Size(123, 71);
            this.Chemical_input_btn.TabIndex = 0;
            this.Chemical_input_btn.Text = "افزودن ماده";
            this.Chemical_input_btn.UseVisualStyleBackColor = true;
            this.Chemical_input_btn.Click += new System.EventHandler(this.Chemical_input_btn_Click);
            // 
            // Companies_input_btn
            // 
            this.Companies_input_btn.Location = new System.Drawing.Point(189, 43);
            this.Companies_input_btn.Name = "Companies_input_btn";
            this.Companies_input_btn.Size = new System.Drawing.Size(123, 71);
            this.Companies_input_btn.TabIndex = 1;
            this.Companies_input_btn.Text = "افزودن شرکت";
            this.Companies_input_btn.UseVisualStyleBackColor = true;
            this.Companies_input_btn.Click += new System.EventHandler(this.Companies_input_btn_Click);
            // 
            // Consumer_input_btn
            // 
            this.Consumer_input_btn.Location = new System.Drawing.Point(335, 43);
            this.Consumer_input_btn.Name = "Consumer_input_btn";
            this.Consumer_input_btn.Size = new System.Drawing.Size(123, 71);
            this.Consumer_input_btn.TabIndex = 2;
            this.Consumer_input_btn.Text = "افزودن مشتری";
            this.Consumer_input_btn.UseVisualStyleBackColor = true;
            this.Consumer_input_btn.Click += new System.EventHandler(this.Consumer_input_btn_Click);
            // 
            // Constituent_Chemicals_input_btn
            // 
            this.Constituent_Chemicals_input_btn.Location = new System.Drawing.Point(473, 43);
            this.Constituent_Chemicals_input_btn.Name = "Constituent_Chemicals_input_btn";
            this.Constituent_Chemicals_input_btn.Size = new System.Drawing.Size(123, 71);
            this.Constituent_Chemicals_input_btn.TabIndex = 3;
            this.Constituent_Chemicals_input_btn.Text = "افزودن مواد تشکیل دهنده";
            this.Constituent_Chemicals_input_btn.UseVisualStyleBackColor = true;
            this.Constituent_Chemicals_input_btn.Click += new System.EventHandler(this.Constituent_Chemicals_input_btn_Click);
            // 
            // Manufacturing_Companies_input_btn
            // 
            this.Manufacturing_Companies_input_btn.Location = new System.Drawing.Point(616, 43);
            this.Manufacturing_Companies_input_btn.Name = "Manufacturing_Companies_input_btn";
            this.Manufacturing_Companies_input_btn.Size = new System.Drawing.Size(123, 71);
            this.Manufacturing_Companies_input_btn.TabIndex = 4;
            this.Manufacturing_Companies_input_btn.Text = "افزودن تولید کننده";
            this.Manufacturing_Companies_input_btn.UseVisualStyleBackColor = true;
            this.Manufacturing_Companies_input_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Tec_input_btn
            // 
            this.Tec_input_btn.Location = new System.Drawing.Point(44, 138);
            this.Tec_input_btn.Name = "Tec_input_btn";
            this.Tec_input_btn.Size = new System.Drawing.Size(123, 71);
            this.Tec_input_btn.TabIndex = 5;
            this.Tec_input_btn.Text = "افزودن تکنولوژی تولید";
            this.Tec_input_btn.UseVisualStyleBackColor = true;
            this.Tec_input_btn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 71);
            this.button2.TabIndex = 6;
            this.button2.Text = "افزودن زیر مجموعه مواد تولیدی تکنولوژَی";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tec_input_btn);
            this.Controls.Add(this.Manufacturing_Companies_input_btn);
            this.Controls.Add(this.Constituent_Chemicals_input_btn);
            this.Controls.Add(this.Consumer_input_btn);
            this.Controls.Add(this.Companies_input_btn);
            this.Controls.Add(this.Chemical_input_btn);
            this.Name = "inputs";
            this.Text = "inputs";
            this.Load += new System.EventHandler(this.inputs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Chemical_input_btn;
        private System.Windows.Forms.Button Companies_input_btn;
        private System.Windows.Forms.Button Consumer_input_btn;
        private System.Windows.Forms.Button Constituent_Chemicals_input_btn;
        private System.Windows.Forms.Button Manufacturing_Companies_input_btn;
        private System.Windows.Forms.Button Tec_input_btn;
        private System.Windows.Forms.Button button2;
    }
}