using FactoryMethodDemo.Models.Objects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Models.Objects.Children
{
    class NokiaX6 : INokia
    {
        private string _name { get; init; }
        private string _price { get; set; }

        public NokiaX6()
        {
            this._name = "Nokia X6";
            this._price = "2.260.000 VND";
        }

        public string GetPaymentInfo()
        {
            return $"Ban da chon {this._name}\nTong tien ban phai tra la: {this._price}";
        }
    }
}
