using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Greeter
{
    // I want to be able to add greetings to other personalities

    public interface IGreeter
    {   
        public void setFormality(FormalityStrategy formality);
        public String greet();
        
    }
}