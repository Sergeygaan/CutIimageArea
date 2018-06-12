using System;
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BadDat_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_BadDat.Text = openFileDialog1.FileName;
        }

        /// <summary>
        /// Метод формирования итоговой строки для передачи в консоль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
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

            textBoxResult.Text = Haarcascade + GoodVec + BadDat + NumStages + Minhitrate + MaxFalseAlarmRate + NumPos + NumNeg + Width + Height + Mode + Precalc;
        }

    }
}
