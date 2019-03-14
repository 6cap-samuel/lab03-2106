using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Greeter
{
    /**
        Abstraction of greeter so that other class can use greeter
    */   
    public interface IGreeter
    {   
        public void setFormality(FormalityStrategy formality);
        public String greet();
        
    }
}