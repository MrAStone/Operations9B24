namespace Operations9B24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operations

            int num1, num2;
            double dNum1, dNum2;
            num1 = 42;
            num2 = 17;
            dNum1 = 1.32516;
            dNum2 = 6.45216;

            // addition
            int num3 = num1 + num2;
            Console.WriteLine(num3);
            double dNum3 = dNum1 + dNum2;
            Console.WriteLine(dNum3);
            //num3 = dNum2 + num1;
            dNum3 = dNum2 + num1;
            Console.WriteLine(dNum3);

            // subtraction

            num3 = num1 - num2;
            Console.WriteLine(num3);
            dNum3 = dNum1 - dNum3;
            Console.WriteLine(dNum3);
            dNum3 = num1 - dNum2;
            Console.WriteLine(dNum3);
            // num3 = dNum1 - num2;  will error as result would be double not integer

            // multiplication
            num3 = num1 * num2;
            Console.WriteLine(num3);
            dNum3 = dNum1 * num2;
            Console.WriteLine(dNum3);
            dNum3 = num1 * dNum2;
            Console.WriteLine(dNum3);
            // num3 = dNum3 * num2;  will error as result would be double not integer

            // division
            num1 = 7;
            num2 = 2;
            num3 = num1 / num2;
            Console.WriteLine(num1 / num2);


        }
    }
}
