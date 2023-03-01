string exit = "exit";
string sum = "sum";

Console.Write($"Доступные вам команды:\nСумма введёных чисел - {sum}\nВыход из программы - {exit}\n");
Console.WriteLine("Введите числа, которые хотите сложить:");
List<int> numbers = new List<int>();
ProcessCommands(numbers, sum, exit);

static void ProcessCommands(List<int> numbers, string sum, string exit)
{
    bool isOpen = true;

    while (isOpen)
    {
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int resaultParse) != false)
        {
            numbers.Add(resaultParse);
        }
        else if (userInput.ToLower() == sum)
        {
            Console.WriteLine(numbers.Sum());
        }
        else if (userInput.ToLower() == exit)
        {
            isOpen = false;
        }
        else
        {
            Console.WriteLine($"Ошибка вводы. Введите число или одну из доступных вам команд.({sum} или {exit})");
        }
    }
}
