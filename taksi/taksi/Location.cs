using System;

namespace taksi
{
    class Location
    {
        public int X {get;set;}
        public int Y {get;set;}
        public string Mekan;
        public Location(string mekan ,int x,int y)
        {
            Mekan = mekan;
            X = x;
            Y = y;
        }

    }
}
