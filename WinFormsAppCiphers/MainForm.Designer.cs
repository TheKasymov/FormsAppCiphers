namespace WinFormsAppCiphers
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainPanel = new Panel();
            label1 = new Label();
            button_caesar = new Button();
            button_atbash = new Button();
            button_morse_code = new Button();
            button_polybia = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.Control;
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Location = new Point(147, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(670, 456);
            MainPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 1;
            label1.Text = "Шифрлар";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button_caesar
            // 
            button_caesar.BackColor = SystemColors.Window;
            button_caesar.ForeColor = SystemColors.ActiveCaptionText;
            button_caesar.Location = new Point(5, 40);
            button_caesar.Name = "button_caesar";
            button_caesar.Size = new Size(136, 39);
            button_caesar.TabIndex = 2;
            button_caesar.Text = "Цезарь";
            button_caesar.UseVisualStyleBackColor = false;
            button_caesar.Click += button_caesar_Click;
            // 
            // button_atbash
            // 
            button_atbash.BackColor = SystemColors.Window;
            button_atbash.ForeColor = SystemColors.ActiveCaptionText;
            button_atbash.Location = new Point(5, 85);
            button_atbash.Name = "button_atbash";
            button_atbash.Size = new Size(136, 39);
            button_atbash.TabIndex = 3;
            button_atbash.Text = "Атбаш";
            button_atbash.UseVisualStyleBackColor = false;
            button_atbash.Click += button_atbash_Click;
            // 
            // button_morse_code
            // 
            button_morse_code.BackColor = SystemColors.Window;
            button_morse_code.ForeColor = SystemColors.ActiveCaptionText;
            button_morse_code.Location = new Point(5, 130);
            button_morse_code.Name = "button_morse_code";
            button_morse_code.Size = new Size(136, 39);
            button_morse_code.TabIndex = 4;
            button_morse_code.Text = "Морзе";
            button_morse_code.UseVisualStyleBackColor = false;
            button_morse_code.Click += button_morse_code_Click;
            // 
            // button_polybia
            // 
            button_polybia.BackColor = SystemColors.Window;
            button_polybia.ForeColor = SystemColors.ActiveCaptionText;
            button_polybia.Location = new Point(5, 175);
            button_polybia.Name = "button_polybia";
            button_polybia.Size = new Size(136, 39);
            button_polybia.TabIndex = 5;
            button_polybia.Text = "Полибия";
            button_polybia.UseVisualStyleBackColor = false;
            button_polybia.Click += button_polybia_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(819, 455);
            Controls.Add(button_polybia);
            Controls.Add(button_morse_code);
            Controls.Add(button_atbash);
            Controls.Add(button_caesar);
            Controls.Add(label1);
            Controls.Add(MainPanel);
            Name = "MainForm";
            Text = "Form1";
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MainPanel;
        private Label label1;
        private Button button_caesar;
        private Button button_atbash;
        private Button button_morse_code;
        private Button button_polybia;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}