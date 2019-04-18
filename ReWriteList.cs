using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3Scrabble
{
    class ReWriteList
    {
       public void newList()
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("Words.txt");
            System.IO.StreamWriter sw = new System.IO.StreamWriter("NewList.txt");

            while(sr.Peek() > -1)
            {
                string temp = sr.ReadLine();

                if (temp.Length <= 7)
                    sw.WriteLine(temp);
                

            }
            sr.Close();
            sw.Flush();
            sw.Close();
            
        }
       

        
    }
}
