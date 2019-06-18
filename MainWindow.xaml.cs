/* Sebastian Horton
June 18th, 2019
A program that finds all of the scrabble words given an input of random letters
*/
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
        public static List<int> strList = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            ScrabbleGame sg = new ScrabbleGame();
            char[] letters = sg.drawInitialTiles().ToLower().ToCharArray();
            List<string> Letters = new List<string>();
            
            int i = 0;
            foreach (char c in letters)
            {
                string temp = new string(c);
                Letters.Add();
            }
            permute(strList);
            
            System.IO.StreamReader sr = new System.IO.StreamReader("Words.txt");
            
                
        }
      
            private List<List<string>> permute(List<string> testValues)
            {
                List<List<string>> result = new List<List<string>>();

            for (int count = 0; count < (1 << testValues.Count); ++count)
            {
                List<string> combinationList = new List<string>();

                for (int i = 0; i < testValues.Count; ++i)
                {
                    if ((count & (1 << i)) == 0)
                    {
                        combinationList.Add(testValues[i]);
                    }
                }
                result.Add(combinationList);
            }
            
            
                return result;
            }
        }
        }
    

