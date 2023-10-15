using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsAppCiphers
{
    class CaesarCipher
    {
        static string alph = "АӘБВГҒДЕЁЖЗИЙКҚЛМНҢОӨПРСТУҰҮФХҺЦЧШЩЪЫІЬЭЮ";

        public static string Encryption(string text, int num)
        {
            text = text.ToUpper();
            var res = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (text[i] == alph[j]) res.Append(alph[(j + num) % alph.Length]);

            return res.ToString();
        }
        public static string Decryption(string crypt, int num)
        {
            crypt = crypt.ToUpper();
            var res = new StringBuilder();
            for (int i = 0; i < crypt.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (crypt[i] == alph[j]) res.Append(alph[(j - num + alph.Length) % alph.Length]);

            return res.ToString();
        }
    }
}
