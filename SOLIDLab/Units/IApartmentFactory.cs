using SOLIDLab.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Units
{
    /**
     * Interface that will be shared between all apartments
     * that are created with Factory
     */
    interface IApartmentFactory
    {
        Apartment Make(String type);
    }
}
