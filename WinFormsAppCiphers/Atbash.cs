using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCiphers
{
    public partial class Atbash : Form
    {
        bool Click = true;
        AtbashCipher atbashCipher = new AtbashCipher();
        public Atbash()
        {
            InitializeComponent();
            lbl_main_text.Text = "Шифрлау";
            button_versa.Text = "Шифрлау";
        }

        private void btn_versa(object sender, EventArgs e)
        {

            tb_result.Text = atbashCipher.Encryption(tb_text.Text);
        }
        private void btn_decoding(object sender, EventArgs e)
        {
            tb_result.Text = atbashCipher.Decryption(tb_text.Text);
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
