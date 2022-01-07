namespace Google_Translate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Font = new System.Drawing.Font("Engravers MT", 8.920354F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(701, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 432);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(567, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(482, 432);
            this.textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "af   ",
            "sq   ",
            "am   ",
            "ar   ",
            "hy   ",
            "az   ",
            "eu   ",
            "be   ",
            "bn   ",
            "bs   ",
            "bg   ",
            "ca   ",
            "ceb  ",
            "ny   ",
            "zh-CN",
            "co   ",
            "hr   ",
            "cs   ",
            "da   ",
            "nl   ",
            "en   ",
            "eo   ",
            "et   ",
            "tl   ",
            "fi   ",
            "fr   ",
            "fy   ",
            "gl   ",
            "ka   ",
            "de   ",
            "el   ",
            "gu   ",
            "ht   ",
            "ha   ",
            "haw  ",
            "iw   ",
            "hi   ",
            "hmn  ",
            "hu   ",
            "is   ",
            "ig   ",
            "id   ",
            "ga   ",
            "it   ",
            "ja   ",
            "jw   ",
            "kn   ",
            "kk   ",
            "km   ",
            "ko   ",
            "ku   ",
            "ky   ",
            "lo   ",
            "la   ",
            "lv   ",
            "lt   ",
            "lb   ",
            "mk   ",
            "mg   ",
            "ms   ",
            "ml   ",
            "mt   ",
            "mi   ",
            "mr   ",
            "mn   ",
            "my   ",
            "ne   ",
            "no   ",
            "ps   ",
            "fa   ",
            "pl   ",
            "pt   ",
            "pa   ",
            "ro   ",
            "ru   ",
            "sm   ",
            "gd   ",
            "sr   ",
            "st   ",
            "sn   ",
            "sd   ",
            "si   ",
            "sk   ",
            "sl   ",
            "so   ",
            "es   ",
            "su   ",
            "sw   ",
            "sv   ",
            "tg   ",
            "ta   ",
            "te   ",
            "th   ",
            "tr   ",
            "uk   ",
            "ur   ",
            "uz   ",
            "vi   ",
            "cy   ",
            "xh   ",
            "yi   ",
            "yo   ",
            "zu   "});
            this.comboBox1.Location = new System.Drawing.Point(42, 526);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select Language";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "af   ",
            "sq   ",
            "am   ",
            "ar   ",
            "hy   ",
            "az   ",
            "eu   ",
            "be   ",
            "bn   ",
            "bs   ",
            "bg   ",
            "ca   ",
            "ceb  ",
            "ny   ",
            "zh-CN",
            "co   ",
            "hr   ",
            "cs   ",
            "da   ",
            "nl   ",
            "en   ",
            "eo   ",
            "et   ",
            "tl   ",
            "fi   ",
            "fr   ",
            "fy   ",
            "gl   ",
            "ka   ",
            "de   ",
            "el   ",
            "gu   ",
            "ht   ",
            "ha   ",
            "haw  ",
            "iw   ",
            "hi   ",
            "hmn  ",
            "hu   ",
            "is   ",
            "ig   ",
            "id   ",
            "ga   ",
            "it   ",
            "ja   ",
            "jw   ",
            "kn   ",
            "kk   ",
            "km   ",
            "ko   ",
            "ku   ",
            "ky   ",
            "lo   ",
            "la   ",
            "lv   ",
            "lt   ",
            "lb   ",
            "mk   ",
            "mg   ",
            "ms   ",
            "ml   ",
            "mt   ",
            "mi   ",
            "mr   ",
            "mn   ",
            "my   ",
            "ne   ",
            "no   ",
            "ps   ",
            "fa   ",
            "pl   ",
            "pt   ",
            "pa   ",
            "ro   ",
            "ru   ",
            "sm   ",
            "gd   ",
            "sr   ",
            "st   ",
            "sn   ",
            "sd   ",
            "si   ",
            "sk   ",
            "sl   ",
            "so   ",
            "es   ",
            "su   ",
            "sw   ",
            "sv   ",
            "tg   ",
            "ta   ",
            "te   ",
            "th   ",
            "tr   ",
            "uk   ",
            "ur   ",
            "uz   ",
            "vi   ",
            "cy   ",
            "xh   ",
            "yi   ",
            "yo   ",
            "zu   "});
            this.comboBox2.Location = new System.Drawing.Point(297, 526);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 27);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Select Language";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 666);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        //private System.Windows.Forms.Button button1;
    }
}
