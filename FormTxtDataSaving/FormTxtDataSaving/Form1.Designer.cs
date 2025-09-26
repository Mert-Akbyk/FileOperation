namespace FormTxtDataSaving
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            Kayıtlar = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Variable Small", 7.8F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(560, 95);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Dosya Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Variable Small", 7.8F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(560, 139);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Oluştur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Kayıtlar
            // 
            Kayıtlar.BackColor = Color.Thistle;
            Kayıtlar.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Kayıtlar.ForeColor = SystemColors.InfoText;
            Kayıtlar.FormattingEnabled = true;
            Kayıtlar.Location = new Point(22, 276);
            Kayıtlar.Name = "Kayıtlar";
            Kayıtlar.Size = new Size(747, 92);
            Kayıtlar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(112, 95);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 4;
            label1.Text = "Dosya Yolu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Bold);
            label2.Location = new Point(120, 139);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 5;
            label2.Text = "Dosya Adı :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 27);
            textBox2.TabIndex = 6;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Variable Small", 7.8F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(560, 183);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Kaydet";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(229, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(325, 27);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Bold);
            label3.Location = new Point(92, 186);
            label3.Name = "label3";
            label3.Size = new Size(131, 22);
            label3.TabIndex = 9;
            label3.Text = "Metin Kaydet :";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Variable Small", 7.8F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(22, 241);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Listele";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Variable Small", 7.8F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(675, 241);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 11;
            button5.Text = "Çıkış";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(229, 9);
            label4.Name = "label4";
            label4.Size = new Size(356, 62);
            label4.TabIndex = 12;
            label4.Text = "Dosya İşlemleri";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 404);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Kayıtlar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Dosya Sistemleri Paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private ListBox Kayıtlar;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button3;
        private TextBox textBox3;
        private Label label3;
        private Button button4;
        private Button button5;
        private Label label4;
    }
}
