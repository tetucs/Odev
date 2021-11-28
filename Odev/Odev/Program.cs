using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, depo=0, sayi1 = 0, sayi2 = 0, toplam = 0, sayac = 0, faktoriyel = 1;
            double ortalama = 0.0, vize, final,yaricap,cevre,uzunluk,yukseklik,alan,not1,not2,not3,kilo,boy,indeks,s1,s2;
            int soruno = 0;
            Console.WriteLine("Soru Numarasını giriniz ---> ");
            soruno = Convert.ToSByte(Console.ReadLine());
            switch (soruno)
            {
                case 1:
                    Console.WriteLine("1. Sayı Giriniz ---> ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. Sayı Giriniz ---> ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    toplam = sayi1 + sayi2;
                    ortalama = toplam / 2;
                    Console.WriteLine("Ortalama : " + ortalama);
                    break;
                case 2:
                     
                    Console.WriteLine("Sayı Giriniz ---> ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    if (sayi1 > 0)
                    {
                        Console.WriteLine(sayi1 + " " + "Sayınız Pozitiftir!");
                    }
                    else if (sayi1 < 0)
                    {
                        Console.WriteLine(sayi1 + " " + "Sayınız Negatiftir!");

                    }
                    else
                    {
                        Console.WriteLine(sayi1 + " " + "Sayınız Nötrdür!");

                    }

                    break;
                case 3:
                    Console.WriteLine("Uzunluk Değeri Giriniz ---> ");
                    uzunluk = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yükseklik Değeri Giriniz ---> ");
                    yukseklik = Convert.ToInt32(Console.ReadLine());
                    alan = (yukseklik * uzunluk) / 2;
                    Console.WriteLine("Üçgenin alanı : " + alan);

                    break;
                case 4:
                    Console.WriteLine("1. Sayıyı Giriniz ---> ");
                    s1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("2. Sayıyı Giriniz ---> ");
                    s2 = Convert.ToDouble(Console.ReadLine());
                    if (s1 < s2)
                    {
                        Console.WriteLine(s1 + "Küçüktür!");
                    }
                    else if (s2 < s1)
                    {
                        Console.WriteLine(s2 + "Küçüktür");
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz Sayılar Eşittir!");
                    }
                    break;
                case 5:
                    Console.Write("Vize Notunuzu Giriniz ---> ");
                    vize = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Final Notunuzu Giriniz ---> ");
                    final = Convert.ToInt32(Console.ReadLine());
                    ortalama = Convert.ToInt32(vize * 0.4 + final * 0.6);
                    Console.WriteLine("Ortalamanız = " + ortalama);
                    break;
                case 6:
                    Console.Write("Daire'nin yarıçapını giriniz ---> ");
                    yaricap = Convert.ToDouble(Console.ReadLine());
                    alan = 3.14 * yaricap * yaricap;
                    cevre = 2 * 3.14 * yaricap;
                    Console.WriteLine("Alan : " + alan);
                    Console.WriteLine("Çevre : " + cevre);
                    break;
                case 7:
                    Console.WriteLine("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        if (sayi > 50)
                        {
                            depo = depo + 1;
                            Console.WriteLine("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("50'den Büyük Sayılar : " + depo);

                    break;
                case 8:
                    Console.WriteLine("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        if (sayi > 100)
                        {
                            depo = depo + 1;
                            Console.WriteLine("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("100'den Büyük " + depo + " sayı bulunmaktadır.");

                    break;
                case 9:
                    while (true)
                    {
                        Console.Write("Sayı giriniz ---> ");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        if (sayi == 0)
                        {
                            break;
                        }
                        toplam = toplam + sayi;
                        sayac++;
                        ortalama = toplam / sayac;
                    }
                    Console.WriteLine("Girdiğiniz Sayıların Toplamı: " + toplam);
                    Console.WriteLine("Girdiğiniz Sayıların Ortalaması: " + ortalama);
                    break;
                case 10:
                    Console.WriteLine("1. Notunuzu giriniz ---> ");
                    not1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("2. Notunuzu giriniz ---> ");
                    not2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("3. Notunuzu giriniz ---> ");
                    not3 = Convert.ToDouble(Console.ReadLine());
                    if (not1 >= 0 && not1 <= 100 && not2 >= 0 && not2 <= 100 && not3 >= 0 && not3 <= 100)
                    {
                        ortalama = (not1 + not2 + not3) / 3;
                        Console.WriteLine("Notlarınızın ortalaması: " + ortalama);
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz not değerleri '0' ve '100' arasında olmaladır.");
                    }

                    break;
                case 11:
                    for (int i = 1; i <= 1000; i++)
                    {
                        Console.WriteLine(i);
                    }

                    break;
                case 12:
                    Console.WriteLine("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi >= 0 && sayi <= 100)
                    {
                        Console.WriteLine("Girdiğiniz sayı '0' ve '100' arasındadır.");

                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz sayı '0' ve '100' arasında değildir.");
                    }

                    break;
                case 13:
                    Console.WriteLine("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= sayi; i++)
                    {
                        toplam += i;
                    }
                    Console.WriteLine("1 den " + sayi + "'e kadar olan sayıların toplamı : " + toplam);
                    break;
                case 14:
                    Console.WriteLine("10. Soru ile aynı olduğu için yapılmamıştır!");
                    break;
                case 15:
                    int derece, radyan, grad;
                    double pi = 3.14;
                    Console.Write("Açıyı giriniz ---> ");
                    derece = Convert.ToInt32(Console.ReadLine());

                    radyan = Convert.ToInt32(derece * pi / 180);
                    grad = derece * 200 / 180;

                    Console.WriteLine("Radyan = " + radyan);
                    Console.WriteLine("Grad = " + grad);
                    break;
                case 16:
                    Console.WriteLine("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi % 2 == 0)
                    {
                        Console.WriteLine("Girdiğiniz "+ sayi +" sayısı çift bir sayıdır.");
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz "+ sayi +" sayısı tek bir sayıdır.");
                    }

                    break;
                case 17:
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    int mutlakDeger = Math.Abs(sayi);
                    Console.WriteLine("Girilen sayının mutlak değeri: " + mutlakDeger);
                    break;
                case 18:
                    Console.WriteLine("1. Sayıyı giriniz ---> ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. Sayıyı giriniz ---> ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    if (sayi1 % sayi2 == 0)
                    {
                        Console.WriteLine("Girdiğniz 1. sayı 2. girdiğiniz sayıya tam bölünür.");

                    }
                    else
                    {
                        Console.WriteLine("Girdiğniz 1. sayı 2. girdiğiniz sayıya tam bölünmez.");

                    }

                    break;
                case 19:
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i <= sayi; i++)
                    {
                        if (i % 2 == 0)
                        {
                            toplam += i;
                        }
                    }
                    Console.WriteLine(sayi + " sayısına kadar çift sayıların toplamı: " + toplam);
                    break;
                case 20:

                    break;
                case 21:

                    break;
                case 22:
                    Console.Write("Boyunuzu m cinsinden Giriniz (Ör:1,65) --->  ");
                    boy = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Kilonuzu Giriniz --->  ");
                    kilo = Convert.ToDouble(Console.ReadLine());
                    indeks = kilo / (boy * boy);
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Vücut Kitle İndeksiniz : ", indeks);
                    if (indeks < 18.5)
                    {
                        Console.WriteLine("Zayıf");
                    }
                    else if (indeks >= 18.5 && indeks < 24.9)
                    {
                        Console.WriteLine("Normal");
                    }
                    else if (indeks >= 25 && indeks < 29.9)
                    {
                        Console.WriteLine("Fazla Kilolu");
                    }
                    else if (indeks <= 30 && indeks < 34.9)
                    {
                        Console.WriteLine("I. Derece Obez");
                    }
                    else if (indeks <= 35 && indeks < 39.9)
                    {
                        Console.WriteLine("II. Derece Obez");
                    }
                    else
                    {
                        Console.WriteLine("III. Derece Obez");
                    }
                    break;
                case 23:
                    double Scalis, Sucret, Ucret;
                    Console.Write("Kaç saat çalıştığınızı yazınız --->  ");
                    Scalis = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Saat ücreti giriniz --->  ");
                    Sucret = Convert.ToDouble(Console.ReadLine());
                    if (Scalis < 40)
                    {
                        Ucret = Scalis * Sucret;
                    }
                    else
                    {
                        Ucret = (Scalis * 2) * Sucret;
                    }
                    Console.Write("Alacağınız ücret : " + Ucret);
                    Console.ReadLine();
                    break;
                case 24:
                    Console.Write("Sayı giriniz --->  ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Girdiğiniz sayının tam bölenleri : ");
                    for (int i = 1; i <= sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }

                    break;
                case 25:
                    Console.Write("Faktröriyelinin bulunmasını istediğiniz bir sayı giriniz --->  ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= sayi1; i++)
                    {
                        faktoriyel = faktoriyel * i;
                    }
                    Console.WriteLine(sayi1 + "! = " + faktoriyel);
                    break;
                default:
                    Console.WriteLine("Yanlış soru numarası girdiniz...!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
