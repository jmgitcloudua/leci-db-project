using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2122
{
    internal class Recipie
    {
        string name; 
        string author; 
        int calories; 
        int preparingTime;
        
        internal Recipie(string name, string author, int calories, int preparingTime)
        {
            this.name = name;
            this.author = author;
            this.calories = calories;
            this.preparingTime = preparingTime;
        }
    }
}
