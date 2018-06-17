using System;
using System.Diagnostics;
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
        /// Путь, до файла выполняюжего приведение положительных изображений к единому виду
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events"> Cодержащих данные событий.</param>
        private void PathButtom_Click(object sender, EventArgs e)
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
        /// <param name="events"> Cодержащих данные событий.</param>
        private void button_Format_Click(object sender, EventArgs events)
        {
            string GoodDat = "-info " + textBox_GoodDat.Text + " ";
            string GoodVec = "-vec " + textBox_GoodVec.Text + "\\" + textBox_NameVec.Text + ".vec ";
            string Width = "-w " + WidthNumericUpDown.Value.ToString() + " ";
            string Height = " -h " + HeightNumericUpDown.Value.ToString() + " ";

            string TextResult = GoodDat + GoodVec + Width + Height;

            Process Process_Opencv_Traincascade = new Process();
            ProcessStartInfo CommandLine = new ProcessStartInfo();

            //Указываем, где лежит exe, и определяем, с какими параметрами приложение будет запускаться
            CommandLine.FileName = textBoxResult.Text;
            CommandLine.Arguments = TextResult;

            // Запускаем Алармы
            Process_Opencv_Traincascade.StartInfo = CommandLine;
            Process_Opencv_Traincascade.Start();
        }
    }
}
