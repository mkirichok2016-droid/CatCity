namespace CatCity {

    interface IUpgradable
    {
        
        
        int Level{
            get;
        }
        void Upgrade(City city);
    }
    abstract class Building : IUpgradable
    {   
        private string name;
        private int level;
        private int upgradeCost;  
        public Building (string Name , int Level)
        {
            name = Name;
            level = Level;
        }
        public string Name
        {
            protected set
            {
                if (name != "")
                {
                    name = value;
                }
                else
                {
                    name = "Mystery building";
                }
            }
            get
            {
                return name;
            }
        }
        
        public int Level
    {
        get
        {
            return level;
        }
        protected set
        {
            if (value < 1)
            {
                level = 1;
            }
            else
            {
                level = value;
            }
          
        }
    }    
        public int UpgradeCost
        {
            get
            {
                return upgradeCost;
            }
           protected set
            {
                if (value < 0)
                {
                    upgradeCost = 0;
                }
                else
                {
                    upgradeCost = value;
                }
            }
        }
        public abstract void Produce(City city);
        
        public virtual void Upgrade(City city)
        {
            if (city.NoCoins(UpgradeCost) == false)
            {
                Level ++;
                UpgradeCost += 25;
                Console.WriteLine(Name + " now upgraded to level " + Level);
            }
            else 
            {
                Console.WriteLine(" not enough coins to upgrade Building by the name of " + Name);
            }
        }
        
        public virtual void ShowBulding()
        {
            Console.WriteLine(" Building: " + Name);
            Console.WriteLine(" Level: " + Level);
            Console.WriteLine(" UpgradeCost: " + UpgradeCost);
        }
        
    }
    class House : Building
{
        public override void Upgrade(City city)
        {
            base.Upgrade(city);
        }
    public int Capacity
    {
        get { return Level * 2; }
    }

    public House() : base("house", 6)
    {
    }
    public override void Produce(City city)
    {
        city.ChangeHappieness(Level);
        Console.WriteLine(Name + " gave +" + Level + " happieness to the city");
    }

    public override void ShowBulding()
    {
        base.ShowBulding();
        Console.WriteLine("space for cats: " + Capacity);
    }
    
}
class Farm : Building
{
    public override void Upgrade(City city)
        {
            base.Upgrade(city);
        }
    public Farm() : base("Farm", 6)
    {
    }

    public override void Produce(City city)
    {
        int food = 2 * Level;
        city.AddFood(food);
        Console.WriteLine(Name + " made  " + food + "food");
    }
}
class FishMarket : Building
{
    public override void Upgrade(City city)
        {
            base.Upgrade(city);
        }
    public FishMarket() : base("Fish market", 10)
    {
    }

    public override void Produce(City city)
    {
        int coins = 2 * Level;
        city.AddCoins(coins);
        Console.WriteLine(Name + " made " + coins + " coins");
    }
}
class Park : Building
{
    public override void Upgrade(City city)
        {
            base.Upgrade(city);
        }
    public Park() : base("Park", 6)
    {
    }

    public override void Produce(City city)
    {
        int happiness = 2 * Level;
        city.ChangeHappieness(happiness);
        Console.WriteLine(Name + " made " + happiness + "happieness");
    }
}
  class City
{
    private string name;
    private int day;
    private int coins;
    private int food;
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
    
    
    public void FeedAllCats()
    {
        foreach (Cat cat in Cats)
        {
            cat.Eat(this);
        }
    }
    public void PlayWithAllCats()
    {
        foreach (Cat cat in Cats)
        {
            cat.Play();
        }
    }
    public void SleepAllCats()
    {
        foreach (Cat cat in Cats)
        {
            cat.Sleep();
        }
    }
    public void WorkAllCats()
    {
        foreach (Cat cat in Cats)
        {
            cat.Work(this);
        }
    }
    public void ShowStats()
    {
        Console.WriteLine("========City=======");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("day: " + Day);
        Console.WriteLine("Coins: " + Coins);
        Console.WriteLine("Food: " + Food);
        Console.WriteLine("city Happiness: " + Happieness);
        Console.WriteLine("how many cats and space for cats you have : " + Cats.Count + "/" + Maxcats);
    }
    
    
    public void AddFood(int fd)
    {
        if (fd > 0)
        {
            Food += fd;
        }
    }
    public void AddCoins (int con)
    {
        if (con > 0)
        {
            Coins += con;
        }
    
    }
    public void ChangeHappieness(int hp)
    {
        Happieness += hp;
    }
    public bool NoCoins(int cn)
    {
        if (cn <= 0 )
        {
            return true;
        }
        else if (Coins >= cn)
        {
            Coins -= cn;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool NoFood(int mn)
    {
        if (mn <= 0)
        {
            return true;
        }
        else if (Food >= mn)
        {
            Food-=mn;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AddCats(Cat cat1)
    {
        if (Cats.Count >= Maxcats)
        {
            Console.WriteLine(" there is no space in city of " + Name);
        }
        else
        {
            Cats.Add(cat1);
            Console.WriteLine(" in city there is new cat " + Name);
        }
        
        
    }

    public void ShowCats()
    {
        if (Cats.Count == 0)
        {
            Console.WriteLine(" in city there is no cats");
        }
        else
        {
            for (int i = 0; i < Cats.Count; i++)
            {
                Console.WriteLine(" CatsCount: ");
                Cats[i].SHOWINFO();
            }
        }
    }
    public int Maxcats
    {
        get
        {
            return 2;
        }
        
    }
    
    public List<Cat> Cats
    {
        private set;
        get;
    }
    
    public int Day
    {
        get
            {
                return day;
            }
        set
            {
                day = value;
            }
    }
    public int Happieness
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
    public int Food
    {
        get
        {
            return food;
        }
        set
        {
            if (value < 0)
            {
                food = 0;
            }
            else
            {
                food = value;
                
            }
        }
    }
    
    
    public int Coins
    {
        set
        {
            if (value < 0)
            {
                coins = 0;
            }
            else
            {
                coins = value;
            }
        }
        get
        {
            return coins;
        }
    }
    public bool HasPlaceForCats
    {
        get
        {
            return Cats.Count() < Maxcats;
        }
    }
    public City(string Namecat)
    {
        Name = Namecat;
        Coins = 100;
        Food = 25;
        Happieness = 50;
        Day = 1;
        Cats = new List<Cat>();
    }
}
}