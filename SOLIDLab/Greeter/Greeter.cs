using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Greeter
{
    /**
        Concrete Greeter class
     */    
    public class Greeter
    {
        FormalityStrategy _formality;

        // Set the formality that the greeter would like to adapt.
        public void setFormality(FormalityStrategy formality)
        {
            this._formality = formality;
        }

        // Greet based on the strategy that the greeter has adapt.
        public String greet(){
            return _formality.greet();
        }
    }
}