#region Using Blogu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace _20181101KirtasiyeUyg
{
    class Program
    {
        static void Main(string[] args)
        {
            // kitap=15, defter=8, cetvel=7, silgi=2, kalem=4, çanta=20, suluk=10 ₺ olan bir kırtasiye
            // Uygulama açılınca br menü geliyor.
            //Menü-> 1- Malzeme Satışı 2- Alışveriş tutarı 3- hesap kes  4- kasa  5- çıkış   sonsuz çalışacak, Kullanıcı 5 tuşuna basınca çıkış yapacak. Menüyü ConsoleKeyInfo sınıfıyla yapılacak
            #region tanımlamalar
            int kasa = 0, satisTutari = 0;
            ConsoleKeyInfo onay;
            #endregion
            Console.Title = "GIRTASIYECİ";
        menum: Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1- Malzeme Satışı\n2- Alışveriş Tutarı\n3- Hesap Kes\n4- Kasa\n5- Çıkış Yap");
            ConsoleKeyInfo menu = Console.ReadKey(true);
            switch (menu.KeyChar)
            {
                #region Malzeme Satışı
                case '1':
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("MALZEME SEÇİMİ");
                  malzeme:  Console.WriteLine("1- Kitap\t15 TL\n2- Defter\t8 TL\n3- Cetvel\t7 TL\n4- Silgi\t2 TL\n5- Kalem\t4 TL\n6- Çanta\t30 TL\n7- Suluk\t14 TL");
                    ConsoleKeyInfo secim = Console.ReadKey(true);
                    if (secim.KeyChar == '1')
                    {
                    onayla: Console.WriteLine("Kitap ücreti 15 TL'dir. Almak için Enter'a, iptal için Escape tuşuna basın.");
                        onay = Console.ReadKey(true);
                        switch (onay.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.WriteLine("Satış gerçekleşti.");
                                satisTutari += 15;
                                break;
                            case ConsoleKey.Escape:
                                Console.WriteLine("Malzeme satışı iptal edildi.");
                                break;
                            default:
                                Console.WriteLine("Hatalı seçim.");
                                Console.Beep(1000, 1000);
                                goto onayla;
                                break;
                        }
                    }
                    else if (secim.KeyChar == '2')
                    {
                    onayla: Console.WriteLine("Defter ücreti 8 TL'dir. Almak için Enter'a, iptal için Escape tuşuna basın.");
                        onay = Console.ReadKey(true);
                        switch (onay.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.WriteLine("Satış gerçekleşti.");
                                satisTutari += 8;
                                break;
                            case ConsoleKey.Escape:
                                Console.WriteLine("Malzeme satışı iptal edildi.");
                                break;
                            default:
                                Console.WriteLine("Hatalı seçim.");
                                Console.Beep(1000, 1000);
                                goto onayla;
                                break;
                        }
                    }
                    else if (secim.KeyChar == '3')
                    {
                    onayla: Console.WriteLine("Cetvel ücreti 7 TL'dir. Almak için Enter'a, iptal için Escape tuşuna basın.");
                        onay = Console.ReadKey(true);
                        switch (onay.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.WriteLine("Satış gerçekleşti.");
                                satisTutari += 15;
                                break;
                            case ConsoleKey.Escape:
                                Console.WriteLine("Malzeme satışı iptal edildi.");
                                break;
                            default:
                                Console.WriteLine("Hatalı seçim.");
                                Console.Beep(1000, 1000);
                                goto onayla;
                                break;
                        }
                    }
                    else if (secim.KeyChar == '4')
                    {
                    onayla: Console.WriteLine("Silgi ücreti 2 TL'dir. Almak için Enter'a, iptal için Escape tuşuna basın.");
                        onay = Console.ReadKey(true);
                        switch (onay.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.WriteLine("Satış gerçekleşti.");
                                satisTutari += 2;
                                break;
                            case ConsoleKey.Escape:
                                Console.WriteLine("Malzeme satışı iptal edildi.");
                                break;
                            default:
                                Console.WriteLine("Hatalı seçim.");
                                Console.Beep(1000, 1000);
                                goto onayla;
                                break;
                        }
                    }
                    else if (secim.KeyChar == '5')
                    {
                    onayla: Console.WriteLine("Kalem ücreti 4 TL'dir. Almak için Enter'a, iptal için Escape tuşuna basın.");
                        onay = Console.ReadKey(true);
                        switch (onay.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.WriteLine("Satış gerçekleşti.");
                                satisTutari += 4;
                                break;
                            case ConsoleKey.Escape:
                                Console.WriteLine("Malzeme satışı iptal edildi.");
                                break;
                            default:
                                Console.WriteLine("Hatalı seçim.");
                                Console.Beep(1000, 1000);
                                goto onayla;
                                break;
                        }
                    }
                    else if (secim.KeyChar == '6')
                    {
                    onayla: Console.WriteLine("çanta ücreti 30 TL'dir. Almak için Enter'a, iptal için Escape tuşuna basın.");
                        onay = Console.ReadKey(true);
                        switch (onay.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.WriteLine("Satış gerçekleşti.");
                                satisTutari += 30;
                                break;
                            case ConsoleKey.Escape:
                                Console.WriteLine("Malzeme satışı iptal edildi.");
                                break;
                            default:
                                Console.WriteLine("Hatalı seçim.");
                                Console.Beep(1000, 1000);
                                goto onayla;
                                break;
                        }
                    }
                    else if (secim.KeyChar == '7')
                    {
                    onayla: Console.WriteLine("Suluk ücreti 14 TL'dir. Almak için Enter'a, iptal için Escape tuşuna basın.");
                        onay = Console.ReadKey(true);
                        switch (onay.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.WriteLine("Satış gerçekleşti.");
                                satisTutari += 14;
                                break;
                            case ConsoleKey.Escape:
                                Console.WriteLine("Malzeme satışı iptal edildi.");
                                break;
                            default:
                                Console.WriteLine("Hatalı seçim.");
                                Console.Beep(1000, 1000);
                                goto onayla;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim.");
                        Console.Beep(1000, 1000);
                        goto malzeme;
                    }

                    break;
                #endregion
                #region Alışveriş Tutarı
                case '2':
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Alış veriş tutarı = " +satisTutari+" TL.");
                    Console.WriteLine("Devam etmek için bir tuşa basın.");
                    Console.ReadKey();
                    break;
                #endregion
                #region Hesap kes
                case '3':
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                   onay1: Console.WriteLine("Alışverişi sonlandırmak için Enter, iptal için Escape tuşuna basın.");
                    onay = Console.ReadKey(true);
                    switch (onay.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.WriteLine("Satış gerçekleşti.");
                            kasa += satisTutari;
                            satisTutari = 0;
                            break;
                        case ConsoleKey.Escape:
                            Console.WriteLine("İşlem iptal edildi.");
                            break;
                        default:
                            Console.WriteLine("Hatalı seçim.");
                            Console.Beep(1000, 1000);
                            goto onay1;
                            break;
                    }
                    break;
                #endregion
                #region Kasa
                case '4':
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Aman da paracıklarım = "+kasa);
                    Console.WriteLine("Devam etmek için bir tuşa basın.");
                    Console.ReadKey();
                    break;
                #endregion
                #region Çıkış
                case '5':
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Çıkış yapmak için enter tuşuna basın.");
                    onay = Console.ReadKey(true);
                    if (onay.Key==ConsoleKey.Enter)
                    {
                        Console.WriteLine("GÜLE GüLE!");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    break;
                #endregion
                #region Diğer
                default:
                    Console.WriteLine("Hatalı işlem!");
                    Console.Beep(1000, 2000);
                    break;
                    #endregion
            }
            Console.WriteLine("Menüye yönleniyor...");
            System.Threading.Thread.Sleep(2300);
            goto menum;
        }
    }
}
