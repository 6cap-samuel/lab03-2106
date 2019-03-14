using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Greeter
{
    // I want to be able to add greetings to other personalities
    public class Formal : FormalityStrategy{
        public String greet(){
            return "Good evening, sir.";
        }
    }
}