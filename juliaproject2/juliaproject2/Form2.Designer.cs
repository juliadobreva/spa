namespace juliaproject2
{
    partial class Form2
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
            customer_name = new TextBox();
            customer_phone = new TextBox();
            service_id = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            treatment_start = new ComboBox();
            treatment_end = new ComboBox();
            label4 = new Label();
            treatment_date = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // customer_name
            // 
            customer_name.BackColor = Color.Pink;
            customer_name.ForeColor = SystemColors.ControlDarkDark;
            customer_name.Location = new Point(54, 65);
            customer_name.Name = "customer_name";
            customer_name.Size = new Size(217, 23);
            customer_name.TabIndex = 0;
            customer_name.Text = "FIRST NAME";
            customer_name.TextAlign = HorizontalAlignment.Center;
            customer_name.TextChanged += textBox1_TextChanged;
            // 
            // customer_phone
            // 
            customer_phone.BackColor = Color.Pink;
            customer_phone.ForeColor = SystemColors.ControlDarkDark;
            customer_phone.Location = new Point(363, 65);
            customer_phone.Name = "customer_phone";
            customer_phone.Size = new Size(217, 23);
            customer_phone.TabIndex = 1;
            customer_phone.Text = "PHONE NUMBER";
            customer_phone.TextAlign = HorizontalAlignment.Center;
            // 
            // service_id
            // 
            service_id.FormattingEnabled = true;
            service_id.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            service_id.Location = new Point(54, 194);
            service_id.Name = "service_id";
            service_id.Size = new Size(217, 23);
            service_id.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 109);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 5;
            label1.Text = "BEGINNING OF TREATMENT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 173);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 6;
            label2.Text = "END OF TREATMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 176);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 7;
            label3.Text = "TREATMENT ID";
            // 
            // treatment_start
            // 
            treatment_start.ForeColor = SystemColors.WindowText;
            treatment_start.FormattingEnabled = true;
            treatment_start.Items.AddRange(new object[] { "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00" });
            treatment_start.Location = new Point(363, 127);
            treatment_start.Name = "treatment_start";
            treatment_start.Size = new Size(217, 23);
            treatment_start.TabIndex = 9;
            // 
            // treatment_end
            // 
            treatment_end.FormattingEnabled = true;
            treatment_end.Items.AddRange(new object[] { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00" });
            treatment_end.Location = new Point(363, 194);
            treatment_end.Name = "treatment_end";
            treatment_end.Size = new Size(217, 23);
            treatment_end.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 109);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 11;
            label4.Text = "TREATMENT DATE";
            label4.Click += label4_Click;
            // 
            // treatment_date
            // 
            treatment_date.Location = new Point(54, 130);
            treatment_date.Name = "treatment_date";
            treatment_date.Size = new Size(217, 23);
            treatment_date.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MistyRose;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(54, 36);
            label5.Name = "label5";
            label5.Size = new Size(207, 17);
            label5.TabIndex = 13;
            label5.Text = "Please provide your name again :)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MistyRose;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(321, 36);
            label6.Name = "label6";
            label6.Size = new Size(284, 17);
            label6.TabIndex = 14;
            label6.Text = "Your number, in case we need to contact you :P";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.download1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(363, 263);
            button1.Name = "button1";
            button1.Size = new Size(225, 31);
            button1.TabIndex = 17;
            button1.Text = "BOOK YOUR TREATMENT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.download1;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(54, 263);
            button2.Name = "button2";
            button2.Size = new Size(225, 31);
            button2.TabIndex = 18;
            button2.Text = "VIEW BOOKING";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(644, 335);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(treatment_date);
            Controls.Add(label4);
            Controls.Add(treatment_end);
            Controls.Add(treatment_start);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(service_id);
            Controls.Add(customer_phone);
            Controls.Add(customer_name);
            ForeColor = SystemColors.ControlText;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customer_name;
        private TextBox customer_phone;
        private ComboBox service_id;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox treatment_start;
        private ComboBox treatment_end;
        private Label label4;
        private DateTimePicker treatment_date;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}