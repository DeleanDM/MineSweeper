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

    public partial class Form1 : Form
    {
        public static bool isGameOver = false;
        public static int flagCounter = 0;
        public static int openedCells = 0;
        byte gamemod = 1; // 1 - beginer, 2 - intermediate, 3 - professional, 4 - custom
        int time = 0; // время игры в секундах
        int mineAmount = 10;
        int rows = 9;
        int cols = 9;
        Cell[,] cells;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gameStart();
        }
        public void gameStart()
        {
            timer1.Stop();
            isGameOver = false;
            time = 0;
            flagCounter = mineAmount;
            mineLabel.Text = flagCounter.ToString();
            timerLabel.Text = "000";
            this.SetClientSizeCore(cols * 25, rows * 25 + fieldPanel.Location.Y);
            fieldPanel.Size = new Size(cols * 25, rows * 25);
            createField();
            showField();
            setMines();
            setField();
            // cheat(); // отображает все мины
            openedCells = 0;
        }
        void cheat() // отображает все мины
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (cells[i, j].MineStatus == 9)
                    {
                        cells[i, j].BackgroundImage = Properties.Resources.bomb;
                    }
                }
            }
        }
        void setField()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (cells[i, j].MineStatus == 9)
                    {
                        continue;
                    }
                    for (int r = -1; r <= 1; r++)
                    {
                        for (int c = -1; c <= 1; c++)
                        {
                            int iCord = i + r;
                            int jCord = j + c;

                            if (iCord >= 0 && iCord < rows && jCord >= 0 && jCord < cols && cells[i + r, j + c].MineStatus == 9)
                            {
                                cells[i, j].MineStatus++;
                            }
                        }
                    }
                    //    cells[i, j].BackgroundImage = Images.images[cells[i, j].MineStatus];
                }
            }
        }
        void setMines()
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < mineAmount; i++)
            {
                int rdRow = rd.Next(0, rows);
                int rdCol = rd.Next(0, cols);
                while (cells[rdRow, rdCol].MineStatus == 9 || cells[rdRow, rdCol].isCorner)
                {
                    rdRow = rd.Next(0, rows);
                    rdCol = rd.Next(0, cols);
                }
                cells[rdRow, rdCol].MineStatus = 9;
                // cells[rdRow, rdCol].BackgroundImage = Properties.Resources.bomb;
            }
        }
        void createField()
        {
            int xCord = 0;
            int yCord = 0;
            cells = new Cell[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                xCord = 0;
                for (int j = 0; j < cols; j++)
                {
                    bool corner = false;
                    if (i == 0 && j == 0)
                    {
                        corner = true;
                    }
                    else if (i == 0 && j == cols - 1)
                    {
                        corner = true;
                    }
                    else if (i == rows - 1 && j == 0)
                    {
                        corner = true;
                    }
                    else if (i == rows - 1 && j == cols - 1)
                    {
                        corner = true;
                    }
                    cells[i, j] = new Cell(xCord, yCord, corner, i, j);
                    cells[i, j].MouseUp += Form1_MouseUp;
                    cells[i, j].MouseDown += Form1_MouseDown;
                    cells[i, j].hereIsMine += Form1_hereIsMine;
                    xCord += 25;
                }
                yCord += 25;
            }
        }
        void showField()
        {
            fieldPanel.Controls.Clear();
            cells.Cast<Cell>().AsParallel().ForAll(x => fieldPanel.Invoke(new Action(() => fieldPanel.Controls.Add(x))));
            //foreach (var item in cells)
            //{
            //    fieldPanel.Controls.Add(item);
            //}
        }
        private void Form1_hereIsMine()
        {
            isGameOver = true;
            pictureBox1.Image = Properties.Resources.rip2;
            timer1.Stop();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    cells[i, j].open(true);
                }
            }

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Cell cell = sender as Cell;

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Cell cell = sender as Cell;
            if (e.Button == MouseButtons.Left)
            {
                openByClick(cell);
            }
            else if (e.Button == MouseButtons.Right)
            {
                cell.putFlag();
                mineLabel.Text = flagCounter.ToString();
            }
        }
        void checkWin()
        {
            if (openedCells == rows * cols - mineAmount)
            {
                timer1.Stop();
                MessageBox.Show("win");
                pictureBox1.Image = Properties.Resources.win2;
                isGameOver = true;
                switch (gamemod)
                {
                    case 1:
                        if (time < Settings.Default.BeginerRecord)
                        {
                            Settings.Default.BeginerRecord = time;
                        }
                        break;
                    case 2:
                        if (time < Settings.Default.IntermediateRecord)
                        {
                            Settings.Default.IntermediateRecord = time;
                        }
                        break;
                    case 3:
                        if ( time < Settings.Default.ProffesionalRecord)
                        {
                            Settings.Default.ProffesionalRecord = time;
                        }
                        break;
                    default:
                        break;
                }
                Settings.Default.Save();
            }
        }
        void openByClick(Cell cell)
        {
            if (!isGameOver)
            {
                if (!timer1.Enabled)
                {
                    timer1.Start();
                }
                if (cell.MineStatus > 0)
                {
                    cell.open(false);
                    //mineLabel.Text = openedCells.ToString(); // для тестов, показывает сколько открытых клеток вместо счетчика флажков
                    checkWin();
                }
                else
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int iCord = i + cell.xCord;
                            int jCord = j + cell.yCord;
                            if (iCord >= 0 && iCord < rows && jCord >= 0 && jCord < cols && !cells[iCord, jCord].isOpened)
                            {
                                cells[iCord, jCord].open(false);
                               // mineLabel.Text = openedCells.ToString(); // для тестов, показывает сколько открытых клеток вместо счетчика флажков
                                checkWin();
                                if (cells[iCord, jCord].MineStatus == 0)
                                {
                                    openByClick(cells[iCord, jCord]);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = (++time).ToString().PadLeft(3, '0');
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStart();
        }
        private void новичокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamemod = 1;
            mineAmount = 10;
            rows = 9;
            cols = 9;
            gameStart();
        }
        private void любительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamemod = 2;
            mineAmount = 40;
            rows = 16;
            cols = 16;
            gameStart();
        }

        private void проффесионалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamemod = 3;
            mineAmount = 99;
            rows = 16;
            cols = 30;
            gameStart();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Capture = false;
            pictureBox1.Image = Properties.Resources.norm2;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.normal1;
            gameStart();
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!isGameOver)
            {
                pictureBox1.Image = Properties.Resources.normal1;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.win2;
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                pictureBox1.Image = Properties.Resources.norm2;
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gamemod = 4;
            customForm form2 = new customForm(rows, cols, mineAmount);
            form2.FormClosing += Form2_FormClosing;
            form2.Show();
        }
        private void рекордыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            customForm form2 = sender as customForm;
            if (form2.DialogResult != DialogResult.Cancel)
            {
                form2.giveFieldInfo(out rows, out cols, out mineAmount);
                gameStart();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
