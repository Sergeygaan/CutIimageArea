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
        private void Button_Click_PathCascade(object sender, EventArgs events)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_Haarcascade.Text = folderDialog.SelectedPath;
                }
            }

        }

        /// <summary>
        /// Путь до файла описания положительных изображений .vec
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events">Класс, выполняющий передачу событий.</param>
        private void Button_Click_GoodVec(object sender, EventArgs events)
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
        private void Opencv_Traincascade_Click(object sender, EventArgs events)
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
        private void Button_Click_Result(object sender, EventArgs events)
        {
            string haarcascade = "-data " + textBox_Haarcascade.Text + " ";
            string goodVec = "-vec " + textBox_GoodVec.Text + " ";
            string badDat = "-bg " + textBox_BadDat.Text + " ";
            string numStages = "-numStages " + numericUpDown_NumStages.Value + " ";
            string minhitrate = "-minhitrate " + numericUpDown_Minhitrate.Value + " ";
            string maxFalseAlarmRate = "-maxFalseAlarmRate " + numericUpDown_MaxFalseAlarmRate.Value + " ";
            string numPos = "-numPos " + numericUpDown_NumPos.Value + " ";
            string numNeg = "-numNeg " + numericUpDown_NumNeg.Value + " ";
            string width = "-w " + WidthNumericUpDown.Value + " ";
            string height = " -h " + HeightNumericUpDown.Value + " ";
            string mode = "-mode ALL ";
            string precalc = "-precalcValBufSize " + numericUpDown_Precalc.Value + " -precalcIdxBufSize " + numericUpDown_Precalc.Value;

            string textResult = haarcascade + goodVec + badDat + numStages + minhitrate + maxFalseAlarmRate + numPos + numNeg + width + height + mode + precalc;

            try
            {
                Process processTrainCascade = new Process();
                ProcessStartInfo commandLine = new ProcessStartInfo();

                //Указываем, где лежит exe, и определяем, с какими параметрами приложение будет запускаться
                commandLine.FileName = textBoxResult.Text;
                commandLine.Arguments = textResult;

                // Запускаем Алармы
                processTrainCascade.StartInfo = commandLine;
                processTrainCascade.Start();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
