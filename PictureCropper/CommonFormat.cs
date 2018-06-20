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
        private void Button_GoodDat_Click(object sender, EventArgs events)
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
        private void Button_GoodVec_Click(object sender, EventArgs events)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_GoodVec.Text = folderDialog.SelectedPath;
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
        private void Button_Format_Click(object sender, EventArgs events)
        {
            string goodDat = "-info " + textBox_GoodDat.Text + " ";
            string goodVec = "-vec " + textBox_GoodVec.Text + "\\" + textBox_NameVec.Text + ".vec ";
            string width = "-w " + WidthNumericUpDown.Value.ToString() + " ";
            string height = " -h " + HeightNumericUpDown.Value.ToString() + " ";

            string textResult = goodDat + goodVec + width + height;

            try
            {
                Process process_Opencv_Traincascade = new Process();
                ProcessStartInfo commandLine = new ProcessStartInfo();

                //Указываем, где лежит exe, и определяем, с какими параметрами приложение будет запускаться
                commandLine.FileName = textBoxResult.Text;
                commandLine.Arguments = textResult;

                // Запускаем Алармы
                process_Opencv_Traincascade.StartInfo = commandLine;
                process_Opencv_Traincascade.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
