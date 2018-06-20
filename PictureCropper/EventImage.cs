using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CutImageArea
{
    /// <summary>
    /// Класс, для обработки изображений
    /// </summary>
    class EventImage
    {
        /// <summary>
        /// Адрес файла с описанием
        /// </summary>
        private string _fileAdress;

        /// <summary>
        /// Номер текущего изображения в папке
        /// </summary>
        private int _currentImageIndex = -1;

        /// <summary>
        /// Отображение текущего номера картинки
        /// </summary>
        private Label _countImage;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="countImage">Переменная, для вывода на форму номера текущей картинки.</param>
        public EventImage(Label countImage)
        {
            _countImage = countImage;
        }

        /// <summary>
        /// Взятие следующего изображения из папки
        /// </summary>
        /// <param name="fileLocationList"> Список загруженных изображений.</param>
        /// <param name="currentImage"> Текущее изображение.</param> 
        /// <param name="pictureWindow"> Форма для вывода изображения.</param>
        public Image<Bgr, Byte> NextNumber(List<string> fileLocationList, Image<Bgr, Byte> currentImage, Emgu.CV.UI.ImageBox pictureWindow)
        {
            if (_currentImageIndex < fileLocationList.Count - 1)
            {
                _currentImageIndex += 1;

                //вывод текста с номером текущего изображения
                _countImage.Text = (_currentImageIndex + 1).ToString() + " из " + fileLocationList.Count.ToString();

                if (File.Exists(fileLocationList[_currentImageIndex]))
                {
                    currentImage = new Image<Emgu.CV.Structure.Bgr, byte>(fileLocationList[_currentImageIndex]);
                    pictureWindow.Image = currentImage;
                }
            }
            else
            {
                _currentImageIndex += 1;

                MessageBox.Show("Изображения закончились");
            }

            return currentImage;
        }

        /// <summary>
        /// Метод, для сохранения изображения
        /// </summary>
        /// <param name="fileLocationList"> Список загруженных изображений.</param>
        /// <param name="carvedImage"> Вырезанная часть изображения.</param> 
        public void SaveImage(List<string> fileLocationList, Image<Bgr, Byte> carvedImage)
        {
            if ((fileLocationList.Count != 0) && ((_currentImageIndex < fileLocationList.Count)))
            {
                string Path = fileLocationList[_currentImageIndex].Substring(0, fileLocationList[_currentImageIndex].LastIndexOf("\\") + 1) + "Good";

                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }

                string PathImageName = fileLocationList[_currentImageIndex].Substring(fileLocationList[_currentImageIndex].LastIndexOf("\\"), fileLocationList[_currentImageIndex].Length - fileLocationList[_currentImageIndex].LastIndexOf("\\") - 4) + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".bmp";

                Path = Path + PathImageName;

                carvedImage.Save(Path);

                File.AppendAllText(_fileAdress, PathImageName + "  1  " + "0 0 " + carvedImage.Width + " " + carvedImage.Height + "\r\n");
            }
        }

        /// <summary>
        /// Метод, для загрузки всех изображений из папки
        /// </summary>
        /// <param name="fileLocationList"> Список загруженных изображений.</param>
        public void LoadImage(List<string> fileLocationList)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = Environment.CurrentDirectory;

            if (folderBrowser.ShowDialog() == DialogResult.OK) //Откроем папку с изображениями
            {
                string folder = folderBrowser.SelectedPath;

                DirectoryInfo thisDirectory = new DirectoryInfo(folder);
                FileInfo[] fileInfo = thisDirectory.GetFiles();

                for (int Index = 0; Index < fileInfo.Length; Index++) //Запишем все изображения из папки в лист
                {
                    if ((fileInfo[Index].Extension == ".jpg") || (fileInfo[Index].Extension == ".jpeg") || (fileInfo[Index].Extension == ".bmp") || (fileInfo[Index].Extension == ".png"))
                    {
                        fileLocationList.Add(fileInfo[Index].FullName);
                    }
                }

                string path = folder + "\\Good\\Good.dat";

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                _fileAdress = path;
            }
        }
    }
}
