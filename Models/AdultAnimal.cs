namespace Park
{
    public class Animal
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public string Type{get;set;}
        public string FavFood{get; set;}
        private bool _Dead;
        public int Hunger{get; set;}

        public Animal(string name, int age, string type, string favfood)
        {
            Name = name;
            Age = age;
            Type = type;
            FavFood = favfood;
            _Dead = false;
            Hunger = 0;
        }

        public void SetDead()
        {
            _Dead = true;
        }

        public bool returnDead()
        {
            return _Dead;
        }
        public int hungry()
        {
            Hunger = Hunger + 1;
            return Hunger;
        }
        public int feed()
        {
            Hunger = Hunger -4;    
            return Hunger; 
        }
       
    }
}