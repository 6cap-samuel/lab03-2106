using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Greeter
{
    // I want to be able to add greetings to other personalities

    public class Greeter
    {
        FormalityStrategy _formality;
        public void setFormality(FormalityStrategy formality)
        {
            this._formality = formality;
        }
        public String greet(){
            return _formality.greet();
        }
    }
}