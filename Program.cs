//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*int [] CreatedNewArray()
{
    int[] array = new int[5];
    for(int i =0;i < array.Length;i++)
    {
    Console.WriteLine("Imput number: ");    
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowNewArray(int[] array)
{
   for(int i = 0;i < array.Length;i++)
   {
    Console.Write(array[i] + " ");
   }
}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0;i < array.Length;i++)
    if(array[i] > 0) count++;

    return count; 
}

int[] X = CreatedNewArray();
ShowNewArray(X);
int M = Count(X);
Console.WriteLine($"-> {M}");
*/

//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*void Method(double b1, double b2, double k1, double k2)
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y1 = k1 * x + b1;
        double y2 = k2 * x + b2;
        Console.WriteLine($"-> ({y1}; {y2})");
    }
    else Console.WriteLine("Not result");
}

Console.WriteLine("Imput b1: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput b2: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput k1: ");
double c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput k2: ");
double d = Convert.ToInt32(Console.ReadLine());
Method(a, b, c, d);
*/