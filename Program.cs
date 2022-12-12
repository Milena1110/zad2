/*int Finds (int num)
{
    int des = num / 10;
    int sot = num /100;
    int res = des - (sot*10);
    return res;
}
int rand = new Random().Next(100,1000);
int NewNumber = Finds(rand);
Console.WriteLine("Наше число "+ rand);
Console.WriteLine("Наш ответ "+ NewNumber);
*/

void Finds (int num)
{   if (num >=100)
    {int ed = num % 10;
    Console.WriteLine(ed);
    }
    else
    {
    Console.WriteLine("3 Цифры нету");
    }
}
int rand = new Random().Next(10,1000);
Console.WriteLine(rand);
Finds(rand);

/*bool main (int num)
{
    if (num == 6 || num == 7)
    {
    return true;
    }
    else
    {
    return false;
    }
}
Console.WriteLine(main(5));*/