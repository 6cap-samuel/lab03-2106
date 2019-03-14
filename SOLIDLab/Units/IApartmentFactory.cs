using SOLIDLab.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Units
{
    interface IApartmentFactory
    {
        Apartment Make(String type);
    }
}
