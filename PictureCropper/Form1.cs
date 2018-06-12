﻿using System;
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
        private int _currentImageIndex = 0;

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

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public CutImageArea()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// Начало выделения области
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureWindow_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownStart = new System.Drawing.Point(e.X, e.Y);
            _flagButton = true;
        }

        /// <summary>
        /// Метод, для отрисовки примерной области выделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if ((_currentImage != null) && (_flagButton))
            {
                Point Select = new Point(Math.Min(e.X, _mouseDownStart.X), Math.Min(e.Y, _mouseDownStart.Y));
                Point Size = new Point(0, 0);
                Size.X = Math.Abs(e.X - _mouseDownStart.X);
                Size.Y = Math.Abs(e.Y - _mouseDownStart.Y);
                double sx = _currentImage.Width / (double)PictureWindow.Width;
                double sy = _currentImage.Height / (double)PictureWindow.Height;
                Rectangle Rec = new Rectangle((int)(Select.X * sx), (int)(Select.Y * sy), (int)(Size.X * sx), (int)(Size.Y * sy));

                Image<Bgr, Byte> Sel = _currentImage.Clone();
                Sel.Draw(Rec, new Bgr(1, 240, 1), 2);
                PictureWindow.Image = Sel;

                Sel.Dispose();
            }
        }

        /// <summary>
        /// Метод для, окончания выделения необходимой области области
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (_currentImage != null)
            {
                _flagButton = false;

                Point Select = new Point(Math.Min(e.X, _mouseDownStart.X), Math.Min(e.Y, _mouseDownStart.Y));
                Point Size = new Point(0, 0);
                Size.X = Math.Abs(e.X - _mouseDownStart.X);
                Size.Y = Math.Abs(e.Y - _mouseDownStart.Y);
                double sx = _currentImage.Width / (double)PictureWindow.Width;
                double sy = _currentImage.Height / (double)PictureWindow.Height;
                Rectangle Rec = new Rectangle((int)(Select.X * sx), (int)(Select.Y * sy), (int)(Size.X * sx), (int)(Size.Y * sy));

                Image<Bgr, Byte> Sel = _currentImage.Clone();
                Sel.Draw(Rec, new Bgr(0, 0, 0), 2);
                PictureWindow.Image = Sel;
                _currentImage.ROI = Rec;
                _carvedImage = _currentImage.Clone();
                CvInvoke.cvResetImageROI(_currentImage);

                Sel.Dispose();
            }
        }

        /// <summary>
        /// Взятие следующего изображения из папки
        /// </summary>
        private void NextNumber()
        {
            if (_currentImageIndex + 1 < _fileLocationList.Count)
            {
                _currentImageIndex += 1;
                if (File.Exists(_fileLocationList[_currentImageIndex]))
                {
                    _currentImage = new Image<Emgu.CV.Structure.Bgr, byte>(_fileLocationList[_currentImageIndex]);
                    PictureWindow.Image = _currentImage;
                }
            }
        }

        /// <summary>
        /// Метод, для сохранения изображения
        /// </summary>
        private void SaveImage()
        {
            if (_fileLocationList.Count != 0)
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

                for (int l = 0; l < FI.Length; l++) //Запишем все изображения из папки в лист
                {
                    if ((FI[l].Extension == ".jpg") || (FI[l].Extension == ".jpeg") || (FI[l].Extension == ".bmp") || (FI[l].Extension == ".png"))
                    {
                        _fileLocationList.Add(FI[l].FullName);
                    }
                }

                _currentImage = new Image<Emgu.CV.Structure.Bgr, byte>(_fileLocationList[_currentImageIndex]);
                PictureWindow.Image = _currentImage; //Вывод текущего изображения

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
