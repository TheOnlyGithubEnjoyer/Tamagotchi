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
            if (hunger > 10)
            {
                isAlive = false;
                Console.WriteLine($"You let {name} starve to death.");
            }
            if (hunger < -10){
                isAlive = false;
                Console.WriteLine($"You overfed {name}. He is now dead.");
            }
        }
    public void ReduceBoredom()
        {
            Console.WriteLine($"{name} is now less bored of you!");
            boredom -= 2;
            if (boredom < -5)
            {
                Console.WriteLine($"{name} is having so much fun that he had a stroke");
                isAlive = false;
            }
            if (boredom > 5)
            {
                Console.WriteLine($"{name} suddenly got depressed and offed himself -_-");
            }
        }

    public void Hi() 
    {

    }

    public void Teach()
    {

    }

    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
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
