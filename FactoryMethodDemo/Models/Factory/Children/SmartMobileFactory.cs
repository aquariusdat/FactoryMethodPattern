using FactoryMethodDemo.Models.Factory.Base;
using FactoryMethodDemo.Models.Objects.Base;
using FactoryMethodDemo.Models.Objects.Children;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Models.Factory.Children
{
    class SmartMobileFactory : IMobileFactory
    {
        public INokia GetMobile(int type)
        {
            switch (type)
            {
                case 1:
                    return new Nokia83();
                case 2:
                    return new NokiaLumia();
                case 3:
                    return new NokiaX6();
                default:
                    return null;
            }
        }
    }
}
