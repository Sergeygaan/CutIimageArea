using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

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
        /// Вырезанное изображение
        /// </summary>
        private Image<Bgr, Byte> _carvedImage;

        /// <summary>
        /// Класс, для работы с командами мыши
        /// </summary>
        private EventMouse _eventMouse;

        /// <summary>
        /// Класс, для работы с изображениями
        /// </summary>
        private EventImage _eventImage;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public CutImageArea()
        {
            InitializeComponent();

            _eventMouse = new EventMouse();
            _eventImage = new EventImage(CountImage);
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
        /// Метод, для загрузки всех изображений из папки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadImage_Button(object sender, EventArgs e)
        {
            _eventImage.LoadImage(_fileLocationList);
            _currentImage = _eventImage.NextNumber(_fileLocationList, _currentImage, PictureWindow);
        }

        /// <summary>
        /// Метод, для выбора следующего изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextImage_Button(object sender, EventArgs e)
        {
            _currentImage = _eventImage.NextNumber(_fileLocationList, _currentImage, PictureWindow);
        }

        /// <summary>
        /// Метод, для сохранения области выделения нужного фрагмента изображения и перехода на следующее изображение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveImage_Button(object sender, EventArgs e)
        {
            _eventImage.SaveImage(_fileLocationList, _carvedImage);
            _currentImage = _eventImage.NextNumber(_fileLocationList, _currentImage, PictureWindow);
        }
    }
}
