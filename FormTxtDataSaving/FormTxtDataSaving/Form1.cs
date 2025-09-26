using System;   
using System.IO;

namespace FormTxtDataSaving
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath, fileName, fileTxt;
        StreamWriter sw;
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = folderBrowserDialog1.SelectedPath;
                textBox1.Text = filePath;
                MessageBox.Show("Dosya yolu oluþturuldu..!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileName = textBox2.Text;
            sw = new StreamWriter(filePath + "\\" + fileName + ".txt");
            sw.WriteLine("Dosya Oluþturuldu.");
            sw.Close();
            MessageBox.Show("Dosya oluþturuldu..!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            fileTxt = textBox3.Text;
            sw.WriteLine(fileTxt);
            sw.Close();
            MessageBox.Show("Kayýt yapýldý..!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Kayýtlar.Items.Add(line);
                    }
                }
            }
            MessageBox.Show("Veriler Listelendi..!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
