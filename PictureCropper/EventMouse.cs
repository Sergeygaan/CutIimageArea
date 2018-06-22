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
    public class EventMouse
    {
        /// <summary>
        /// Начало выделения области
        /// </summary>
        private Point _mouseDownStart;

        /// <summary>
        /// Вырезанное изображение
        /// </summary>
        private bool _flagButton;

        /// <summary>
        /// Начало выделения области
        /// </summary>
        /// <param name="events"> События маши.</param>
        public void MouseDown(MouseEventArgs events)
        {
            _mouseDownStart = new Point(events.X, events.Y);
            _flagButton = true;
        }

        /// <summary>
        /// Метод, для отрисовки примерной области выделения
        /// </summary>
        /// <param name="events"> События маши.</param>
        /// <param name="currentImage"> Текущее изображение.</param>
        /// <param name="pictureWindow"> Форма для вывода изображения.</param>
        public void MouseMove(MouseEventArgs events, 
            Image<Bgr, Byte> currentImage, Emgu.CV.UI.ImageBox pictureWindow)
        {
            if ((currentImage != null) && (_flagButton))
            {
                Rectangle rectangle = WorkMouse(events, currentImage, 
                                                        pictureWindow);

                Image<Bgr, Byte> imageClone = currentImage.Clone();
                imageClone.Draw(rectangle, new Bgr(1, 240, 1), 2);
                pictureWindow.Image = imageClone;

                imageClone.Dispose();
            }
        }

        /// <summary>
        /// Метод для, окончания выделения необходимой области области
        /// </summary>
        /// <param name="events"> События маши.</param>
        /// <param name="currentImage"> Текущее изображение.</param>
        /// <param name="pictureWindow"> Форма для вывода изображения.</param>
        public Image<Bgr, Byte> MouseUp(MouseEventArgs events, 
            Image<Bgr, Byte> currentImage, Emgu.CV.UI.ImageBox pictureWindow)
        {
            Image<Bgr, Byte> currentCarvedImage = null;
            _flagButton = false;

            if (currentImage != null)
            {
                Rectangle rectangle = WorkMouse(events, currentImage,
                                                        pictureWindow);
            
                Image<Bgr, Byte> imageClone = currentImage.Clone();
                imageClone.Draw(rectangle, new Bgr(0, 0, 0), 2);
                pictureWindow.Image = imageClone;

                currentImage.ROI = rectangle;
                currentCarvedImage = currentImage.Clone();
                CvInvoke.cvResetImageROI(currentImage);

                imageClone.Dispose();
            }

            return currentCarvedImage;
        }

        /// <summary>
        /// Метод, объединяющий общий код
        /// </summary>
        /// <param name="events"> События маши.</param>
        /// <param name="currentImage"> Текущее изображение.</param>
        /// <param name="pictureWindow"> Форма для вывода
        /// изображения.</param>
        private Rectangle WorkMouse(MouseEventArgs events, 
            Image<Bgr, Byte> currentImage, Emgu.CV.UI.ImageBox pictureWindow)
        {
            Point selectPoint = new Point(Math.Min(events.X, 
                _mouseDownStart.X), Math.Min(events.Y, _mouseDownStart.Y));

            Point sizePoint = new Point(0, 0);

            sizePoint.X = Math.Abs(events.X - _mouseDownStart.X);
            sizePoint.Y = Math.Abs(events.Y - _mouseDownStart.Y);

            double scaleX = currentImage.Width 
                            / (double)pictureWindow.Width;

            double scaleY = currentImage.Height 
                            / (double)pictureWindow.Height;

            Rectangle rectangle = new Rectangle((int)(selectPoint.X * scaleX), 
                                                (int)(selectPoint.Y * scaleY), 
                                                (int)(sizePoint.X * scaleX),
                                                (int)(sizePoint.Y * scaleY));

            Image<Bgr, Byte> imageClone = currentImage.Clone();
            imageClone.Draw(rectangle, new Bgr(0, 0, 0), 2);
            pictureWindow.Image = imageClone;

            return rectangle;
        }
    }
}
