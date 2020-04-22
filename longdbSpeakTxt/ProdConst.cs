using Sunisoft.IrisSkin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longdbSpeakTxt
{
    public class ProdConst
    {
        /// <summary>
        /// 皮肤设置。
        /// </summary>
        public static SkinEngine skinEngine = new SkinEngine();
        /// <summary>
        /// 语速设置 -10-10之间。
        /// </summary>
        public static int SRate = 0;
        public static string fieletxtpath = Directory.GetCurrentDirectory() + "\\Resources\\AncientPoetry.txt";
        public static string backimgpath = Directory.GetCurrentDirectory() + @"\Resources\pictures\mainbackimg.png";

    }
}
