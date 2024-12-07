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
    public partial class affine : Form
    {
        public affine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try 
            //{
            //    string input = textBoxPlainText.Text.ToUpper();
            //    int key_a = int.Parse(textBoxKeyA.Text);
            //    int key_b = int.Parse(textBoxKeyB.Text);
            //    //verifier si A est prémier avec 26
            //if(pgcd(key_a, 26) !=1)
            //{
            //    MessageBox.Show("La clé doit être primeir avec 26");
            //    return;
            //}
            //string textChiffre = chiffreAffine(input, key_a, key_b);
            //    label7.Text = $"Texte chiffré : {textChiffre}";
            //}
            //catch
            //{
            //    MessageBox.Show("Erreur");
            //}
           try
            {
                string plaintext = textBoxPlainText.Text.ToUpper();
                int a = int.Parse(textBoxKeyA.Text);
                int b = int.Parse(textBoxKeyB.Text);

                // Vérification si a est copremier avec 26
                if (GCD(a, 26) != 1)
                {
                    MessageBox.Show("La clé a doit être copremière avec 26 !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string ciphertext = EncryptAffine(plaintext, a, b);
                txtout.Text = ciphertext;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur");
            }
        }

private int GCD(int a,int b)
{
 	            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;

}

private string EncryptAffine(string plaintext,int a,int b)
{
 	            string result = "";
            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    int x = c - 'A'; // Convertir en index (A=0, B=1, ...)
                    int encrypted = (a * x + b) % 26; // Formule de chiffrement
                    result += (char)(encrypted + 'A'); // Reconvertir en caractère
                }
                else
                {
                    result += c; // Conserver les caractères non alphabétiques
                }
            }  
            return result; 
        }

      


    }
}
