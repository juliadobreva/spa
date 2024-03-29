namespace juliaproject2
{
    partial class Form1
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            search = new Button();
            clear = new Button();
            book = new Button();
            comboBox4 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Pink;
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Massage", "Facial", "Manicure", "Haircut", "Body scrub", "Facial Treatment", "Coloring", "Steam Bath", "Deep Tissue Massage", "Mani-Pedi Combo" });
            comboBox1.Location = new Point(86, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Pink;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Spa Center", "Treatment Room 1", "Nail Salon", "Salon Floor", "Wellness Suite", "Treatment Room 2" });
            comboBox2.Location = new Point(294, 103);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.Pink;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "John Doe", "Jane Smith", "Chris Johnson", "Emily Davis", "Michael Brown", "Olivia White", "Andrew Taylor", "Emma Turner", "James Brown", "Lily Chen" });
            comboBox3.Location = new Point(504, 103);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(164, 23);
            comboBox3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Thistle;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(780, 232);
            dataGridView1.TabIndex = 3;
            // 
            // search
            // 
            search.BackColor = SystemColors.ButtonFace;
            search.DialogResult = DialogResult.Retry;
            search.ForeColor = Color.MediumVioletRed;
            search.Location = new Point(86, 428);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 4;
            search.Text = "FILTER";
            search.UseVisualStyleBackColor = false;
            search.Click += button1_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.ButtonFace;
            clear.DialogResult = DialogResult.Retry;
            clear.ForeColor = Color.MediumVioletRed;
            clear.Location = new Point(226, 428);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 5;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // book
            // 
            book.BackColor = SystemColors.ButtonFace;
            book.DialogResult = DialogResult.Retry;
            book.ForeColor = Color.MediumVioletRed;
            book.Location = new Point(791, 428);
            book.Name = "book";
            book.Size = new Size(75, 23);
            book.TabIndex = 6;
            book.Text = "BOOK";
            book.UseVisualStyleBackColor = false;
            book.Click += book_Click;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = Color.Pink;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Available" });
            comboBox4.Location = new Point(702, 103);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(164, 23);
            comboBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(190, 34);
            label3.Name = "label3";
            label3.Size = new Size(600, 28);
            label3.TabIndex = 14;
            label3.Text = "                                                                                                  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(86, 83);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 15;
            label2.Text = "Service type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(294, 83);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 16;
            label1.Text = "Service location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MistyRose;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(504, 83);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 17;
            label4.Text = "Employee:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MistyRose;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(702, 83);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 18;
            label5.Text = "Availability:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(969, 490);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboBox4);
            Controls.Add(book);
            Controls.Add(clear);
            Controls.Add(search);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
        private Button search;
        private Button clear;
        private Button book;
        private ComboBox comboBox4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}