using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longdbSpeakTxt.Tools
{
    /// <summary>
    /// https://www.cnblogs.com/wupeihong/p/3919576.html
    /// </summary>
    public class DealImg
    {
        /// <summary>
        /// 图片上方加文字，文字将会被180度反转
        /// </summary>
        /// <param name="Img">待处理图片</param>
        /// <param name="WriteString">写入的字符串</param>
        /// <param name="UpMargin">180度反转后文字顶部距离上边缘距离</param>
        /// <param name="RightMargin">文字最左边距离右边缘距离</param>
        /// <returns>Bitmap</returns>
        public static Bitmap WriteUp(Image Img, string WriteString, int UpMargin, int RightMargin)
        {
            return WriteUp(Img, WriteString, UpMargin, RightMargin, "宋体", 20);
        }

        /// <summary>
        /// 图片上方加文字，文字将会被180度反转
        /// </summary>
        /// <param name="Img">待处理图片</param>
        /// <param name="WriteString">写入的字符串</param>
        /// <param name="UpMargin">180度反转后文字顶部距离上边缘距离</param>
        /// <param name="RightMargin">文字最左边距离右边缘距离</param>
        /// <param name="FontType">字体类型</param>
        /// <param name="FontSize">字体大小</param>
        /// <returns></returns>
        public static Bitmap WriteUp(Image Img, string WriteString, int UpMargin, int RightMargin, string FontType, int FontSize)
        {
            //获取图片宽高
            int Width = Img.Width;
            int Height = Img.Height;
            //获取图片水平和垂直的分辨率
            float dpiX = Img.HorizontalResolution;
            float dpiY = Img.VerticalResolution;
            //创建一个位图文件
            Bitmap BitmapResult = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            //设置位图文件的水平和垂直分辨率  与Img一致
            BitmapResult.SetResolution(dpiX, dpiY);
            //在位图文件上填充一个矩形框
            Graphics Grp = Graphics.FromImage(BitmapResult);
            System.Drawing.Rectangle Rec = new System.Drawing.Rectangle(0, 0, Width, Height);
            //向矩形框内填充Img
            Grp.DrawImage(Img, 0, 0, Rec, GraphicsUnit.Pixel);


            //平移Graphics对象
            Grp.TranslateTransform(Width - RightMargin, UpMargin);
            //设置Graphics对象的输出角度以改变文字方向
            Grp.RotateTransform(180);
            //设置文字填充颜色
            Brush brush = Brushes.Black;
            //旋转显示文字
            Grp.DrawString(WriteString, new Font(FontType, FontSize, GraphicsUnit.Pixel), brush, 0, 0);
            //恢复全局变换矩阵
            Grp.ResetTransform();
            Grp.Dispose();
            GC.Collect();
            return BitmapResult;
        }
    }
}
