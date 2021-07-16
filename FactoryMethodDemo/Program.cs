using FactoryMethodDemo.Models.Factory.Base;
using FactoryMethodDemo.Models.Factory.Children;
using FactoryMethodDemo.Models.Objects.Base;
using FactoryMethodDemo.Models.Objects.Children;
using System;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default
            int type = 0;
            do
            {
                Console.WriteLine("-------------------- MENU ----------------");
                Console.WriteLine("Ban muon chon dien thoai Nokia nao?");
                Console.WriteLine("(1)\t Nokia 1200");
                Console.WriteLine("(2)\t Nokia 1280");
                Console.WriteLine("(3)\t Nokia 6300");
                Console.WriteLine("(4)\t Nokia 83");
                Console.WriteLine("(5)\t Nokia Lumia");
                Console.WriteLine("(6)\t Nokia X6");
                Console.WriteLine("-------------------------------------------");

                type = Convert.ToInt32(Console.ReadLine().ToString());

                if (type <= 0 || type > 7)
                {
                    Console.Clear();
                    Console.WriteLine("Du lieu nhap khong hop le.\nVui long ban nhap lai.\n");
                }
            } while (type <= 0 || type > 7);

            switch (type)
            {
                case 1:
                    Nokia1200 nokia1200 = new Nokia1200();
                    Console.WriteLine(nokia1200.GetPaymentInfo());
                    break;
                case 2:
                    Nokia1280 nokia1280 = new Nokia1280();
                    Console.WriteLine(nokia1280.GetPaymentInfo());
                    break;
                case 3:
                    Nokia6300 nokia6300 = new Nokia6300();
                    Console.WriteLine(nokia6300.GetPaymentInfo());
                    break;
                case 4:
                    Nokia83 nokia83 = new Nokia83();
                    Console.WriteLine(nokia83.GetPaymentInfo());
                    break;
                case 5:
                    NokiaLumia nokialumia = new NokiaLumia();
                    Console.WriteLine(nokialumia.GetPaymentInfo());
                    break;
                case 6:
                    NokiaX6 nokiax6 = new NokiaX6();
                    Console.WriteLine(nokiax6.GetPaymentInfo());
                    break;
                case 7:
                    Nokia6666 nokia6666 = new Nokia6666();
                    System.Console.WriteLine(nokia6666.GetPaymentInfo());
                    break;
                default:
                    break;
            }
            #endregion

            #region Simple Factory
            //INokia chooseMobile = null;
            //do
            //{
            //    Console.WriteLine("-------------------- MENU ----------------");
            //    Console.WriteLine("Ban muon chon dien thoai Nokia nao?");
            //    Console.WriteLine("(1)\t Nokia 1200");
            //    Console.WriteLine("(2)\t Nokia 1280");
            //    Console.WriteLine("(3)\t Nokia 6300");
            //    Console.WriteLine("(4)\t Nokia 83");
            //    Console.WriteLine("(5)\t Nokia Lumia");
            //    Console.WriteLine("(6)\t Nokia X6");
            //    Console.WriteLine("-------------------------------------------");

            //    int type = Convert.ToInt32(Console.ReadLine().ToString());
            //    NokiaMobileFactory factory = new NokiaMobileFactory();
            //    chooseMobile = factory.GetMobile(type);
            //    if (chooseMobile == null)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Du lieu nhap khong hop le.\nVui long ban nhap lai.\n");
            //    }
            //} while (chooseMobile == null);

            //Console.WriteLine(chooseMobile.GetPaymentInfo());
            #endregion

            #region Factory Method
            //Console.WriteLine("-------------------- MENU ----------------");
            //Console.WriteLine("Ban muon dien thoai thong minh hay dien thoai thong thuong");
            //Console.WriteLine("(1)\t Dien thoai thong minh");
            //Console.WriteLine("(2)\t Dien thoai thong thuong");

            //Console.WriteLine("-------------------------------------------");
            //int type = Convert.ToInt32(Console.ReadLine().ToString());

            //IMobileFactory factory = null;
            //INokia nokia = null;

            //switch (type)
            //{
            //    case 1:
            //        factory = new SmartMobileFactory();
            //        Console.WriteLine("Vui long chon loai:");
            //        Console.WriteLine("(1)\t Nokia 8.3");
            //        Console.WriteLine("(2)\t Nokia Lumia");
            //        Console.WriteLine("(3)\t Nokia X6");
            //        int type1 = Convert.ToInt32(Console.ReadLine().ToString());
            //        nokia = factory.GetMobile(type1);
            //        break;
            //    case 2:
            //        factory = new NormalMobileFactory();
            //        Console.WriteLine("Vui long chon loai:");
            //        Console.WriteLine("(1)\t Nokia 1200");
            //        Console.WriteLine("(2)\t Nokia 1280");
            //        Console.WriteLine("(3)\t Nokia 6300");
            //        int type2 = Convert.ToInt32(Console.ReadLine().ToString());
            //        nokia = factory.GetMobile(type2);
            //        break;
            //}

            //Console.WriteLine(nokia?.GetPaymentInfo() ?? "Dien thoai ban chon khong co trong he thong cua hang.");
            #endregion

            Console.ReadKey();
        }
    }
}
