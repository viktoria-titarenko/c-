int[] numbers = new int[5]{1,2,3,4,5};
Console.WriteLine(numbers[^1]);
Man Sasha = new Man("Sasha", 20, 33);
Sasha.Height = 192; Sasha.Weight = 79;
Women Vika = new Women("Vika", 21, 2);
Vika.Weight = 62; Vika.Height = 169;
Vika.say();
Sasha.say();
Vika.Work();
Sasha.Work();
Vika.BMI(); Sasha.BMI();
abstract class  Person{
    public int Age;
    public string Name;
    public int Weight;
    public int Height;
    private double bmi;

    public Person(string name, int age){
        this.Name = name;
        this.Age = age;
    }

    public void say()=>Console.WriteLine($"{Name} говорит");
    public virtual void Work()
    {
        Console.WriteLine($"{Name} работает");
    }
    public void BMI(){
        bmi = Weight/(Math.Pow((Height/100d),2));
        Console.WriteLine($"{Name} BMI = {bmi}");
    }  
}

class Man: Person{
    public int Sizep;
    public Man(string name, int age, int sizep):base(name, age){
        this.Sizep = sizep;
    }
    public override void Work()
    {
        Console.WriteLine($"{Name} работает программистом");
    }
    
}

class Women:Person{
    public int Sizes;
    public Women(string name, int age, int sizes):base(name, age){
        this.Sizes = sizes;
    }
    public override void Work()
    {
        Console.WriteLine($"{Name} работает женой Саши");
    }
}