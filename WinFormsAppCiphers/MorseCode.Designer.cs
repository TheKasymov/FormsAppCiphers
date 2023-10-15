namespace WinFormsAppCiphers
{
    partial class MorseCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_main_text = new Label();
            button_versa = new Button();
            button_start = new Button();
            label3 = new Label();
            label2 = new Label();
            tb_result = new TextBox();
            label1 = new Label();
            tb_text = new TextBox();
            SuspendLayout();
            // 
            // lbl_main_text
            // 
            lbl_main_text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_main_text.AutoSize = true;
            lbl_main_text.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_main_text.Location = new Point(254, 5);
            lbl_main_text.Name = "lbl_main_text";
            lbl_main_text.Size = new Size(111, 47);
            lbl_main_text.TabIndex = 27;
            lbl_main_text.Text = "Мәтін";
            // 
            // button_versa
            // 
            button_versa.BackColor = SystemColors.ControlDark;
            button_versa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_versa.ImageAlign = ContentAlignment.TopCenter;
            button_versa.Location = new Point(7, 405);
            button_versa.Name = "button_versa";
            button_versa.Size = new Size(72, 44);
            button_versa.TabIndex = 26;
            button_versa.Text = "Versa";
            button_versa.UseVisualStyleBackColor = false;
            button_versa.Click += button_versa_Click;
            // 
            // button_start
            // 
            button_start.BackColor = SystemColors.ControlDark;
            button_start.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_start.ImageAlign = ContentAlignment.TopCenter;
            button_start.Location = new Point(266, 394);
            button_start.Name = "button_start";
            button_start.Size = new Size(159, 44);
            button_start.TabIndex = 25;
            button_start.Text = "Бастау";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += btn_versa;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(304, 131);
            label3.Name = "label3";
            label3.Size = new Size(77, 40);
            label3.TabIndex = 24;
            label3.Text = "==>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(501, 50);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 23;
            label2.Text = "Нәтижесі";
            // 
            // tb_result
            // 
            tb_result.BackColor = SystemColors.ScrollBar;
            tb_result.Location = new Point(420, 78);
            tb_result.Multiline = true;
            tb_result.Name = "tb_result";
            tb_result.ReadOnly = true;
            tb_result.Size = new Size(243, 140);
            tb_result.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 50);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 21;
            label1.Text = "Мәтін";
            // 
            // tb_text
            // 
            tb_text.BackColor = SystemColors.ScrollBar;
            tb_text.Location = new Point(17, 78);
            tb_text.Multiline = true;
            tb_text.Name = "tb_text";
            tb_text.Size = new Size(243, 140);
            tb_text.TabIndex = 20;
            // 
            // MorseCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 454);
            Controls.Add(lbl_main_text);
            Controls.Add(button_versa);
            Controls.Add(button_start);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_result);
            Controls.Add(label1);
            Controls.Add(tb_text);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MorseCode";
            Text = "MorseCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_main_text;
        private Button button_versa;
        private Button button_start;
        private Label label3;
        private Label label2;
        private TextBox tb_result;
        private Label label1;
        private TextBox tb_text;
    }
}