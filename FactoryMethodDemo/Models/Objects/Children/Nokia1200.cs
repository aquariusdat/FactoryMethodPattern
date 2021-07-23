using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDemo.Models.Objects.Base;

namespace FactoryMethodDemo.Models.Objects.Children
{
    class Nokia1200 : INokia
    {
        private string _name { get; init; }
        private string _price { get; set; }

        public Nokia1200()
        {
            this._name = "Nokia 1200";
            this._price = "280.000 VND";
        }

        public string GetPaymentInfo()
        {
            return $"Ban da chon {this._name}\nTong tien ban phai tra la: {this._price}";
        }
    }
}
