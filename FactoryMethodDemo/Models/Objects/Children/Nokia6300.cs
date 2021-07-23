using FactoryMethodDemo.Models.Objects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Models.Objects.Children
{
    class Nokia6300 : INokia
    {
        private string _name { get; init; }
        private string _price { get; set; }

        public Nokia6300()
        {
            this._name = "Nokia 6300";
            this._price = "280.000 VND";
        }

        public string GetPaymentInfo()
        {
            return $"Ban da chon {this._name}\nTong tien ban phai tra la: {this._price}";
        }
    }
}
