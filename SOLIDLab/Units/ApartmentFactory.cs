using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDLab.Units
{
    /**
     * Create an interface for the factory
     */
    class ApartmentFactory : IApartmentFactory
    {
        /**
         * Returns the object based on the input type
         */
        public Apartment Make(String type)
        {
            switch (type)
            {
                case "Studio":
                    return new Studio();
                case "PenthouseSuite":
                    return new PenthouseSuite();
                default:
                    throw new TypeLoadException();
            }
        }
    }
}
