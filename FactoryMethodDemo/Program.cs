using FactoryMethodDemo.Models.Factory.Base;
using FactoryMethodDemo.Models.Factory.Children;
using FactoryMethodDemo.Models.Objects.Base;
using FactoryMethodDemo.Models.Objects.Children;
using System;
using System.Text;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Menu
            // All mobile
            StringBuilder menuAll = new StringBuilder();
            menuAll.AppendLine("-------------------- MENU ----------------");
            menuAll.AppendLine("Ban muon chon dien thoai Nokia nao?");
            menuAll.AppendLine("(1)\t Nokia 1200");
            menuAll.AppendLine("(2)\t Nokia 1280");
            menuAll.AppendLine("(3)\t Nokia 6300");
            menuAll.AppendLine("(4)\t Nokia 83");
            menuAll.AppendLine("(5)\t Nokia Lumia");
            menuAll.AppendLine("(6)\t Nokia X6");
            menuAll.AppendLine("-------------------------------------------");

            // SmartMobile and NormalMobile
            StringBuilder menuSmartAndNormal = new StringBuilder();
            menuSmartAndNormal.AppendLine("-------------------- MENU ----------------");
            menuSmartAndNormal.AppendLine("Ban muon dien thoai thong minh hay dien thoai thong thuong");
            menuSmartAndNormal.AppendLine("(1)\t Dien thoai thong minh");
            menuSmartAndNormal.AppendLine("(2)\t Dien thoai thong thuong");
            menuSmartAndNormal.AppendLine("-------------------------------------------");

            // Smart
            StringBuilder menuSmart = new StringBuilder();
            menuSmart.AppendLine("Vui long chon loai:");
            menuSmart.AppendLine("(1)\t Nokia 8.3");
            menuSmart.AppendLine("(2)\t Nokia Lumia");
            menuSmart.AppendLine("(3)\t Nokia X6");

            // Mobile
            StringBuilder menuNormal = new StringBuilder();
            menuNormal.AppendLine("Vui long chon loai:");
            menuNormal.AppendLine("(1)\t Nokia 1200");
            menuNormal.AppendLine("(2)\t Nokia 1280");
            menuNormal.AppendLine("(3)\t Nokia 6300");
            #endregion

            #region Default
            // int type = 0;
            // do
            // {
            //     System.Console.WriteLine(menuAll);
            //     type = Convert.ToInt32(Console.ReadLine().ToString());

            //     if (type <= 0 || type > 7)
            //     {
            //         Console.Clear();
            //         Console.WriteLine("Du lieu nhap khong hop le.\nVui long ban nhap lai.\n");
            //     }

            // } while (type <= 0 || type > 7);

            // switch (type)
            // {
            //     case 1:
            //         Nokia1200 nokia1200 = new Nokia1200();
            //         Console.WriteLine(nokia1200.GetPaymentInfo());
            //         break;
            //     case 2:
            //         Nokia1280 nokia1280 = new Nokia1280();
            //         Console.WriteLine(nokia1280.GetPaymentInfo());
            //         break;
            //     case 3:
            //         Nokia6300 nokia6300 = new Nokia6300();
            //         Console.WriteLine(nokia6300.GetPaymentInfo());
            //         break;
            //     case 4:
            //         Nokia83 nokia83 = new Nokia83();
            //         Console.WriteLine(nokia83.GetPaymentInfo());
            //         break;
            //     case 5:
            //         NokiaLumia nokialumia = new NokiaLumia();
            //         Console.WriteLine(nokialumia.GetPaymentInfo());
            //         break;
            //     case 6:
            //         NokiaX6 nokiax6 = new NokiaX6();
            //         Console.WriteLine(nokiax6.GetPaymentInfo());
            //         break;
            //     default:
            //         break;
            // }
            #endregion

            #region Simple Factory
            // INokia chooseMobile = null;
            // do
            // {
            //     System.Console.WriteLine(menuAll);

            //     int type = Convert.ToInt32(Console.ReadLine().ToString());
            //     NokiaMobileFactory factory = new NokiaMobileFactory();
            //     chooseMobile = factory.GetMobile(type);
            //     if (chooseMobile == null)
            //     {
            //         Console.Clear();
            //         Console.WriteLine("Du lieu nhap khong hop le.\nVui long ban nhap lai.\n");
            //     }
            // } while (chooseMobile == null);

            // Console.WriteLine(chooseMobile.GetPaymentInfo());
            #endregion

            #region Factory Method
            System.Console.WriteLine(menuSmartAndNormal);

            int type = Convert.ToInt32(Console.ReadLine().ToString());

            IMobileFactory factory = null;
            INokia nokia = null;

            switch (type)
            {
                case 1:
                    factory = new SmartMobileFactory();

                    System.Console.WriteLine(menuSmart);

                    int type1 = Convert.ToInt32(Console.ReadLine().ToString());
                    nokia = factory.GetMobile(type1);
                    break;
                case 2:
                    factory = new NormalMobileFactory();

                    System.Console.WriteLine(menuNormal);

                    int type2 = Convert.ToInt32(Console.ReadLine().ToString());
                    nokia = factory.GetMobile(type2);
                    break;
            }

            Console.WriteLine(nokia?.GetPaymentInfo() ?? "Dien thoai ban chon khong co trong he thong cua hang.");
            #endregion
        }
    }
}
