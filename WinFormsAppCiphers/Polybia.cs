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
    public partial class Polybia : Form
    {
        bool Click1 = true;
        PolybiuscICipher polybiuscICipher = new PolybiuscICipher();
        public Polybia()
        {
            InitializeComponent();
            lbl_main_text.Text = "Шифрлау";
            button_versa.Text = "Шифрлау";
        }

        private void btn_versa(object sender, EventArgs e)
        {
            tb_result.Text = polybiuscICipher.Encryption(tb_text.Text);
        }
        private void btn_decoding(object sender, EventArgs e)
        {
            tb_result.Text = polybiuscICipher.Decryption(tb_text.Text);
        }
        private void button_versa_Click(object sender, EventArgs e)
        {
            if (Click1)
            {
                Click1 = false;
                lbl_main_text.Text = "Декодтау";
                button_versa.Text = "Шифрлау";
                button_start.Click += new EventHandler(this.btn_decoding);
            }
            else
            {
                Click1 = true;
                lbl_main_text.Text = "Шифрлау";
                button_versa.Text = "Декодтау";
                button_start.Click += new EventHandler(this.btn_versa);
            }
        }
    }
}
