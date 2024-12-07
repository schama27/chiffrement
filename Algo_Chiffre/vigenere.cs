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
    public partial class vigenere : Form
    {
        public vigenere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string input = txtinput.Text;
                string key = txtkey.Text;
                
                if(string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("La clé doit contenir des lettres seulement");
                    return;
                }
                txtout.Text = chiffreVigenere(input, key, true);
            }
            catch 
            {
                MessageBox.Show("Erreur de chiffrement");
            }

            
        }

        private string chiffreVigenere(string input, string key, bool crypt)
        {
            string resultat = "";
            int indexkey = 0;
            foreach (char c in input) 
            {
                if (char.IsLetter(c))
                {
                    char tbl = char.IsUpper(c) ? 'A' : 'a';
                    int keyshift = key[indexkey % key.Length] - 'A';
                    keyshift = crypt ? keyshift : -keyshift;
                    char nouvChar = (char)(((c - tbl + keyshift + 26) % 26) + tbl);
                    resultat += nouvChar;
                    indexkey++;
                }
                else
                {
                    resultat += c;
                }
            }
            return resultat;

        }
    }
}
