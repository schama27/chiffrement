using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algo_Chiffre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                int key = int.Parse(txtKey.Text);
                txtOutput.Text = Cesar(input, key);
            }
            catch
            {
                MessageBox.Show("Veillez entre un nombre entier");
            }
            finally 
            {} 
        }

        private string Cesar(string input, int p)
        {
            char[] tableau = input.ToCharArray();
            for (int i = 0; i < tableau.Length; i++)
            {
                char lettre = tableau[i];
                if (char.IsLetter(lettre)) 
                {
                    char tbl = char.IsUpper(lettre) ? 'A' : 'a';
                    lettre = (char)(((lettre+p-tbl)%26+26)%26+tbl);
                }
                tableau[i] = lettre;
            }
            return new string(tableau);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vigenere f = new vigenere();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            affine f = new affine();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hill f = new hill();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rail_fence f = new rail_fence();
            f.Show();
        }
    }
}
