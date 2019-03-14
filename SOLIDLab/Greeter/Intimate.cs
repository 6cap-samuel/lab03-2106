using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Greeter
{
    /**
        Intimate class that indicate user would want to have a intimate greeting.
     */        
     public class Intimate : FormalityStrategy{
        public String greet(){
            return "Hello Darling!";
        }
    }
}