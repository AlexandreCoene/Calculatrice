using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Alexandre_Calculette_V2
{
    public partial class MainWindow : Window
    {

        /* ************************ Initialisation *************************/


        double N1 = 0;
        double N2 = 0;
        double result = 0;
        char operation = ' ';

        public MainWindow()
        {
            InitializeComponent();
        }

        /* ************************ Affichage de chaque chiffre (0 à 9) *************************/


        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display("0");
        }

        /* ************************ Affichage des opérateurs et virgule dans la TextBox *************************/


        private void BTN_Virgule_Click(object sender, RoutedEventArgs e)
        {
            display(",");
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);  // Récupère le nombre actuel dans le champ de texte (TB_Affichage) et le stocke dans la variable N1.
            TB_Affichage.Text = "0";               // Réinitialise le champ de texte (TB_Affichage) à "0" pour commencer à saisir un nouveau nombre.                
            operation = '+';                      // Stocke le caractère '+' dans la variable 'operation', indiquant que l'opération à effectuer est une addition.
        }

        private void BTN_Minus_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);
            TB_Affichage.Text = "0";
            operation = '-';
        }

        private void BTN_Multi_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);
            TB_Affichage.Text = "0";
            operation = '*';
        }

        private void BTN_Division_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);
            TB_Affichage.Text = "0";
            operation = '/';
        }

        private void BTN_Racine_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);
            TB_Affichage.Text = "0";
            operation = 'r';
        }

        private void BTN_Puissance_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);
            TB_Affichage.Text = "0";
            operation = 'y';
        }

        private void BTN_Cos_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);
            TB_Affichage.Text = "0";
            operation = 'c';
        }

        private void BTN_Sin_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);
            TB_Affichage.Text = "0";
            operation = 's';
        }

        private void BTN_Tan_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);
            TB_Affichage.Text = "0";
            operation = 't';
        }

        private void BTN_Pi_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Affichage.Text != "")                 // Vérifie si le texte dans le contrôle TextBox TB_Affichage n'est pas vide
                N1 = double.Parse(TB_Affichage.Text);   // Si le texte n'est pas vide, convertit le texte en double et assigne la valeur à N1
            {
                operation = 'p';
                TB_Affichage.Text = "0";
            }
        }

        /* ************************ Fonction pour afficher un chiffre ou un opérateur *************************/

        public void display(string num)
        {
            if (TB_Affichage.Text == "0") //  Si le champ de texte contient actuellement "0"
            {
                TB_Affichage.Text = num; // Il le remplace par le chiffre cliqué.
            }
            else
            {
                TB_Affichage.Text = TB_Affichage.Text + num; //  Sinon, il concatène simplement le chiffre cliqué au texte existant dans le champ de texte.
            }
        }

        /* ************************ Egale / Afficher le résultat *************************/

        private void BTN_Egale_Click(object sender, RoutedEventArgs e)
        {

            N2 = double.Parse(TB_Affichage.Text);

            switch (operation)
            {
                case '+':
                    result = N1 + N2;
                    TB_Affichage.Text = result.ToString();
                    break;

                case '-':
                    result = N1 - N2;
                    TB_Affichage.Text = result.ToString();
                    break;

                case '*':
                    result = N1 * N2;
                    TB_Affichage.Text = result.ToString();
                    break;

                case '/':
                    result = N1 / N2;
                    TB_Affichage.Text = result.ToString();
                    break;

                case 'p':
                    result = N1 * Math.PI;
                    TB_Affichage.Text = result.ToString();
                    break;

                case 'r':
                    result = Math.Sqrt(N1);
                    TB_Affichage.Text = result.ToString();
                    break;

                case 'y':
                    result = N1 * N1;
                    TB_Affichage.Text= result.ToString();
                    break;

                case 'c':
                    result = Math.Cos(N1);
                    TB_Affichage.Text = result.ToString();
                    break;

                case 's':
                    result = Math.Sin(N1);
                    TB_Affichage.Text = result.ToString();
                    break;

                case 't':
                    result = Math.Tan(N1);
                    TB_Affichage.Text = result.ToString();
                    break;
            }
        }

        /* ************************ Clear / Supprime tous le contenu de la Textbox *************************/

        private void BTN_Del_Click(object sender, RoutedEventArgs e)
        {
            N1 = 0;
            N2 = 0;
            result = 0;
            TB_Affichage.Text = "0";
        }
           
        }
    }

