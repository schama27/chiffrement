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
    public partial class rail_fence : Form
    {
        public rail_fence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          try
            {
                // Lire le texte clair et la profondeur
                string plainText = txtPlainText.Text.Replace(" ", "").ToUpper();
                if (string.IsNullOrWhiteSpace(plainText))
                {
                    MessageBox.Show("Veuillez entrer un texte clair.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int depth;
                if (!int.TryParse(txtDepth.Text, out depth))
                {
                    MessageBox.Show("Veuillez entrer une profondeur valide (un nombre entier).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (depth < 2)
                {
                    MessageBox.Show("La profondeur doit être au moins égale à 2.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chiffrer avec Rail Fence
                string cipherText = RailFenceEncrypt(plainText, depth);

                // Afficher le texte chiffré
                txtCipherText.Text = cipherText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fonction de chiffrement Rail Fence
        private string RailFenceEncrypt(string plainText, int depth)
        {
            char[,] rail = new char[depth, plainText.Length];

            // Initialiser la matrice rail avec des blancs
            for (int i = 0; i < depth; i++)
            {
                for (int j = 0; j < plainText.Length; j++)
                {
                    rail[i, j] = '\n';
                }
            }
            // Remplir la matrice rail en zigzag
            bool down = false;
            int row = 0, col = 0;
            for (int i = 0; i < plainText.Length; i++)
            {
                if (row == 0 || row == depth - 1)
                    down = !down;

                rail[row, col++] = plainText[i];

                row += down ? 1 : -1;
            }
            // Lire la matrice rail ligne par ligne
            string cipherText = "";
            for (int i = 0; i < depth; i++)
            {
                for (int j = 0; j < plainText.Length; j++)
                {
                    if (rail[i, j] != '\n')
                        cipherText += rail[i, j];
                }
            }

            return cipherText;



        }
    }
}
