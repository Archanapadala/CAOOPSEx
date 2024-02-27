namespace CAOOPSEx
{
    class Example2
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetData();
            Console.WriteLine("Total is: " + s1.GetTotal());
            Console.WriteLine("Average is: " + s1.Average());
            Console.WriteLine("Result is: " + s1.Result());
        }
    }
}
