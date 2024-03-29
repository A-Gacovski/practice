using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace racing_program.Classes
{
    internal class F1_car
    {
        public string Team { get; set; }
        public int Speed { get; set; }

        public F1_car(){ }
        public F1_car(string team, int speed)
        {
            Team = team;
            Speed = speed;
        }
    }
}
