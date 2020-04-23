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
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable table = TxtDA.GetUser(txtuser.Text.Trim(),txtpwd.Text.Trim());
            if (table != null && table.Rows.Count > 0)
            {
                MainForm mainForm = new MainForm();
                this.Visible = false;
                mainForm.ShowDialog();
                this.Visible = true;
            }
            else

            {
                MessageBox.Show("无该用户！", "提示：");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
