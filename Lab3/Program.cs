// While loop

Console.WriteLine("Welcome player, type play to start the game");
string response = Console.ReadLine();
Console.WriteLine("Welcome player, insert a number between 10 and 99 or type exit the game");
string userInput = Console.ReadLine();
int num;  
    while(userInput != "exit") {
        var isNumeric = int.TryParse(userInput, out num);
      
        if (isNumeric) {

            if (num < 10 || num > 99)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Invalid number, try again"); 

            }
            else if (num % 23 == 0)
            {
                Console.WriteLine("Divisible by 23.");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            else if (num % 23 != 0)
            {
                Console.WriteLine("Not divisible by 23.");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }
        else {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Not a number, try again.");
            
        }
        Console.WriteLine("Welcome player, insert a number between 10 and 99 or type exit the game");
        userInput = Console.ReadLine();

    }

    Console.WriteLine("Thanks for playing");
    Console.ReadKey();
    Console.Clear();


// do while

int num2;
string userInput2;
do
{
    Console.WriteLine("Welcome player, insert a number between 10 and 99 or type exit the game");
    userInput2 = Console.ReadLine();

    var isNumeric = int.TryParse(userInput2, out num2);
    if (isNumeric)
    {
        if (num2 < 10 || num2 > 99)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Invalid number, try again.");
        }
        else if (num2 % 34 == 0)
        {
            Console.WriteLine("Divisible by 34.");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else // not 34
        {
            Console.WriteLine("Not divisible by 34.");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Not a number, try again.");
        Console.ReadLine();
        Console.Clear();
     }
} while (userInput2 != "exit");



// for loop

int num3;
string userInput3;
for (userInput3 = ""; userInput3 != "exit";) // for(pre; condition; post)
{
    Console.WriteLine("Welcome player, insert a number between 10 and 99 or type exit the game");
    userInput3 = Console.ReadLine();
    var isNumeric = int.TryParse(userInput3, out num3);
    if (isNumeric) {
        if (num3 < 10 || num3 > 99)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Invalid number, try again.");
        }
        else if (num3 % 33 == 0)
        {
            Console.WriteLine("Divisible by 33.");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else 
        {
            Console.WriteLine("Not divisible by 33.");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else if (userInput3 != "exit"){
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Not a number, try again.");
    }
 }


// Switch

  bool done = false;
  while (!done){
  
    Console.WriteLine("Please write one number: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Please write another number: ");
    int number2 = int.Parse(Console.ReadLine());
    float result;
    

    Console.WriteLine("Which operation you want to perform?");
    Console.WriteLine("1: Addition");
    Console.WriteLine("2: Substraction");
    Console.WriteLine("3: Multiplication");
    Console.WriteLine("4: Division");
    Console.WriteLine("5: Exit");
    int opCode = int.Parse(Console.ReadLine());
  
    switch (opCode){
        case 1: 
            result = number1 + number2;
            Console.WriteLine($"The result of adding {number1} and {number2} is: {result} ");
            break;
        case 2:
            result= number1 - number2;
            Console.WriteLine(result);
            Console.WriteLine($"The result of substracting {number1} and {number2} is: {result} ");
            break;
        case 3: 
            result= number1 * number2;
            Console.WriteLine(result);
            Console.WriteLine($"The result of multiplying {number1} and {number2} is: {result} ");
            break;
        case 4:
            result= (float)number1 / (float)number2;
            Console.WriteLine(result);
            Console.WriteLine($"The result of dividing {number1} and {number2} is: {result} ");
            break;   
      case 5:
            Console.WriteLine("Program exiting.");
            done = true;     
            break;
    }
}