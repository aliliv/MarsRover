using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Direction
    {
        public readonly static Dictionary<int, string> Directions = new Dictionary<int, string>(){
            {1, "N"},
            {2, "E"},
            {3, "S"},
            {4, "W"}
           };
    }
}
