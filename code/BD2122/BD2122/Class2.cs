using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2122
{
    internal class Recipie
    {
        public string name { get; } 
        public string author { get; }
        public int calories { get; }
        public int preparingTime { get; }

        internal Recipie(string name, string author, int calories, int preparingTime)
        {
            this.name = name;
            this.author = author;
            this.calories = calories;
            this.preparingTime = preparingTime;
        }
    }
}
