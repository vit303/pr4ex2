using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4ex2
{
    public class Month
    {
        public string Name { get; }
        public int Number { get; }
        public string Season { get; }

        public Month(string name, int number, string season)
        {
            Name = name;
            Number = number;
            Season = season;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
