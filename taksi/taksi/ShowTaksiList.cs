using System;
using System.Collections.Generic;

namespace taksi
{
    class ShowTaksiList
    {

        public static void showAll()
        {
            foreach (var item in TaksiSifariwi.TaksiList)
            {
                Console.WriteLine($"Taksi markasi: {item.CarModel} \n Taksi nomresi {item.CarNumber}  \n Taksi rengi: {item.Color} \n Surucu : {item.Driver} \n Taksinin yeri: ({item.Locate.X},{item.Locate.Y})\n");
            }
        } 

    }
}
