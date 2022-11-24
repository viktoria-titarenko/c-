using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

string str1 = Console.ReadLine();
string str2 = Console.ReadLine();
var str11 = str1.Split(' ');
var str22 = str2.Split(' ');
int x = Convert.ToInt32(str11[0]);
int y = Convert.ToInt32(str11[1]);
int a = Convert.ToInt32(str22[0]);
int b = Convert.ToInt32(str22[1]);
int c = Convert.ToInt32(str22[2]);
int d = Convert.ToInt32(str22[3]);
    
    Console.WriteLine(count_left(x, y, a, b, c, d));


int count_left(int x, int y, int a, int b, int c, int d)
{
    List<int> list = new List<int>();
    list.Add(d);
    list.Add(a);
    list.Add(y - b);
    list.Add(x - c);

    return list.Min();
}