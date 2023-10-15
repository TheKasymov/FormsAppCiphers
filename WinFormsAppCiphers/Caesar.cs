using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsAppCiphers
{
    public partial class Caesar : Form
    {
        bool Click = true;
        public Caesar()
        {
            InitializeComponent();
            lbl_main_text.Text = "Шифрлау";
            button_versa.Text = "Шифрлау";
        }

        private void btn_versa(object sender, EventArgs e)
        {
            tb_result.Text = CaesarCipher.Encryption(tb_text.Text, Int32.Parse(tb_step.Text));
        }
        private void btn_decoding(object sender, EventArgs e)
        {
            tb_result.Text = CaesarCipher.Decryption(tb_text.Text, Int32.Parse(tb_step.Text));

        }
        private void button_versa_Click(object sender, EventArgs e)
        {
            if (Click)
            {
                Click = false;
                lbl_main_text.Text = "Декодтау";
                button_versa.Text = "Шифрлау";
                button_start.Click += new EventHandler(this.btn_decoding);
            }
            else
            {
                lbl_main_text.Text = "Шифрлау";
                button_versa.Text = "Декодтау";
                Click = true;
                button_start.Click += new EventHandler(this.btn_versa);
            }
        }
    }
}
