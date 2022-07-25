Random rand = new Random();
Console.Write("Введите количество строк: ");
int strok = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = int.Parse(Console.ReadLine());
int[,] matrix = new int[strok, stolb];
long sum = 0;

for (int i = 0; i < strok; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        matrix[i, j] = rand.Next();
        sum += matrix[i, j];
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine($"\nСумма всех элементов: {sum}");
Console.ReadLine();



Console.Write("Введите длину последовательности: ");
int longer = int.Parse(Console.ReadLine());
int[] massiv = new int[longer];
int minValue = Int32.MaxValue;
for (int i = 0; i < massiv.Length; i++)
{
    Console.Write($"Индекс массива ({i}): ");
    massiv[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] < minValue)
    {
        minValue = massiv[i];
    }
}
Console.WriteLine($"\nНаименьшее число = {minValue}");
Console.ReadKey();



Random random = new Random();
Console.WriteLine("Для завершения оставьте строку пустой");
Console.Write("Введите диапазон: ");
int range = int.Parse(Console.ReadLine());
int[] randmas = new int[range];
bool bolean = true;
int rad = random.Next(0, randmas.Length + 1);
int result = rad;

for (int i = 0; i < randmas.Length; i++)
{
    while (bolean)
    {
        Console.Write("\nВведите число: ");
        string user = Console.ReadLine();
        if (user == string.Empty)
        {
            Console.WriteLine($"Вы завершили программу. Загаданное число было {result}");
            break;
        }
        int userint = Convert.ToInt32(user); 
        if (userint > rad)
        {
            Console.WriteLine("Меньше");
        }
        else if (userint < rad)
        {
            Console.WriteLine("Больше");
        }
        else
        {
            Console.WriteLine("Верно!");
            Console.WriteLine("Программа завершена");
            break;
        }
        if (userint > randmas.Length)
        {
            Console.WriteLine("Число больше указанного диапазона");
        }
    }
    if (bolean) bolean = false;
}
Console.ReadKey();



