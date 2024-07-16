using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_on_the_Loose
{
    public class StateOfGame
    {
        public bool Chapter1Done { get; set; }
        public bool Chapter2Done { get; set; }



        public StateOfGame()
        {
            Chapter1Done = false;
            Chapter2Done = false;
        }
    }
}
