using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace longdbSpeakTxt.TxtToVoice
{
    public partial class PoetryCreateForm : Form
    {
        private DataTable pdt = new DataTable();
        private DataTable poedt = new DataTable();
        private DataTable postmdt = new DataTable();
        private DataTable postddt = new DataTable();
        public PoetryCreateForm()
        {
            InitializeComponent();
            InitDatatable("");
            InitPostTable();

        }
        private void InitPostTable()
        {
            postmdt.Columns.Add("FNo", typeof(string));
            postmdt.Columns.Add("FTitle", typeof(string));

            postddt.Columns.Add("FMNo", typeof(string));
            postddt.Columns.Add("FLine1", typeof(string));
            postddt.Columns.Add("FLine2", typeof(string));
            postddt.Columns.Add("FLine3", typeof(string));
            postddt.Columns.Add("FLine4", typeof(string));
            postddt.Columns.Add("FLine5", typeof(string));
            postddt.Columns.Add("FLine6", typeof(string));
            postddt.Columns.Add("FLine7", typeof(string));
            postddt.Columns.Add("FLine8", typeof(string));
            postddt.Columns.Add("FLine", typeof(string));
        }
        private void InitDatatable(string title)
        {
            if (!poedt.Columns.Contains("FTitle"))
            {
                poedt.Columns.Add("FTitle", typeof(string));
                poedt.Columns.Add("FLine", typeof(string));
                poedt.Columns.Add("FMNo", typeof(string));
            }
            else
            {
                poedt.Rows.Clear();
            }
            pdt = TxtDA.GetPoetryTable(title);
            if (pdt != null && pdt.Rows.Count > 0)
            {              
                for (int i = 0; i < pdt.Columns.Count; i++)
                {
                    if (i==0)
                    {
                        poedt.Rows.Add();
                        poedt.Rows[0]["FTitle"] = pdt.Rows[0]["FTitle"];
                        poedt.Rows[0]["FLine"] = pdt.Rows[0]["FLine1"];
                        poedt.Rows[0]["FMNo"] = pdt.Rows[0]["FMNo"];
                        i++;
                    }
                    else
                    {
                        if (i < 9)
                        {
                            poedt.Rows.Add();
                            poedt.Rows[i - 1]["FLine"] = pdt.Rows[0]["FLine" + i.ToString()];
                        }
                    }
                }
                dgrid.DataSource = poedt;
            }
        }
        private void PostData()
        {
            if (dgrid.Rows.Count > 0)
            {
                if (postmdt.Rows.Count > 0)
                {
                    postmdt.Rows.Clear();
                    postddt.Rows.Clear();
                }
                //主单
                postmdt.Rows.Add();
                if (string.IsNullOrEmpty(dgrid.Rows[0].Cells["FMNo"].Value.ToString()))
                {
                    postmdt.Rows[0]["FNo"] = Guid.NewGuid().ToString();
                }
                else
                {
                    postmdt.Rows[0]["FNo"] = dgrid.Rows[0].Cells["FMNo"].Value;
                }
                postmdt.Rows[0]["FTitle"] = dgrid.Rows[0].Cells["FTitle"].Value;
                postddt.Rows.Add();
                for (int i = 0; i < dgrid.RowCount; i++)
                {
                    postddt.Rows[0]["FMNo"] = postmdt.Rows[0]["FNo"];
                    postddt.Rows[0]["FLine"+(i+1).ToString()]= dgrid.Rows[i].Cells["FLine"].Value;
                }
               int retvalue = TxtDA.Update(postmdt, "TPoetry", postddt, "TPoetryDetail",true);
                if (retvalue > 0)
                {
                    MessageBox.Show("保存成功！", "提示：");
                }
                else
                {
                    MessageBox.Show("保存失败！", "提示：");
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            PostData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitDatatable(txttitle.Text.Trim());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
