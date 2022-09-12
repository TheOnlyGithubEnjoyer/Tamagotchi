using System;

Console.WriteLine("Welcome to your Tamagotchi");

Tamagotchi myTamagotchi = new Tamagotchi();

Console.WriteLine("What would you like to name you Tamagotchi?");
myTamagotchi.name = Console.ReadLine();

Console.WriteLine($"Wow! {myTamagotchi.name} is a great name for a Tamagotchi!");
Console.WriteLine($"Now, Press Enter to show the stats of {myTamagotchi.name}");

while (myTamagotchi.GetAlive() == true){
    Console.Clear();
    myTamagotchi.PrintStats();
    Console.WriteLine("DO SOMETHING!");
    Console.WriteLine($"1. Tell {myTamagotchi.name} a joke");
    Console.WriteLine($"2. Feed {myTamagotchi.name} a biscuit");
    Console.WriteLine($"3. Teach {myTamagotchi.name} a word");
    Console.WriteLine($"4. Do nothing");

    string doSome = Console.ReadLine();
    if (doSome == "1")
    {
        myTamagotchi.ReduceBoredom();
    }
    if (doSome == "2")
    {
        myTamagotchi.Feed();
    }
        if (doSome == "3")
    {
        Console.WriteLine("What word?");
        string word = Console.ReadLine();
        myTamagotchi.Teach(word);
    }
    if (doSome == "4")
    {
        myTamagotchi.Tick();
    }
}

Console.WriteLine("Your Tamgotchi died");


Console.ReadLine();
