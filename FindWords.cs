using System;
using System.Windows;

namespace u3Scrabble
{
    class FindWords
    {
        public static void search(string[] arr, char x)
        {
           //string test = "Abadite";
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if ((x.ToString()))
                {
                    MessageBox.Show(arr[i]);
                    Console.WriteLine(arr[i]);
                    //return arr[i];
                }
               
            }
        }

        public static void returnResults()
        {
            ScrabbleGame sg = new ScrabbleGame();
            System.IO.StreamReader sr = new System.IO.StreamReader("NewList.txt");
            sg.drawInitialTiles();
            char[] tiles = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };//sg.drawInitialTiles().ToCharArray();
            string[] words = sr.ReadToEnd().Split('\r');
            for (int i = 0; i < tiles.Length; i++)
            {
                search(words, tiles[i]);
            }
            //search(words, tiles[0]);
            
        }
    }
}
