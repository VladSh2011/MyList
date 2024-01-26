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
        //list.Clear();
        //Console.WriteLine(list.Count);
        //list.Show();
        Console.WriteLine(list.Contains(2));
        //Console.WriteLine(list.Contains(5));
        Console.WriteLine(list.IndexOf(2));
        Console.WriteLine(list.IndexOf(8));
        //list.RemoveAt(2);
        //Console.WriteLine("-------------------------");
        //list.Show();
        //list.Remove(1);
        //list.Show();
        List<int> list2 = new List<int>() {1, 2, 3, 4, 5, 6, 3};
        //list.Reverse();
        //list.Show();
        Console.WriteLine(list2.LastIndexOf(3));
        Console.WriteLine(list.LastIndexOf(5));
        list.Show();
        list.Insert(0, 1);
        list.Show();
    }
}

