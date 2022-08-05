using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryUneHistoire
{
    public class Radiator : Iadvisable
    {
        public void StartWork()
        {
            Console.WriteLine("Radiateur dit : Ok, j'eteind le bordel.");
        }


        public void PogressingWork()
        {

        }

        public int CompleteWork()
        {

            Console.WriteLine("Radiateur dit : Ok, je fait chauffer la baraque !");
            return 10;
        }

    }
}