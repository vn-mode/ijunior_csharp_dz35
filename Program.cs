string commandExit = "exit";
string commandSum = "sum";

Console.Write($"Доступные вам команды:\nСумма введёных чисел - {commandSum}\nВыход из программы - {commandExit}\n");
Console.WriteLine("Введите числа, которые хотите сложить:");
List<int> numbers = new List<int>();
ProcessCommands(numbers, commandSum, commandExit);

static void ProcessCommands(List<int> numbers, string commandSum, string commandExit)
{
    bool isOpen = true;

    while (isOpen)
    {
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int resaultParse))
        {
            numbers.Add(resaultParse);
        }
        else if (userInput.ToLower() == commandSum)
        {
            Console.WriteLine(SumNumbers(numbers));
        }
        else if (userInput.ToLower() == commandExit)
        {
            isOpen = false;
        }
        else
        {
            Console.WriteLine($"Ошибка вводы. Введите число или одну из доступных вам команд.({commandSum} или {commandExit})");
        }
    }
}

static int SumNumbers(List<int> numbers)
{
    int numberSum = 0;
    foreach (var number in numbers)
    {
        numberSum += number;
    }

    return numberSum;
}
