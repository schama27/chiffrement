namespace Algo_Chiffre
{
    partial class hill
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
            this.txtout = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkey01 = new System.Windows.Forms.TextBox();
            this.txtkey00 = new System.Windows.Forms.TextBox();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.txtkey10 = new System.Windows.Forms.TextBox();
            this.txtkey11 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(110, 234);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(719, 189);
            this.txtout.TabIndex = 23;
            this.txtout.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Chiffrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "OutPut_Text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Clés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "ALGORITHME DE HILL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Input_Text";
            // 
            // txtkey01
            // 
            this.txtkey01.Location = new System.Drawing.Point(217, 121);
            this.txtkey01.Name = "txtkey01";
            this.txtkey01.Size = new System.Drawing.Size(46, 26);
            this.txtkey01.TabIndex = 13;
            // 
            // txtkey00
            // 
            this.txtkey00.Location = new System.Drawing.Point(149, 121);
            this.txtkey00.Name = "txtkey00";
            this.txtkey00.Size = new System.Drawing.Size(48, 26);
            this.txtkey00.TabIndex = 14;
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(110, 48);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(719, 26);
            this.txtinput.TabIndex = 15;
            // 
            // txtkey10
            // 
            this.txtkey10.Location = new System.Drawing.Point(150, 187);
            this.txtkey10.Name = "txtkey10";
            this.txtkey10.Size = new System.Drawing.Size(48, 26);
            this.txtkey10.TabIndex = 14;
            // 
            // txtkey11
            // 
            this.txtkey11.Location = new System.Drawing.Point(218, 187);
            this.txtkey11.Name = "txtkey11";
            this.txtkey11.Size = new System.Drawing.Size(46, 26);
            this.txtkey11.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "c";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "d";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.richTextBox1.Location = new System.Drawing.Point(112, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(172, 115);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // hill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 451);
            this.Controls.Add(this.txtout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkey11);
            this.Controls.Add(this.txtkey10);
            this.Controls.Add(this.txtkey01);
            this.Controls.Add(this.txtkey00);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.richTextBox1);
            this.Name = "hill";
            this.Text = "hill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkey01;
        private System.Windows.Forms.TextBox txtkey00;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.TextBox txtkey10;
        private System.Windows.Forms.TextBox txtkey11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}