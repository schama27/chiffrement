namespace Algo_Chiffre
{
    partial class affine
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKeyA = new System.Windows.Forms.TextBox();
            this.textBoxPlainText = new System.Windows.Forms.TextBox();
            this.textBoxKeyB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(110, 200);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(719, 189);
            this.txtout.TabIndex = 12;
            this.txtout.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Chiffrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "OutPut_Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ALGORITHME AFFINE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input_Text";
            // 
            // textBoxKeyA
            // 
            this.textBoxKeyA.Location = new System.Drawing.Point(110, 124);
            this.textBoxKeyA.Name = "textBoxKeyA";
            this.textBoxKeyA.Size = new System.Drawing.Size(95, 26);
            this.textBoxKeyA.TabIndex = 5;
            // 
            // textBoxPlainText
            // 
            this.textBoxPlainText.Location = new System.Drawing.Point(110, 51);
            this.textBoxPlainText.Name = "textBoxPlainText";
            this.textBoxPlainText.Size = new System.Drawing.Size(719, 26);
            this.textBoxPlainText.TabIndex = 6;
            // 
            // textBoxKeyB
            // 
            this.textBoxKeyB.Location = new System.Drawing.Point(263, 124);
            this.textBoxKeyB.Name = "textBoxKeyB";
            this.textBoxKeyB.Size = new System.Drawing.Size(95, 26);
            this.textBoxKeyB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "b";
            // 
            // affine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 448);
            this.Controls.Add(this.txtout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKeyB);
            this.Controls.Add(this.textBoxKeyA);
            this.Controls.Add(this.textBoxPlainText);
            this.Name = "affine";
            this.Text = "affine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKeyA;
        private System.Windows.Forms.TextBox textBoxPlainText;
        private System.Windows.Forms.TextBox textBoxKeyB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}