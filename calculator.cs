Console.WriteLine("Welcome to calculator, please choose operation: ");
Console.WriteLine("1 for +, 2 for -, 3 for *, 4 for /");
string operation = Console.ReadLine();
int chosenOperation = int.Parse(operation);

bool anotherOperation = true;
int a = 0;
int b = 0;
string decision = "";

while (anotherOperation == true)
{
    switch (chosenOperation)
    {
        case 1:
            Console.WriteLine("Write first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is: ");
            Console.WriteLine(a + b);
            Console.WriteLine("");
            Console.WriteLine("Do you want to continue with calculations ? write YES/NO");
            decision = Console.ReadLine();
            if (decision == "YES")
            {
                anotherOperation = true;
            }
            else
            {
                anotherOperation = false;
            }
            break;
        case 2:
            Console.WriteLine("Write first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is: ");
            Console.WriteLine(a - b);
            Console.WriteLine("");
            Console.WriteLine("Do you want to continue with calculations ? write YES/NO");
            decision = Console.ReadLine();
            if (decision == "YES")
            {
                anotherOperation = true;
            }
            else
            {
                anotherOperation = false;
            }
            break;
        case 3:
            Console.WriteLine("Write first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is: ");
            Console.WriteLine(a * b);
            Console.WriteLine("");
            Console.WriteLine("Do you want to continue with calculations ? write YES/NO");
            decision = Console.ReadLine();
            if (decision == "YES")
            {
                anotherOperation = true;
            }
            else
            {
                anotherOperation = false;
            }
            break;
        case 4:
            Console.WriteLine("Write first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is: ");
            Console.WriteLine(a / b);
            Console.WriteLine("");
            Console.WriteLine("Do you want to continue with calculations ? write YES/NO");
            decision = Console.ReadLine();
            if (decision == "YES")
            {
                anotherOperation = true;
            }
            else
            {
                anotherOperation = false;
            }
            break;
    }
}
