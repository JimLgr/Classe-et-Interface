using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryUneHistoire 
{
    public class Worker 
    {
        private Iadvisable Advisable;
        private string m_Nom;
        public string Nom
        {
            get => m_Nom;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("Manque le nom");
                if (value.Trim().Length < 3) throw new ArgumentException("Error : Le nom doit être de minimum 3");
                m_Nom = value;
            }
        }

        public Iadvisable PersonneToAdvise
        {
            get => default;
            set
            {
            }
        }

        public void Advise(Iadvisable pAdvisable)
        {
           Advisable = pAdvisable;
        }

        public void DoWork()
        {
            Console.WriteLine("Worker dit : je démarre mon travail");
            Advisable.StartWork();

            Console.WriteLine("Worker dit : je continue mon travail");
            Advisable.PogressingWork();

            Console.WriteLine("Worker dit : je fini mon travail");
            int grade = Advisable.CompleteWork();
            Console.WriteLine($"Le grade est : {grade}");
        }
    }
}