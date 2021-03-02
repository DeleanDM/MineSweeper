using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace minesweeper
{
    class Cell : UserControl
    {
        public delegate void explode();
        public event explode hereIsMine;
        public int xCord;
        public int yCord;
        public bool isOpened = false;
        int defaultSize = 25;
        public bool isCorner;
        public bool flagged = false;
        public int MineStatus { get; set; } = 0;  // 9 = есть мина
        public Cell()
        {
            BackgroundImageLayout = ImageLayout.Stretch; // фиксит изображение кнопки
            BackgroundImage = Properties.Resources.closedCell;
            Size = new System.Drawing.Size(defaultSize, defaultSize);
        }
        public Cell(int X, int Y, bool isCorner, int xCord, int yCord)
        {
            Size = new System.Drawing.Size(defaultSize, defaultSize);
            Location = new System.Drawing.Point(X, Y);

            BackgroundImageLayout = ImageLayout.Stretch; // фиксит изображение кнопки
            BackgroundImage = Properties.Resources.closedCell;
           

            this.isCorner = isCorner;

            this.xCord = xCord;
            this.yCord = yCord;
        }
        public void open(bool isGameOver)
        {
            if (MineStatus == 9 && !isGameOver)
            {
                hereIsMine();
                BackgroundImage = Properties.Resources.boom;
            }
            else if (!isGameOver && !isOpened)
            {
                BackgroundImage = Images.images[MineStatus];
                isOpened = true;
                Form1.openedCells++;
                flagged = false;
            }
            else if (flagged && MineStatus != 9)
            {
                BackgroundImage = Images.images[12];
            }
            else if (flagged && MineStatus == 9) 
            {
                // оставляем как есть
            }
            else 
            { 
                BackgroundImage = Images.images[MineStatus];
                isOpened = true;
              //  Form1.openedCells++;
            }
        }
        public void putFlag()
        {
            if (!isOpened) // pay att
            {
                flagged = !flagged;
                int x = 0;
                //int x = flagged ? 11 : 13; // -> class image
                if (flagged)
                {
                    Form1.flagCounter--;
                    x = 11; // -> в классе image х это номер картинки которую нужно поставить 
                }
                else
                {
                    Form1.flagCounter++;
                    x = 13; // ->  в классе image х это номер картинки которую нужно поставить 
                }
                 BackgroundImage = Images.images[x];
            }
        }
    }
}
