using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationSicilyLines.modeles.Exceptions
{
    //Exceptions sur les liaisons
    public class ExceptionsLiaison : Exception
    {
        public ExceptionsLiaison()
        {

        }

        public ExceptionsLiaison(string message) : base(message)
        {

        }

    }
}
