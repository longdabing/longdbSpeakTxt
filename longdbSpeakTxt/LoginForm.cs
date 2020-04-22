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
            if (txtuser.Text.Equals("admin"))
            {
                MainForm mainForm = new MainForm();
                this.Visible = false;
                mainForm.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
