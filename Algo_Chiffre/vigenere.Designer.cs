namespace Algo_Chiffre
{
    partial class vigenere
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtout = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(121, 49);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(719, 26);
            this.txtinput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input_Text";
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(121, 106);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(719, 26);
            this.txtkey.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clé";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chiffrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(121, 198);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(719, 189);
            this.txtout.TabIndex = 3;
            this.txtout.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "OutPut_Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ALGORITHME DE VIGENERE";
            // 
            // vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 444);
            this.Controls.Add(this.txtout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.txtinput);
            this.Name = "vigenere";
            this.Text = "vigenere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}