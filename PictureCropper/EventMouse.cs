using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CutImageArea
{
    class EventMouse
    {
        /// <summary>
        /// Начало выделения области
        /// </summary>
        private Point _mouseDownStart = new Point();

        /// <summary>
        /// Вырезанное изображение
        /// </summary>
        private bool _flagButton = false;

        /// <summary>
        /// Начало выделения области
        /// </summary>
        /// <param name="e"></param>
        public void MouseDown(MouseEventArgs e)
        {
            _mouseDownStart = new System.Drawing.Point(e.X, e.Y);
            _flagButton = true;
        }

        /// <summary>
        /// Метод, для отрисовки примерной области выделения
        /// </summary>
        /// <param name="e"></param>
        public void MouseMove(MouseEventArgs e, Image<Bgr, Byte> _currentImage, Emgu.CV.UI.ImageBox PictureWindow)
        {
            if ((_currentImage != null) && (_flagButton))
            {
                Rectangle Rec = WorkMouse(e, _currentImage, PictureWindow);

                Image<Bgr, Byte> Sel = _currentImage.Clone();
                Sel.Draw(Rec, new Bgr(1, 240, 1), 2);
                PictureWindow.Image = Sel;

                Sel.Dispose();
            }
        }

        /// <summary>
        /// Метод для, окончания выделения необходимой области области
        /// </summary>
        /// <param name="e"></param>
        public Image<Bgr, Byte> MouseUp(MouseEventArgs e, Image<Bgr, Byte> _currentImage, Emgu.CV.UI.ImageBox PictureWindow)
        {
            Image<Bgr, Byte> _carvedImage = null;
            _flagButton = false;

            if (_currentImage != null)
            {
                Rectangle Rec = WorkMouse(e, _currentImage, PictureWindow);

                Image<Bgr, Byte> Sel = _currentImage.Clone();
                Sel.Draw(Rec, new Bgr(0, 0, 0), 2);
                PictureWindow.Image = Sel;

                _currentImage.ROI = Rec;
                _carvedImage = _currentImage.Clone();
                CvInvoke.cvResetImageROI(_currentImage);

                Sel.Dispose();

            }

            return _carvedImage;
        }

        /// <summary>
        /// Метод, объединяющий общий код
        /// </summary>
        private Rectangle WorkMouse(MouseEventArgs e, Image<Bgr, Byte> _currentImage, Emgu.CV.UI.ImageBox PictureWindow)
        {
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

            return Rec;
        }
    }
}
