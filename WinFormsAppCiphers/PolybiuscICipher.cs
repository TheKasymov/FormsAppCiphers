using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCiphers
{
    internal class PolybiuscICipher
    {
        char[,] alfrus = {     
            {'А', 'Ә', 'Б', 'В', 'Ғ', 'Г', 'Д', 'Е'},
            {'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н'},
            {'Ң', 'О', 'Ө', 'П', 'Р', 'С', 'Т', 'У'}, 
            {'Ұ', 'Ү', 'Ф', 'Х', 'Һ', 'Ц', 'Ч', 'Щ'},
            {'Ъ', 'Ш', 'Ы', 'І', 'Ь', 'Э', 'Ю', 'Я'}
        };
        public string Encryption(string text)
        {
            text = text.ToUpper();
            string str = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alfrus.GetLength(0); j++)
                    for (int k = 0; k < alfrus.GetLength(1); k++)
                        if (Char.ToLower(alfrus[j, k]) == text[i] || Char.ToUpper(alfrus[j, k]) == text[i])
                        {
                            str += (Convert.ToString(j) + Convert.ToString(k));
                            break;
                        }

            }
            return str;
        }
        public string Decryption(string text)
        {
            text = text.ToUpper();
            string str = string.Empty;
            for (int a = 0; a < text.Length; a += 2)
            {
                str += alfrus[Convert.ToInt32(text[a].ToString()), Convert.ToInt32(text[a + 1].ToString())];
            }
            return str;
        }
    }
}
