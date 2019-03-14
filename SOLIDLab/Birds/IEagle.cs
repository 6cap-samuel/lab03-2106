using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Birds
{
    //this interface is implemented for
    //eagles with eagle-only functions
    interface IEagle:Bird
    {
        void fly();
    }
}
