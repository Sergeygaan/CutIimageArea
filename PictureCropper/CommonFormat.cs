using System;
using System.Windows.Forms;

namespace CutImageArea
{
    /// <summary>
    /// Класс, для формирования строки для приведения положительных примеров к единому виду
    /// </summary>
    public partial class CommonFormat : Form
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public CommonFormat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Путь до файла описания положительных изображений Good.dat
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events"> Cодержащих данные событий.</param>
        private void button_GoodDat_Click(object sender, EventArgs events)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_GoodDat.Text = openFileDialog1.FileName;
        }

        /// <summary>
        /// Путь, куда сохранять выходной файл с приведенными к общему формату положительными изображениями
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events"> Cодержащих данные событий.</param>
        private void button_GoodVec_Click(object sender, EventArgs events)
        {
            using (var FolderDialog = new FolderBrowserDialog())
            {
                if (FolderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_GoodVec.Text = FolderDialog.SelectedPath;
                }
            }
        }

        /// <summary>
        /// Метод формирования итоговой строки для передачи в консоль
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events"> Cодержащих данные событий.</param>
        private void button_Format_Click(object sender, EventArgs events)
        {
            string GoodDat = "-info " + textBox_GoodDat.Text + " ";
            string GoodVec = "-vec " + textBox_GoodVec.Text + "\\" + textBox_NameVec.Text + ".vec ";
            string Width = "-w " + WidthNumericUpDown.Value.ToString() + " ";
            string Height = " -h " + HeightNumericUpDown.Value.ToString() + " ";

            textBoxResult.Text = GoodDat + GoodVec + Width + Height;
        }
    }
}
