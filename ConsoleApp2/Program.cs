using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(1);
        list.Add(2);
        Console.WriteLine(list.Count);
        list.Show();
        Console.WriteLine(list[0]);
        Console.WriteLine(list[2]);
        Console.WriteLine(list[4]);
        Console.WriteLine(list[14]);
    }
}

