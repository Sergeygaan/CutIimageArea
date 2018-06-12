using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CutImageArea
{
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
        /// Отображение текущего номера картиник
        /// </summary>
        private Label _countImage;

        public EventImage(Label CountImage)
        {
            _countImage = CountImage;
        }

        /// <summary>
        /// Взятие следующего изображения из папки
        /// </summary>
        public Image<Bgr, Byte> NextNumber(List<string> _fileLocationList, Image<Bgr, Byte> _currentImage, Emgu.CV.UI.ImageBox PictureWindow)
        {
            if (_currentImageIndex < _fileLocationList.Count - 1)
            {
                _currentImageIndex += 1;

                //вывод текста с номером текущего изображения
                _countImage.Text = (_currentImageIndex + 1).ToString() + " из " + _fileLocationList.Count.ToString();

                if (File.Exists(_fileLocationList[_currentImageIndex]))
                {
                    _currentImage = new Image<Emgu.CV.Structure.Bgr, byte>(_fileLocationList[_currentImageIndex]);
                    PictureWindow.Image = _currentImage;
                }
            }
            else
            {
                _currentImageIndex += 1;
                MessageBox.Show("Изображения закончились");
            }

            return _currentImage;
        }

        /// <summary>
        /// Метод, для сохранения изображения
        /// </summary>
        public void SaveImage(List<string> _fileLocationList, Image<Bgr, Byte> _carvedImage)
        {
            if ((_fileLocationList.Count != 0) && ((_currentImageIndex < _fileLocationList.Count)))
            {
                string Path = _fileLocationList[_currentImageIndex].Substring(0, _fileLocationList[_currentImageIndex].LastIndexOf("\\") + 1) + "ProcessedPhotos";

                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }

                string PathImageName = _fileLocationList[_currentImageIndex].Substring(_fileLocationList[_currentImageIndex].LastIndexOf("\\"), _fileLocationList[_currentImageIndex].Length - _fileLocationList[_currentImageIndex].LastIndexOf("\\") - 4) + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".bmp";

                Path = Path + PathImageName;

                _carvedImage.Save(Path);

                File.AppendAllText(_fileAdress, PathImageName + "  1  " + "0 0 " + _carvedImage.Width + " " + _carvedImage.Height + "\r\n");
            }
        }

        /// <summary>
        /// Метод, для загрузки всех изображений из папки
        /// </summary>
        /// <param name="sender"></param>
        public void LoadImage(List<string> _fileLocationList)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = Environment.CurrentDirectory;

            if (FBD.ShowDialog() == DialogResult.OK) //Откроем папку с изображениями
            {
                string Folder = FBD.SelectedPath;
                DirectoryInfo ThisDir = new DirectoryInfo(Folder);
                FileInfo[] FI = ThisDir.GetFiles();

                for (int Index = 0; Index < FI.Length; Index++) //Запишем все изображения из папки в лист
                {
                    if ((FI[Index].Extension == ".jpg") || (FI[Index].Extension == ".jpeg") || (FI[Index].Extension == ".bmp") || (FI[Index].Extension == ".png"))
                    {
                        _fileLocationList.Add(FI[Index].FullName);
                    }
                }

                string Path = Folder + "\\ProcessedPhotos\\Good.dat";

                if (File.Exists(Path))
                {
                    File.Delete(Path);
                }

                _fileAdress = Path;
            }
        }

    }
}
