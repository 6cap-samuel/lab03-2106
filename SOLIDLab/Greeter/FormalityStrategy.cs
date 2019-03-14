using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Greeter
{
    /**
        Strategy that the Greeter would want to adapt.
     */        
     public abstract class FormalityStrategy{
         
        /**
            By default says hello.
        */    
        public String greet(){
            return "Hello.";
        }
    }
}