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
            Console.WriteLine(9/2); // 9 and 2 are integers
            Console.WriteLine(9/2.0); // 9 is an integer 2.0 is a double
            Console.WriteLine(9.0/2);

            // remainder
            Console.WriteLine(7%2); // 7 MOD 2 = 1

            Console.WriteLine(Math.Pow(2,8));
            Console.WriteLine(Math.Pow(2,-8));
            Console.WriteLine(Math.Sqrt(81));

            // Relational Operators
            int a = 3;
            // equal to
            if (a == 3)
            {
                Console.WriteLine("It is 3");
            }
            // not equal to
            if(a != 3)
            {
                Console.WriteLine("It is not 3");
            }
            // less than
            if (a < 3)
            {
                Console.WriteLine("less than 3");
            }
            // greater than
            if (a > 3)
            {
                Console.WriteLine("greater than 3");
            }

            // less than or equal to
            if(a <= 3)
            {
                Console.WriteLine("less than or equal to 3");
            }
            // greater than or equal to
            if(a >= 3)
            {
                Console.WriteLine("greater than or equal to 3");
            }




        }
    }
}
