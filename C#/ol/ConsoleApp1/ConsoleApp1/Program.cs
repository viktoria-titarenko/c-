string str1 = Console.ReadLine();
string str2 = Console.ReadLine();
var str11 = str1.Split(' ');
var str22 = str2.Split(' ');
double a =Convert.ToDouble(  str11[0]);
double b = Convert.ToDouble ( str11[1]);
double c = Convert.ToDouble (str22[0]);
double d = Convert.ToDouble(str22[1]);
double e = Math.Round( Math.Pow(a/b, 2));
double f = Math.Pow(c/d, 2);
Console.WriteLine(e);
Console.WriteLine(f);
int count = 0;
for(double i = e; i <= f; i++)
{
    count++;
}
Console.WriteLine(count);

