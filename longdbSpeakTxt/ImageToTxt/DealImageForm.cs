using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace longdbSpeakTxt.ImageToTxt
{
    /// <summary>
    /// 参考博客。
    /// https://blog.csdn.net/jiangxinyu/article/details/6222322/
    /// </summary>
    public partial class DealImageForm : Form
    {
        private Image temimg = null;
        private Image backimg = null;
        /// <summary>
        /// 图片上画矩形。
        /// </summary>
        private int intStartX = 0;
        private int intStartY = 0;
        private bool isMouseDraw = false;
        public DealImageForm()
        {
            InitializeComponent();
        }

        private void btngrap_Click(object sender, EventArgs e)
        {
            //亮度百分比
            int percent = 50;
            Single v = 0.006F * percent;
            Single[][] matrix = {
                new Single[] { 1, 0, 0, 0, 0 },

                new Single[] { 0, 1, 0, 0, 0 },

                new Single[] { 0, 0, 1, 0, 0 },

                new Single[] { 0, 0, 0, 1, 0 },

                new Single[] { v, v, v, 0, 1 }
            };
            ColorMatrix cm = new ColorMatrix(matrix);
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(cm);

            //Image tmp 
            temimg = picbox.Image;
            Graphics g = Graphics.FromImage(temimg);
            try
            {
                Rectangle destRect = new Rectangle(0, 0, temimg.Width, temimg.Height);
                g.DrawImage(temimg, destRect, 0, 0, temimg.Width, temimg.Height, GraphicsUnit.Pixel, attr);
            }
            finally
            {
                g.Dispose();
            }
            this.picbox.Image = (Image)temimg.Clone();
        }

        private void btnloadimg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var imgPath = openFileDialog1.FileName;
                picbox.Image = Image.FromFile(imgPath);
                backimg = picbox.Image.Clone() as Image;
            }
        }

        private void btnrotatflip_Click(object sender, EventArgs e)
        {
            temimg = picbox.Image;
            temimg.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picbox.Image = temimg;
        }

        private void btgetgray_Click(object sender, EventArgs e)
        {
            Bitmap currentBitmap = new Bitmap(picbox.Image);
            Graphics g = Graphics.FromImage(currentBitmap);
            ImageAttributes ia = new ImageAttributes();
            float[][] colorMatrix =   {
                new   float[]   {0.299f,   0.299f,   0.299f,   0,   0},
                new   float[]   {0.587f,   0.587f,   0.587f,   0,   0},
                new   float[]   {0.114f,   0.114f,   0.114f,   0,   0},
                new   float[]   {0,   0,   0,   1,   0},
                new   float[]   {0,   0,   0,   0,   1}
            };
            ColorMatrix cm = new ColorMatrix(colorMatrix);
            ia.SetColorMatrix(cm, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            g.DrawImage(currentBitmap, new Rectangle(0, 0, currentBitmap.Width, currentBitmap.Height), 0, 0, currentBitmap.Width, currentBitmap.Height, GraphicsUnit.Pixel, ia);
            this.picbox.Image = (Image)(currentBitmap.Clone());
            g.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            picbox.Image = backimg;
        }

        private void picbox_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDraw = true;
            intStartX = e.X;
            intStartY = e.Y;
        }

        private void picbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDraw)
            {
                try
                {
                    Image tmp = picbox.Image;
                    Graphics g = picbox.CreateGraphics();

                    //清空上次画下的痕迹
                    g.Clear(picbox.BackColor);
                    Brush brush = new SolidBrush(Color.Red);
                    Pen pen = new Pen(brush, 1);

                    pen.DashStyle = DashStyle.Solid;
                    g.DrawRectangle(pen, new Rectangle(intStartX > e.X ? e.X : intStartX, intStartY > e.Y ? e.Y : intStartY, Math.Abs(e.X - intStartX), Math.Abs(e.Y - intStartY)));
                    g.Dispose();
                    //picbox.Image = tmp;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void picbox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDraw = false;
            intStartX = 0;
            intStartY = 0;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (backimg == null) return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP Files(*.bmp)|*.bmp|JPG Files(*.jpg;*.jpeg)|*.jpg;*.png|All Files(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                picbox.Image.Save(sfd.FileName);
                MessageBox.Show("保存成功!", "提示");
                sfd.Dispose();
            }
        }

        private void btncutscreen_Click(object sender, EventArgs e)
        {
            Image screenimg = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(screenimg);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));       
            g.Dispose();
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox.Image = screenimg;
            //截取后自动保存到当前目录
            //screenimg.Save("screenimg.png", ImageFormat.Png);
        }
    }
}
