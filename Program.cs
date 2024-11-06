namespace Assignment01_StepsLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("|=========================|");
            Console.WriteLine("|Task01: Simple Calculator|");
            Console.WriteLine("|=========================|");


            #region Task01[Simple Calculator]
            double num1, num2;
            Console.Write("Enter First Number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
            Console.WriteLine($"{num1} - {num2} = {num1-num2}");
            Console.WriteLine($"{num1} * {num2} = {num1*num2}");
            Console.WriteLine($"{num1} / {num2} = {(num1/num2):F2}");
            #endregion




            Console.WriteLine("|=================|");
            Console.WriteLine("|Task02: Full Name|");
            Console.WriteLine("|=================|");


            #region Task02[Full Name Length]
            string firstName, lastName;
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();
            int nameLength = firstName.Length+ lastName.Length;

            Console.WriteLine($"Full Name: {firstName} {lastName}\nName Length: {nameLength}");
            #endregion
        }
    }
}
