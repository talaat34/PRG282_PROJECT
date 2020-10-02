using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_PROJECT_Military_Simulations
{
    class AirCraft
    {
        public string id;
        public string name;
        public string surname;
        public bool goLeft, goRight, goDown, goUp, gameOver = false;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }


        public AirCraft()
        {

        }
    }
}
