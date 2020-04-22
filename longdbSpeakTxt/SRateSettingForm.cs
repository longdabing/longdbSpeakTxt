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
    public partial class SRateSettingForm : Form
    {
        public SRateSettingForm()
        {
            InitializeComponent();
            cboxrate.Text = ProdConst.SRate.ToString();
        }

        private void cboxrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdConst.SRate =Convert.ToInt32(cboxrate.Text);
        }
    }
}
