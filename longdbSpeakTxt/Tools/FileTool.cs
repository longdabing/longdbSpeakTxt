using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace longdbSpeakTxt.Tools
{
    public class FileTool
    {
        public static DataTable ReadTxt(string path)
        {
            DataTable txtdt = new DataTable();
            txtdt.Columns.Add("Title", typeof(string));//题目
            txtdt.Columns.Add("Author", typeof(string));//作者
            txtdt.Columns.Add("Line1", typeof(string));
            txtdt.Columns.Add("Line2", typeof(string));
            txtdt.Columns.Add("Line3", typeof(string));
            txtdt.Columns.Add("Line4", typeof(string));

            txtdt.Columns.Add("Line5", typeof(string));
            txtdt.Columns.Add("Line6", typeof(string));
            txtdt.Columns.Add("Line7", typeof(string));
            txtdt.Columns.Add("Line8", typeof(string));

            //filelist[i].FullName 返回文件的绝对路径

            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
            {
                return null;
            }
            StreamReader sr = new StreamReader(path, Encoding.Default);//path 绝对路径（包含文件名及其后缀。
            String line;
            string[] linelist = { };
            while ((line = sr.ReadLine()) != null)
            {
                //line += "," + ",";
                linelist = line.Split(',');

                txtdt.Rows.Add(linelist);               
            }
            return txtdt;
        }
        /// <summary>
        /// 流转成图片
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Image StreamConvertToImage(Stream stream)
        {
            byte[] data = new byte[1024];
            int length = 0;
            using (MemoryStream ms = new MemoryStream())
            {
                while ((length = stream.Read(data, 0, data.Length)) > 0)
                {
                    ms.Write(data, 0, length);
                }
                ms.Seek(0, SeekOrigin.Begin);
               return Image.FromStream(ms);
            }          
        }

        /// <summary>
        /// 创建xml文件。
        /// </summary>
        /// <param name="path"></param>
        public static void CreateXml(string path)
        {
            XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
            //设置缩进
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("UserMess");

            //写中间字节点
            writer.WriteStartElement("hname");
            writer.WriteString("龙大饼");
            writer.WriteEndElement();

            writer.WriteStartElement("hage");
            writer.WriteString("18");
            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
            writer.Dispose();
        }
        public static List<string> ReadXml(string path)
        {
            List<string> listcontent = new List<string>();
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
               
                XmlDocument document = new XmlDocument();
                document.Load(path);
                XmlElement element = document.DocumentElement;
                foreach (XmlElement xmlnode in element.ChildNodes)
                {
                    switch (xmlnode.Name)
                    {
                        case "hname":
                            listcontent.Add(xmlnode.InnerText);
                            break;
                        case "hpwd":
                            listcontent.Add(xmlnode.InnerText);
                            break;
                    }
                }
            }
            return listcontent;
        }
    }
}
