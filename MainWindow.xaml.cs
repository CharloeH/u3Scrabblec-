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

namespace u3Scrabble
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int counter = 0;
        public static List<string> strList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ScrabbleGame sg = new ScrabbleGame();
            string letters = sg.drawInitialTiles().ToLower();
            string letterSearched = "";
            int n;
            string currentWord;
          
            System.IO.StreamReader sr = new System.IO.StreamReader("Words.txt");
            for (int i = 0; i < 7; i++)
            {
                letterSearched += letters[i];
                n = letterSearched.Length;
                permute(letterSearched, 0, n - 1);
            }
            MessageBox.Show(counter.ToString());
            while (!sr.EndOfStream)
            {
                currentWord = sr.ReadLine();
                foreach (string s in strList)
                {
                    if (currentWord == s)
                        MessageBox.Show(currentWord);
                }
            }
        }
            private static void permute(String str,
                                    int l, int r)
            {
                
                if (l == r)
                {
                    strList.Add(str);
                Console.WriteLine(str);
                counter++;
                }
                else
                {
                    for (int i = l; i <= r; i++)
                    {
                        str = swap(str, l, i);
                        permute(str, l + 1, r);
                        str = swap(str, l, i);
                    }
                }
            }


            public static String swap(String a,
                                      int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                string s = new string(charArray);
                return s;
            }
        }
    }

