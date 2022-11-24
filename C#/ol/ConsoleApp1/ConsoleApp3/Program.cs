using System.Diagnostics;

int L = Convert.ToInt32(Console.ReadLine());
int R = Convert.ToInt32(Console.ReadLine());
SortedDictionary<int, List<int>> dic = new();  
var sw = new Stopwatch();
int k = 0;
sw.Start();
for (int j = L; j <= R; j++)
{
    for (int i = 1; i <=j; i++)
    {
        if (j % i == 0) { k++;
        }
    }
  /*  Console.Write($"{j} {k}");
    k = 0;
    Console.WriteLine();*/
   
    if(dic.TryGetValue(k, out var list))
    {
        list.Add(j);
    k=0;
    }
    else
    {
        dic[k] = new List<int> { j };
    k=0;
    }
}
foreach (var item in dic)
{
    foreach (var item1 in item.Value)
    {
        Console.WriteLine(item1);
    }
    
}
{

}
sw.Stop();

Console.WriteLine(sw.Elapsed);