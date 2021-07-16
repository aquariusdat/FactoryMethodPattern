using FactoryMethodDemo.Models.Objects.Base;

namespace FactoryMethodDemo.Models.Objects.Children
{
    public class Nokia6666 : INokia
    {
        private readonly string _name;
        private string _price { get; set; }

        public Nokia6666()
        {
            this._name = "Nokia 6666";
            this._price = "2.100.000";
        }

        public string GetPaymentInfo()
        {
            return $"Ban da chon {this._name}\nTong tien ban phai tra la: {this._price}";
        }
    }
}