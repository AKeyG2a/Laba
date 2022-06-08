using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba
{
    public partial class Form1 : Form
    {
        private Label label1; //Теккст
        private TextBox textBox1; //Для ввода текста
        private Button button; //кнопка

        public Form1()
        {
            InitializeComponent();
            //инициализация кнопки
            label1 = new Label()
            {
                Location = new Point(200, 200),
                Text = "Введите возраст",
                AutoSize = true
            };
            Controls.Add(label1);
            //инициализация окна для ввода текста
            textBox1 = new TextBox()
            {
                Location = new Point(200, 300),
                AutoSize = true
            };
            Controls.Add(textBox1);
            //иницияализация кнопки
            button = new Button()
            {
                Location = new Point(200, 400),
                Text = "Обновить",
                AutoSize = true
            };
            Controls.Add(button);
            button.Click += new EventHandler(ButtonClick); // привязка события
        }
        //событие вызываемое кнопкой
        private void ButtonClick(object sender, EventArgs e)
        {
            var age = textBox1.Text; // считывание текста 

            int.TryParse(age, out var a); //перевод из string в int

            /*switch (a)
            {
                case 10:
                    MessageBox.Show("Вы пиздюк");
                    break;
            }*/
            if (0 <= a && a <= 1)
                MessageBox.Show("Ваш период жизни: Младенчество");

            if (1 < a && a <= 3)
                MessageBox.Show("Ваш период жизни: Раннее детство");

            if (3 < a && a <= 6)
                MessageBox.Show("Ваш период жизни: Дошкольное детство");

            if (6 < a && a <= 10)
                MessageBox.Show("Ваш период жизни: Младший школьный возраст");

            if (10 < a && a <= 14)
                MessageBox.Show("Ваш период жизни: Школьный возраст");

            if (14 < a && a <= 17)
                MessageBox.Show("Ваш период жизни: Ранний юношеский возраст");

            if (18 <= a && a <= 23)
                MessageBox.Show("Ваш период жизни: Юношеский возраст");

            if (24 <= a && a <= 33)
                MessageBox.Show("Ваш период жизни: Молодость");

            if (34 <= a && a <= 50)
                MessageBox.Show("Ваш период жизни: Зрелость");

            if (50 < a && a <= 60)
                MessageBox.Show("Ваш период жизни: Пожилой возраст");

            if (60 < a && a <= 70)
                MessageBox.Show("Ваш период жизни: Старость");

            if (a > 70)
                MessageBox.Show("Ваш период жизни: Долгожительство");

        }

    }
}

