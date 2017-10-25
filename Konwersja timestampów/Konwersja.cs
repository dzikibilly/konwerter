using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

class Konwersja
 {
    #region przykłady ramek
    //string przyklProxiserve_20 = "5E 44 01 06 75 61 00 00 20 08 7A 8F 70 00 85 2F 2F 04 6D 2B 27 2D 21 04 6E 5C 00 00 00 82 04 6C 01 21 83 04 6E 00 00 00 8D 04 EE 1F 23 33 FE 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 5C 00 00 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F";
    // string przyCeris_21 = "4E 44 01 06 66 61 00 00 21 08 7A CC 70 00 85 2F 2F 0F A0 20 0B 45 71 31 12 23 D7 00 C1 00 00 C3 C3 00 BC BB BC BC 00 86 00 00 00 00 9B 40 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 2D 00 00 06 3E B2 00 00 4E 4E 4E 00 00 00 2F 2F 2F 2F";

    /*
     ALARMY
7A 12 50 20 85 2F 2F C2 04 6C 35 22 84 05 20 26 00 00 00 C2 04 6C 00 00 84 05 20 00 00 00 00 2F 2F 2F 2F 2F 2F 
STATYSTYCZNA
7A 01 00 70 85 2F 2F 0F A4 09 66 20 00 1F EF 12 12 10 D2 00 00 0B 50 05 22 74 16 9A 27 10 03 E8 82 64 00 04 00 00 00 00 00 00 00 00 00 00 00 00 00 00 58 00 0B 00 00 21 00 05 00 08 80 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 2F 2F 2F 2F 2F 2F 2F 
HISTORYCZNA
7A 01 00 80 85 2F 2F 0F A1 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 
PODSTAWOWA
7A 01 00 40 85 2F 2F 0F A0 20 3E EF 76 31 12 30 E3 00 BA 00 0B AE 31 E0 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 A9 00 00 00 00 00 2F 2F 2F 2F 
HIST_MAX
7A 01 00 30 85 2F 2F C2 04 6C 01 22 CA 04 5A 00 00 CD 04 DA 1F 18 3A FE 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 2F 2F 2F 2F 2F 2F 2F 

        dane metra5
A0 9F 01 70 01 70 01 3C 00 00 00 00 00 07 00 00 00 07 00 06 00 06 00 05 00 05 00 04 00 A0 0F
dane metra6
A0 02 37 9F 01 70 01 70 01 3C 00 00 00 00 00 07 00 07 00 07 00 06 00 06 00 05 00 05 00 04 00 A0 0F
metra7
A0 9F 01 70 01 70 01 3C 00 00 00 00 00 07 00 00 00
metra8
A0 02 37 9F 01 70 01 70 01 3C 00 00 00 00 00 07 00 00 00
     */
    #endregion
    public static string metra5 = "A09F01700170013C000000000007000000070006000600050005000400A00F"; //62
    public static string metra6 = "A002379F01700170013C000000000007000700070006000600050005000400A00F"; //66
    public static string metra7 = "A09F01700170013C000000000007000000"; //34
    public static string metra8 = "A002379F01700170013C000000000007000000"; //38

    public static string metra6_kodowana = "A0 B7 1E BE DA 1E A2 8A C6 BF 37 25 4B 86 26 7A 4C FF F7 2F F3 40 38 E0 D1 AB 58 20 DE E2 B7 AA 3E";
    public static string metra6_zdekodowana = "A0 1B 0D 00 00 21 00 5B 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
    public Konwersja()
        {
            
        } 
    public string DateTypeF(byte[] data)
    {
        int minute = data[0] & 0x3f;
        int hour = data[1] & 0x1f;
        int day = data[2] & 0x1f;
        int month = data[3] & 0x0f;
        int invalid = (data[0] >> 7) & 0x01;
        int century = (data[1] >> 5) & 0x03;
        int summer = (data[1] >> 7) & 0x01;
        int year = ((data[2] >> 5) & 0x07) + (((data[3] >> 4) & 0x0f) << 3);

        #region zera wiodące
        string minuty;
        if (minute<10)
        {
            minuty =("0"+minute.ToString());
        }else
        {
            minuty = minute.ToString();
        }
        string godziny;
        if (hour<10)
        {
            godziny = ("0" + hour.ToString());
        }
        else
        {
            godziny = hour.ToString();
        }
        string dni;
        if (day < 10)
        {
            dni = ("0" + day.ToString());
        }
        else
        {
            dni = day.ToString();
        }
        string miesiace;
        if (month < 10)
        {
            miesiace = ("0" + month.ToString());
        }
        else
        {
            miesiace = month.ToString();
        }
        #endregion

        return "Data typu G:"+ dni + "/"+ miesiace + "/"+ year+" "+godziny+":"+ minuty+" "+ (summer == 1 ? "summer" : "standard") + " time"
            + (invalid == 1 ? " INVALID" : "");

      /*  return day + "/" + month + "/" + year + " " + hour + ":" + minute
            + " " + (summer == 1 ? "summer" : "standard") + " time"
            + (invalid == 1 ? " INVALID" : ""); */
    }
    public string DataMetra_BezLEdian(byte[] data) //zapisane normalnie
    {
        //  int year = ((data[1] >> 1)&0x7f);
        int year = 2000 + (data[0] >> 1); //ok
        int month = ((data[0] & 0x01) << 3) + ((data[1] & 0xE0) >> 5);
        int day = (data[1] & 0x1f); //ok
        return "dzien:" + day + " miesiac:" + month + " rok:" + year + " ";
    }
    public string DataMetra_LittleEdian(byte[] data) //po prostu kopiowane
    {
        int year = 2000 + (data[1] >> 1); 
        int month = ((data[1] & 0x01) << 3) + ((data[0] & 0xE0) >> 5);
        int day = (data[0] & 0x1f); 
        return "dzien:" + day + " miesiac:" + month + " rok:" + year + " ";
    }
    public int Typ_ramki(string wej)
    {
        if((Log_Error(wej))==false)
        {
            if (Convert.ToInt32(wej.Substring(24, 2)) == 20)
            {
                return 20;
            }
            else if (Convert.ToInt32(wej.Substring(24, 2)) == 21)
            {
                return 21;
            }
            else if (Convert.ToInt32(wej.Substring(24, 2)) == 25)
            {
                return 25;
            }
            else if (Convert.ToInt32(wej.Substring(24, 2)) == 26)
            {
                return 26;
            }
            else if (Convert.ToInt32(wej.Substring(24, 2)) == 27)
            {
                return 27;
            }
            else if (Convert.ToInt32(wej.Substring(24, 2)) == 28)
            {
                return 28;
            }
            return 0;
        }
        else
        {
            return 0;
        }     

    }
    public string Czas_z_ramki_proxiserve_calej(string wej)
    {
        string str = wej.Substring(57, 14);

        if (str.Length==metra8.Length)
        {
            return str;
        }
        return str;
    }
    public string Czas_z_ramki_proxiserve_dane(string wej)
    {
        string str = wej.Substring(27, 14);
        return str;
    }
    public bool Log_Error(string wej)
    {
        bool pom=true;
        if (wej.Replace(" ",string.Empty).Length>=170)
        {
            pom = false;
        }
        return pom;
    }
    public int Dane_Wejsciowe(string wej)
    {
        int pomocnicza=wej.Replace(" ", string.Empty).Length;

        if (wej.Length == metra5.Length)
        {
            return 251;
        }else
        if (wej.Length == metra6.Length)
        {
            return 261;
        }
        else
        if (wej.Length == metra7.Length)
        {
            return 271;
        }
        else
        if (wej.Length == metra8.Length)
        {
            return 281;
        }
        if (wej.Length == metra5.Length+20)
        {
            return 25;
        }
        else
        if (wej.Length == metra6.Length + 20)
        {
            return 26;
        }
        else
        if (wej.Length == metra7.Length + 20)
        {
            return 27;
        }
        else
        if (wej.Length == metra8.Length + 20)
        {
            return 28;
        }
        else
            return 0;
    }

    public string drukowanie_danych(string wej,bool ch1,bool ch2, bool ch3)
    {
        byte[] dec;


        if (((eliminacjaPrzerwy(wej) == metra5.Length) || (eliminacjaPrzerwy(wej) == metra7.Length)) & (ch1 == true) & (ch2 == true) & (ch3 == true))
        {
            dec = SoapHexBinary.Parse(wej.Substring(3, 5)).Value; //start okresu rozliczeniowego
            string okresR = DataMetra_LittleEdian(dec);
            string Odczytu = DataMetra_LittleEdian(SoapHexBinary.Parse(wej.Substring(9, 5)).Value);
            string plomby = DataMetra_LittleEdian(SoapHexBinary.Parse(wej.Substring(15, 5)).Value);
            return "Okres rozliczeniowy:"+okresR+"Data odczytu:"+ Odczytu+ "Alarm plomby:" + plomby;
        } else if (((eliminacjaPrzerwy(wej) == 62) || (eliminacjaPrzerwy(wej) == 50))&(ch1==true)& (ch2==true))
        {
            dec = SoapHexBinary.Parse(wej.Substring(3, 5)).Value; //start okresu rozliczeniowego
            string okresR = DataMetra_LittleEdian(dec);
            string Odczytu = DataMetra_LittleEdian(SoapHexBinary.Parse(wej.Substring(9, 5)).Value);
            return "Okres rozliczeniowy:" + okresR + "Data odczytu:" + Odczytu;
        } else if (((eliminacjaPrzerwy(wej) == 62) || (eliminacjaPrzerwy(wej) == 50))&(ch1==true))
        {
            dec = SoapHexBinary.Parse(wej.Substring(3, 5)).Value; //start okresu rozliczeniowego
            string okresR = DataMetra_LittleEdian(dec);
            return "Okres rozliczeniowy:" + okresR;
        }
            return "Błędne pole danych - obsługiwane Metra 5 i 7";
    }
    public string drukowanie_danych_Metra6_8(string wej, bool ch1, bool ch2, bool ch3)
    {
        byte[] dec;

            dec = SoapHexBinary.Parse(wej.Substring(6, 5)).Value; //start okresu rozliczeniowego
            string okresR = DataMetra_LittleEdian(dec);
            string Odczytu = DataMetra_LittleEdian(SoapHexBinary.Parse(wej.Substring(13, 5)).Value);
            string plomby = DataMetra_LittleEdian(SoapHexBinary.Parse(wej.Substring(15, 5)).Value);
            return "Okres rozliczeniowy:" + okresR + "Data odczytu:" + Odczytu + "Alarm plomby:" + plomby; 
    }
    public string drukowanie_danych_Metra8(string wej, bool ch1, bool ch2, bool ch3)
    {
        byte[] dec;

        dec = SoapHexBinary.Parse(wej.Substring(6, 5)).Value; //start okresu rozliczeniowego
        string okresR = DataMetra_LittleEdian(dec);
        string Odczytu = DataMetra_LittleEdian(SoapHexBinary.Parse(wej.Substring(13, 5)).Value);
        string plomby = DataMetra_LittleEdian(SoapHexBinary.Parse(wej.Substring(15, 5)).Value);
        return "Okres rozliczeniowy:" + okresR + "Data odczytu:" + Odczytu + "Alarm plomby:" + plomby;
    }
    public static DateTime Konwersja_Timestamp_Ceris(int unixTimeStamp)
    {
        System.DateTime dtDateTime = new DateTime(2000, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
        dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
        return dtDateTime;
    }
    public string DateTypeG(byte[] data)
    {
        int dzien = data[0] & 0x1F;
        int miesiac = (data[1] & 0x0F);
        int rok = ((data[0] & 0xE0)>>5) | (data[1] & 0xF0) >> 1;
        return ""+ dzien + "/" + miesiac +"/" + (rok+2000);
    }
    public int eliminacjaPrzerwy(string wej)
    {
        int pom= wej.Replace(" ", string.Empty).Length;
        return pom;
    }

}
