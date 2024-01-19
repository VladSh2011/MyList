using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        Console.WriteLine(list.Count);
        list.Show();
        //list.Clear();
        //Console.WriteLine(list.Count);
        //list.Show();
        Console.WriteLine(list.Contains(2));
        Console.WriteLine(list.Contains(5));
    }
}

