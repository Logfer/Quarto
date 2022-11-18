using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Quarto
{
    class Field
    {
        public PictureBox Picture;
        public bool Rentable;

        
        public Field(Point point, Size size)
        {
            Picture = new PictureBox();
            Picture.Location = point;
            Picture.Size = size;
            Picture.BackColor = Color.White;
            Picture.BorderStyle = BorderStyle.FixedSingle;
            Picture.Visible = true;
            Picture.SizeMode = PictureBoxSizeMode.Zoom;
            Rentable = true;
        }
    }
}
