//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5

int Prompt(string message)
    {   
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
    };
    int numberA = Prompt("Введите первое число");
    int numberB = Prompt("Введите второе число");
    if (numberA > numberB)
    {
    Console.Write("max = "+ numberA);
    Console.WriteLine("; min = "+ numberB);
    }
        if (numberA < numberB)
        {
        Console.Write("max = "+ numberB);
        Console.WriteLine("; min = "+ numberA);
        }
            if(numberA == numberB)
            {
            Console.WriteLine("Первое число равно второму");
            }

           

