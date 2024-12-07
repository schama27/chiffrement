namespace Algo_Chiffre
{
    partial class rail_fence
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
            this.txtCipherText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(128, 218);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(719, 189);
            this.txtCipherText.TabIndex = 11;
            this.txtCipherText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Chiffrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "OutPut_Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ALGORITHME DE VIGENERE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input_Text";
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(128, 126);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(719, 26);
            this.txtDepth.TabIndex = 4;
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(128, 69);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(719, 26);
            this.txtPlainText.TabIndex = 5;
            // 
            // rail_fence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 449);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.txtPlainText);
            this.Name = "rail_fence";
            this.Text = "rail_fence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCipherText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtPlainText;
    }
}