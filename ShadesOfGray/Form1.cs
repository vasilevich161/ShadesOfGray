using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadesOfGray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int MyWidth=240;   //ширина картинки по умолчанию
        int MyHeight=128;  //высота картинки по умолчанию
        String Bintext2 = "";
        int blackLevel = 200; // порог уровня черного для конвертации
        // кнопка Открыть
        private void openButton_Click(object sender, EventArgs e)
        {
            // диалог для выбора файла
            OpenFileDialog ofd = new OpenFileDialog();
            // фильтр форматов файлов
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // загружаем изображение
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // кнопка Сохранить
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null) // если изображение в pictureBox2 имеется
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true; // показывать ли "Перезаписать файл" если пользователь указывает имя файла, который уже существует
                sfd.CheckPathExists = true; // отображает ли диалоговое окно предупреждение, если пользователь указывает путь, который не существует
                // фильтр форматов файлов
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                sfd.ShowHelp = true; // отображается ли кнопка Справка в диалоговом окне
                // если в диалоге была нажата кнопка ОК
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // сохраняем изображение
                        pictureBox2.Image.Save(sfd.FileName);
                    }
                    catch // в случае ошибки выводим MessageBox
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // кнопка Ч/Б
        private void grayButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) // если изображение в pictureBox1 имеется
            {
                // создаём Bitmap из изображения, находящегося в pictureBox1
                Bitmap input1 = new Bitmap(pictureBox1.Image);
              if (input1.Width >= MyWidth && input1.Height >= MyHeight)   // если картинка подходит по размрам
              {
                 ConvertImageText();
                //  Bintext2 = Bintext2.Remove(Bintext2.Length - 1); // убираем последнию запятую
                  textBox1.Text = "{ " + Bintext2 + " };";
                }
               else
               {
                    MessageBox.Show("Изображение меньше требуемого", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelTest.Text = "МЕЛКО";
                    labelWidth1.Text = input1.Width.ToString();
                    labelHeight1.Text = input1.Height.ToString();
               }
        }
                 
           
}
        private void ConvertImageText()
        {
            int[] MyArray = new int[8];
            short point=0, val = 0;
            Bitmap input = new Bitmap(pictureBox1.Image);
            Bitmap output = new Bitmap(input.Width, input.Height);
           String Bintext1 = "";  // чистим
                  Bintext2 = "";  // чистим 
                output = new Bitmap(MyWidth, MyHeight);
                labelWidth1.Text = MyWidth.ToString();
                labelHeight1.Text = MyHeight.ToString();
                // перебираем в циклах все пиксели исходного изображения
                 for (int j = 0; j < MyHeight; j++)
                    for (int i = 0; i < MyWidth; i++)
                    {
                        // получаем (i, j) пиксель
                        UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                        // получаем компоненты цветов пикселя
                        float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                        float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                        float B = (float)(pixel & 0x000000FF); // синий
                                                               // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                        R = (R + G + B) / 3.0f;
                        // собираем новый пиксель по частям (по каналам)
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        // если уровень черного выше заданного уровня
                        if (R > blackLevel)
                        {
                            newPixel = 0xFFFFFFFF; val = 0;
                        }
                        else
                        {
                            newPixel = 0xFF000000; val = 1;
                        }
                        if (point <= 7)
                        {
                            MyArray[point] = val;
                            Bintext1 = Bintext1 + Convert.ToString(val);
                            if (point == 7)
                            {
                                int xx = 0;
                                for (int z = 1, m = 0; m <= 7; m++)
                                {
                                    xx = xx + MyArray[m] * z;
                                    z = z * 2;
                                }
                                Bintext1 = Convert.ToString(xx, 16);
                                Bintext2 = Bintext2 + "0x" + Bintext1 + ", ";
                                point = 0; Bintext1 = "";
                            }
                            else point++;
                        }
                        // добавляем его в Bitmap нового изображения
                        output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                // выводим черно-белый Bitmap в pictureBox2
                pictureBox2.Image = output;
        }
        private void zoomImage(int x,int y)
        {
            MyWidth = x; MyHeight = y;
            pictureBox2.Image = null; textBox1.Text = "";   // чистим 2 экран и стираем старый текст, при смене размера картинки
            pictureBox1.Width = MyWidth; pictureBox1.Height = MyHeight;
            pictureBox2.Width = MyWidth; pictureBox2.Height = MyHeight;
        }
        private void radioButton128x64_CheckedChanged(object sender, EventArgs e)
        {
            zoomImage(128, 64);
        }

        private void radioButton240x64_CheckedChanged(object sender, EventArgs e)
        {
            zoomImage(240, 64);
        }

        private void radioButton128x32_CheckedChanged(object sender, EventArgs e)
        {
            zoomImage(128, 32);
        }

        private void radioButton240x128_CheckedChanged(object sender, EventArgs e)
        {
            zoomImage(240, 128);
        }

        private void radioButtonRandom_CheckedChanged(object sender, EventArgs e)
        {
            zoomImage(128, 64); // тут будет другое со временем
        }
    }
}
