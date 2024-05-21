using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekstSjekker
{
    internal class Utility
    {


        public static bool palindrome(string tekst)
        {
            bool state = true;
            tekst = tekst.ToLower();

            for (int i = 0; i < tekst.Length / 2; i++)
            {
                if (tekst[i] != tekst[tekst.Length - i - 1])
                {
                    state = false;
                }
            }


            return state;
        }

        public static string reversed(string tekst)
        {
            string reversedString = "";

            for (int i = tekst.Length; i > 0; i--)
            {
                reversedString += tekst[i - 1];
            }

            return reversedString;
        }
    }
}
