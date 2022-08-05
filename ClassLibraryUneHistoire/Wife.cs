using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryUneHistoire
{
    public class Wife : Person, Iadvisable
    {
        
        public void StartWork()
        {
            Console.WriteLine("Wife dit : Passe une bonne journée");
        }


        public  void PogressingWork()
        {
            
        }


        public  int CompleteWork()
        {

            Console.WriteLine("Wife dit : Bravo mon chou, passe au magasin");
            return 7;
        }
    }
}