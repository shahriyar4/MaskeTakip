using Business.Concrete;
using Entities.Concrete;

namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
        //degiskenler();
       // Vatandas vatandas1 = new Vatandas();
        // Console.WriteLine(vatandas1.ad);



        //SelamVer("Engin");
        //Topla(3, 5);

        string ogrenci1 = "Engin";
        string ogrenci2 = "Serkan";
        string ogrenci3 = "Murat";
        string[] ogrenciler = new string[3];

        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Serkan";
        ogrenciler[2] = "Murat";

        //for (int i = 0; i < ogrenciler.Length; i++)
        //{
        //    Console.WriteLine(ogrenciler[i]);

        //}


        //string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
        //string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakir" };

        //sehirler2 = sehirler1;
        //sehirler1[0] = "Adana";
        //Console.WriteLine(sehirler2[0]);

        //int sayi1 = 10;
        //int sayi2 = 20;
        //sayi2 = sayi1;
        //sayi1 = 30;
        //sayi2??





        //foreach (string sehir in sehirler1)
        //{
        //    Console.WriteLine(sehir);
        //}

        //List<String> yeniSehirler1 = new List<string> { "Ankara1", "Istanbul1", "Izmir1" };
        //List<String> yeniSehirler2 = new List<string> { "Bursa1", "Antalya1", "Diyarbakir1" };

        //yeniSehirler1.Add("Adana3");
        //foreach (string sehir1 in yeniSehirler1)
        //{
        //    Console.WriteLine(sehir1);
        //}

        Person person1 = new Person();
        person1.FirstName = "Shah";
        person1.LastName = "Hasanov";
        person1.DateOfBirthYear = 2003;
        person1.NationalIdentity = 123;

        PttManager pttManager = new PttManager(new PersonManager());
         pttManager.GiveMask(person1);
        Console.WriteLine(person1.DateOfBirthYear);
        // Console.ReadLine();
        // Person person = new Person();

    }

    static void SelamVer(string isim)
    {
       // Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1, int sayi2)
    {
        int result = sayi1 + sayi2;
      //  Console.WriteLine("Toplam: " + result);
        return result;
    }

    //static

    //private static void degiskenler()
    //{
    //    Console.WriteLine("Hello World!");
    //    string mesaj = "Merhaba";
    //    double tutar = 10000;
    //    int sayi = 100;
    //    bool girisYapmisMi = false;
    //}
}

public class Vatandas
{
    public string Name { get; set; }
    public string lastName { get; set; }
    public int birthDay { get; set; }
    public long tcNo { get; set; }

}