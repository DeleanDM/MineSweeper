using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using minesweeper.Properties;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            beginerTime.Text = Settings.Default.BeginerRecord.ToString();
            intermediateTime.Text = Settings.Default.IntermediateRecord.ToString();
            profTime.Text = Settings.Default.ProffesionalRecord.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.BeginerRecord = 999;
            Settings.Default.IntermediateRecord = 999;
            Settings.Default.ProffesionalRecord = 999;

            beginerTime.Text = Settings.Default.BeginerRecord.ToString();
            intermediateTime.Text = Settings.Default.BeginerRecord.ToString();
            profTime.Text = Settings.Default.BeginerRecord.ToString();

            Settings.Default.Save();
        }
    }
}
