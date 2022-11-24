using System.Net.Sockets;
using System.Text.Json;

Console.WriteLine("your name is:");
string? name = Console.ReadLine();
Console.WriteLine("Youe age is:");
int age = Convert.ToInt32(Console.ReadLine());
man one = new man(name, age);
one.print();
using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
{
    man one1 = new man(name, age);
    await JsonSerializer.SerializeAsync<man>(fs, one1);
    Console.WriteLine("Data has been saved to file");
}
using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
{
    man? mann = await JsonSerializer.DeserializeAsync<man>(fs);
    Console.WriteLine($"Name: {mann?.Name}  Age: {mann?.Age}");
}
Console.WriteLine($"your name is {name} and you are {age}");

class man{
    public string Name { get;}
    public int Age { get; set; }
    public man(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void print(){
        Console.WriteLine($"object's name is {Name}. Object's age is {Age}");
    }
}