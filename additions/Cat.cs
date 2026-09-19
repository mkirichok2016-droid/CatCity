
namespace CatCity {
class Cat
{
    
    private int age;
    private string name;
    private int hunger;
    private int energy;
    private static int count = 0;
    private int happiness;
    
    
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Happiness
    {
        set
        {

            if (value < 0)
            {
                happiness = 0;
            
            }
            else if (value > 100)
            {
                happiness = 100;
            }
            else
            {
                happiness = value;
            }
        }
        get
        {
            return happiness;
        }
    }
    public int Hunger
    {
        set
        {
            if (value < 0)
            {
                hunger = 0;
            }
            else if (value > 100)
            {
                hunger = 100;
            }
        }
        get
        {
            return hunger;
        }
    }
    public void Work(City city)
    {
        if (Energy < 25)
        {
            Console.WriteLine(Name + " too tired give him a break");
        }
        else if (hunger > 65)
        {
            Console.WriteLine(Name + " wanna eat so badly. he cant work until hes well feeden");
        }
        else
        {
            city.AddCoins(10);
            Energy -= 20;
            Hunger += 15;
            Happiness += 5;
        }
    }
    
    public void Eat(City city)
    {
        if (city.NoFood(5))
        {
            Hunger -= 20;
            Happiness += 4;
        }
        else
        {
            Console.WriteLine(" do not have enogh Food for cat " + Name);
        }
    }
    public void NEXTDAY()
    {
        Energy -= 10;
        Hunger += 15;
    }
    

    public static int GetCount()
    {
        return count;
    }
    public void SHOWINFO()
    {
        Console.WriteLine(" Name: " + Name);
    Console.WriteLine(" Age: " + Age);
    Console.WriteLine(" Hunger: " + Hunger);
    Console.WriteLine(" Energy: " + Energy);
    Console.WriteLine(" there is " + count + " cats");
    }
    public void Sleep()
    {
        Energy += 30;
        Hunger += 10;
        Console.WriteLine(Name + " sleeped");
    }
    public void Play()
    {
        if (Energy >= 10)
        {
            Energy -= 10;
            Happiness += 15;
            Hunger += 10;
            Console.WriteLine(Name + " played");
        }
        else
        {
            Console.WriteLine (" he tired to play give him a break ");
        }
    }
    public Cat (int age, string name)
    {
        Age = age;
        Name = name;
        Hunger = 30;
        Energy = 70;
        count ++;
    }
    
        
    
    public Cat() : this (1 , "noNamecat")
    {
        
    } 

    public int Hungry
    {
        set
        {
                if  (value < 0)
            {
                hunger = 0; 
            }
            else if (value > 100)
            {
                hunger = 100;
            }
            else
            {
                hunger = value;
            }
        }
        get
        {
            return hunger;
        }
    }
    public int Energy
    {
        set
        {
            if (value < 0)
            {
                energy = 0;
            }
            else if (value > 100)
            {
                energy = 100;
            }
            else
            {
                energy = value;
            }
        }
        get
        {
            return energy;
        }

    }
    
    public int Age
    {
    set
        {
            if (value < 0)
            {
                age= 0;
            }
            else
            {
                age= value;
            }
        }
        get
        {
            return age;
        }
    }


}
}