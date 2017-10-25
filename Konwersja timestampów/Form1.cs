using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Globalization;

namespace Konwersja_timestampów
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
           // string daneProxi = "A09F015B22000000000000000000000000000000000000000000000000A00F";
            InitializeComponent();
            // wyswietlanieWynikow.Text=daneProxi.Length.ToString();
            chbDataR.Checked = true;
            chbAlarmy.Checked = true;
            chbDataAktualna.Checked = true;

        }
        public string str;
        public string danePrx = "7A 05 00 50 85 2F 2F 04 6D 07 20 01 01 04 6E 00 00 00 00 82 04 6C E1 F1 83 04 6E 7F FE FF 8D 04 EE 1F 23 33 FE 89 FE FF 98 FE FF AC FE FF C5 FE FF E3 FE FF 06 FF FF 2E FF FF 5B FF FF 8D FF FF C4 FF FF 00 00 00 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F 2F ";
        Konwersja knwrs = new Konwersja();
        Dekodowanie dek = new Dekodowanie();

        #region Metra-analiza daty
        private void button1_Click(object sender, EventArgs e)
        {
            wyswietlanieWynikow.ScrollToCaret();
            wyswietlanieWynikow.Refresh();
            byte[] dec;
            if (((knwrs.eliminacjaPrzerwy(tbWprowadzenie.Text) == 62)||(knwrs.eliminacjaPrzerwy(tbWprowadzenie.Text) == 34)) & (ckDane.Checked == true))
            {
                string str1 = tbWprowadzenie.Text;
                str=str+ knwrs.drukowanie_danych(str1, chbDataR.Checked, chbDataAktualna.Checked, chbAlarmy.Checked) + "\r\n";
                wyswietlanieWynikow.Text = str;
            }
            else if ((tbWprowadzenie.TextLength == 4))
            {

                dec = SoapHexBinary.Parse(tbWprowadzenie.Text).Value;
                str = str + "    " + knwrs.DataMetra_LittleEdian(dec) + "\r\n";
                wyswietlanieWynikow.Text = (str);
            }
            else
                MessageBox.Show("Podano nieprawidłową długośc hexa - 2 bajty - xx xx po przestawieniu");


            
        }
        #endregion

        #region Proxiserve
        private void button2_Click(object sender, EventArgs e)
        {

            byte[] dec;



            if ((tbWprowadzenie.TextLength == 10)||(tbWprowadzenie.TextLength == 14))
            {
                dec = SoapHexBinary.Parse(tbWprowadzenie.Text).Value;
                str = str+ tbWprowadzenie.Text+"    " + knwrs.DateTypeF(dec) + "\r\n";
                wyswietlanieWynikow.Text = (str);
            }
         /*   else if ((chRamka.Checked == true) & (knwrs.Typ_ramki(wprowadzenie.Text) == 170))
            {
                string pom;
                wyswietlanieWynikow.Text = str + "\r\n"+"Poprawnie wprowadzono ramkę Proxiserve";;
                dec = SoapHexBinary.Parse(knwrs.Czas_z_ramki_proxiserve(wprowadzenie.Text)).Value;
                str = str + knwrs.DateTypeF(dec) + "\r\n";
                wyswietlanieWynikow.Text = (str);
            }*/
                else if ((ckDane.Checked == true) & (knwrs.eliminacjaPrzerwy(tbWprowadzenie.Text) == 170))
            {
                string pom;
                wyswietlanieWynikow.Text = str + "\r\n" + "Poprawnie wprowadzono ramkę Proxiserve"; ;
                dec = SoapHexBinary.Parse(knwrs.Czas_z_ramki_proxiserve_dane(tbWprowadzenie.Text)).Value;
                str = str + knwrs.DateTypeF(dec) + "\r\n";
                wyswietlanieWynikow.Text = (str);
            } 
            else
            {
                MessageBox.Show("Podano nieprawidłową długość ramki Proxiserve lub samego hexa - 6D xx xx xx xx xx bajty");
            }
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            str = "";
            wyswietlanieWynikow.Text = str;
        }

        private void btnRozpoznanie_Click(object sender, EventArgs e)
        {
            if (chRamka.Checked == true & knwrs.Log_Error(tbWprowadzenie.Text) == false)
            {
                string[] tab = { "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "nieznana", "Proxiserve", "Ceris", "nieznana", "nieznana", "nieznana", "Metra-5", "Metra-6", "Metra-7", "Metra-8" };
                str = str + tab[knwrs.Typ_ramki(tbWprowadzenie.Text)];
                wyswietlanieWynikow.Text = (str);
            }
        }

        private void btnClearTBox_Click(object sender, EventArgs e)
        {
            tbWprowadzenie.Clear();
        }

        private void chRamka_CheckedChanged(object sender, EventArgs e)
        {
            if (chRamka.Checked == true)
            {
                ckDane.Checked = false;
                btnRozpoznanie.Enabled = true;
                Metra5.Enabled = false;
            }
            else
                btnRozpoznanie.Enabled = false;
        }

        private void ckDane_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDane.Checked == true)
            {
                chRamka.Checked = false;
                chbDataR.Enabled = true;
                chbDataAktualna.Enabled = true;
                chbAlarmy.Enabled = true;

                chbDataR.Checked = true;
                chbDataAktualna.Checked = true;
                chbAlarmy.Checked = true;
                Metra5.Enabled = true;

            } else
            {
                chbDataR.Enabled = false;
                chbDataAktualna.Enabled = false;
                chbAlarmy.Enabled = false;

                chbDataR.Checked = false;
                chbDataAktualna.Checked = false;
                chbAlarmy.Checked = false;
                Metra5.Enabled = false;
            }
        }

        private void chbTimestamp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCeris_Click(object sender, EventArgs e)
        {
            if (ckDane.Checked == true)
            {
                if (tbWprowadzenie.Text.Length>40)
                {
                    string hex = tbWprowadzenie.Text.Substring(27, 11);
                    hex = hex.Replace(" ", String.Empty);
                    int intValue = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                    str = str + "Ceris - " + Konwersja.Konwersja_Timestamp_Ceris(intValue) + "\r\n";
                    wyswietlanieWynikow.Text = (str);
                } else if(tbWprowadzenie.Text.Length == 11)
                {
                    string hex = tbWprowadzenie.Text.Substring(0, 11);
                    hex = hex.Replace(" ", String.Empty);
                    int intValue = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                    str = str + "Ceris - " + Konwersja.Konwersja_Timestamp_Ceris(intValue) + "\r\n";
                    wyswietlanieWynikow.Text = (str);
                }
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chbDataR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbDataAktualna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbAlarmy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHistoriaAlarmow_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] dec;
                if (ckDane.Checked == true)
                {
                    dec = SoapHexBinary.Parse(tbWprowadzenie.Text).Value;
                    str = str + "Data typuG:" + knwrs.DateTypeG(dec) + "\r\n";
                    wyswietlanieWynikow.Text = (str);
                }
                else if (tbWprowadzenie.Text.Replace(" ", String.Empty).Length == 4)
                {
                    dec = SoapHexBinary.Parse(tbWprowadzenie.Text).Value;
                    str = str + "Data typuG:" + knwrs.DateTypeG(dec) + "\r\n";
                    wyswietlanieWynikow.Text = (str);
                }
            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak");
            }
        }

        private void btnMetra6_8_Click(object sender, EventArgs e)
        {
    //        try
    //        {
              //  Dekodowanie dek = new Dekodowanie();
             //   byte temp= Byte.Parse(txtbAES.Text, NumberStyles.HexNumber);
              //  dek.KluczAES = temp;
                dek.Metra();
                string pomocnicza = tbWprowadzenie.Text.Replace(" ", String.Empty);

                if (pomocnicza.Length == Konwersja.metra6.Length)
                {
                    byte[] dec = SoapHexBinary.Parse(pomocnicza.Substring(2,64)).Value;
                    byte[] result = dek.AES_decrypt(dec,1);
                    byte[] result2 = dek.przepisywanie_tablicy(result);
                    str = str + knwrs.DataMetra_LittleEdian(result)+  knwrs.DataMetra_LittleEdian(result2) + "\r\n";
                    wyswietlanieWynikow.Text = (str);
                }
                else if (pomocnicza.Length == Konwersja.metra8.Length)
                {
                    byte[] dec = SoapHexBinary.Parse(pomocnicza.Substring(2, Konwersja.metra8.Length-6)).Value;
                    byte[] result = dek.AES_decrypt(dec,1);
                    byte[] result2 = dek.przepisywanie_tablicy(result);
                    str = str + knwrs.DataMetra_LittleEdian(result) + knwrs.DataMetra_LittleEdian(result2) + "\r\n";
                    wyswietlanieWynikow.Text = (str);
            } /*
            }catch (Exception ex)
            {
                MessageBox.Show("Wystapił problem z kluczem");
                txtbAES.Focus();
            }
            */
        }

        private void btnTestDanych_Click(object sender, EventArgs e)
        {
            int pom=knwrs.eliminacjaPrzerwy(tbWprowadzenie.Text);
            if (pom % 2 == 0)
            {
                str = str + " Długość ramki:" + pom + "\r\n";
            }
            else
                str = str + " Ramka o nieprawiłowej długości - niepełna długość bajtów" + "\r\n";
            wyswietlanieWynikow.Text = (str);
        }

        private void btndekodowanie_Click(object sender, EventArgs e)
        {
            //Dekodowanie dek = new Dekodowanie();
            try
            {
                byte[] AES_key = SoapHexBinary.Parse(txtbAES.Text).Value;
                dek.KluczAES = AES_key; //wprowadzenie klucza do klasy dekodowanie
                                     //wprowadzenie sn podzielnika i wektora
                byte temp_2 = Byte.Parse(txtbFrameVersion.Text, NumberStyles.HexNumber);
                dek.Vektor_wersja_ramki = temp_2;   //wprowadzenie numeru sn
                byte[] SN = SoapHexBinary.Parse(txtSN.Text).Value;
                byte Vektor = Byte.Parse(tztbVek.Text, NumberStyles.HexNumber);

                dek.Vektor = Vektor;
                dek.VektorSN = SN;
                if (ckbEncDecMetra.Checked==true)
                {
                    dek.Metra();
                }
                if (chbAPT.Checked == true)
                {
                    dek.Vektor = Vektor;
                    dek.VektorSN = SN;
                    dek.APT();
                }
                if (chbAPA.Checked == true)
                {
                    dek.APA();
                }
                string pomocnicza = tbWprowadzenie.Text.Replace(" ", String.Empty);
                byte[] dec = SoapHexBinary.Parse(pomocnicza).Value;
                byte[] result = dek.AES_decrypt(dec, 0);
                int ciekawe = result.Length; //dlugosc tablicy wejsciowej
                int i = 0;
                for (i = 0; i < ciekawe; i++)
                {
                    str = str + Convert.ToString(result[i], 16) + " ";
                }
                str = str + "\r\n";
                wyswietlanieWynikow.Text = (str);

                byte[] wyjsciowy = dek.KluczAES;


            }
            catch (Exception)
            {
                MessageBox.Show("Wystapil problem w SNie lub wektorze - 0x000000");
            }         
        }

        private void btnKoduj_Click(object sender, EventArgs e)
        {
           // Dekodowanie dek = new Dekodowanie();
            try
            {
                byte[] AES_key = SoapHexBinary.Parse(txtbAES.Text).Value;
                dek.KluczAES = AES_key; //wprowadzenie klucza do klasy dekodowanie
                                     //wprowadzenie sn podzielnika i wektora
                byte[] SN = SoapHexBinary.Parse(txtSN.Text).Value;
                byte Vektor = Byte.Parse(tztbVek.Text, NumberStyles.HexNumber);

                dek.Vektor = Vektor;
                dek.VektorSN = SN;
                if (ckbEncDecMetra.Checked == true)
                {
                    dek.Metra();
                }
                if (chbAPA.Checked == true)
                {
                    dek.APA();
                }
                if (chbAPT.Checked == true)
                {
                    dek.APT();
                }
                string pomocnicza = tbWprowadzenie.Text.Replace(" ", String.Empty);
                byte[] dec = SoapHexBinary.Parse(pomocnicza).Value;
                byte[] result = dek.AES_encrypt(dec);
                int ciekawe = result.Length; //dlugosc tablicy wejsciowej
                int i = 0;
                for (i = 0; i < ciekawe; i++)
                {
                    str = str + Convert.ToString(result[i], 16) + " ";
                }
                str = str + "\r\n";
                wyswietlanieWynikow.Text = (str);
            }
            catch (Exception)
            {
                MessageBox.Show("Cos poszlo nie tak w trakcie szyfrowania");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] dec;
                if (ckDane.Checked == true)
                {
                    dec = SoapHexBinary.Parse(tbWprowadzenie.Text).Value;
                    str = str + "Data typuF:" + knwrs.DataMetra_LittleEdian(dec) + "\r\n";
                    wyswietlanieWynikow.Text = (str);
                }
                else if (tbWprowadzenie.Text.Replace(" ", String.Empty).Length == 4)
                {
                    dec = SoapHexBinary.Parse(tbWprowadzenie.Text).Value;
                    str = str + "Data typuF:" + knwrs.DataMetra_LittleEdian(dec) + "\r\n";
                    wyswietlanieWynikow.Text = (str);
                }
            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak");
            }
        }

        private void ckbEncDecMetra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEncDecMetra.Checked == true)
            {
                chbAPA.Checked = false;
                chbAPT.Checked = false;
            }
                txtbVektor.Text = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
        }

        private void chbAPT_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAPT.Checked == true)
            {
                ckbEncDecMetra.Checked = false;
                chbAPA.Checked = false;
            }
            txtbVektor.Text = "14 06 __ __ __ 00 20 08 lp lp lp lp lp lp lp lp";

        }

        private void chbAPA_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAPA.Checked == true)
            {
                ckbEncDecMetra.Checked = false;
                chbAPT.Checked = false;
            }
            txtbVektor.Text = "01 06 __ __ __ 00 20 08 lp lp lp lp lp lp lp lp";
        }
    }
}
