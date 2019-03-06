

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG40Assignment3
{
    class Program

    {
        public static int MenSelValidation()
        {

            string iUser = "";

            bool SelectedMenValidate = false;

            while (SelectedMenValidate == false){

                Console.WriteLine("1 = To enter First Number");
                Console.WriteLine("2 = To change First Number");

                Console.WriteLine("3 = To enter Second Number");
                Console.WriteLine("4 = To change Second Number");

                Console.WriteLine("5 = Do Addition");
                Console.WriteLine("6 = Do Subtraction");

                Console.WriteLine("7 = Do Multiplication");
                Console.WriteLine("8 = Do Division");

                Console.WriteLine("9 = Exit\n");
                Console.WriteLine("Please select any option as listed : \n");

                iUser = Console.ReadLine();


                if (iUser != "1" && iUser != "2" && iUser != "3" && iUser != "4" && iUser != "5" && iUser != "6" && iUser != "7" && iUser != "8" && iUser != "9")
                {
                    Console.WriteLine("Well that seems odd! Please enter a valid input ! \n");
                }
                else
                {
                    SelectedMenValidate = true;
                }
            }

            Console.WriteLine();
            return int.Parse(iUser);
        }

        public static double ValidateUserInput(string thenumberChosen)
        {

            double numberX = 1;

            bool validIf = false;

            while (validIf == false)
            {

                Console.WriteLine($"Please enter the {thenumberChosen}:");

                string inputOfUser = Console.ReadLine();

                Console.WriteLine();

                bool resultOf = double.TryParse(inputOfUser, out numberX);

                if (resultOf == false)
                {

                    Console.WriteLine("Not a valid selection. Please enter a correct one !\n");

                }

                else
                {

                    validIf = true;

                    Console.WriteLine($"Your {thenumberChosen} is changed to: {numberX}.\n");
                }
            }

            return numberX;
        }


        static void Main(string[] args)
        {
            CalculatorCode c = new CalculatorCode();

            bool vCSelection = false;

            string calculatorSelection;
            int selectionOf;

            while (vCSelection == false)
            {
                Console.WriteLine("1 = To use random numbers click 1\n");
                Console.WriteLine("2 = To use your own numbers click 2\n");

                Console.WriteLine("Choose a menu item number to begin:");
                calculatorSelection = Console.ReadLine();

                Console.WriteLine();

                if (calculatorSelection != "1" && calculatorSelection != "2")
                {
                    Console.WriteLine("Please enter a valid selection and please do try again ! .\n");
                }
                else if (int.Parse(calculatorSelection) == 1)
                {
                    vCSelection = true;
                    Random random = new Random();

                    double fNumberOf;

                    double sNumberOf;

                    fNumberOf = Math.Round((random.NextDouble() * 500), 2);

                    sNumberOf = Math.Round((random.NextDouble() * 500), 2);

                    Console.WriteLine($"Your random numbers will be {fNumberOf} and {sNumberOf}.\n");
                    CalculatorCode customCalculator = new CalculatorCode(fNumberOf, sNumberOf);

                    c = customCalculator;

                }
                else if (int.Parse(calculatorSelection) == 2)
                {
                    vCSelection = true;

                    double fNumberOf;

                    double sNumberOf;

                    fNumberOf = ValidateUserInput("First Number");

                    sNumberOf = ValidateUserInput("Second Number");

                    Console.WriteLine($"Your custom numbers selected by the program itself is {fNumberOf} and {sNumberOf}.\n");

                    CalculatorCode customCalculator = new CalculatorCode(fNumberOf, sNumberOf);

                    c = customCalculator;
                }
            }


            selectionOf = MenSelValidation();

            while (selectionOf != 9)
            {
                double resultOf;



                switch (selectionOf)
                {
                    case 1:

                        Console.WriteLine($"First Number is: {c.PrintFno()}\n");

                        break;
                    case 2:

                        resultOf = ValidateUserInput("First Number");

                        c.SetFno(resultOf);

                        break;
                    case 3:

                        Console.WriteLine($"Second Number is: {c.PrintSno()}\n");

                        break;
                    case 4:

                        resultOf = ValidateUserInput("Second Number");

                        c.SetSno(resultOf);

                        break;
                    case 5:

                        Console.WriteLine($"The result of {c.PrintFno()} added to {c.PrintSno()} equals {c.DoAddition()}\n");

                        break;
                    case 6:

                        Console.WriteLine($"The result of {c.PrintFno()} subtracted from {c.PrintSno()} equals {c.DoSubtraction()}\n");

                        break;
                    case 7:

                        Console.WriteLine($"The resultOf of {c.PrintFno()} multiplied to {c.PrintSno()} equals {c.DoMultiplication()}\n");

                        break;
                    case 8:

                        Console.WriteLine($"The resultOf of {c.PrintFno()} divided with {c.PrintSno()} equals {c.DoDivision()}\n");

                        break;
                    default:
                        break;
                }

                selectionOf = MenSelValidation();

            }

        }
    }
}