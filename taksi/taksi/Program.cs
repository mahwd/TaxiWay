using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taksi
{
    class Program
    {
        static void Main(string[] args)
        {
            var priora = new Taksi("Priora", "90-NX-248", "qara","Isi" ,new Location("28 may",20, 40));
            var cewka = new Taksi("Mercedes c220", "90-DB-761", "metallic","Namiq", new Location("Gunewli",10,70));
            var maseratti = new Taksi("Maseratti Gran Turismo", "99-DD-999", "qirmizi","Wamo", new Location("Qara Qarayev",60, 40 ));
            var porwe = new Taksi("Porshe Cayenne Magan Turbo", "10-ON-010", "jet black carbon fiber ", "Wamo", new Location("Yeni Yasamal", 80, 60));
            var panarama = new Taksi("Mercedes E280","90-VE-565","jet black","Wamo", new Location("8km", 60, 20));

            Console.Write("Salam hormetli mushteri zehmet olmasa adinizi ve soyadinizi daxil edin . \nAd:");
            string name = Console.ReadLine();
            Console.Write("Soyad:");
            string surname = Console.ReadLine();
            string input="";

            while (input != "done")
            {
                Console.Write($"Hormetli {name} {surname}, taksilerin siyahisina baxmaq ucun [1], taksi sifarish etmek ucun [2], " +
                    $"\nKonsolu temizlemek ucun [3] , proqramdan cixmaq ucun 'done' daxil edin : ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ShowTaksiList.showAll();
                        break;
                    case "2":
                        while (true)
                        {
                            try
                            {
                                Console.Write("Muellim zehmet olmasa koordinatlarini daxil ederdiniz. \n X:");
                                int userX = int.Parse(Console.ReadLine());
                                Console.Write(" Y:");
                                int userY = int.Parse(Console.ReadLine());
                                Console.Write("Lutf etdiniz, indi ise getmeyi arzuladiginiz yerin koordinatlarini daxil edin: \n X:");
                                int userEndPointX = int.Parse(Console.ReadLine());
                                Console.Write(" Y:");
                                int userEndPointY = int.Parse(Console.ReadLine());
                                TaksiSifariwi.SifariwEt(name, surname, new Location("", userX, userY), new Location("", userEndPointX, userEndPointY));
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine($"{name} duzgun reqemi daxil edin!");
                            }
                        }
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    case "done":
                        Console.WriteLine($"{name} muellim size gelecek heyatinizda ugurlar ^_^ ");
                        break;
                    case "Done":
                        Console.WriteLine($"{name} muellim bizi secdiyiniz ucun tewekkurler ^_^ ");
                        break;
                    case "DONE":
                        Console.WriteLine($"{name} muellim size gelecek heyatinizda ugurlar ^_^ ");
                        break;
                    default:
                        break;
                }
            }
            
            //TaksiSifariwi.SifariwEt(name,surname,new Location("28 may",45,65), new Location("Yeni Yasamal",82,64));

            //TaksiSifariwi.sifariwInfo();


        }
    }
}
