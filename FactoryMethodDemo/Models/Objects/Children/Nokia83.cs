using FactoryMethodDemo.Models.Objects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Models.Objects.Children
{
    class Nokia83 : INokia
    {
        private readonly string _name;
        private string _price { get; set; }

        public Nokia83()
        {
            this._name = "Nokia 8.3";
            this._price = "7.880.000 VND";
        }

        public string GetPaymentInfo()
        {
            return $"Ban da chon {this._name}\nTong tien ban phai tra la: {this._price}";
        }
    }
}
