using System;
using System.Collections.Generic;
public class Band
{
    public string Name;
    public List<Musician> Musicians = new List<Musician>();

    public void Announce()
    {
        Console.WriteLine("Welcome " + Name + " to the stage!");
        foreach (var musician in Musicians)
        {
            musician.Announce();
        }
    }
    public void AddMusician()
    {
        var musician = new Musician();
        Console.WriteLine("What is the name of the musician to be added?");
        var name = Console.ReadLine();
        Console.WriteLine("What instrument does " + musician.Name + " play?");
        var instrument = Console.ReadLine();
        AddMusician(name,instrument);
    }

    public void AddMusician(string name, string instrument)
    {
        var musician = new Musician();
        musician.Name = name;
        musician.Instrument = instrument;
        Musicians.Add(musician);
        Console.WriteLine(musician.Name + " was added.");
    }
}