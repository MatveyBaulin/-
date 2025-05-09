using System;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class Form10 : Form
    {
        private int time = 20; // Сделать переменную полем класса
        public Form10()
        {
            InitializeComponent();
            label1.Text = "Осталось времени: " + time.ToString();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        public static class TestResult
        {
            public static int Score { get; set; } = 0;
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string audioFilePath = "C:/Работы 2 Курса/C#/Курсовой проект/Аудио/Казаки_в_Берлине(Диктант).mp3";

            // Назначьте файл компоненту
            axWindowsMediaPlayer1.URL = audioFilePath;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                label1.Text = "Осталось времени: " + time.ToString();
            }
            else
            {
                if (radioButton2.Checked)
                {
                    Form1.TestResult.Score += 1; // или любое другое увеличение
                }
                timer1.Stop();
                Form11 nextForm = new Form11();
                nextForm.Show();
                switch (Form1.TestResult.Score)
                {
                    case int i when (i >= 0 && i <= 3):
                        MessageBox.Show("Ваш результат: " + Convert.ToString(Form1.TestResult.Score) + "\nВам стоит попробовать запомнить песни ещё раз. У Вас всё получится!");
                        break;
                    case int i when (i > 3 && i <= 6):
                        MessageBox.Show("Ваш результат: " + Convert.ToString(Form1.TestResult.Score) + "\nСтоит ещё раз послушать песни для более высокого результата. У Вас всё получится!");
                        break;
                    case int i when (i > 6 && i <= 9):
                        MessageBox.Show("Ваш результат: " + Convert.ToString(Form1.TestResult.Score) + "\nНеплохой результат! Попробуйте послушать песни ещё раз для наивысшего результата. У Вас всё получится!");
                        break;
                    case 10:
                        MessageBox.Show("Ваш результат: " + Convert.ToString(Form1.TestResult.Score) + "\nВы запомнили все песни Великой Отечественной Войны! Так держать!");
                        break;
                }
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (radioButton2.Checked)
            {
                Form1.TestResult.Score += 1; // или любое другое увеличение
            }
            // Создаем и показываем следующую форму
            Form11 nextForm = new Form11();
            nextForm.Show();
            switch(Form1.TestResult.Score)
            {
                case int i when(i >= 0 && i <= 3):
                    MessageBox.Show("Ваш результат: " + Convert.ToString(Form1.TestResult.Score) + "\nВам стоит попробовать запомнить песни ещё раз. У Вас всё получится!");
                    break;
                case int i when (i > 3 && i <= 6):
                    MessageBox.Show("Ваш результат: " + Convert.ToString(Form1.TestResult.Score) + "\nСтоит ещё раз послушать песни для более высокого результата. У Вас всё получится!");
                    break;
                case int i when (i > 6 && i <= 9):
                    MessageBox.Show("Ваш результат: " + Convert.ToString(Form1.TestResult.Score) + "\nНеплохой результат! Попробуйте послушать песни ещё раз для наивысшего результата. У Вас всё получится!");
                    break;
                case 10:
                    MessageBox.Show("Ваш результат: " + Convert.ToString(Form1.TestResult.Score) + "\nВы запомнили все песни Великой Отечественной Войны! Так держать!");
                    break;
            }
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
