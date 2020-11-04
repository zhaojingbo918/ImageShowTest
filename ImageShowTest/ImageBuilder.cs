using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ImageShowTest
{
    public class ImageBuilder
    {
        [DllImport("gdi32")]
        static extern int DeleteObject(IntPtr o);
        /// <summary>
        /// 创建有线图标
        /// </summary> 
        /// <returns></returns>
        public ImageSource CreateImage(int x, int y)
        {
            Bitmap bmp = new Bitmap(150, 150);
            Graphics graphics = Graphics.FromImage(bmp);
            int targetX, targetY, srcX, srcY, width, height;
            Rectangle rect1;

            // graphics.Clear(System.Drawing.Color.Transparent);
            Random random = new Random();

            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Brushes.Red);


            {
                //graphics.DrawRectangle(pen, new Rectangle(x, y, 5, 5));
                graphics.FillRectangle(System.Drawing.Brushes.Red, new Rectangle(x, y, 5, 5));
            }


            graphics.Dispose();
            IntPtr it = bmp.GetHbitmap();
            BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(it, IntPtr.Zero,
                                                                                                     Int32Rect.Empty,
                                                                                                     BitmapSizeOptions.FromEmptyOptions
                                                                                                         ());
            DeleteObject(it);
            bmp.Dispose();

            return bitmapSource;
        }
    }
}
