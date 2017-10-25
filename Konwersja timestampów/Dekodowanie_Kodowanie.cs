using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;


class Dekodowanie
{
    private byte klucz = (0x00);
    private byte[] key = { 0xFE, 0x00, 0xAB, 0x12, 0x2B, 0x4A, 0x18, 0x11, 0xF9, 0x8A, 0x00, 0x34, 0x13, 0xC7, 0xC8, 0x13 };
  //  private byte[] initial_vector = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }; //metra
    private byte[] initial_vector = { 0x01, 0x06, 0x92, 0x43, 0x00, 0x00, 0x26, 0x08, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01}; //normalne

    public void InitialAPA()
    {
        initial_vector[0] = 0x01;
        initial_vector[1] = 0x06;
    }
    public void InitialAPT()
    {
        initial_vector[0] = 0x14;
        initial_vector[1] = 0x06;
    }
    public void InitialHCA()
    {
        initial_vector[7] = 0x08;
    }

    public byte[] AES_decrypt(byte[] wejsciowe,int rodzaj)
    {
        byte[] plainText = null;
        using (Aes aes = new AesManaged())
        {
            aes.Padding = PaddingMode.None;
            aes.KeySize = 256;          // in bits
            aes.Key = key;
            aes.IV = initial_vector;

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(),
                                                            CryptoStreamMode.Write))
                {
                    cs.Write(wejsciowe, 0, wejsciowe.Length);
                }

                plainText = ms.ToArray();
            }
        }
        if (rodzaj == 1)
        {
            return przepisywanie_tablicy(plainText);
        }
        else
            return plainText;
    }
    public byte[] AES_encrypt(byte[] wejsciowe)
    {
        byte[] data = new byte[wejsciowe.Length];
        AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
        aes.Padding = PaddingMode.None;
        aes.KeySize = 256;          // in bits
        aes.Key = key;
        aes.IV = initial_vector;
        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        byte[] encrypted = encryptor.TransformFinalBlock(wejsciowe, 0, wejsciowe.Length);
        for (int i = 0; i < wejsciowe.Length; ++i)
        {
            data[i] = encrypted[i];
        }
        return data;
    }
    //przesuwa zdekodowana tablice o dwa bajty bo na poczatku sa sumy kontrolne
    public byte[] przepisywanie_tablicy(byte[] wejsciowe)
    {
        byte[] przepisywana=new byte[wejsciowe.Length];
        int i;

        for (i=0;i< wejsciowe.Length-2;i++)
        {
            przepisywana[i] = wejsciowe[i+2];
        }

        return przepisywana;
    }
    //ustawienie klucza AES
    public byte[] KluczAES
    {
        get
        {
            return key;
        }
        set
        {
                key[1] = value[0];
                key[10] = value[1];
        }    
    }
    public byte Vektor
    {
        get
        {
            return 0;
        }
        set
        {
            int i;
            for (i=8;i<16;i++)
            {
                initial_vector[i] = value;
            }
        }
    }
    public byte[] VektorSN
    {
        set
        {
            int i;
            int x = 4;
            for (i=0;i<3;i++)
            {
                initial_vector[ x - i] = value[ i ];
            }
        }
    }
    public void Metra()
    {
        byte[] initial_vectorMetra = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        initial_vector = initial_vectorMetra;
    }
    public void APT()
    {
        InitialAPT();
        InitialHCA();
    }
    public void APA()
    {
        InitialAPA();
        InitialHCA();
    }
    public byte Vektor_wersja_ramki
    {
        get
        {
            return klucz;
        }
        set
        {
            initial_vector[6] = value;
        }
    }
}

