using longdbSpeakTxt.Tools;
using SpeechLib;
using System;
using System.Data;
using System.Windows.Forms;

namespace longdbSpeakTxt.TxtToVoice
{
    public partial class TxtToVoiceForm : Form
    {
        DataTable listdt = new DataTable();//左边列表
        DataTable righttxtdt = new DataTable();//右边内容
        DataTable txtdt = new DataTable();//总的记录
        delegate void myInvoke();
        SpVoice speech = new SpVoice();
        public TxtToVoiceForm()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {          
            listdt.Columns.Add("title", typeof(string));
            righttxtdt.Columns.Add("txt", typeof(string));
        }
        public void SpeakTxt(bool iscycle=false)
        {
            speech.Rate = ProdConst.SRate;//语速  介于-10于10之间
            speech.Volume = 100;
            speech.Voice = speech.GetVoices().Item(0);//0-中文,1-英文。

            while(true)
            {
                for (int i = 0; i < righttxtdt.Rows.Count; i++)
                {
                    //SVSFlagsAsync异步播放。
                    speech.Speak(righttxtdt.Rows[i]["txt"].ToString(),
                    SpeechVoiceSpeakFlags.SVSFlagsAsync);
                }
                if (iscycle == false)
                {
                    break;
                }
            }
        }
        /// <summary>
        /// 输入的文字。
        /// </summary>
        /// <param name="text"></param>
        public void SpeakTxt(string text)
        {
            SpVoice speech = new SpVoice();
            speech.Rate = int.Parse("0");//语速  介于-10于10之间
            speech.Volume = 100;
            speech.Voice = speech.GetVoices().Item(0);//0-中文,1-英文。
            speech.Speak(text);
        }

        private void btngettxt_Click(object sender, EventArgs e)
        {
            SpeakTxt();
        }

        private void GetData()
        {
            txtdt = FileTool.ReadTxt(ProdConst.fieletxtpath);
            if (txtdt != null && txtdt.Rows.Count > 0)
            {
                listdt = txtdt.DefaultView.ToTable(true, "Title");
                listgrid.DataSource = listdt;
            }
        }

        private void RightTitleToTxt()
        {
            if (listgrid.CurrentCell != null
                &&listgrid.CurrentCell.RowIndex >= 0 
                && listdt!= null && listdt.Rows.Count >0)
            {
                if (righttxtdt != null && righttxtdt.Rows.Count > 0)
                {
                    righttxtdt.Rows.Clear();
                }
                string cellvalue = listgrid.CurrentCell.Value.ToString();
                DataRow[] dr =txtdt.Select("Title='"+ cellvalue + "'");
                for (int i = 0; i < dr.Length; i++)
                {
                    for (int j = 0; j < txtdt.Columns.Count; j++)
                    {                  
                        if (!string.IsNullOrEmpty(dr[i][j].ToString()))
                        {
                            righttxtdt.Rows.Add(1);
                            righttxtdt.Rows[j]["txt"]= dr[i][j].ToString();
                        }
                    }
                }
                //myInvoke invoke = SpeakTxt;
                //this.Invoke(invoke, null);
                txtgrid.DataSource = righttxtdt;
                SpeakTxt();
               //txtgrid.Invoke(new Action(() => txtgrid.DataSource = righttxtdt));
                //this.Invoke(new Action(() => ));             
            }
        }

        private void TxtToVoiceForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void listgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Task task = new Task(RightTitleToTxt);
            //task.Start();
            RightTitleToTxt();
        }

        private void btnpasuse_Click(object sender, EventArgs e)
        {
            if ("暂停".Equals(btnpasuse.Text))
            {
                btnpasuse.Text = "继续";
                speech.Pause();
            }
            else
            {
                btnpasuse.Text = "暂停";
                speech.Resume();
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            speech.Speak(string.Empty, SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
        }

        private void TxtToVoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnstop_Click(null,null);
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            SpeakTxt(true);
        }
    }
}
