using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //txtdt.Columns.Add("Line5", typeof(string));
            //txtdt.Columns.Add("Line6", typeof(string));
            //txtdt.Columns.Add("Line7", typeof(string));
            //txtdt.Columns.Add("Line8", typeof(string));

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
    }
}
