using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matahari
{
    public class ScreenshotCreator
    {
        private readonly Size size;
        private readonly Bitmap bitmap;
        private readonly Graphics graphics;

        public ScreenshotCreator()
        {
            size = CalculateFullScreenSize();
            bitmap = new Bitmap(size.Width, size.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        public Bitmap CreateScreenshot()
        {
            graphics.CopyFromScreen(0, 0, 0, 0, size);
            return bitmap;
        }

        public Size CalculateFullScreenSize()
        {
            int width = 0;
            int height = 0;

            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                int screenHeight = screen.Bounds.Height;
                if (screenHeight > height)
                {
                    height = screenHeight;
                }

                width += screen.Bounds.Width;
            }

            return new Size(width, height);
        }


    }
}
