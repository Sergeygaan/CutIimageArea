using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CutImageArea
{
    /// <summary>
    /// Класс, выполняющий различные операции с событиями мыши
    /// </summary>
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
        /// <param name="events"> События маши.</param>
        public void MouseDown(MouseEventArgs events)
        {
            _mouseDownStart = new System.Drawing.Point(events.X, events.Y);
            _flagButton = true;
        }

        /// <summary>
        /// Метод, для отрисовки примерной области выделения
        /// </summary>
        /// <param name="events"> События маши.</param>
        /// <param name="currentImage"> Текущее изображение.</param>
        /// <param name="pictureWindow"> Форма для вывода изображения.</param>
        public void MouseMove(MouseEventArgs events, Image<Bgr, Byte> currentImage, Emgu.CV.UI.ImageBox pictureWindow)
        {
            if ((currentImage != null) && (_flagButton))
            {
                Rectangle Rec = WorkMouse(events, currentImage, pictureWindow);

                Image<Bgr, Byte> Sel = currentImage.Clone();
                Sel.Draw(Rec, new Bgr(1, 240, 1), 2);
                pictureWindow.Image = Sel;

                Sel.Dispose();
            }
        }

        /// <summary>
        /// Метод для, окончания выделения необходимой области области
        /// </summary>
        /// <param name="events"> События маши.</param>
        /// <param name="currentImage"> Текущее изображение.</param>
        /// <param name="pictureWindow"> Форма для вывода изображения.</param>
        public Image<Bgr, Byte> MouseUp(MouseEventArgs events, Image<Bgr, Byte> currentImage, Emgu.CV.UI.ImageBox pictureWindow)
        {
            Image<Bgr, Byte> _carvedImage = null;
            _flagButton = false;

            if (currentImage != null)
            {
                Rectangle Rec = WorkMouse(events, currentImage, pictureWindow);

                Image<Bgr, Byte> Sel = currentImage.Clone();
                Sel.Draw(Rec, new Bgr(0, 0, 0), 2);
                pictureWindow.Image = Sel;

                currentImage.ROI = Rec;
                _carvedImage = currentImage.Clone();
                CvInvoke.cvResetImageROI(currentImage);

                Sel.Dispose();

            }

            return _carvedImage;
        }

        /// <summary>
        /// Метод, объединяющий общий код
        /// </summary>
        /// <param name="events"> События маши.</param>
        /// <param name="currentImage"> Текущее изображение.</param>
        /// <param name="pictureWindow"> Форма для вывода изображения.</param>
        private Rectangle WorkMouse(MouseEventArgs events, Image<Bgr, Byte> currentImage, Emgu.CV.UI.ImageBox pictureWindow)
        {
            Point Select = new Point(Math.Min(events.X, _mouseDownStart.X), Math.Min(events.Y, _mouseDownStart.Y));
            Point Size = new Point(0, 0);
            Size.X = Math.Abs(events.X - _mouseDownStart.X);
            Size.Y = Math.Abs(events.Y - _mouseDownStart.Y);
            double sx = currentImage.Width / (double)pictureWindow.Width;
            double sy = currentImage.Height / (double)pictureWindow.Height;
            Rectangle Rec = new Rectangle((int)(Select.X * sx), (int)(Select.Y * sy), (int)(Size.X * sx), (int)(Size.Y * sy));

            Image<Bgr, Byte> Sel = currentImage.Clone();
            Sel.Draw(Rec, new Bgr(0, 0, 0), 2);
            pictureWindow.Image = Sel;

            return Rec;
        }
    }
}
