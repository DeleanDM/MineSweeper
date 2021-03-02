using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class customForm : Form
    {
        int raws;
        int cols;
        int mines;
        public customForm(int raws, int cols, int mines)
        {
            InitializeComponent();
            this.raws = raws;
            this.cols = cols;
            this.mines = mines;
            rawsCtor.Text = raws.ToString();
            colsCtor.Text = cols.ToString();
            mineCtor.Text = mines.ToString();
        }
        public void giveFieldInfo(out int _raws, out int _cols, out int _mines)
        {
            _raws = raws;
            _cols = cols;
            _mines = mines;
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(rawsCtor.Text, out raws);
            Int32.TryParse(colsCtor.Text, out cols);
            Int32.TryParse(mineCtor.Text, out mines);
            if (checkField())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Некоректные данные");
            }
        }
        bool checkField()
        {
            if (raws > 8 || cols > 8 || mines < raws * cols - 10) 
            {
                return true;
            }
            return false;
        }
        private void rawsCtor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
