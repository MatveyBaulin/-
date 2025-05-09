using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class Form6 : Form
    {
        private int time = 20; // Сделать переменную полем класса
        public Form6()
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
            string audioFilePath = "C:/Работы 2 Курса/C#/Курсовой проект/Аудио/Огонёк(Диктант).mp3";

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
                if (radioButton3.Checked)
                {
                    Form1.TestResult.Score += 1; // или любое другое увеличение
                }
                timer1.Stop();
                Form7 nextForm = new Form7();
                nextForm.Show();
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (radioButton3.Checked)
            {
                Form1.TestResult.Score += 1; // или любое другое увеличение
            }
            // Создаем и показываем следующую форму
            Form7 nextForm = new Form7();
            nextForm.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
        }
    }
}
