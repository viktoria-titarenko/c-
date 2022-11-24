var counter1 = new Counter { Value = 15 };
var counter2 = new Counter { Value = 12 };
Counter result = counter1 + counter2;
Console.WriteLine($"Сумма = {result.Value}");
bool result2 = counter1 < counter2;
Console.WriteLine($"Первое число меньше второго? {result2}");
bool result3 = counter1 > counter2;
Console.WriteLine($"Первое число больше второго? {result3}");
if (result3)
{
    Counter result4 = counter1 - counter2;
    Console.WriteLine($"Разность = {result4.Value}");
}
else Console.WriteLine("Разность посчитать невозможно");
class Counter
{
    public int Value { get; set; }
    public static Counter operator +(Counter counter1, Counter counter2)
    {
        return new Counter { Value = counter1.Value + counter2.Value };
    }
    public static bool operator <(Counter counter1, Counter counter2)
    {
        return counter1.Value < counter2.Value;
    }
    public static bool operator >(Counter counter1, Counter counter2)
    {
        return counter1.Value > counter2.Value;
    }
    public static Counter operator -(Counter counter1, Counter counter2)
    {
        return new Counter { Value = counter1.Value - counter2.Value };
    }

}

