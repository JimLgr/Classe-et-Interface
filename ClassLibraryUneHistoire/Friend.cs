using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryUneHistoire
{
    public class Friend : Person, Iadvisable
    {
        public  void StartWork()
        {
            Console.WriteLine("L'ami a dit : Moi aussi, passe une belle journée");
        }


        public  void PogressingWork()
        {
            Console.WriteLine("L'ami dit : Ne lâche rien tu a bientot fini !");
        }


        public  int CompleteWork()
        {

            Console.WriteLine("L'ami dit : Ok Cool, une petite bière ce soir ?");
            return 10;
        }
    }
}