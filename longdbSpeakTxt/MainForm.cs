using longdbSpeakTxt.ImageToTxt;
using longdbSpeakTxt.TxtToVoice;
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
    public partial class MainForm : Form
    {
   
        public MainForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(ProdConst.backimgpath);
        }

        private void txttovice_Click(object sender, EventArgs e)
        {
            TxtToVoiceForm voiceForm = new TxtToVoiceForm();
            voiceForm.MdiParent = this;
            voiceForm.WindowState = FormWindowState.Maximized;
            voiceForm.Show();
        }

        private void imagetotxt_Click(object sender, EventArgs e)
        {
            ImageToTxtForm imageForm = new ImageToTxtForm();
            imageForm.MdiParent = this;
            imageForm.WindowState = FormWindowState.Maximized;
            imageForm.Show();
        }

        private void settingitem_Click(object sender, EventArgs e)
        {
            SetSkinsForm imageForm = new SetSkinsForm();
            imageForm.MdiParent = this;
            imageForm.WindowState = FormWindowState.Maximized;
            imageForm.Show();
        }

        private void backsetitem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var imgPath = openFileDialog1.FileName;
                this.BackgroundImage = Image.FromFile(imgPath);
            }
        }

        private void RateItemSetting_Click(object sender, EventArgs e)
        {
            SRateSettingForm rateForm = new SRateSettingForm();
            rateForm.MdiParent = this;
            rateForm.WindowState = FormWindowState.Maximized;
            rateForm.Show();
        }

        private void PoetryCreateItem_Click(object sender, EventArgs e)
        {
            PoetryCreateForm Poetry = new PoetryCreateForm();
            Poetry.MdiParent = this;
            Poetry.WindowState = FormWindowState.Maximized;
            Poetry.Show();
        }
    }
}
