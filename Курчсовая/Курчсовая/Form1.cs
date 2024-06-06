using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Курчсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
                    if (radioButton10.Checked)
                    {
                        richTextBox1.Text = "Мультиплексор - устройство, имеющее несколько сигнальных входов, один или более управляющих входов и один выход. Мультиплексор позволяет передавать сигнал с одного из входов на выход; при этом выбор желаемого входа осуществляется подачей соответствующей комбинации управляющих сигналов.";
                        string imagePath = @"C:\Users\kbeke\Downloads\multi1.jpg";
                        pictureBox1.BackgroundImage = Image.FromFile(imagePath);
                        pictureBox1.Width = 236;
                        pictureBox1.Height = 253;
                        string sumImagePath = @"C:\Users\kbeke\Downloads\multi.jpg";
                        pictureBox2.BackgroundImage = Image.FromFile(sumImagePath);
                        pictureBox2.Width = 229;
                        pictureBox2.Height = 288;
                        richTextBox2.Text = "Заполни все поля этими значениями: 0 или 1";
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                    }
                    else
                    {
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                    }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                richTextBox1.Text = "Шифратор — логическое устройство, выполняющее преобразование позиционного кода в n-разрядный двоичный код.";
                string imagePath = @"C:\Users\kbeke\Downloads\15.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(imagePath);
                pictureBox1.Width = 184;
                pictureBox1.Height = 160;
                string sumImagePath = @"C:\Users\kbeke\Downloads\16.jpg";
                pictureBox2.BackgroundImage = Image.FromFile(sumImagePath);
                pictureBox2.Width = 192;
                pictureBox2.Height = 189;
                richTextBox2.Text = "Заполни все поля этими значениями: 0 и 1. Можно вводить только одно значение 1";
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                richTextBox1.Text = "Демультиплексор — это логическое устройство, предназначенное для переключения сигнала с одного информационного входа на один из информационных выходов. Таким образом, демультиплексор в функциональном отношении противоположен мультиплексору.";
                string imagePath = @"C:\Users\kbeke\Downloads\13.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(imagePath);
                pictureBox1.Width = 235;
                pictureBox1.Height = 281;
                string sumImagePath = @"C:\Users\kbeke\Downloads\14.jpg";
                pictureBox2.BackgroundImage = Image.FromFile(sumImagePath);
                pictureBox2.Width = 309;
                pictureBox2.Height = 228;
                richTextBox2.Text = "Заполни поле 1, поле 2 этими значениями: 0 и 1";
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                richTextBox1.Text = "Полусумматор - это логическая схема, способная складывать два одноразрядных двоичных числа";
                string imagePath = @"C:\Users\kbeke\Downloads\11.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(imagePath);
                pictureBox1.Width = 247;
                pictureBox1.Height = 125;
                string sumImagePath = @"C:\Users\kbeke\Downloads\12.jpg";
                pictureBox2.BackgroundImage = Image.FromFile(sumImagePath);
                pictureBox2.Width = 235;
                pictureBox2.Height = 180;
                richTextBox2.Text = "Заполни поле 1, поле 2 этими значениями: 0 и 1";
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                richTextBox1.Text = "Сумматор – логическая схема, которая способна суммировать 2 одноразрядных двоичных числа с переносом из предыдущего разряда.";
                string imagePath = @"C:\Users\kbeke\Downloads\summator.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(imagePath);
                pictureBox1.Width = 230;
                pictureBox1.Height = 140;
                string sumImagePath = @"C:\Users\kbeke\Downloads\sum.jpg";
                pictureBox2.BackgroundImage = Image.FromFile(sumImagePath);
                pictureBox2.Width = 209;
                pictureBox2.Height = 228;
                richTextBox2.Text = "Заполни поле 1, поле 2 и поле 3 этими значениями: 0 и 1";
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                richTextBox1.Text = "Триггер – это основной элемент электронной вычислительной машины устройство, имеющее два устойчивых состояния, 0 и 1.";
                string imagePath = @"C:\Users\kbeke\Downloads\triggeer.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(imagePath);
                pictureBox1.Width = 185;
                pictureBox1.Height = 140;
                richTextBox2.Text = "Заполни поле 1, и поле 2 этими значениями: 0 и 1";
                string trigImagePath = @"C:\Users\kbeke\Downloads\trig.jpg";
                pictureBox2.BackgroundImage = Image.FromFile(trigImagePath);
                pictureBox2.Width = 185;
                pictureBox2.Height = 125;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                richTextBox1.Text = "Инвертор - простейший логический элемент, выполняющий функцию отрицания. Если на вход поступает сигнал, соответствующий единице, то на выходе будет ноль. И наоборот.";
                string imagePath = @"C:\Users\kbeke\Downloads\invertorr.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(imagePath);
                pictureBox1.Width = 160;
                pictureBox1.Height = 119;
                richTextBox2.Text = "Заполни поле 1 значениями: 0 или 1";
                string dizImagePath = @"C:\Users\kbeke\Downloads\inv.jpg";
                pictureBox2.BackgroundImage = Image.FromFile(dizImagePath);
                pictureBox2.Width = 108;
                pictureBox2.Height = 114;
                textBox2.Enabled = true;
            }
            else textBox2.Enabled = false;

        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                richTextBox1.Text = "Дизъюнктор - выдает на выходе значение логической суммы входных сигналов. Он имеет один выход и не менее двух входов.";
                richTextBox2.Text = "Заполни поле 1, и поле 2 этими значениями: 0 и 1";
                string imagePath = @"C:\Users\kbeke\Downloads\111.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(imagePath);
                pictureBox1.Width = 157;
                pictureBox1.Height = 95;
                string dizImagePath = @"C:\Users\kbeke\Downloads\diztab.jpg";
                pictureBox2.BackgroundImage = Image.FromFile(dizImagePath);
                pictureBox2.Width = 222;
                pictureBox2.Height = 226;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
          
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                richTextBox1.Text = "Конъюктор - операция, соединяющая два или более высказываний при помощи логической связки или. Результат операции может быть истинным только в том случае, если одновременно истинны исходные высказывания ";
                string imagedPath = @"C:\Users\kbeke\Downloads\konyktor.jpg";
                string konImagePath = @"C:\Users\kbeke\Downloads\kontab.jpg";
                pictureBox2.BackgroundImage = Image.FromFile(konImagePath);
                pictureBox2.Width = 132;
                pictureBox2.Height = 98;
                pictureBox1.BackgroundImage = Image.FromFile(imagedPath);
                pictureBox1.Width = 267;
                pictureBox1.Height = 178;
                richTextBox2.Text = "Заполни поле 1, и поле 2 этими значениями: 0 и 1";
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;

            }
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                richTextBox1.Text = "Дешифратор — это комбинационное логическое устройство, которое предназначено для преобразования двойного двоичного кода в необходимый сигнал управления в какой-либо системе исчисления на одном из выходов.";
                string imagePath = @"C:\Users\kbeke\Downloads\deshivrator.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(imagePath);
                pictureBox1.Width = 365;
                pictureBox1.Height = 328;
                string desmagePath = @"C:\Users\kbeke\Downloads\desh.jpg";
                pictureBox2.BackgroundImage = Image.FromFile(desmagePath);
                pictureBox2.Width = 232;
                pictureBox2.Height = 110;
                richTextBox2.Text = "Заполни поле 1, и поле 2 этими значениями: 0 и 1";
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;

            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);

                if (a == 0 && b == 0) textBox1.Text = "0";
                else textBox1.Text = "1";
            }
            if (radioButton4.Checked)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                int c = int.Parse(textBox4.Text);
                if (a == 0 && b == 0 && c == 0) textBox1.Text = "0|0";
                else if (a == 0 && b == 0 && c == 1 || a == 0 && b == 1 && c == 0 || a == 1 && b == 0 && c == 0) textBox1.Text = "0|1";
                else if (a == 0 && b == 1 && c == 1 || a == 1 && b == 0 && c == 1 || a == 1 && b == 1 && c == 0) textBox1.Text = "1|0";
                else textBox1.Text = "1|1";
            }
            if (radioButton8.Checked)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);

                if (a == 1 && b == 1) textBox1.Text = "1";
                else textBox1.Text = "0";
            }
            if (radioButton5.Checked)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);

                if (a == 0 && b == 0) textBox1.Text = "1";
                else textBox1.Text = "0";
            }
            if (radioButton6.Checked)
            {
                int a = int.Parse(textBox2.Text);

                if (a == 1) textBox1.Text = "0";
                else textBox1.Text = "1";
            }
            if (radioButton9.Checked)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);

                if (a == 0 && b == 0) textBox1.Text = "1|0|0|0";
                else if (a == 0 && b == 1) textBox1.Text = "0|1|0|0";
                else if (a == 1 && b == 0) textBox1.Text = "0|0|1|0";
                else if (a == 1 && b == 1) textBox1.Text = "0|0|0|1";
            }
            if (radioButton10.Checked)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                int c = int.Parse(textBox4.Text);
                int d = int.Parse(textBox5.Text);

                if (a == 0 && b == 0 && c == 0 && d == 0 || a == 0 && b == 0 && c == 1 && d == 0 || a == 0 && b == 0 && c == 1 && d == 1 || a == 0 && b == 1 && c == 1 && d == 1 || a == 0 && b == 1 && c == 1 && d == 1 || a == 0 && b == 1 && c == 1 && d == 1 || a == 1 && b == 0 && c == 0 && d == 0 || a == 1 && b == 1 && c == 0 && d == 0) textBox1.Text = "0";
                else textBox1.Text = "1";
            }
            if (radioButton3.Checked)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                if (a == 0 && b == 0) textBox1.Text = "0|0";
                else if (a == 1 && b == 1) textBox1.Text = "1|0";
                else textBox1.Text = "0|1";
            }
            if (radioButton2.Checked)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                if (a == 0 && b == 0) textBox1.Text = "0|0|0|-";
                else if (a == 0 && b == 1) textBox1.Text = "0|0|-|0";
                else if (a == 1 && b == 1) textBox1.Text = "-|0|0|0";
                else if (a == 1 && b == 0) textBox1.Text = "0|-|0|0";
            }
            if (radioButton1.Checked)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                int c = int.Parse(textBox4.Text);
                int d = int.Parse(textBox5.Text);
                if (a == 1 && b == 0 && c == 0 && d == 0) textBox1.Text = "0|0";
                else if (a == 0 && b == 1 && c == 0 && d == 0) textBox1.Text = "0|1";
                else if (a == 0 && b == 0 && c == 1 && d == 0) textBox1.Text = "1|0";
                else if (a == 0 && b == 0 && c == 0 && d == 1) textBox1.Text = "1|1";
                else textBox1.Text = "Неверные входные данные";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0' && e.KeyChar <= '1') && textBox2.Text.Length < 1) || (int)e.KeyChar == 8)) e.KeyChar = (char)0;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0' && e.KeyChar <= '1') && textBox3.Text.Length < 1) || (int)e.KeyChar == 8)) e.KeyChar = (char)0;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0' && e.KeyChar <= '1') && textBox4.Text.Length < 1) || (int)e.KeyChar == 8)) e.KeyChar = (char)0;
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0' && e.KeyChar <= '1') && textBox5.Text.Length < 1) || (int)e.KeyChar == 8)) e.KeyChar = (char)0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.KeyChar = (char)0;
        }
    }
}
