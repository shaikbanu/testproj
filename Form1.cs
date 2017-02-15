using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormsPalendrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);

        }


        public bool IsPalindrome(string value)
        {

            var temp = value.ToLower();
            var valueArray = value.ToLower().ToArray();
            var reverseString = ""; var originalstring="";
            int j = 0;
            for (int i = valueArray.Length - 1; i >= 0; i--)
            {
                if (valueArray[j].ToString() != " ")               
                    originalstring = originalstring + valueArray[j];
                  
                if (valueArray[i].ToString() != " ")                
                    reverseString = reverseString + valueArray[i];

                j++;
            }




            if (originalstring == reverseString)
            {
                return true;

            }
            else
                return false;

            //int min = 0;
            //int max = value.Length - 1;
            //while (true)
            //{
            //    if (min > max)
            //    {
            //        return true;
            //    }
            //    char a = value[min];
            //    char b = value[max];

            //    // Scan forward for a while invalid.
            //    while (!char.IsLetterOrDigit(a))
            //    {
            //        min++;
            //        if (min > max)
            //        {
            //            return true;
            //        }
            //        a = value[min];
            //    }

            //    // Scan backward for b while invalid.
            //    while (!char.IsLetterOrDigit(b))
            //    {
            //        max--;
            //        if (min > max)
            //        {
            //            return true;
            //        }
            //        b = value[max];
            //    }

            //    if (char.ToLower(a) != char.ToLower(b))
            //    {
            //        return false;
            //    }
            //    min++;
            //    max--;
            //}
        }


        //bool IsPalindrome(string s)
        //{


        //    //string temp = s;
        //    //var d=  s.Reverse();
        //    //if (temp == s)
        //    //    return true;
        //    //else
        //    //    
        //    return true;

        //           }

        void Check(string s, bool shouldBePalindrome)
        {
            var r = IsPalindrome(s);
            if(r == shouldBePalindrome)
            {
                MessageBox.Show("pass");

            }
            else
                MessageBox.Show("fail");

          //  MessageBox.Show(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");

            //Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }

    }
}
