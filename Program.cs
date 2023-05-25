Random random = new Random();
Console.WriteLine("Компьютер загадал число от 1 до 5");
bool error = false;
int rand = random.Next(1, 6);
for (int i = 1; i <=3; i++)
{
    Console.Write("Введите число ");
    int n = int.Parse(Console.ReadLine());
    if (rand == n)
    {
        Console.WriteLine("Вы отгадали!");
        break;
    }
    else
    {
        if (i<3)
        Console.WriteLine("Неправильно, попробуйте еще раз!");
        else
        error = true;
    }
}
if (error)
    Console.WriteLine("Вы проиграли! Загаданное число:"+rand);