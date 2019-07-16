using System;

namespace CalculatorApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool cont = false;
            while (cont == false)
            {
                //ask user for input
                Console.WriteLine("Enter numbers to calculate, first number here");
                string input = Console.ReadLine();
                double number1;
                bool valid = double.TryParse(input, out number1);
                if (valid == true)
                {
                    Console.WriteLine("You input in {0}", number1);
                }
                else
                {
                    throw new System.ArgumentException("Invalid input, please enter a number");
                }
                //double intInput = Convert.ToDouble(input);
                Console.WriteLine("Enter another number");
                string input2 = Console.ReadLine();
                double number2;
                bool valid2 = double.TryParse(input2, out number2);
                if (valid2 == true)
                {
                    Console.WriteLine("You input in {0}", number2);
                }
                else
                {
                    throw new System.ArgumentException("Invalid input, please enter a number");
                }
                //double intInput2 = Convert.ToDouble(input2);


                Console.WriteLine("You entered: {0} {1} ", number1, number2);

                Console.WriteLine("What operation did wish to use?");
                Console.WriteLine("Plese enter multiplication, division, addition, or subtraction");
                Console.WriteLine("Or enter * , / , - , + ");

                string reply = Console.ReadLine();

                if (reply.ToUpper() == "MULTIPLICATION" | reply.ToUpper() == "*")
                {
                    Console.WriteLine("You selected multiplication");
                    double result = number1 * number2;
                    Console.WriteLine("Your answer is: {0} ", result);
                    cont = true;
                }
                else if (reply.ToUpper() == "DIVISION" | reply.ToUpper() == "/")
                {
                    Console.WriteLine("You selected division");
                    double resultDivide = number1 / number2;
                    Console.WriteLine("Your answer is: {0} ", resultDivide);
                    cont = true;
                }
                else if (reply.ToUpper() == "ADDITION" | reply.ToUpper() == "+")
                {
                    Console.WriteLine("You selected addition");
                    double result = number1 + number2;
                    Console.WriteLine("Your answer is: {0} ", result);
                    cont = true;
                }
                else if (reply.ToUpper() == "SUBTRACTION" | reply.ToUpper() == "-")
                {
                    Console.WriteLine("You selected subtraction");
                    double result = number1 - number2;
                    Console.WriteLine("Your answer is: {0} ", result);
                    cont = true;
                }
                else
                {
                    Console.WriteLine("I didn't quite understand that");
                    cont = false;
                }
            }
            



            //end main
        }
    }
}
