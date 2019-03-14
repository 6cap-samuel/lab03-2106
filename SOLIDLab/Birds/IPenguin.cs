using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Birds
{
    //this interface is implemented for
    //penguin with penguin-only functions
    interface IPenguin : SOLIDLab.Birds.Bird
    {
        void Swim();
    }
}
