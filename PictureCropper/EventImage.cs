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
    public class EventImage
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
        /// <param name="countImage">Переменная, для вывода на форму
        /// номера текущей картинки.</param>
        public EventImage(Label countImage)
        {
            _countImage = countImage;
        }

        /// <summary>
        /// Взятие следующего изображения из папки
        /// </summary>
        /// <param name="fileLocationList"> Список загруженных
        /// изображений.</param>
        /// <param name="currentImage"> Текущее изображение.</param> 
        /// <param name="pictureWindow"> Форма для вывода
        /// изображения.</param>
        public Image<Bgr, Byte> NextNumber(List<string> fileLocationList, 
            Image<Bgr, Byte> currentImage, Emgu.CV.UI.ImageBox pictureWindow)
        {
            if (_currentImageIndex < fileLocationList.Count - 1)
            {
                _currentImageIndex += 1;

                //вывод текста с номером текущего изображения
                _countImage.Text = _currentImageIndex + 1
                                   + " из " + fileLocationList.Count;

                if (File.Exists(fileLocationList[_currentImageIndex]))
                {
                    currentImage = new Image<Bgr, byte>(
                        fileLocationList[_currentImageIndex]);

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
        /// <param name="fileLocationList"> Список загруженных
        /// изображений.</param>
        /// <param name="carvedImage"> Вырезанная часть изображения.</param> 
        public void SaveImage(List<string> fileLocationList, Image<Bgr, Byte> carvedImage)
        {
            if (fileLocationList.Count != 0 && _currentImageIndex < fileLocationList.Count)
            {
                int indexLenght = fileLocationList[_currentImageIndex]
                                                .LastIndexOf("\\") + 1;

                string path = fileLocationList[_currentImageIndex]
                                  .Substring(0, indexLenght) + "Good";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                var currentImageName = fileLocationList[_currentImageIndex];

                var charPos = fileLocationList[_currentImageIndex]
                                                        .LastIndexOf("\\");

                var lenghtLine = fileLocationList[_currentImageIndex]
                            .Length - fileLocationList[_currentImageIndex]
                            .LastIndexOf("\\") - 4;


                string pathName = currentImageName.Substring(charPos, 
                                        lenghtLine)
                                        + DateTime.Now.Hour
                                        + DateTime.Now.Minute
                                        + DateTime.Now.Second
                                        + ".bmp";

                path = path + pathName;

                carvedImage.Save(path);

                File.AppendAllText(_fileAdress, pathName
                    + "  1  " + "0 0 " + carvedImage.Width + " " 
                    + carvedImage.Height + "\r\n");
            }
        }

        /// <summary>
        /// Метод, для загрузки всех изображений из папки
        /// </summary>
        /// <param name="fileLocationList"> Список загруженных
        /// изображений.</param>
        public void LoadImage(List<string> fileLocationList)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = Environment.CurrentDirectory;
            //Откроем папку с изображениями
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folder = folderBrowser.SelectedPath;

                DirectoryInfo thisDirectory = new DirectoryInfo(folder);
                FileInfo[] fileInfo = thisDirectory.GetFiles();

                //Запишем все изображения из папки в лист
                for (var i = 0; i < fileInfo.Length; i++) 
                {
                    if (fileInfo[i].Extension == ".jpg"
                        || fileInfo[i].Extension == ".jpeg"
                        || fileInfo[i].Extension == ".bmp"                          
                        || fileInfo[i].Extension == ".png")
                    {
                        fileLocationList.Add(fileInfo[i].FullName);
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
