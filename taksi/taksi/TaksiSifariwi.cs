using System;
using System.Collections.Generic;
namespace taksi
{
    class TaksiSifariwi
    {
        public static string CustomerName { get; set; }
        public static string CustomerSurname{get;set;}
        public static Location StartPoint { get; set; }
        public static Location EndPoint { get; set; }
        public static Taksi taxi;
        public static List<Taksi> TaksiList = new List<Taksi>();


        public static void SifariwEt(string name,string surname,Location startPoint , Location endPoint )
        {
            CustomerName = name;
            CustomerSurname = surname;
            StartPoint = startPoint;
            EndPoint = endPoint;
            taxi = Calc.nearestTaksi(startPoint,endPoint);
            Calc.CalcTime();
            Calc.CalcPrice();
            TaksiSifariwi.sifariwInfo();
            taxi.move(endPoint);
        }
            

        public static void sifariwInfo()
        {
            Console.WriteLine($"Hormetli {CustomerName} {CustomerSurname} sizin sifariwiniz qebul olundu.");
            Console.WriteLine($"{taxi.Color} rengli {taxi.CarNumber} nomreli {taxi.CarModel} markali taksi \n {Calc.Time} deqiqeden sonra istediyiniz noqtede olacaq." +
                $" Xidmet haqqi {Calc.Price} manatdir.\n Bizi secdiyiniz ucun tewekkurler");
        }

        public static void AddTaksi(Taksi taksi)
        {
            TaksiList.Add(taksi);
        }


    }
}
