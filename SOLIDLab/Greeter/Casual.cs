using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Greeter
{
    /**
        Casual class that indicate user would want to have a casual greeting.
     */
    public class Casual : FormalityStrategy{
        public String greet(){
            return "Sup bro?"; 
        }
    }
}