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
        public PoetryCreateForm()
        {
            InitializeComponent();
            InitDatatable();
        }
        private void InitDatatable()
        {
            pdt = TxtDA.GetPoetryTable("");
            if (pdt != null && pdt.Rows.Count > 0)
            {
                poedt.Columns.Add("FTitle", typeof(string));
                poedt.Columns.Add("FLine", typeof(string));
                for (int i = 0; i < pdt.Columns.Count; i++)
                {
                    if ("FTitle".Equals(pdt.Columns[i].ColumnName))
                    {
                        poedt.Rows.Add();
                        poedt.Rows[0]["FTitle"] = pdt.Rows[0]["FTitle"];
                        poedt.Rows[0]["FLine"] = pdt.Rows[0]["FLine1"];
                        i++;
                    }
                    else
                    {
                        poedt.Rows.Add();
                        poedt.Rows[i-1]["FLine"] = pdt.Rows[0]["FLine"+i.ToString()];
                    }
                }
                dgrid.DataSource = poedt;
            }
        }
    }
}
