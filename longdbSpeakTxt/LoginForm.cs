using longdbSpeakTxt.Tools;
using Sunisoft.IrisSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace longdbSpeakTxt
{
    public partial class LoginForm : Form
    {
        //public SkinEngine skinEngine = new SkinEngine();
        public LoginForm()
        {
            InitializeComponent();
            ProdConst.skinEngine.SkinFile = @"Skins/mp10.ssk";
            btnlogin_Click(null,null);//根据xml文件中的用户和密码自动登录。
        }
        private void ReadXml()
        {
           

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            List<string> loginlist = FileTool.ReadXml(ProdConst.fielexmlpath);
            if (loginlist != null && loginlist.Count > 0)
            {
                if (txtuser.Text.Equals(loginlist[0])
                    && txtpwd.Text.Equals(loginlist[1])
                    && chkauto.Checked)
                {
                    MainForm mainForm = new MainForm();
                    this.Visible = false;
                    mainForm.ShowDialog();
                    this.Visible = true;
                }
            }
            //DataTable table = TxtDA.GetUser(txtuser.Text.Trim(),txtpwd.Text.Trim());
            //if (table != null && table.Rows.Count > 0)
            //{
            //    MainForm mainForm = new MainForm();
            //    this.Visible = false;
            //    mainForm.ShowDialog();
            //    this.Visible = true;
            //}
            //else

            //{
            //    MessageBox.Show("无该用户！", "提示：");
            //}
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
