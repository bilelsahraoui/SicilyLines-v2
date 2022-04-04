using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationSicilyLines.modeles.Exceptions
{   
    //Exceptions sur les durée
    public class ExceptionsDuree : Exception
    {
        public ExceptionsDuree()
        {

        }

        public ExceptionsDuree(string message) : base(message)
        {

        }
    }
}
