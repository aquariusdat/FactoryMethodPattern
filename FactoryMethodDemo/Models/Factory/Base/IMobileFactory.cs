using FactoryMethodDemo.Models.Objects.Base;
using FactoryMethodDemo.Models.Objects.Children;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Models.Factory.Base
{
    interface IMobileFactory
    {
        INokia GetMobile(int type);
      
    }
}
