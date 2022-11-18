using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto
{
    class Doll
    {
        public bool Hole, Bright, Square, Shadow;
        
        public Doll(int number)
        {
            switch (number)
            {
                case 1:
                    Bright = true;
                    Square = true;
                    Hole = true;
                    Shadow = true;
                    break;
                case 2:
                    Bright = true;
                    Square = true;
                    Hole = false;
                    Shadow = true;
                    break;
                case 3:
                    Bright = true;
                    Square = true;
                    Hole = true;
                    Shadow = false;
                    break;
                case 4:
                    Bright = true;
                    Square = true;
                    Hole = false;
                    Shadow = false;
                    break;
                case 5:
                    Bright = true;
                    Square = false;
                    Hole = true;
                    Shadow = true;
                    break;
                case 6:
                    Bright = true;
                    Square = false;
                    Hole = false;
                    Shadow = true;
                    break;
                case 7:
                    Bright = true;
                    Square = false;
                    Hole = true;
                    Shadow = false;
                    break;
                case 8:
                    Bright = true;
                    Square = false;
                    Hole = false;
                    Shadow = false;
                    break;
            }
        }
        public Doll(string number)
        {
            switch (number)
            {
                case "1":
                    Bright = false;
                    Square = true;
                    Hole = true;
                    Shadow = true;
                    break;
                case "2":
                    Bright = false;
                    Square = true;
                    Hole = false;
                    Shadow = true;
                    break;
                case "3":
                    Bright = false;
                    Square = true;
                    Hole = true;
                    Shadow = false;
                    break;
                case "4":
                    Bright = false;
                    Square = true;
                    Hole = false;
                    Shadow = false;
                    break;
                case "5":
                    Bright = false;
                    Square = false;
                    Hole = true;
                    Shadow = true;
                    break;
                case "6":
                    Bright = false;
                    Square = false;
                    Hole = false;
                    Shadow = true;
                    break;
                case "7":
                    Bright = false;
                    Square = false;
                    Hole = true;
                    Shadow = false;
                    break;
                case "8":
                    Bright = false;
                    Square = false;
                    Hole = false;
                    Shadow = false;
                    break;
            }
        }
    }
}
