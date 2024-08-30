
bool continueprogram = true;

static void calculate(float firstNumber, string operater, float secondNumber)
{
    switch (operater)
    {
        case "+":
            Console.WriteLine(firstNumber + secondNumber);
            break;
        case "-":
            Console.WriteLine(firstNumber - secondNumber);
            break;
        case "*":
            Console.WriteLine(firstNumber * secondNumber);
            break;
        case "/":
            Console.WriteLine(firstNumber / secondNumber);
            break;

    }
}

static string readOperator()
{
    string operater;
    bool inputInvalid;
    do
    {
        inputInvalid = false;
        Console.WriteLine("Please Input Operator to Execute ( * , / , + , - )");
        operater = Console.ReadLine();
        List<string> operators = new List<string> { "+", "-", "*", "/" };
        inputInvalid = !operators.Contains(operater);
        if (inputInvalid)
        {
            Console.WriteLine("Please Input a valid Operator");
        }
    }
    while (inputInvalid);
    return operater;
}

static float readNumber()
{
    float number;
    bool inputInvalid;
    do
    {
        inputInvalid = false;
        Console.WriteLine("Please enter a number");
        string _UserinputOne = Console.ReadLine();
        inputInvalid = !float.TryParse(_UserinputOne, out number);
        if (inputInvalid)
        {
            Console.WriteLine("Please enter a valid input");
        }
    }
    while (inputInvalid);
    return number;
}

while (continueprogram)
{
    float firstNumber = readNumber();
    string operater = readOperator();
    float secondNumber = readNumber();

    calculate(firstNumber, operater, secondNumber);
    bool continueInputInvalid;
    do
    {
        Console.WriteLine("Do you want to continue? (Y/N)");
        string userinputcont = Console.ReadLine();
        userinputcont = userinputcont.ToUpper();
        if (userinputcont == "Y")
        {
            continueprogram = true;
            continueInputInvalid = false;
        }
        else if (userinputcont == "N")
        {
            continueprogram = false;
            continueInputInvalid = false;
        }
        else
        {
            Console.WriteLine("Please Enter a valid option (Y/N)");
            continueInputInvalid = true;
        }
    }
    while (continueInputInvalid);




}