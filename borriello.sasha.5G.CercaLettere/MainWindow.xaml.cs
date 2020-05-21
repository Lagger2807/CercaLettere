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

namespace borriello.sasha._5G.CercaLettere
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Calcola_Click(object sender, RoutedEventArgs e)
        {

            bool Tutte = true;

            bool[] LettereBool = new bool[21];

            string Frase = TxT_Frase.Text;

            for(int i = 0; i < TxT_Frase.Text.Length; i++)
            {

                string lettera = Frase.Substring(i, 1);

                switch(lettera)
                {

                    case "a":
                        LettereBool[0] = true;
                        break;

                    case "b":
                        LettereBool[1] = true;
                        break;

                    case "c":
                        LettereBool[2] = true;
                        break;

                    case "d":
                        LettereBool[3] = true;
                        break;

                    case "e":
                        LettereBool[4] = true;
                        break;

                    case "f":
                        LettereBool[5] = true;
                        break;

                    case "g":
                        LettereBool[6] = true;
                        break;

                    case "h":
                        LettereBool[7] = true;
                        break;

                    case "i":
                        LettereBool[8] = true;
                        break;

                    case "l":
                        LettereBool[9] = true;
                        break;

                    case "m":
                        LettereBool[10] = true;
                        break;

                    case "n":
                        LettereBool[11] = true;
                        break;

                    case "o":
                        LettereBool[12] = true;
                        break;

                    case "p":
                        LettereBool[13] = true;
                        break;

                    case "q":
                        LettereBool[14] = true;
                        break;

                    case "r":
                        LettereBool[15] = true;
                        break;

                    case "s":
                        LettereBool[16] = true;
                        break;

                    case "t":
                        LettereBool[17] = true;
                        break;

                    case "u":
                        LettereBool[18] = true;
                        break;

                    case "v":
                        LettereBool[19] = true;
                        break;

                    case "z":
                        LettereBool[20] = true;
                        break;

                    case "A":
                        LettereBool[0] = true;
                        break;

                    case "B":
                        LettereBool[1] = true;
                        break;

                    case "C":
                        LettereBool[2] = true;
                        break;

                    case "D":
                        LettereBool[3] = true;
                        break;

                    case "E":
                        LettereBool[4] = true;
                        break;

                    case "F":
                        LettereBool[5] = true;
                        break;

                    case "G":
                        LettereBool[6] = true;
                        break;

                    case "H":
                        LettereBool[7] = true;
                        break;

                    case "I":
                        LettereBool[8] = true;
                        break;

                    case "L":
                        LettereBool[9] = true;
                        break;

                    case "M":
                        LettereBool[10] = true;
                        break;

                    case "N":
                        LettereBool[11] = true;
                        break;

                    case "O":
                        LettereBool[12] = true;
                        break;

                    case "P":
                        LettereBool[13] = true;
                        break;

                    case "Q":
                        LettereBool[14] = true;
                        break;

                    case "R":
                        LettereBool[15] = true;
                        break;

                    case "S":
                        LettereBool[16] = true;
                        break;

                    case "T":
                        LettereBool[17] = true;
                        break;

                    case "U":
                        LettereBool[18] = true;
                        break;

                    case "V":
                        LettereBool[19] = true;
                        break;

                    case "Z":
                        LettereBool[20] = true;
                        break;

                    default:
                        break;

                }
            }

            for(int i = 0; i < 21; i++)
            {

                if (LettereBool[i] == false)
                    Tutte = false;

            }

            if (Tutte == true)
                Text_Risultato.Text = "La frase contiene tutte le lettere dell'alfabeto";
            else
                Text_Risultato.Text = "La frase non contiene tutte le lettere dell'alfabeto";

        }
    }
}
