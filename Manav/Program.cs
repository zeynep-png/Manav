using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rüya manavına hoşgeldiniz".ToUpper());//metnin hepsini büyük harfle yazar

            Console.WriteLine("Hangi meyveyi satın almak istiyorsunuz?");
            string meyve = Console.ReadLine().ToLower(); //büyük harfle de değer girilse küçüğe çevirir

            int fiyat;

            switch (meyve)
            {
                case "elma":
                    fiyat = 2;
                    break;
                case "armut":
                    fiyat = 3;
                    break;
                case "çilek":
                    fiyat = 2;
                    break;
                case "muz":
                    fiyat = 3;
                    break;
                default:
                    fiyat = 4;
                    break;
            }
            //her iki yöntemde çalışır ancak basit bir yapı olduğu için switch case  daha pratiktir
            /*
              if (meyve == "elma")
        {
            fiyat = 2;
        }
        else if (meyve == "armut")
        {
            fiyat = 3;
        }
        else if (meyve == "çilek")
        {
            fiyat = 2;
        }
        else if (meyve == "muz")
        {
            fiyat = 3;
        }
        else
        {
            fiyat = 4;
        }
            */

            Console.WriteLine($"{meyve} fiyatı: {fiyat} TL");
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadLine();
        }
    }
    }

