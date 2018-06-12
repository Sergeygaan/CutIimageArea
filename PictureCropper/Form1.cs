using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;

namespace CutImageArea
{
    public partial class CutImageArea : Form
    {
        /// <summary>
        /// Адреса всех файлов
        /// </summary>
        private List<string> _fileLocationList = new List<string>();

        /// <summary>
        /// Текущее изображение
        /// </summary>
        private Image<Bgr, Byte> _currentImage;

        /// <summary>
        /// Номер текущего изображения в папке
        /// </summary>
        private int _currentImageIndex = -1;

        /// <summary>
        /// Адрес файла с описанием
        /// </summary>
        private string _fileAdress;

        /// <summary>
        /// Начало выделения области
        /// </summary>
        private Point _mouseDownStart = new Point();

        /// <summary>
        /// Вырезанное изображение
        /// </summary>
        private Image<Bgr, Byte> _carvedImage;

        /// <summary>
        /// Вырезанное изображение
        /// </summary>
        private bool _flagButton = false;

        private EventMouse _eventMouse;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public CutImageArea()
        {
            InitializeComponent();

            _eventMouse = new EventMouse();
        }
       
        /// <summary>
        /// Начало выделения области
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureWindow_MouseDown(object sender, MouseEventArgs e)
        {
            _eventMouse.MouseDown(e);
        }

        /// <summary>
        /// Метод, для отрисовки примерной области выделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureWindow_MouseMove(object sender, MouseEventArgs e)
        {
            _eventMouse.MouseMove(e, _currentImage, PictureWindow);
        }

        /// <summary>
        /// Метод для, окончания выделения необходимой области области
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureWindow_MouseUp(object sender, MouseEventArgs e)
        {
            _carvedImage = _eventMouse.MouseUp(e, _currentImage, PictureWindow);
        }

        /// <summary>
        /// Взятие следующего изображения из папки
        /// </summary>
        private void NextNumber()
        {
            if (_currentImageIndex < _fileLocationList.Count - 1)
            {
                _currentImageIndex += 1;

                //вывод текста с номером текущего изображения
                CountImage.Text = (_currentImageIndex + 1).ToString() + " из " + _fileLocationList.Count.ToString();

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
        }

        /// <summary>
        /// Метод, для сохранения изображения
        /// </summary>
        private void SaveImage()
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
        /// <param name="e"></param>
        private void LoadImage_Button(object sender, EventArgs e)
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

                NextNumber();
                //_currentImage = new Image<Emgu.CV.Structure.Bgr, byte>(_fileLocationList[_currentImageIndex]);
                //PictureWindow.Image = _currentImage; //Вывод текущего изображения
                //CountImageText();

                string Path = Folder + "\\ProcessedPhotos\\Good.dat";

                if (File.Exists(Path))
                {
                    File.Delete(Path);
                }

                _fileAdress = Path;
            }
        }

        /// <summary>
        /// Метод, для выбора следующего изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextImage_Button(object sender, EventArgs e)
        {
            NextNumber(); //Следующее изображение
        }

        /// <summary>
        /// Метод, для сохранения области выделения нужного фрагмента изображения и перехода на следующее изображение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveImage_Button(object sender, EventArgs e)
        {
            SaveImage();
            NextNumber();
        }
    }
}
