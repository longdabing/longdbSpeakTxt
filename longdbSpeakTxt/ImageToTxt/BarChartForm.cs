using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace longdbSpeakTxt.ImageToTxt
{
    public partial class BarChartForm : Form
    {
        public BarChartForm()
        {
            InitializeComponent();
        }

        public void BarExample()
        {
            this.barchart.Series.Clear();

            // Data arrays
            string[] seriesArray = { "Cat", "Dog", "Bird", "Monkey" };
            int[] pointsArray = { 2, 1, 7, 5 };

            // Set palette
            this.barchart.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.barchart.Titles.Add("Animals");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.barchart.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarExample();
        }
    }
}
