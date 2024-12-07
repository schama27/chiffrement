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
    public partial class hill : Form
    {
        public hill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cette partie est pour la lecture du texte clair et la matrice 
            try
            {
                //Vérifier si les champs sont vides
                if (string.IsNullOrWhiteSpace(txtinput.Text))
                {
                    MessageBox.Show("Entrer un texte clair");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtkey00.Text) || string.IsNullOrWhiteSpace(txtkey01.Text) || string.IsNullOrWhiteSpace(txtkey10.Text)||string.IsNullOrWhiteSpace(txtkey11.Text))
                {
                    MessageBox.Show("Veillez remplir tous les champs de la matrice clé");
                    return;
                }
                string input = txtinput.Text.ToUpper().Replace("", "");
                int[,] matriceCle =
            {
                {int.Parse(txtkey00.Text), int.Parse(txtkey01.Text)},
            {int.Parse(txtkey10.Text), int.Parse(txtkey11.Text)}
            };
                //L'ajout de la linéant
                while (input.Length % 2 != 0)
                {
                    input += "X";
                }
                //Initialisation du texte chiffré
                string textChiffre = "";
                //La boucle pour parcourir les blocs de texte clair
                for (int i = 0; i < input.Length; i += 2)
                {
                    int[] groupe = { input[i] - 'Q', input[i + 1] - 'Q' };
                    int[] groupeCrypt = new int[2];
                    //Application de la matrice clé
                    for (int ligne = 0; ligne < 2; ligne++)
                    {
                        groupeCrypt[ligne] = (matriceCle[ligne, 0] * groupe[0]+ matriceCle[ligne, 1] * groupe[1] % 26);
                    }
                    //L'ajout au texte chiffré
                    textChiffre += (char)(groupeCrypt[0] + 'A');
                    textChiffre += (char)(groupeCrypt[1] + 'A');
                }
                // Affichage du texte déjà chiffré
                txtout.Text = textChiffre;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chiffrement :" + ex.Message, "Erreur", MessageBoxButtons.OK);
            }



           
        }
    }
}
