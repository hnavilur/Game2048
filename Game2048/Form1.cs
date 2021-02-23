using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game2048
{
    public partial class Form1 : Form
    {
        int[,] arr = new int[4, 4]; // By default zeroes
        bool moved = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNumber();  // insert first number
            addNumber();  // insert second number
            display();
            //gamePlay(); // start game
        }
        public int numberSelector()
        {
            Random rand = new Random();
            if (rand.Next(0, 4) == 0)
                return 4;
            else 
                return 2;
        }
        public int pickEmpty()
        {
            /* Return position of one empty cell */
            int[] listOfEmpty = new int[16];
            int k = 0;
            Random rand = new Random();
            // Find all empty cells
            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    if (arr[r, c] == 0)
                        listOfEmpty[k++] = r * 4 + c;
            // If no cell is empty, error
            // Otherwise, return position of one of the empty cells
            if (k == 0)
                return -1;
            else
                return listOfEmpty[rand.Next(0,listOfEmpty.Length)];
        }
        void addNumber()
        {
            int pos = pickEmpty();
            moved = false;
            if(pos != -1)
                arr[pos / 4, pos % 4] = numberSelector();
        }
        void gamePlay()
        {
            addNumber();
            moved = false;
            display();   
        }
        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            int i, j, k;
            if (e.KeyCode == Keys.Up)
            {
                for (j = 0; j < 4; j++) // column major
                    for (i = 0; i < 3; i++)
                    {
                        if (arr[i, j] == arr[i + 1, j])
                        {
                            arr[i, j] *= 2;
                            arr[i + 1, j] = 0;
                            i++; // below cell is emptied in last statement. skip.
                            moved = true;
                        }
                    }
                for (j = 0; j < 4; j++)
                    for (i = 0; i < 3; i++)
                    {
                        if (arr[i, j] == 0)
                        {
                            for (k = i + 1; k < 4 && arr[k, j] == 0; k++) ;
                            if (k != 4)
                            {
                                arr[i, j] = arr[k, j];
                                arr[k, j] = 0;
                                moved = true;
                            }
                            else i = 3; // all cells below in the column are empty. so, skip to next column.
                        }
                    }
            }
            else if (e.KeyCode == Keys.Down)
            {
                for (j = 0; j < 4; j++)
                    for (i = 3; i > 0; i--)
                    {
                        if (arr[i, j] == arr[i - 1, j])
                        {
                            arr[i, j] *= 2;
                            arr[i - 1, j] = 0;
                            i--; // above cell is emptied in last statement. skip.
                            moved = true;
                        }
                    }
                for (j = 0; j < 4; j++)
                    for (i = 2; i >= 0; i--)
                    {
                        if (arr[i, j] == 0)
                        {
                            for (k = i - 1; k >= 0 && arr[k, j] == 0; k--) ;
                            if (k != -1)
                            {
                                arr[i, j] = arr[k, j];
                                arr[k, j] = 0;
                                moved = true;
                            }
                            else i = -1; // all cells above in the column are empty. so, skip to next column.
                        }
                    }
            }
            else if (e.KeyCode == Keys.Left)
            {
                for (i = 0; i < 4; i++)
                    for (j = 0; j < 3; j++)
                    {
                        if (arr[i, j] == arr[i , j + 1])
                        {
                            arr[i, j] *= 2;
                            arr[i , j + 1] = 0;
                            j++; // right cell is emptied in last statement. skip.
                            moved = true;
                        }
                    }
                for (i = 0; i < 4; i++)
                    for (j = 1; j < 4; j++)
                    {
                        if (arr[i, j] == 0)
                        {
                            for (k = j + 1; k < 4 && arr[i, k] == 0; k++) ;
                            if (k != 4)
                            {
                                arr[i, j] = arr[i, k];
                                arr[i, k] = 0;
                                moved = true;
                            }
                            else j = 4; // all cells to right in the row are empty. so, skip to next row.
                        }
                    }
            }
            else if (e.KeyCode == Keys.Right)
            {
                for (i = 0; i < 4; i++)
                    for (j = 3; j > 0; j--)
                    {
                        if (arr[i, j] == arr[i, j - 1])
                        {
                            arr[i, j] *= 2;
                            arr[i, j - 1] = 0;
                            j--; // left cell is emptied in last statement. skip.
                            moved = true;
                        }
                    }
                for (i = 0; i < 4; i++)
                    for (j = 3; j > 0; j--)
                    {
                        if (arr[i, j] == 0)
                        {
                            for (k = j - 1; k >= 0 && arr[i, k] == 0; k--) ;
                            if (k != -1)
                            {
                                arr[i, j] = arr[i, k];
                                arr[i, k] = 0;
                                moved = true;
                            }
                            else j = 0; // all cells to right in the row are empty. so, skip to next row.
                        }
                    }
            }
            gamePlay();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    arr[i, j] = 0;
            
            addNumber();
            addNumber();
            moved = false;
            //gamePlay();
        }
        private void display()
        {
            b00.Text = arr[0, 0].ToString();
            b01.Text = arr[0, 1].ToString();
            b02.Text = arr[0, 2].ToString();
            b03.Text = arr[0, 3].ToString(); 
            b10.Text = arr[1, 0].ToString();
            b11.Text = arr[1, 1].ToString();
            b12.Text = arr[1, 2].ToString();
            b13.Text = arr[1, 3].ToString();
            b20.Text = arr[2, 0].ToString();
            b21.Text = arr[2, 1].ToString();
            b22.Text = arr[2, 2].ToString();
            b23.Text = arr[2, 3].ToString();
            b30.Text = arr[3, 0].ToString();
            b31.Text = arr[3, 1].ToString();
            b32.Text = arr[3, 2].ToString();
            b33.Text = arr[3, 3].ToString();
        }
    }
}
