// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program !");


stAnimal[] animals = new stAnimal[]
{
    new stAnimal(2){ Name = "Max", Kind = "Dog"},
    new stAnimal(5){ Name = "Woffie", Kind = "Cat",},
    new stAnimal(15){ Name = "Dumbo", Kind = "Elephant"},
    new stAnimal(17){ Name = "Snapping Shellfish", Kind = "Turtle"},
    new stAnimal(26){ Name = "Woffie", Kind = "Cat"}
    };


for (int i = 0; i < animals.Length; i++)
{
    System.Console.WriteLine(animals[i]);
    System.Console.WriteLine();

}
System.Console.WriteLine($"The oldest age of the animal is {stAnimal.oldest}");
System.Console.WriteLine($"The total numbers is {stAnimal.nrOfAnimals}");
System.Console.WriteLine($"The youngest age of the animal {stAnimal.Youngest}");
System.Console.WriteLine();
System.Console.WriteLine($"there is this many young {stAnimal.nrofYoung}");
System.Console.WriteLine($"there is this many old {stAnimal.nrOfOld} ");


public struct stAnimal {
    public string Name{get; set;}
    public string Kind{get; set;}
    public int Age {get; set;}

    public static int nrOfAnimals = 0;

    public static int nrofYoung = 0;

    public static int nrOfOld = 0;

    private static int maxAge = 0;
    
    private static int minAge = int.MaxValue;

    public static int oldest => maxAge;

    public static int Youngest => minAge;

    public stAnimal()
    {
        nrOfAnimals ++;
    }



    public override string ToString() {
        return $"Hello from {Name}. I'm a {Age} year old {Kind}!";
    }

    public stAnimal(int _Age)
    {
        if (_Age > maxAge)
        {
            maxAge = _Age;
             nrOfOld++;

        }
        if (_Age < minAge)
        {
            nrofYoung++;
            minAge = _Age;
        }

        Age = _Age;
        nrOfAnimals++;
    }

}


/*
1. Use above Model of an animal, stAnimal.
   Create 5 instances of various animals and print then out
2. Modify stAnimal to have constructors and static fields to keep track of the
   youngest and oldest age (not animal)
3. Print out youngest and oldest age of animals instatiated

Advances:
4. Modify stAnimal with static fields of type stAnimal to keep track of oldest and yougest animal (not only age) 
5. Print out youngest and oldest animals (not only age) instatiated
*/