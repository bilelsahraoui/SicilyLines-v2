using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationSicilyLines.modeles.Exceptions
{   
    //Exceptions sur les tarifs
    public class ExceptionsTarif : Exception
    {
        public ExceptionsTarif()
        {

        }

        public ExceptionsTarif(string message) : base(message)
        {

        }
 

    }
}
