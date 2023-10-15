namespace WinFormsAppCiphers
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Main";
        }

        private void button_caesar_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            this.Text = "Caesar";
            Caesar caesar = new Caesar();
            caesar.TopLevel = false;
            caesar.AutoScroll = true;
            this.MainPanel.Controls.Add(caesar);
            caesar.Show();
        }

        private void button_atbash_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            this.Text = "Atbash";
            Atbash atbash = new Atbash();
            atbash.TopLevel = false;
            atbash.AutoScroll = true;
            this.MainPanel.Controls.Add(atbash);
            atbash.Show();
        }

        private void button_morse_code_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            this.Text = "Morse Code";
            MorseCode morseCode = new MorseCode();
            morseCode.TopLevel = false;
            morseCode.AutoScroll = true;
            this.MainPanel.Controls.Add(morseCode);
            morseCode.Show();
        }

        private void button_polybia_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            this.Text = "Polybia";
            Polybia polybia = new Polybia();
            polybia.TopLevel = false;
            polybia.AutoScroll = true;
            this.MainPanel.Controls.Add(polybia);
            polybia.Show();
        }
    }
}