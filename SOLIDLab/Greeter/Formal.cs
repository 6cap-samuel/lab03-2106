using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Greeter
{
    /**
        Formal class that indicate user would want to have a formal greeting.
     */    
     public class Formal : FormalityStrategy{
        public String greet(){
            return "Good evening, sir.";
        }
    }
}