using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryUneHistoire
{
    public class Boss : Person , Iadvisable
    {

        public  void StartWork() { }


        public  void PogressingWork() { }


        public  int CompleteWork()
        {

            Console.WriteLine("Le boss dit : Ok à demain.");
            return 2;
        }
    }
}