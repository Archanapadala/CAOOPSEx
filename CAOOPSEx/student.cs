namespace CAOOPSEx
{
     public enum Result
    {
        Distinction,
        Pass,
        Fail
    }
    class Student
    {
        //Variables
        string stdName; int subCount; double[] marks;

        //Method
        public void GetData()
        {
            Console.WriteLine("Enter Your Name: ");
            stdName = Console.ReadLine();
            Console.WriteLine("Enter No of Subjects: ");
            subCount = Convert.ToInt32(Console.ReadLine());
            marks = new double[subCount];
            for (int i = 0; i < subCount; i++)
            {
                Console.WriteLine($"Enter Sub-{i + 1}: ");
                marks[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        //Function
        public double GetTotal()
        {
            double total = 0;
            foreach (int i in marks)
            {
                total = total + i;
            }
            return total;
        }
        //Function
        public double Average()
        {
            double avg = GetTotal() / subCount;
            return avg;
        }
        //public string Result()
        //{
        //    double avg = Average();
        //    if (avg > 75)
        //        return "Distinction";
        //    else if (avg > 35 && avg < 74)
        //        return "Pass";
        //    else 
        //        return "Fail";
        //}

        public Result Result()
        {
            double avg = Average();
            if (avg > 75)
                return CAOOPSEx.Result.Distinction;
            else if (avg > 35 && avg < 74)
                return CAOOPSEx.Result.Pass;
            else
                return CAOOPSEx.Result.Fail;
        }
    }
}
