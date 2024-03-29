namespace juliaproject2
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            length = new Label();
            capital = new Label();
            number = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 46);
            label1.Name = "label1";
            label1.Size = new Size(197, 28);
            label1.TabIndex = 0;
            label1.Text = "REGISRATION FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 1;
            label2.Text = "Username : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(25, 167);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 2;
            label3.Text = "E-mail : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MistyRose;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(25, 224);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 3;
            label4.Text = "Password : ";
            // 
            // length
            // 
            length.AutoSize = true;
            length.BackColor = Color.MistyRose;
            length.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            length.Location = new Point(47, 284);
            length.Name = "length";
            length.Size = new Size(215, 12);
            length.TabIndex = 4;
            length.Text = "Your password should include more than 8 characters.";
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.BackColor = Color.MistyRose;
            capital.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            capital.Location = new Point(47, 310);
            capital.Name = "capital";
            capital.Size = new Size(221, 12);
            capital.TabIndex = 5;
            capital.Text = "Your password should include at least one capital letter.";
            // 
            // number
            // 
            number.AutoSize = true;
            number.BackColor = Color.MistyRose;
            number.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            number.Location = new Point(47, 334);
            number.Name = "number";
            number.Size = new Size(203, 12);
            number.TabIndex = 6;
            number.Text = "Your password should include at least one number.";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Linen;
            textBox1.Location = new Point(25, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 10;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Linen;
            textBox2.Location = new Point(25, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 11;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Linen;
            textBox3.Location = new Point(25, 244);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Validating += textBox3_Validating;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.download1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(72, 358);
            button1.Name = "button1";
            button1.Size = new Size(160, 31);
            button1.TabIndex = 16;
            button1.Text = "CREATE ACCOUNT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.MistyRose;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(43, 405);
            label9.Name = "label9";
            label9.Size = new Size(219, 13);
            label9.TabIndex = 17;
            label9.Text = "Already have an account? Login instead :)";
            label9.Click += label9_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(318, 458);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(number);
            Controls.Add(capital);
            Controls.Add(length);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label length;
        private Label capital;
        private Label number;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label9;
    }
}