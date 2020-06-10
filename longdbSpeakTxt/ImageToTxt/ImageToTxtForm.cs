using longdbSpeakTxt.Tools;
using OpenCvSharp;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Tesseract;

namespace longdbSpeakTxt.ImageToTxt
{
    public partial class ImageToTxtForm : Form
    {
        public ImageToTxtForm()
        {
            InitializeComponent();
            string str = "413";
            int len = str.Length;
            string txt = "longdb413";
            str = txt.Substring(0, txt.Length - len);
        }

        /// <summary>
        /// 识别率不是很高,微软的
        /// </summary>
        /// <param name="imgfileName"></param>
        /// <returns></returns>
        private string OcrFunc(string imgfileName) // 参数为包含文本的图片文件名
        {
            var langs = MODI.MiLANGUAGES.miLANG_ENGLISH;
            // MODI.MiLANGUAGES.miLANG_CHINESE_SIMPLIFIED; 中文含英文
            // MODI.MiLANGUAGES.miLANG_JAPANESE; 日文含英文

            var doc = new MODI.Document();
            var image = default(MODI.Image);
            var layout = default(MODI.Layout);

            try
            {
                doc.Create(imgfileName);
                doc.OCR(langs, true, true);
                var sb = new StringBuilder();

                for (int i = 0; i < doc.Images.Count; i++)
                {
                    image = (MODI.Image)doc.Images[i];
                    layout = image.Layout;
                    sb.AppendLine(string.Format("{0}, {1}", i, layout.Text));
                }
                doc.Close(false);
                return sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
            finally
            {
                layout = null;
                image = null;
                doc = null;
            }
        }

        private void btnselectimg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var imgPath = openFileDialog1.FileName;
                #region//测试代码 2020.5.20
                FileStream stream = new FileStream(imgPath, FileMode.OpenOrCreate);
                byte[] arr = new byte[stream.Length];
                stream.Read(arr, 0, arr.Length);

                string imgstr = Encoding.UTF8.GetString(arr);
                imgstr = Encoding.UTF7.GetString(arr);
                #endregion

                Image image = Image.FromFile(imgPath);
                pictureBox1.Image = image;
       
                string strResult = ImageToText(imgPath);
                if (string.IsNullOrEmpty(strResult))
                {
                    txtResult.Text = "无法识别";
                }
                else
                {
                    txtResult.Text = strResult;
                }
            }
        }
        /// <summary>
        /// 调用tesseract实现OCR识别
        /// </summary>
        /// <param name="imgPath"></param>
        /// <returns></returns>
        public string ImageToText(string imgPath)
        {
            string langbk = cboxlang.Text;
            string lang = "chi_sim";
            if (langbk.Equals("中文"))
            {
                lang = "chi_sim";
            }
            else if ("英文".Equals(langbk))
            {
                lang = "eng";
            }
            else
            {
                lang = langbk;
            }
            
            using (var engine = new TesseractEngine("tessdata", lang, EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(imgPath))
                {
                    using (var page = engine.Process(img))
                    {
                        return page.GetText();
                    }
                }
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //从网上读取一张图片，该api是自动产生验证码。
            string imgUrl = "https://service.cheshi.com/user/validate/validatev3.php";
            Stream stream = HttpUtil.GetSingleton().ReadImgFromWeb(imgUrl);
            pictureBox1.Image= FileTool.StreamConvertToImage(stream);
            OpenCvSHarp(stream, "d:\\img.png");

            txtResult.Text =" " +ImageToText("d:\\img.png");
        }

        /// <summary>
        /// 用opencv进行降噪处理再ocr识别
        /// </summary>
        /// <param name="ms"></param>
        private void OpenCvSHarp(Stream ms,string path)
        {
            Mat simg = Mat.FromStream(ms, ImreadModes.Grayscale);
            //Cv2.ImShow("Input Image", simg);
            //阈值操作 阈值参数可以用一些可视化工具来调试得到
            Mat ThresholdImg = simg.Threshold(29, 255, ThresholdTypes.Binary);
            Cv2.ImShow("Threshold", ThresholdImg);
            Cv2.ImWrite(path, ThresholdImg);
        }
        /// <summary>
        /// 从网上读取一张图片
        /// </summary>
        /// <param name="Url"></param>
        public Stream ReadImgFromWeb(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Credentials = CredentialCache.DefaultCredentials; // 添加授权证书
            request.UserAgent = "Microsoft Internet Explorer";
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
           
            //pictureBox1.Image = Image.FromStream(ms);
            return stream;
        }

        private void btnopencv_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var imgPath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(imgPath);
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                    OpenCvSHarp(stream, imgPath);
                }
        
                string strResult = ImageToText(imgPath);
                if (string.IsNullOrEmpty(strResult))
                {
                    txtResult.Text = "无法识别";
                }
                else
                {
                    txtResult.Text = strResult;
                }
            }
        }
    }
}
