using System;
using System.Collections.Generic;


namespace taksi
{
    class Taksi
    {
        public string CarModel;
        public string CarNumber;
        public string Color;
        public string Driver;
        public string Mekan = "Chapayev";
        public Location Locate;



        public Taksi(string model, string number,string color ,  string surucu, Location location)
        {
            CarModel = model;
            CarNumber = number;
            Color = color;
            Driver = surucu;
            this.Locate = location;
            TaksiSifariwi.AddTaksi(this);
        }


        public void move(Location newLocation)
        {
            Mekan = newLocation.Mekan;
            Locate = newLocation;
        }

        
    }
}
