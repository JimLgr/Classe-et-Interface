using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryUneHistoire
{
    public interface Iadvisable
    {
        public void StartWork();


        public void PogressingWork();

        public  int CompleteWork();
    }
}