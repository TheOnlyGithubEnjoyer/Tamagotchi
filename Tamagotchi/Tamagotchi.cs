using System;
using System.Collections.Generic;

public class Tamagotchi
{

    private int hunger = 0;

    private int boredom = 0;

    private List<string> words = new List<string>() {"Hello"};

    private bool isAlive;

    private Random generator;

    public string name;

    public Tamagotchi (){
        generator = new Random();
        isAlive = true;
    }

    
    public void Feed()
        {
            Console.WriteLine($"You fed {name} a biscuit and he is now less hungry.");
            hunger -= 2;
            if (hunger > 5)
            {
                isAlive = false;
                Console.WriteLine($"You let {name} starve to death.");
            }
            if (hunger < -5){
                isAlive = false;
                Console.WriteLine($"You overfed {name}. He is now dead.");
            }
        }
    public void ReduceBoredom()
        {
            boredom -= 2;
            if (boredom < -5)
            {
                Console.WriteLine($"{name} is having so much fun that he had a stroke");
                isAlive = false;
            }
            if (boredom > 5)
            {
                Console.WriteLine($"{name} suddenly got depressed and offed himself -_-");
                isAlive = false;
            }
        }

    public void Hi() 
    {

    }

    public void Teach(string word)
    {
        Console.WriteLine($" [{name}] learns: {word}");
        words.Add(word);
        ReduceBoredom();

    }

    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 5 || boredom > 5)
    {
      isAlive = false;
    }

    }       
    
    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom}");
    }

    public bool GetAlive()
    {
        return isAlive;
    }



}
