using System;
using System.Linq;
using System.Collections.Generic;


namespace taksi
{
    class Calc
    {
        public static int taksiVelosity = 3;
        public static int taksiPrice = 2;
        public static List<double> mesafeler = new List<double>();
        public static List<Taksi> taksiler = new List<Taksi>();
        public static double minMesafe { get; set; }
        public static double mesafe;
        public static double Price { get ; set ; }
        public static int Time { get; set; }
        
        

        public static Taksi nearestTaksi(Location startPoint,Location endPoint)
        {
            mesafe = Calc.CalcMesafe(startPoint,endPoint);
            foreach (var item in TaksiSifariwi.TaksiList)
            {
                mesafeler.Add(Calc.CalcMesafe(item.Locate,startPoint));
                taksiler.Add(item);
            }

            minMesafe = mesafeler.ToArray().Min();
            int index = mesafeler.IndexOf(minMesafe);
            return taksiler[index];
        } 

        public static double CalcPrice()
        {
            Price = mesafe * 0.2;
            return Price;
        }

        public static double CalcMesafe(Location startPoint, Location endPoint)
        {
            return Math.Sqrt(Math.Pow((startPoint.X - endPoint.X), 2) + Math.Pow((startPoint.Y - startPoint.Y), 2));
        }

        public static int CalcTime()
        {
            Time = Convert.ToInt32(mesafe / 3);
            return Time;
        }

    }
}
