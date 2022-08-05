using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryUneHistoire
{
    public abstract class Person
    {
        private string m_Nom;
        public string Nom
        {
            get => m_Nom;
            set
            {
                if (value == null) throw new ArgumentNullException("Error : value");
                if (value.Trim().Length < 3) throw new ArgumentException("Error : longueur nom doit être de 3 au minimum");
                m_Nom = value;
            }
        }
       
     
    }
}