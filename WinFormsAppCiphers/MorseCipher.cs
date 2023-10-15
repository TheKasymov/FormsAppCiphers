using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsAppCiphers
{
    internal class MorseCipher
    {
        char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0'};

        string[] codeMorse = new string[] { "*–", "–***", "*––", "––*",
                                                        "–**", "*", "***–", "––**",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*",
                                                        "*–*", "***", "–", "**–",
                                                        "**–*", "****", "–*–*",
                                                        "–––*", "––––", "−−*−",
                                                        "−*−−", "−**−", "**−**",
                                                        "**−−", "*−*−", "*−−−−",
                                                        "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−−−−*", "−−−−−"};


        public string Encryption(string text)
        {
            text = text.ToUpper();
            string output = "";
            int index;
            foreach (char c in text)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(characters, c);
                    output += codeMorse[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            return output;
        }
        public string Decryption(string text)
        {
            string[] split = text.Split(' ');
            string output = string.Empty;
            int index;
            foreach (string s in split)
            {
                index = Array.IndexOf(codeMorse, s);
                output += characters[index] + " ";  //
            }
            output = output.Remove(output.Length - 1);
            return output;
        }
    }
}
