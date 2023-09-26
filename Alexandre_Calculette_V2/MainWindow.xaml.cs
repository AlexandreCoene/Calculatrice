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

        double N1 = 0;
        double N2 = 0;
        double result = 0;
        char operation = ' ';

        public MainWindow()
        {
            InitializeComponent();
        }

        /* ************************ Apparition de tous les boutons *************************/


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

        /* ************************ Apparition des opérateurs et virgule *************************/


        private void BTN_Virgule_Click(object sender, RoutedEventArgs e)
        {
            display(",");
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            N1 = double.Parse(TB_Affichage.Text);
            TB_Affichage.Text = "0";
            operation = '+';
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


        private void BTN_Pi_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Affichage.Text != "") N1 = double.Parse(TB_Affichage.Text);
            {


                operation = 'p';
                TB_Affichage.Text = "0";
            }
        }


        /* ************************ Fonction pour afficher un chiffre ou un opérateur *************************/


        public void display(string num)
        {
            if (TB_Affichage.Text == "0")
            {
                TB_Affichage.Text = num;
            }
            else
            {
                TB_Affichage.Text = TB_Affichage.Text + num;
            }
        }

        /* ************************ Egale *************************/

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

            }
        }

        /* ************************ Clear *************************/

        private void BTN_Del_Click(object sender, RoutedEventArgs e)
        {
            N1 = 0;
            N2 = 0;
            result = 0;
            TB_Affichage.Text = "0";
        }
           
        }
    }

