using ClassLibraryUneHistoire;

try
{
    Console.WriteLine("Début du programme");

    do
    {
        Console.WriteLine("Quel type de personne voulez-vous prévenir?");
        string typePerson = Console.ReadLine();

        Iadvisable choixPerson = IAdvisableFactory.GetInstance(typePerson);
        //choixPerson.Nom = "Jim";
        Worker worker = new Worker();
        worker.Advise(choixPerson);
        worker.DoWork();
    } while (true);
   

    Console.WriteLine("Fin du programme");
}
catch (Exception exc)
{
    Console.WriteLine(exc.Message);
}