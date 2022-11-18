using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quarto
{
    public partial class Form1 : Form
    {
        static int Size = 4;
        static Field[,] Map = new Field[Size, Size];
        static List<Doll> Dolls = new List<Doll>();



        public Form1()
        {
            InitializeComponent();
            GenerateMap();
            GenerateDolls();
            GenerateDollsBoard();
        }

        private void GenerateDollsBoard()
        {
            int gap = 10;
            int size = ((groupBox1.Height - 60) / Map.GetLength(1)) - (gap / Map.GetLength(1) - 1);

            int startY = gap;
            int startX = 4*size/10*(groupBox1.Height - (Map.GetLength(1) * size + (Map.GetLength(1) - 1) * gap)) / 2;

            for (int row = 0; row < Map.GetLength(0); row++)
            {
                for (int column = 0; column < Map.GetLength(1); column++)
                {
                    int xPosition = startX + column * size + column * gap;
                    int yPosition = startY + row * size + row * gap;

                    Map[row, column] = new Field(new Point(xPosition, yPosition), new Size(size, size));
                    Map[row, column].Picture.Click += Picture_Click;
                    //Map[row, column].Picture.Image = ;
                    this.Controls.Add(Map[row, column].Picture);
                }
            }
        }

        private void GenerateDolls()
        {
            for (int i = 1; i < 8; i++)
            {
                Dolls.Add(new Doll(i));
            }
            for (int i = 1; i < 8; i++)
            {
                Dolls.Add(new Doll(Convert.ToString(i)));
            }
        }

        private void GenerateMap()
        {
            int gap = 10;
            int size = ((groupBox1.Height - 60) / Map.GetLength(1)) - (gap / Map.GetLength(1) - 1);

            int startY = gap;
            int startX = (groupBox1.Height - (Map.GetLength(1) * size + (Map.GetLength(1) - 1) * gap)) / 2;

            for (int row = 0; row < Map.GetLength(0); row++)
            {
                for (int column = 0; column < Map.GetLength(1); column++)
                {
                    int xPosition = startX + column * size + column * gap;
                    int yPosition = startY + row * size + row * gap;

                    Map[row, column] = new Field(new Point(xPosition, yPosition), new Size(size, size));
                    Map[row, column].Picture.Click += Picture_Click;
                    this.Controls.Add(Map[row, column].Picture);
                }
            }
        }
        private Point RelMousPoz()
        {
            return new Point(MousePosition.X - this.Location.X - 8, MousePosition.Y - this.Location.Y - 38);
        }


        private void Picture_Click(object sender, EventArgs e)
        {
        }
    }
}
