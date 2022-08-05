using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUneHistoire
{
    public class IAdvisableFactory
    {
        public static Iadvisable GetInstance(string pType)
        {
            if (pType.ToLower() == "wife")
            {
                return new Wife();
            }
            else if (pType.ToLower() == "boss")
            {
                return new Boss();
            }
            else if (pType.ToLower() == "friend")
            {
                return new Friend();
            }
            else if (pType.ToLower() == "radiateur")
            {
                return new Radiator();
            }
            else
            {
                throw new ArgumentException("Error : Le type est inconnu");
            }
               
        }
    }
}
