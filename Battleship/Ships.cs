using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ships
    {
        public string name;
        public int spaceSize;
        public bool sunk;

        public Ships(string name, int spaceSize, bool sunk)
        {
            this.name = name;
            this.spaceSize = spaceSize;
            this.sunk = sunk;
        }
    }
}
