using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CutImageArea
{
    /// <summary>
    /// Класс, для формирования строки по обучению каскада хаара
    /// </summary>
    public partial class CascadeTraining : Form
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public CascadeTraining()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Адрес папки с куда класть готовый каскад после обучения
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events"> Cодержащих данные событий.</param>
        private void button1_Click(object sender, EventArgs events)
        {
            using (var FolderDialog = new FolderBrowserDialog())
            {
                if (FolderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_Haarcascade.Text = FolderDialog.SelectedPath;
                }
            }

        }

        /// <summary>
        /// Путь до файла описания положительных изображений .vec
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events">Класс, выполняющий передачу событий.</param>
        private void button2_Click(object sender, EventArgs events)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_GoodVec.Text = openFileDialog1.FileName;
        }

        /// <summary>
        /// Путь до файла описания положительных изображений Bad.dat
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events">Класс, выполняющий передачу событий.</param>
        private void BadDat_Click(object sender, EventArgs events)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_BadDat.Text = openFileDialog1.FileName;
        }

        /// <summary>
        /// Путь до файла выполняюжего обучение каскада
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events">Класс, выполняющий передачу событий.</param>
        private void Opencv_Traincascade_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBoxResult.Text = openFileDialog1.FileName;
        }

        /// <summary>
        /// Метод формирования итоговой строки для передачи в консоль
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events">Класс, выполняющий передачу событий.</param>
        private void button4_Click(object sender, EventArgs events)
        {
            string Haarcascade = "-data " + textBox_Haarcascade.Text + " ";
            string GoodVec = "-vec " + textBox_GoodVec.Text + " ";
            string BadDat = "-bg " + textBox_BadDat.Text + " ";
            string NumStages = "-numStages " + numericUpDown_NumStages.Value.ToString() + " ";
            string Minhitrate = "-minhitrate " + numericUpDown_Minhitrate.Value.ToString() + " ";
            string MaxFalseAlarmRate = "-maxFalseAlarmRate " + numericUpDown_MaxFalseAlarmRate.Value.ToString() + " ";
            string NumPos = "-numPos " + numericUpDown_NumPos.Value.ToString() + " ";
            string NumNeg = "-numNeg " + numericUpDown_NumNeg.Value.ToString() + " ";
            string Width = "-w " + WidthNumericUpDown.Value.ToString() + " ";
            string Height = " -h " + HeightNumericUpDown.Value.ToString() + " ";
            string Mode = "-mode ALL ";
            string Precalc = "-precalcValBufSize " + numericUpDown_Precalc.Value.ToString() + " -precalcIdxBufSize " + numericUpDown_Precalc.Value.ToString();

            string TextResult = Haarcascade + GoodVec + BadDat + NumStages + Minhitrate + MaxFalseAlarmRate + NumPos + NumNeg + Width + Height + Mode + Precalc;

            try
            {
                Process Process_Opencv_Traincascade = new Process();
                ProcessStartInfo CommandLine = new ProcessStartInfo();

                //Указываем, где лежит exe, и определяем, с какими параметрами приложение будет запускаться
                CommandLine.FileName = textBoxResult.Text;
                CommandLine.Arguments = TextResult;

                // Запускаем Алармы
                Process_Opencv_Traincascade.StartInfo = CommandLine;
                Process_Opencv_Traincascade.Start();
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
