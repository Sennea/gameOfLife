using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameOfLife
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen pen;
        private SolidBrush brush;
        private SolidBrush brush2;
        private int width;
        private int height;
        private int delay;
        private int[,] lifeTab;
        private int[,] lifeTabComputed;
        private int[,] lifeTabNew;
        private int nodesPerWidth;
        private int nodesPerHeight;
        private BackgroundWorker worker = null;
        private Boolean isGrid = false;
        private Boolean isNull = true;
        private Boolean isRunning = false;
        private Boolean isAdded = false;
        private Boolean isResizeTrackbar = false;
        private Random random = new Random();

        public int PIXEL_SIZE;
        public int PIXEL_SIZE_TMP;
        public readonly int DEFAULT_SIZE = 10;

        public Form1()
        {
            PIXEL_SIZE = DEFAULT_SIZE;
            InitializeComponent();
            pen = new Pen(Color.Black);
            g = pictureBox1.CreateGraphics();
            brush = new SolidBrush(Color.Black);
            brush2 = new SolidBrush(Color.White);
            

            width = pictureBox1.Width;
            height = pictureBox1.Height;
            nodesPerWidth = width / PIXEL_SIZE;
            nodesPerHeight = height / PIXEL_SIZE;

            textBox1.Text = nodesPerWidth.ToString();
            textBox2.Text = nodesPerHeight.ToString();
        }





        private void gameOfLife()
        {
            isRunning = true;
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            int neighbourNumber = 0;

            lifeTabComputed = new int[nodesPerWidth, nodesPerHeight];

            if (isAdded)
            {
                for (int i = 0; i < nodesPerWidth; ++i)
                    for (int j = 0; j < nodesPerHeight; ++j)
                    {
                        if (lifeTabNew[i, j] == 1)
                        {
                            lifeTab[i, j] = 1;
                            drawCurrent(lifeTab, i, j);
                        }
                    }
                isAdded = false;
            }


            worker.DoWork += new DoWorkEventHandler((state, args) =>
            {
                do
                {
                    if (worker.CancellationPending)
                        break;

                    for (int i = 0; i < nodesPerWidth; ++i)
                        for (int j = 0; j < nodesPerHeight; ++j)
                        {
                            neighbourNumber = computeNeighbours(lifeTab, i, j);
                            lifeTabComputed[i, j] = checkIfAlive(neighbourNumber, lifeTab[i, j]);
                        }

                    for (int i = 0; i < nodesPerWidth; ++i)
                        for (int j = 0; j < nodesPerHeight; ++j)
                            if (isChanged(lifeTab, lifeTabComputed, i, j))
                            {
                                clearCurrent(lifeTab, i, j);
                                drawCurrent(lifeTabComputed, i, j);
                                lifeTab[i, j] = lifeTabComputed[i, j];
                            }

                    if (isAdded)
                    {
                        for (int i = 0; i < nodesPerWidth; ++i)
                            for (int j = 0; j < nodesPerHeight; ++j)
                            {

                                if (lifeTabNew[i, j] == 1)
                                {
                                    lifeTab[i, j] = 1;
                                    drawCurrent(lifeTab, i, j);
                                }
                            }
                        isAdded = false;
                    }

                    if (isResizeTrackbar)
                    {
                        resizeTracbar();
                        lifeTabComputed = new int[nodesPerWidth, nodesPerHeight];
                    }
                    System.Threading.Thread.Sleep(delay);

                } while (true);
            });

            worker.RunWorkerAsync();
        }








        private void prepare()
        {
            if (isNull)
            {
                lifeTab = new int[nodesPerWidth, nodesPerHeight];
                for (int i = 0; i < nodesPerWidth; ++i)
                    for (int j = 0; j < nodesPerHeight; ++j)
                    {
                        lifeTab[i, j] = 0;
                    }
                isNull = false;
            }

            if (!isGrid)
                drawGrid();
        }

        private void stableButton_Click(object sender, EventArgs e)
        {
            prepare();
            int x = random.Next(1, nodesPerWidth - 3);
            int y = random.Next(0, nodesPerHeight - 3);

            if (!isAdded)
                lifeTabNew = new int[nodesPerWidth, nodesPerHeight];

            lifeTabNew[x, y] = 1;
            lifeTabNew[x + 1, y] = 1;
            lifeTabNew[x - 1, y + 1] = 1;
            lifeTabNew[x, y + 2] = 1;
            lifeTabNew[x + 1, y + 2] = 1;
            lifeTabNew[x + 2, y + 1] = 1;
            isAdded = true;

            if (!isRunning)
                drawWhole(lifeTabNew);
        }

        private void oscylatorButton_Click(object sender, EventArgs e)
        {
            prepare();
            int x = random.Next(0, nodesPerWidth);
            int y = random.Next(0, nodesPerHeight - 3);
            if (!isAdded)
                lifeTabNew = new int[nodesPerWidth, nodesPerHeight];

            lifeTabNew[x, y] = 1;
            lifeTabNew[x, y + 1] = 1;
            lifeTabNew[x, y + 2] = 1;
            isAdded = true;

            if (!isRunning)
                drawWhole(lifeTabNew);
        }

        private void gliderButton_Click(object sender, EventArgs e)
        {
            prepare();
            int x = random.Next(1, nodesPerWidth - 2);
            int y = random.Next(0, nodesPerHeight - 3);
            if (!isAdded)
                lifeTabNew = new int[nodesPerWidth, nodesPerHeight];

            lifeTabNew[x, y] = 1;
            lifeTabNew[x + 1, y] = 1;
            lifeTabNew[x - 1, y + 1] = 1;
            lifeTabNew[x, y + 1] = 1;
            lifeTabNew[x + 1, y + 2] = 1;
            isAdded = true;

            if (!isRunning)
                drawWhole(lifeTabNew);
        }



        private void gliderGunButton_Click(object sender, EventArgs e)
        {
            prepare();
            if (!isAdded)
                lifeTabNew = new int[nodesPerWidth, nodesPerHeight];

            if(nodesPerHeight >13 && nodesPerWidth >37)
            {
                lifeTabNew[1, 10] = 1;
                lifeTabNew[2, 10] = 1;
                lifeTabNew[1, 11] = 1;
                lifeTabNew[2, 11] = 1;

                lifeTabNew[13, 9] = 1;
                lifeTabNew[13, 10] = 1;
                lifeTabNew[13, 11] = 1;
                lifeTabNew[13, 12] = 1;
                lifeTabNew[13, 13] = 1;
                lifeTabNew[14, 8] = 1;
                lifeTabNew[14, 10] = 1;
                lifeTabNew[14, 11] = 1;
                lifeTabNew[14, 12] = 1;
                lifeTabNew[14, 14] = 1;
                lifeTabNew[15, 9] = 1;
                lifeTabNew[15, 13] = 1;
                lifeTabNew[16, 10] = 1;
                lifeTabNew[16, 11] = 1;
                lifeTabNew[16, 12] = 1;
                lifeTabNew[17, 11] = 1;

                lifeTabNew[21, 9] = 1;
                lifeTabNew[22, 9] = 1;
                lifeTabNew[23, 8] = 1;
                lifeTabNew[23, 10] = 1;
                lifeTabNew[24, 7] = 1;
                lifeTabNew[24, 8] = 1;
                lifeTabNew[24, 10] = 1;
                lifeTabNew[24, 11] = 1;
                lifeTabNew[25, 6] = 1;
                lifeTabNew[25, 12] = 1;
                lifeTabNew[26, 9] = 1;
                lifeTabNew[27, 6] = 1;
                lifeTabNew[27, 7] = 1;
                lifeTabNew[27, 11] = 1;
                lifeTabNew[27, 12] = 1;

                lifeTabNew[30, 10] = 1;
                lifeTabNew[31, 10] = 1;
                lifeTabNew[32, 11] = 1;

                lifeTabNew[35, 8] = 1;
                lifeTabNew[35, 9] = 1;
                lifeTabNew[36, 8] = 1;
                lifeTabNew[36, 9] = 1;
                isAdded = true;
            }
            

            if (!isRunning)
                drawWhole(lifeTabNew);
        }



        private void randomButton_Click(object sender, EventArgs e)
        {
            prepare();
            if (!isAdded)
                lifeTabNew = new int[nodesPerWidth, nodesPerHeight];

            for (int i = 0; i < nodesPerWidth * 4; ++i)
            {
                int x = random.Next(0, nodesPerWidth);
                int y = random.Next(0, nodesPerHeight);
                lifeTabNew[x, y] = 1;
            }
            isAdded = true;

            if (!isRunning)
                drawWhole(lifeTabNew);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (worker != null)
            {
                worker.CancelAsync();
                isRunning = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            isGrid = false;
            isRunning = false;
            isNull = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isRunning && !isNull)
                gameOfLife();
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X/PIXEL_SIZE;
            int y = e.Y/PIXEL_SIZE;

            prepare();
            if (!isAdded)
                lifeTabNew = new int[nodesPerWidth, nodesPerHeight];

            lifeTabNew[x, y] = 1;


            if (!isRunning)
                drawCurrent(lifeTabNew,x,y);
            isAdded = true;
            isGrid = true;
        }




        



        private bool isChanged(int[,] tab, int[,] tab2, int x, int y)
        {
            if (tab[x, y] != tab2[x, y])
                return true;

            return false;
        }


        private int checkIfAlive(int count, int state)
        {
            if (state == 0 && count == 3)
                return 1;
            else if ((state == 1 && count == 2) || (state == 1 && count == 3))
                return 1;
            else if (state == 1 && count > 3)
                return 0;
            else if (state == 1 && count < 2)
                return 0;
            return 0;
        }

        private int computeNeighbours(int[,] tab, int x, int y)
        {
           int count = 0;
           int tmp = 0;

            int down = y - 1;
            int up = y + 1;
            int left = x - 1;
            int right = x + 1;
            if (up >= nodesPerHeight)
                up = 0;
            if (down < 0)
                down = nodesPerHeight - 1;
            if (left < 0)
                left = nodesPerWidth - 1;
            if (right >= nodesPerWidth)
                right = 0;

            if (tab[left, up] == 1) count++;
            if (tab[x, up] == 1) count++;
            if (tab[right, up] == 1) count++;

            if (tab[left, y] == 1) count++;
            if (tab[right, y] == 1) count++;

            if (tab[left, down] == 1) count++;
            if (tab[x, down] == 1) count++;
            if (tab[right, down] == 1) count++;
           
            return count;
        }


        private void drawWhole(int[,] tab)
        {
            for (int i = 0; i < nodesPerWidth; ++i)
                for (int j = 0; j < nodesPerHeight; ++j)
                    drawCurrent(tab, i, j);
        }

        private void drawCurrent(int[,] tab, int pos, int iteracja)
        {
            if (tab[pos, iteracja] == 1)
            {
                g.FillRectangle(brush, ( pos * PIXEL_SIZE+1), (iteracja * PIXEL_SIZE+1), PIXEL_SIZE-1, PIXEL_SIZE-1);
            }
        }

        private void clearCurrent(int[,] tab, int pos, int iteracja)
        {
            if (tab[pos, iteracja] == 1)
            {
                g.FillRectangle(brush2, (pos * PIXEL_SIZE+1), (iteracja * PIXEL_SIZE+1), PIXEL_SIZE-1, PIXEL_SIZE-1);
            }
        }

        private void drawGrid()
        {
            nodesPerWidth = int.Parse(textBox1.Text);
            nodesPerHeight = int.Parse(textBox2.Text);

            for (int i = 0; i <= nodesPerHeight; ++i)
                g.DrawLine(pen, 0, i * PIXEL_SIZE, nodesPerWidth * PIXEL_SIZE, i * PIXEL_SIZE);
            
            for (int i = 0; i <= nodesPerWidth; ++i)
                g.DrawLine(pen, i * PIXEL_SIZE,0, i * PIXEL_SIZE, PIXEL_SIZE * nodesPerHeight);

            isGrid = true;
        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            delay = trackBar1.Value;
        }

        private void gridButton_Click(object sender, EventArgs e)
        {
            if (!isGrid)
            {
                drawGrid();
                isGrid = true;
            }
        }

        private void resizeTracbar()
        {
            PIXEL_SIZE = PIXEL_SIZE_TMP;
            g.Clear(Color.White);
            isGrid = false;
            nodesPerWidth = int.Parse(textBox1.Text);
            nodesPerHeight = int.Parse(textBox2.Text);

            lifeTab = new int[nodesPerWidth, nodesPerHeight];

            drawGrid();
            isResizeTrackbar = false;
        }


        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            
            PIXEL_SIZE_TMP = trackBar2.Value;
            isResizeTrackbar = true;

            if (!isRunning)
                resizeTracbar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nodesPerWidth = int.Parse(textBox1.Text);
            //nodesPerWidth = width / PIXEL_SIZE;
            isGrid = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nodesPerHeight = int.Parse(textBox2.Text);
           // nodesPerHeight = height / PIXEL_SIZE;
            isGrid = false;
        }
    }
}
