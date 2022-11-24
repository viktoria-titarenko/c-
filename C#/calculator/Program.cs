
// internal class Program
// {
//     private static void Main(string[] args)

//     {
//         Console.WriteLine("expression");
//         string? expression = Console.ReadLine();
//         string first1 = "";
//         int k = 0;
//         foreach(var ch in expression){
//             if ((ch=='+') || (ch=='-') || (ch=='*') || (ch=='/') || (ch=='^')){
//                 break;
//             }
//             else{
//                 k+=1;
//                 first1 = first1 + ch;
//             }
//         }
//         expression = expression.Remove(0,k);
//         int first = Convert.ToInt32(first1);
//         string? mark =Convert.ToString(expression[0]);
//         expression = expression.Remove(0,1);
//         int second = Convert.ToInt32(expression);

//         // Console.WriteLine("first number");
//         // int first = Convert.ToInt32(Console.ReadLine());

//         // Console.WriteLine("mark");
//         // string? mark = Console.ReadLine();

//         // Console.WriteLine("second number");
//         // int second = Convert.ToInt32(Console.ReadLine());

//         switch (mark)
//         {
//             case "+":
//                 Console.WriteLine(first + second);
//                 break;
//             case "-":
//                 Console.WriteLine(first - second);
//                 break;
//             case "*":
//                 Console.WriteLine(first * second);
//                 break; 
//             case "/":
//                 Console.WriteLine(first / second);
//                 break; 
//             case "^":
//                 Console.WriteLine(Math.Pow(first,second));
//                 break;             
//         }
//     }
// }

class Program
{
    public static void Main()
    {
        var operations = new List<IOperation>
        {
            new PlusOperation(),
            new MinusOperation(),
            new MultiplyOperation(),
            new DivideOperation(),
            new PowOperation()
        };

        while (true)
        {
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty string");
                continue;
            }

            foreach (var o in operations)
            {
                if (input.Contains(o.Symbol))
                {
                    var splittedInput = input.Split(o.Symbol);
                    var numbers = splittedInput.Select(symb => int.Parse(symb.Trim()));
                    var result = o.RunOperation(numbers);
                    Console.WriteLine(result);
                    break;
                }
            }

        }

    }
}

interface IOperation
{
    char Symbol { get; }
    int RunOperation(IEnumerable<int> numbers);
}

class MinusOperation : IOperation
{
    public char Symbol => '-';

    public int RunOperation(IEnumerable<int> numbers)
    {
        var nums = numbers.ToList();
        return nums[0] - nums[1];   
    }
}

class PlusOperation : IOperation
{
    public char Symbol => '+';

    public int RunOperation(IEnumerable<int> numbers) => numbers.Sum();
}

class MultiplyOperation : IOperation
{
    public char Symbol => '*';

    public int RunOperation(IEnumerable<int> numbers)
    {
        return numbers.Aggregate((i, j) => {
            return i * j;
        });
    } 
}

class DivideOperation : IOperation
{
    public char Symbol => '/';

    public int RunOperation(IEnumerable<int> numbers)
    {
        var nums = numbers.ToList();

        return nums[0] / nums[1];
    }
}

class PowOperation : IOperation
{
    public char Symbol => '^';

    public int RunOperation(IEnumerable<int> numbers)
    {
        var nums = numbers.ToList();
        return Convert.ToInt32(Math.Pow(nums[0], nums[1]));
    }
}