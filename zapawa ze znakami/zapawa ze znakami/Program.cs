using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapawa_ze_znakami
{
    class Program
    {
        static void Main(string[] args)
        {
            string przyklProxiserve_20 = "5E 44 01 06 75 61 00 00 20 08 7A 8F 70 00 85 2F 2F 04 6D 2B 27 2D 21 04 6E 5C 00 00 00 82 04 6C 01 21 83 04 6E 00 00 00 8D 04 EE 1F 23 33 FE 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 5C 00 00 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F";
            string przyklProxiserve_20_NAGLOWEK = "5E 44 01 06 75 61 00 00 20 08 ";
            string przyklProxiserve_20_TIME_p = "5E 44 01 06 75 61 00 00 20 08 7A 8F 70 00 85 2F 2F 04 6D ";
            string przyklProxiserve_20_TIME_k = "2B 27 2D 21 04";
            string przyklProxiserve_20_WersjaP = "5E 44 01 06 75 61 00 00 ";

            string metra5_Dane = "A0 9F 01 41 22 41 22 2D 23 00 00 00 00 05 00 00 00 04 00 04 00 03 00 03 00 02 00 02 00 A0 0F";
            string metra6_Dane = "A0 3D 4B 0C 85 99 02 02 73 B7 7E 25 69 1B 5E 7C 3D 5A 37 5A FC 05 63 E8 CD 0C 36 0B BC 12 79 5A 96";
            string metra7_Dane = "A0 9F 01 41 22 41 22 2D 23 00 00 00 00 05 00 00 00";
            string metra8_Dane = "A0 3D 4B 0C 85 99 02 02 73 B7 7E 25 69 1B 5E 7C 3D 47 14";
            string proxi_Dane = "7A 21 70 50 85 2F 2F 04 6D 0F 2D 21 22 04 6E BD 5F 01 00 82 04 6C 01 22 83 04 6E AF 5E 01 8D 04 EE 1F 23 33 FE AF 5E 01 B4 5E 01 BE 5E 01 CD 5E 01 E1 5E 01 FA 5E 01 18 5F 01 3B 5F 01 63 5F 01 90 5F 01 BD 5F 01 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F";

            Console.WriteLine(przyklProxiserve_20);
            Console.WriteLine(przyklProxiserve_20.Replace(" ",""));
            Console.WriteLine("\ncalosc:{0}", przyklProxiserve_20.Length);
            Console.WriteLine("\nNaglowek:{0}", przyklProxiserve_20_NAGLOWEK.Length);
            Console.WriteLine("\nCzas poczatek:{0}", przyklProxiserve_20_TIME_p.Length);
            Console.WriteLine("\nCzas dlugosc:{0}", przyklProxiserve_20_TIME_k.Length);
            Console.WriteLine("\nWersja:{0}", przyklProxiserve_20_WersjaP.Length);
            Console.WriteLine("\nNaglowek bez przerw:{0}", przyklProxiserve_20_NAGLOWEK.Replace(" ",string.Empty).Length);
            Console.WriteLine("\nMetra 5:{0}", metra5_Dane.Length);
            Console.WriteLine("\nMetra 6:{0}", metra6_Dane.Length);
            Console.WriteLine("\nMetra 7:{0}", metra7_Dane.Length);
            Console.WriteLine("\nMetra 8:{0}", metra8_Dane.Length);
            Console.WriteLine("\nProxi dane:{0}", proxi_Dane.Replace(" ", string.Empty).Length);

            Console.Read();
        }
    }
}
