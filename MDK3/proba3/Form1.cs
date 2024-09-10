using System;
using System.Drawing;
using System.Windows.Forms;

namespace proba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Изображение 1");
            comboBox1.Items.Add("Изображение 2");

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedItem = comboBox1.SelectedItem.ToString();
        string imagePath = string.Empty;

        switch (selectedItem)
        {
            case "Изображение 1":
                imagePath = @"C:\Users\Student\Downloads\fizio.png"; // Замените на ваш путь
                break;
            case "Изображение 2":
                imagePath = @"C:\Users\Student\Downloads\Bit.png"; // Замените на ваш путь
                break;
        }
        if (!string.IsNullOrEmpty(imagePath))
        {
            pictureBox1.Image = new Bitmap(imagePath);
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}