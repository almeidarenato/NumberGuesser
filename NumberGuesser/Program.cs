using System;


//namespace
namespace NumberGuesser
{
    //classe
    class Program
    {
        //metodo de entrada 
        static void Main(string[] args)
        {
             
            getAppInfo(); // Present the app information
            GreetUser(); // greet user



            while (true) { 
                //Create a Random Number object
                Random randomNumber = new Random();

                int correctNumber = randomNumber.Next(1, 11);

                // Init guess var

                int guess = 0;

                // Ask user for number
                Console.WriteLine("Advinhe um numero entre 0 e 10: ");

                // while guess is wrong do the loop
                while(guess != correctNumber)
                {
                    string input = Console.ReadLine();


                    //Make sure its input is a number
                    if (!int.TryParse(input,out guess))
                    {
                        //print error message
                        printColorMessage(ConsoleColor.Red, "Por favor digite um número");

                    } else
                    {
                        // Cast to int and put into guess variable
                        guess = Int32.Parse(input);

                        if (guess != correctNumber)
                        { 
                            printColorMessage(ConsoleColor.Red, "Numero errado por favor tente novamente");
                        }
                        else
                        {
                            printColorMessage(ConsoleColor.Yellow,"Você está correto");
                        }
                    
                    }

                }

                Console.WriteLine("Quer jogar novamente?(S/N)");
                string inputGame = Console.ReadLine().ToUpper();

                if(inputGame == "N")
                {
                    return;
                }
                else if(inputGame == "S")
                {
                    continue;
                } else
                {
                    return; 
                }

            }
        }

        static void getAppInfo()
        {
            // set app vars
            string appName = "Advinhador de Numeros - Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Renato Almeida";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // write app information
            Console.WriteLine("{0}, Version: {1} by {2}, ", appName, appVersion, appAuthor);

            //change text color to default
            Console.ResetColor();

        }

        //greet User
        static void GreetUser()
        {
            //Ask User's Name
            Console.WriteLine("Qual o seu nome? : ");
            string inputName = Console.ReadLine();
            //Greet
            Console.WriteLine("Hello {0} , Vamos jogar!", inputName);
        }

        //print message with color on terminal

        static void printColorMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }   
}